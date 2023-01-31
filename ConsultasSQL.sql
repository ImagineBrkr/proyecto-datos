use BD_ContratacionEmpleos
go

drop view if exists V_EmpresaOferta
go

create view V_EmpresaOferta
as
select  E.Nombre as [Empresa],
		E.Rubro as [Rubro],
		O.Descripcion as [Descripción de la oferta],
		R.Nombre as [Región],
		A.Descripcion as [Área],
		O.FechaPublicacion as [Fecha de publicacion],
		CASE WHEN O.FechaFin <= getDate() THEN 'Finalizado'
			ELSE 'En curso' END as [Estado]
	from Oferta O
	inner join Empresa E
		on E.IdEmpresa = O.IdEmpresa
	inner join Area A
		on A.IdArea = O.IdArea
	inner join Region R
		on R.IdRegion = O.IdRegion
go

drop view if exists V_PostulantePromedios
go

create view V_PostulantePromedios
as
select  P.IdPostulante as [Id], 
		P.Nombres + ' ' + P.Apellidos as [Nombre completo],
		P.TipoDocumento as [Tipo de documento],
		P.NroDocumento as [Nro de documento],
		COALESCE(AVG(EL.Salario), 'Sin experiencia previa') as [Salario promedio],
		COALESCE(AVG(PE.Calificacion), 'Sin evaluaciones registradas') as [Calificación promedio]
		from Postulante P
		left join ExperienciaLaboral EL
			on EL.IdPostulante = P.IdPostulante
		left join Postulante_Evaluacion PE
			on PE.IdPostulante = P.IdPostulante
		group by P.IdPostulante, P.Nombres + ' ' + P.Apellidos, P.TipoDocumento, P.NroDocumento
go

drop view if exists V_PostulanteSeleccionado
go

create view V_PostulanteSeleccionado
as
select  P.IdPostulante as [Id],
		P.Nombres + ' ' + P.Apellidos as [Nombre completo],
		O.Descripcion as [Oferta],
		D.Nombres + ' ' + D.Apellidos as [Director RR.HH.],
		PS.Resultado as [Resultado]
		from Postulacion_Seleccion PS
		inner join Postulante P
			ON P.IdPostulante = PS.IdPostulante
		inner join Oferta O
			ON O.CodOferta = PS.CodOferta
		inner join Director_RRHH D
			ON D.CodDirector = PS.CodDirector
		where PS.Resultado != 'En evaluacion'
			and PS.Resultado != 'No aprobado'
go

drop view if exists V_PostulanteACargo
go

create view V_PostulanteACargo
as
select  P.IdPostulante as [Id], 
		P.Nombres + ' ' + P.Apellidos as [Nombre completo],
		P.TipoDocumento as [Tipo de documento],
		P.NroDocumento as [Nro de documento],
		MAX(EL.PersonasACargo) as [Máximo de personas a cargo],
		Round(AVG(EL.Salario), 2) as [Salario promedio]
		from Postulante P
		inner join ExperienciaLaboral EL
		ON EL.IdPostulante = P.IdPostulante
		where EL.CodExperiencia in (
			select distinct CodExperiencia 
				from ExperienciaLaboral
				where DATEDIFF(day, FechaFin, getDate()) <= 365
					or AlPresente = 'SI')
		group by P.IdPostulante, P.Nombres + ' ' + P.Apellidos, P.TipoDocumento, P.NroDocumento
		having MAX(EL.PersonasACargo) > 5
go

drop view if exists V_EvaluacionesRecurrentes
go

create view V_EvaluacionesRecurrentes
as
select  E.IdEvaluacion as [Id],
		E.Prueba as [Prueba],
		TE.Nombre as [Tipo de prueba],
		AVG(OE.CalificacionMinima) as [Calificación mínima promedio],
		AVG(PE.Calificacion) as [Calificación promedio]
		from Evaluacion E
		left join Oferta_Evaluacion OE
		ON OE.IdEvaluacion = E.IdEvaluacion
		inner join TipoEvaluacion TE
		ON TE.IdTipoEvaluacion = E.IdTipoEvaluacion
		left join Postulante_Evaluacion PE
		ON PE.IdEvaluacion = E.IdEvaluacion
		inner join Oferta O
		ON OE.CodOferta = O.CodOferta
		where DATEDIFF(day, O.FechaPublicacion, getDate()) <= 365
			and E.IdEvaluacion in (
				select IdEvaluacion from Oferta_Evaluacion
				group by IdEvaluacion
				 having COUNT(IdEvaluacion) >= 5
			)
		group by E.IdEvaluacion, E.Prueba, TE.Nombre
go

drop procedure if exists SP_ExperienciaIdiomaSoftware
go

create procedure SP_ExperienciaIdiomaSoftware
(@PalabraClave varchar(30),
@Busqueda varchar(10) = 'Software'
)
AS
BEGIN
if (@Busqueda = 'Software')
	select  distinct P.IdPostulante as [Id], 
			P.Nombres + ' ' + P.Apellidos as [Nombre completo],
			P.TipoDocumento as [Tipo de documento],
			P.NroDocumento as [Nro de documento],
			S.Software as [Software],
			S.Nivel as [Nivel]
			from Software S
			inner join Postulante P
			ON S.IdPostulante = P.IdPostulante
			where S.Software like '%' + @PalabraClave + '%'
else if (@Busqueda = 'Idioma')
		select  distinct P.IdPostulante as [Id], 
			P.Nombres + ' ' + P.Apellidos as [Nombre completo],
			P.TipoDocumento as [Tipo de documento],
			P.NroDocumento as [Nro de documento],
			I.Idioma as Idioma,
			I.Nivel as [Nivel]
			from Idiomas I
			inner join Postulante P
			ON I.IdPostulante = P.IdPostulante
			where I.Idioma like '%' + @PalabraClave + '%'
else
return 0
END
go

drop function if exists F_EvaluacionesAprobadas
go

create function F_EvaluacionesAprobadas 
(@CodOferta int,
@IdPostulante char(04)
)
returns @TablaResultados table
	(IdEvaluacion char(04) not null,
	resultado varchar(100) not null
	)
as
begin
	Insert @TablaResultados
		select OE.IdEvaluacion,
			CASE WHEN PE.Calificacion < OE.CalificacionMinima THEN 'No, el postulante no alcanzó la calificación mínima'
				 WHEN PE.Calificacion >= OE.CalificacionMinima THEN 'SI'
				 END as resultado
			from Oferta_Evaluacion OE
			inner join Postulante_Evaluacion PE
				on OE.IdEvaluacion = PE.IdEvaluacion 
				AND OE.CodOferta = PE.CodOferta
			where OE.CodOferta = @CodOferta
				and PE.IdPostulante = @IdPostulante
return
end
go

drop procedure if exists SP_SeleccionarPostulantes
go

create procedure SP_SeleccionarPostulantes
(@CodOferta int
)
AS
BEGIN
UPDATE Postulacion_Seleccion
	SET Resultado = 'Seleccionado'
	WHERE CodOferta = @CodOferta
	and IdPostulante in (
		select IdPostulante
		from Postulacion_Seleccion
		where (select count(*) from F_EvaluacionesAprobadas(@CodOferta, IdPostulante) where resultado = 'SI')
				= (select count(*) from Oferta_Evaluacion where CodOferta = @CodOferta)
	)
UPDATE Postulacion_Seleccion
	SET Resultado = 'No aprobado'
	where CodOferta = @CodOferta
	and Resultado != 'Seleccionado' 
		and Resultado !='Contratado'
END
go

drop procedure if exists SP_PostulanteOferta
go

create procedure SP_PostulanteOferta
(@CodOferta int
)
AS
BEGIN
	select  P.IdPostulante as [Id], 
			P.Nombres + ' ' + P.Apellidos as [Nombre completo],
			P.TipoDocumento as [Tipo de documento],
			P.NroDocumento as [Nro de documento],
			PP.FechaPostulacion as [Fecha de publicación],
			COALESCE(PS.Resultado, 'No seleccionado') as [Estado]
			from Postulacion_Preseleccion PP
			left join Postulacion_Seleccion PS
				on PS.IdPostulante = PP.IdPostulante
				and PS.CodOferta = PP.CodOferta
			inner join Postulante P
				on P.IdPostulante = PP.IdPostulante
			where PP.CodOferta = @CodOferta
END
GO


drop procedure if exists SP_PostulanteArea
go

create procedure SP_PostulanteArea
(@IdArea char(04)
)
AS
BEGIN
select  P.IdPostulante as [Id], 
		P.Nombres + ' ' + P.Apellidos as [Nombre completo],
		P.TipoDocumento as [Tipo de documento],
		P.NroDocumento as [Nro de documento],
		EL.Empresa as [Empresa],
		EL.Puesto as [Puesto],
		EL.Salario as [Salario]
		from ExperienciaLaboral EL
		inner join Postulante P
			on EL.IdPostulante = P.IdPostulante
		where EL.IdArea = @IdArea
END
go

drop function if exists F_CantidadOfertas
go

create function F_CantidadOfertas 
(@Id char(04),
@Busqueda varchar(10) = 'Region'
)
returns int 
as
begin
	declare @total int = 0
		if @Busqueda = 'Region'
			begin
			select @total = count(*) from Oferta where IdRegion = @Id
			end
		else if @Busqueda = 'Area'
			select @total = count(*) from Oferta where IdArea = @Id
	return @total
end
go

drop function if exists F_PromedioEvaluacion
go

create function F_PromedioEvaluacion 
(@IdTipo char(04),
@IdPostulante char(04)
)
returns float 
as
begin
	declare @Promedio float
	select @Promedio = AVG(PE.Calificacion) from Postulante_Evaluacion PE
		inner join Evaluacion E
			ON E.IdEvaluacion = PE.IdEvaluacion
		inner join TipoEvaluacion TE
			ON TE.IdTipoEvaluacion = E.IdTipoEvaluacion
		where E.IdTipoEvaluacion = @IdTipo
			and PE.IdPostulante = @IdPostulante
	return COALESCE(@Promedio, 0)
end
go

drop procedure if exists SP_OfertaDetalles
go

create procedure SP_OfertaDetalles 
(@CodOferta int,
@Busqueda varchar(15) = 'Requerimientos'
)
as
BEGIN
	If @Busqueda = 'Requerimientos'	
		select Descripcion, Prioridad from Requerimiento 
				where CodOferta = @CodOferta
	Else If @Busqueda = 'Funciones'
		select Descripcion from Funciones 
				where CodOferta = @CodOferta
	Else If @Busqueda = 'Beneficios'
		select Descripcion from Beneficios 
				where CodOferta = @CodOferta
	Else If @Busqueda = 'Evaluaciones'
		select E.Prueba, TE.Nombre as Tipo, OE.CalificacionMinima as [Calificacion Mínima] 
				from Oferta_Evaluacion OE
				inner join Evaluacion E ON E.IdEvaluacion = OE.IdEvaluacion
				inner join TipoEvaluacion TE ON TE.IdTipoEvaluacion = E.IdTipoEvaluacion
				where CodOferta = @CodOferta
	Else
		return 0
end
go

drop procedure if exists SP_PostulanteDetalles
go

create procedure SP_PostulanteDetalles 
(@IdPostulante char(04),
@Busqueda varchar(30) = 'Experiencia Laboral'
)
as
BEGIN
	IF @Busqueda = 'Experiencia Laboral'
		select  EL.Empresa, EL.Puesto, EL.FechaInicio as [Fecha de inicio], 
				EL.AlPresente as [Actualmente],
				EL.Salario, A.Descripcion
				from ExperienciaLaboral EL
				inner join Area A ON A.IdArea =  EL.IdArea
				where IdPostulante = @IdPostulante

	ELSE IF @Busqueda = 'Estudios'
		select GradoAcademico as [Grado Académico], Institucion, Carrera, FechaInicio as [Fecha de inicio], 
				AlPresente as [Actualmente]
			from Estudios where IdPostulante = @IdPostulante

	ELSE IF @Busqueda = 'Estudios Postgrado'
		select TipoEstudios as [Tipo de estudios], NombreEstudio as [Nombre de estudios], 
				Institucion, FechaInicio as [Fecha de inicio], 
				AlPresente as [Actualmente]
			from EstudiosPostgrado where IdPostulante = @IdPostulante

	ELSE IF @Busqueda = 'Idiomas'
		select Idioma, Nivel
			from Idiomas where IdPostulante = @IdPostulante
	ELSE IF @Busqueda = 'Software'
		select Software, Nivel
			from Software where IdPostulante = @IdPostulante
	ELSE IF @Busqueda = 'Referencias'
		select Nombres + ' ' + Apellidos as [Nombre], Correo, Telefono, 
			TipoReferencia as [Tipo de referencia], TipoRelacion as [Tipo de relación],
			COALESCE(Empresa, '-') as [Empresa], COALESCE(Puesto, '-') as [Puesto]
			from Referencias where IdPostulante = @IdPostulante
	ELSE
		return 0
END
go

drop function if exists F_EmpresaOferta
go

create function F_EmpresaOferta
(@IdEmpresa char(04)
)
returns @OfertasResultados Table
	(Descripcion varchar(1000) not null,
	FechaPublicacion datetime not null,
	Area varchar(50) not null,
	NivelLaboral varchar(50) not null,
	IdPostulante char(04) not null,
	Postulante varchar(101) not null)
AS
BEGIN
insert into @OfertasResultados
		select  O.Descripcion,
			O.FechaPublicacion,
			A.Descripcion as [Area],
			O.NivelLaboral,
			P.IdPostulante,
			P.Nombres + ' ' + P.Apellidos as [Postulante]
			from Postulacion_Seleccion PS
			inner join Oferta O
				ON O.CodOferta = PS.CodOferta
			inner join Postulante P
				ON P.IdPostulante = PS.IdPostulante
			inner join Area A
				ON A.IdArea = O.IdArea
			where PS.Resultado = 'Contratado'
				and O.IdEmpresa = @IdEmpresa
return
END 
GO

drop function if exists F_ValidarLicencia
go

create function F_ValidarLicencia
(@Licencia varchar(6),
@LicenciaRequerida varchar(6)
)
returns varchar(2)
as
begin
	declare @Resultado varchar(2) = 'NO'
		IF LEFT(@Licencia, 1) = LEFT(@LicenciaRequerida,1)
			BEGIN
				IF @Licencia = @LicenciaRequerida
					SET @Resultado = 'SI'
				ELSE IF LEFT(@LicenciaRequerida, 1) = 'A'
				BEGIN
					IF @Licencia = 'A-IIIc'
						set @Resultado = 'SI'
					ELSE IF @Licencia = 'A-IIIb' AND @LicenciaRequerida != 'A-IIIc' AND @LicenciaRequerida != 'A-IIIa' 
						set @Resultado = 'SI'
					ELSE IF @Licencia = 'A-IIIa' AND @LicenciaRequerida != 'A-IIIc' AND @LicenciaRequerida != 'A-IIIb'
						set @Resultado = 'SI'
					ELSE IF @Licencia = 'A-IIb' AND (@LicenciaRequerida = 'A-IIa' OR @LicenciaRequerida = 'A-I')
						set @Resultado = 'SI'
					ELSE IF @Licencia = 'A-IIa' AND @LicenciaRequerida = 'A-I'
						set @Resultado = 'SI'
				END
				ELSE IF LEFT(@LicenciaRequerida, 1) = 'B'
				BEGIN
					IF @LicenciaRequerida = 'B-IIa' and (@Licencia = 'B-IIb' OR @Licencia = 'B-IIc') 
						set @Resultado = 'SI'
					ELSE IF @LicenciaRequerida = 'B-IIb' and @Licencia = 'B-IIc'
						set @Resultado = 'SI'
				END
			END
	return @Resultado
end
go

drop procedure if exists SP_IngresarPostulante
go

create procedure SP_IngresarPostulante 
(@CodOferta int,
@IdPostulante char(04)
)
as
begin
	declare @Resultado varchar(100) = 'Ingresado'
	IF (select count(*) from Postulacion_Preseleccion 
			where CodOferta = @CodOferta and IdPostulante = @IdPostulante) > 0
			set @Resultado = 'El postulante ya ha sido ingresado'
	ELSE IF (select FechaFin from Oferta where CodOferta = @CodOferta) < GETDATE()
			set @Resultado = 'La oferta ya no acepta nuevas postulaciones'
	ELSE
		BEGIN	
			IF (select DisponibilidadViajar from Oferta where CodOferta = @CodOferta) = 'SI'
			BEGIN
				IF (select DisponibilidadViajar from Postulante where IdPostulante = @IdPostulante) = 'NO'
				set @Resultado = 'Se requiere disponibilidad para viajar'
			END
			IF(select MovilidadPropia from Oferta O where CodOferta = @CodOferta) = 'SI'
			BEGIN
				IF (select MovilidadPropia from Postulante where IdPostulante = @IdPostulante) = 'NO'
				set @Resultado = 'Se requiere movilidad propia'
			END
			IF(select LicenciaConducir from Oferta where CodOferta = @CodOferta) = 'SI'
			BEGIN
				IF (select LicenciaConducir from Postulante where IdPostulante = @IdPostulante) = 'NO'
				set @Resultado = 'Se requiere una licencia para conducir'
				ELSE
				BEGIN
					IF dbo.F_ValidarLicencia((select TipoLicencia from Postulante where IdPostulante = @IdPostulante), 
											(select TipoLicencia from Oferta where CodOferta = @CodOferta)) = 'NO'
					set @Resultado = 'La licencia no es válida para el requerimiento'
				END
			END
			IF(select Discapacidad from Oferta where CodOferta = @CodOferta) = 'NO'
			BEGIN
				IF (select Discapacidad from Postulante where IdPostulante = @IdPostulante) = 'SI'
				set @Resultado = 'Lastimosamente, no se aceptan personas con discapacidades'
			END
		END
	IF @Resultado = 'Ingresado'
		INSERT INTO Postulacion_Preseleccion(IdPostulante, CodOferta, FechaPostulacion) values(@IdPostulante, @CodOferta, GETDATE())
	Select @Resultado as [Resultado]
end
go
