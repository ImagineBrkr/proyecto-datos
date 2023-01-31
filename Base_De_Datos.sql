use master 
go

drop database if exists BD_ContratacionEmpleos
go

create database BD_ContratacionEmpleos
go

use BD_ContratacionEmpleos
go


CREATE TABLE Area
( 
	IdArea               char(4)  NOT NULL ,
	Descripcion          varchar(50)  NOT NULL 
)
go



ALTER TABLE Area
	ADD CONSTRAINT XPKArea PRIMARY KEY  CLUSTERED (IdArea ASC)
go



CREATE TABLE Beneficios
( 
	CodOferta            int  NOT NULL ,
	CodBeneficios        int IDENTITY ( 1,1 ) ,
	Descripcion          varchar(500)  NULL 
)
go



ALTER TABLE Beneficios
	ADD CONSTRAINT XPKBeneficios PRIMARY KEY  CLUSTERED (CodOferta ASC,CodBeneficios ASC)
go



CREATE TABLE ContactoEmpresa
( 
	DNIContacto          char(8)  NOT NULL ,
	Nombres              varchar(50)  NOT NULL ,
	Apellidos            varchar(50)  NOT NULL ,
	Cargo                varchar(50)  NOT NULL ,
	Telefono             varchar(15)  NOT NULL ,
	Email                varchar(100)  NULL 
)
go



ALTER TABLE ContactoEmpresa
	ADD CONSTRAINT XPKContactoEmpresa PRIMARY KEY  CLUSTERED (DNIContacto ASC)
go



CREATE TABLE Director_RRHH
( 
	CodDirector          char(4)  NOT NULL ,
	Nombres              varchar(50)  NOT NULL ,
	Apellidos            varchar(50)  NOT NULL 
)
go



ALTER TABLE Director_RRHH
	ADD CONSTRAINT XPKDirector_RRHH PRIMARY KEY  CLUSTERED (CodDirector ASC)
go



CREATE TABLE Empresa
( 
	DNIContacto          char(8)  NOT NULL ,
	IdEmpresa            char(4)  NOT NULL ,
	Nombre               varchar(100)  NOT NULL ,
	Rubro                varchar(50)  NOT NULL ,
	RUC                  char(11)  NOT NULL 
)
go



ALTER TABLE Empresa
	ADD CONSTRAINT XPKEmpresa PRIMARY KEY  CLUSTERED (IdEmpresa ASC)
go



CREATE TABLE Estudios
( 
	IdPostulante         char(4)  NOT NULL ,
	CodEstudios          int IDENTITY ( 1,1 ) ,
	GradoAcademico       varchar(30)  NOT NULL ,
	Institucion          varchar(100)  NOT NULL ,
	Carrera              varchar(100)  NULL ,
	FechaInicio          datetime  NOT NULL ,
	AlPresente           char(2)  NULL 
	CONSTRAINT C_AlPresente_1828069274
		CHECK  ( AlPresente IN ('SI', 'NO') ),
	FechaFin             datetime  NULL 
)
go



ALTER TABLE Estudios
	ADD CONSTRAINT XPKEstudios PRIMARY KEY  CLUSTERED (IdPostulante ASC,CodEstudios ASC)
go



CREATE TABLE EstudiosPostgrado
( 
	CodEstudiosPostgrado int IDENTITY ( 1,1 ) ,
	TipoEstudios         varchar(50)  NOT NULL ,
	NombreEstudio        varchar(100)  NOT NULL ,
	Institucion          varchar(100)  NOT NULL ,
	FechaInicio          datetime  NOT NULL ,
	AlPresente           char(2)  NOT NULL 
	CONSTRAINT C_AlPresente_1894905154
		CHECK  ( AlPresente IN ('SI', 'NO') ),
	FechaFin             datetime  NULL ,
	IdPostulante         char(4)  NOT NULL 
)
go



ALTER TABLE EstudiosPostgrado
	ADD CONSTRAINT XPKEstudiosPostgrado PRIMARY KEY  CLUSTERED (CodEstudiosPostgrado ASC,IdPostulante ASC)
go



CREATE TABLE Evaluacion
( 
	IdEvaluacion         int IDENTITY ( 1,1 ) ,
	Prueba               varchar(50)  NOT NULL ,
	Descripcion          varchar(500)  NOT NULL ,
	TiempoLimite         varchar(20)  NOT NULL ,
	IdTipoEvaluacion     char(4)  NOT NULL 
)
go



ALTER TABLE Evaluacion
	ADD CONSTRAINT XPKEvaluación PRIMARY KEY  CLUSTERED (IdEvaluacion ASC)
go



CREATE TABLE ExperienciaLaboral
( 
	IdPostulante         char(4)  NOT NULL ,
	CodExperiencia       int IDENTITY ( 1,1 ) ,
	Empresa              varchar(50)  NOT NULL ,
	Puesto               varchar(50)  NOT NULL ,
	FechaInicio          datetime  NOT NULL ,
	AlPresente           char(2)  NULL 
	CONSTRAINT C_AlPresente_1925522148
		CHECK  ( AlPresente IN ('SI', 'NO') ),
	FechaFin             datetime  NULL ,
	PersonasACargo       int  NULL 
	CONSTRAINT D_PersonasACargo_1926531169
		 DEFAULT  0,
	Salario              float  NULL ,
	IdArea               char(4)  NULL 
)
go



ALTER TABLE ExperienciaLaboral
	ADD CONSTRAINT XPKExperienciaLaboral PRIMARY KEY  CLUSTERED (IdPostulante ASC,CodExperiencia ASC)
go



CREATE TABLE Funciones
( 
	CodOferta            int  NOT NULL ,
	CodFuncion           int IDENTITY ( 1,1 ) ,
	Descripcion          varchar(500)  NULL 
)
go



ALTER TABLE Funciones
	ADD CONSTRAINT XPKFunciones PRIMARY KEY  CLUSTERED (CodOferta ASC,CodFuncion ASC)
go



CREATE TABLE Idiomas
( 
	CodIdioma            int IDENTITY ( 1,1 ) ,
	Idioma               varchar(100)  NULL ,
	Nivel                varchar(15)  NOT NULL 
	CONSTRAINT C_Nivel_1814429444
		CHECK  ( Nivel IN ('Básico', 'Intermedio', 'Avanzado', 'Experto') ),
	IdPostulante         char(4)  NOT NULL 
)
go



ALTER TABLE Idiomas
	ADD CONSTRAINT XPKIdiomas PRIMARY KEY  CLUSTERED (CodIdioma ASC,IdPostulante ASC)
go



CREATE TABLE Oferta
( 
	IdEmpresa            char(4)  NOT NULL ,
	CodOferta            int IDENTITY ( 1,1 ) ,
	Descripcion          varchar(1000)  NOT NULL ,
	FechaPublicacion     datetime  NOT NULL ,
	TipoHorario          varchar(50)  NOT NULL ,
	NivelLaboral         varchar(50)  NOT NULL ,
	DisponibilidadViajar char(2)  NOT NULL 
	CONSTRAINT C_DisponibilidadViajar_1578268937
		CHECK  ( DisponibilidadViajar IN ('SI', 'NO') ),
	MovilidadPropia      char(2)  NOT NULL 
	CONSTRAINT C_MovilidadPropia_1919679245
		CHECK  ( MovilidadPropia IN ('SI', 'NO') ),
	Discapacidad         char(2)  NOT NULL 
	CONSTRAINT Default_Value_796_1131962912
		 DEFAULT  'SI'
	CONSTRAINT C_Discapacidad_154201659
		CHECK  ( Discapacidad IN ('SI', 'NO') ),
	IdRegion             char(4)  NULL ,
	IdArea               char(4)  NULL ,
	FechaFin             datetime  NOT NULL ,
	LicenciaConducir     char(2)  NULL 
	CONSTRAINT C_LicenciaConducir_603668210
		CHECK  ( LicenciaConducir IN ('SI', 'NO') ),
	TipoLicencia         varchar(6)  NULL 
	CONSTRAINT C_TipoLicencia_271840574
		CHECK  ( TipoLicencia IN('A-I', 'A-IIa', 'A-IIb', 'A-IIIb', 'A-IIb', 'A-IIIa', 'A-IIIc', 'B-I', 'B-IIa', 'B-IIb', 'B-IIc') )
)
go



ALTER TABLE Oferta
	ADD CONSTRAINT XPKOferta PRIMARY KEY  CLUSTERED (CodOferta ASC)
go



CREATE TABLE Oferta_Evaluacion
( 
	IdEvaluacion         int  NOT NULL ,
	CodOferta            int  NOT NULL ,
	CalificacionMinima   int  NOT NULL 
	CONSTRAINT D_CalificacionMinima_1018043544
		 DEFAULT  11
	CONSTRAINT C_CalificacionEvaluacion_1843753965
		CHECK  ( CalificacionMinima BETWEEN 0 AND 20 )
)
go



ALTER TABLE Oferta_Evaluacion
	ADD CONSTRAINT XPKOferta_Evaluacion PRIMARY KEY  CLUSTERED (IdEvaluacion ASC,CodOferta ASC)
go



CREATE TABLE Postulacion_Preseleccion
( 
	IdPostulante         char(4)  NOT NULL ,
	CodOferta            int  NOT NULL ,
	FechaPostulacion     datetime  NULL 
)
go



ALTER TABLE Postulacion_Preseleccion
	ADD CONSTRAINT XPKPostulacion_Preseleccion PRIMARY KEY  CLUSTERED (IdPostulante ASC,CodOferta ASC)
go



CREATE TABLE Postulacion_Seleccion
( 
	IdPostulante         char(4)  NOT NULL ,
	CodOferta            int  NOT NULL ,
	CodDirector          char(4)  NULL ,
	Resultado            varchar(20)  NULL 
	CONSTRAINT D_Resultado_470555228
		 DEFAULT  'En evaluacion'
	CONSTRAINT C_Resultado_470489692
		CHECK  ( Resultado IN ('Seleccionado', 'En evaluacion', 'No aprobado', 'Contratado') )
)
go



ALTER TABLE Postulacion_Seleccion
	ADD CONSTRAINT XPKPostulacion_Seleccion PRIMARY KEY  CLUSTERED (IdPostulante ASC,CodOferta ASC)
go



CREATE TABLE Postulante
( 
	IdPostulante         char(4)  NOT NULL ,
	Nombres              varchar(50)  NOT NULL ,
	Apellidos            varchar(50)  NOT NULL ,
	Email                varchar(100)  NOT NULL ,
	Sexo                 varchar(10)  NOT NULL 
	CONSTRAINT D_Sexo_102098199
		 DEFAULT  'Masculino'
	CONSTRAINT C_Sexo_102097943
		CHECK  ( Sexo IN ('Masculino', 'Femenino', 'Otros') ),
	TelFijo              varchar(11)  NULL ,
	TelCelular           varchar(13)  NOT NULL ,
	TipoDocumento        varchar(21)  NOT NULL 
	CONSTRAINT D_TipoDocumento_2002242289
		 DEFAULT  'DNI'
	CONSTRAINT C_TipoDocumento_2002307825
		CHECK  ( TipoDocumento IN ('DNI', 'Pasaporte', 'Carné de extranjería') ),
	NroDocumento         varchar(10)  NOT NULL ,
	FechaNacimiento      datetime  NULL ,
	EstadoCivil          varchar(20)  NULL 
	CONSTRAINT C_EstadoCivil_525314675
		CHECK  ( EstadoCivil IN ('Soltero', 'Casado', 'Conviviente', 'Divorciado', 'Separado', 'Viudo') ),
	Provincia            varchar(100)  NULL ,
	Distrito             varchar(100)  NULL ,
	Direccion            varchar(100)  NULL ,
	MovilidadPropia      char(2)  NOT NULL 
	CONSTRAINT C_MovilidadPropia_50037908
		CHECK  ( MovilidadPropia IN ('SI', 'NO') ),
	DisponibilidadViajar char(2)  NOT NULL 
	CONSTRAINT C_DisponibilidadViajar_409400936
		CHECK  ( DisponibilidadViajar IN ('SI', 'NO') ),
	LicenciaConducir     char(2)  NOT NULL 
	CONSTRAINT C_LicenciaConducir_1384001663
		CHECK  ( LicenciaConducir IN ('SI', 'NO') ),
	Discapacidad         char(2)  NOT NULL 
	CONSTRAINT D_Discapacidad_2141871787
		 DEFAULT  'NO'
	CONSTRAINT C_Discapacidad_2141871531
		CHECK  ( Discapacidad IN ('SI', 'NO') ),
	IdRegion             char(4)  NOT NULL ,
	TipoLicencia         varchar(6)  NULL 
	CONSTRAINT C_TipoLicencia_2035456850
		CHECK  ( TipoLicencia IN('A-I', 'A-IIa', 'A-IIb', 'A-IIIb', 'A-IIb', 'A-IIIa', 'A-IIIc', 'B-I', 'B-IIa', 'B-IIb', 'B-IIc') )
)
go



ALTER TABLE Postulante
	ADD CONSTRAINT XPKPostulante PRIMARY KEY  CLUSTERED (IdPostulante ASC)
go



CREATE TABLE Postulante_Evaluacion
( 
	IdPostulante         char(4)  NOT NULL ,
	IdEvaluacion         int  NOT NULL ,
	CodOferta            int  NOT NULL ,
	FechaEvaluacion      datetime  NOT NULL ,
	Calificacion         int  NOT NULL 
	CONSTRAINT C_Calificacion_1508742614
		CHECK  ( Calificacion BETWEEN 0 AND 20 )
)
go



ALTER TABLE Postulante_Evaluacion
	ADD CONSTRAINT XPKPostulante_Evaluacion PRIMARY KEY  CLUSTERED (IdPostulante ASC,IdEvaluacion ASC,CodOferta ASC)
go



CREATE TABLE Referencias
( 
	IdPostulante         char(4)  NOT NULL ,
	CodReferencia        int IDENTITY ( 1,1 ) ,
	Nombres              varchar(50)  NOT NULL ,
	Apellidos            varchar(50)  NULL ,
	Correo               varchar(100)  NOT NULL ,
	Telefono             varchar(12)  NULL ,
	TipoReferencia       varchar(20)  NOT NULL 
	CONSTRAINT C_TipoReferencia_99103144
		CHECK  ( TipoReferencia IN ('Laboral', 'De estudio') ),
	TipoRelacion         varchar(20)  NOT NULL ,
	Empresa              varchar(100)  NULL ,
	Puesto               varchar(100)  NULL 
)
go



ALTER TABLE Referencias
	ADD CONSTRAINT XPKReferencias PRIMARY KEY  CLUSTERED (IdPostulante ASC,CodReferencia ASC)
go



CREATE TABLE Region
( 
	IdRegion             char(4)  NOT NULL ,
	Nombre               varchar(30)  NOT NULL 
)
go



ALTER TABLE Region
	ADD CONSTRAINT XPKRegion PRIMARY KEY  CLUSTERED (IdRegion ASC)
go



CREATE TABLE Requerimiento
( 
	CodOferta            int  NOT NULL ,
	CodRequerimiento     int IDENTITY ( 1,1 ) ,
	Descripcion          varchar(500)  NOT NULL ,
	Prioridad            varchar(10)  NOT NULL 
	CONSTRAINT C_Prioridad_1077302664
		CHECK  ( Prioridad IN ('Alta', 'Media', 'Baja') )
)
go



ALTER TABLE Requerimiento
	ADD CONSTRAINT XPKRequermiento PRIMARY KEY  CLUSTERED (CodOferta ASC,CodRequerimiento ASC)
go



CREATE TABLE Software
( 
	CodSoftware          int IDENTITY ( 1,1 ) ,
	Software             varchar(100)  NOT NULL ,
	Nivel                varchar(15)  NOT NULL 
	CONSTRAINT C_Nivel_285993991
		CHECK  ( Nivel IN ('Básico', 'Intermedio', 'Avanzado', 'Experto') ),
	IdPostulante         char(4)  NOT NULL 
)
go



ALTER TABLE Software
	ADD CONSTRAINT XPKSoftware PRIMARY KEY  CLUSTERED (CodSoftware ASC,IdPostulante ASC)
go



CREATE TABLE TipoEvaluacion
( 
	IdTipoEvaluacion     char(4)  NOT NULL ,
	Nombre               varchar(50)  NOT NULL 
)
go



ALTER TABLE TipoEvaluacion
	ADD CONSTRAINT XPKTipoEvaluacion PRIMARY KEY  CLUSTERED (IdTipoEvaluacion ASC)
go




ALTER TABLE Beneficios
	ADD CONSTRAINT R_3 FOREIGN KEY (CodOferta) REFERENCES Oferta(CodOferta)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Empresa
	ADD CONSTRAINT R_19 FOREIGN KEY (DNIContacto) REFERENCES ContactoEmpresa(DNIContacto)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Estudios
	ADD CONSTRAINT R_21 FOREIGN KEY (IdPostulante) REFERENCES Postulante(IdPostulante)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE EstudiosPostgrado
	ADD CONSTRAINT R_22 FOREIGN KEY (IdPostulante) REFERENCES Postulante(IdPostulante)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Evaluacion
	ADD CONSTRAINT R_32 FOREIGN KEY (IdTipoEvaluacion) REFERENCES TipoEvaluacion(IdTipoEvaluacion)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE ExperienciaLaboral
	ADD CONSTRAINT R_20 FOREIGN KEY (IdPostulante) REFERENCES Postulante(IdPostulante)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE ExperienciaLaboral
	ADD CONSTRAINT R_33 FOREIGN KEY (IdArea) REFERENCES Area(IdArea)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Funciones
	ADD CONSTRAINT R_2 FOREIGN KEY (CodOferta) REFERENCES Oferta(CodOferta)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Idiomas
	ADD CONSTRAINT R_23 FOREIGN KEY (IdPostulante) REFERENCES Postulante(IdPostulante)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Oferta
	ADD CONSTRAINT R_26 FOREIGN KEY (IdEmpresa) REFERENCES Empresa(IdEmpresa)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Oferta
	ADD CONSTRAINT R_28 FOREIGN KEY (IdRegion) REFERENCES Region(IdRegion)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Oferta
	ADD CONSTRAINT R_31 FOREIGN KEY (IdArea) REFERENCES Area(IdArea)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Oferta_Evaluacion
	ADD CONSTRAINT R_15 FOREIGN KEY (IdEvaluacion) REFERENCES Evaluacion(IdEvaluacion)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Oferta_Evaluacion
	ADD CONSTRAINT R_14 FOREIGN KEY (CodOferta) REFERENCES Oferta(CodOferta)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Postulacion_Preseleccion
	ADD CONSTRAINT R_9 FOREIGN KEY (IdPostulante) REFERENCES Postulante(IdPostulante)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Postulacion_Preseleccion
	ADD CONSTRAINT R_10 FOREIGN KEY (CodOferta) REFERENCES Oferta(CodOferta)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Postulacion_Seleccion
	ADD CONSTRAINT R_18 FOREIGN KEY (IdPostulante,CodOferta) REFERENCES Postulacion_Preseleccion(IdPostulante,CodOferta)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Postulacion_Seleccion
	ADD CONSTRAINT R_34 FOREIGN KEY (CodDirector) REFERENCES Director_RRHH(CodDirector)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Postulante
	ADD CONSTRAINT R_30 FOREIGN KEY (IdRegion) REFERENCES Region(IdRegion)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Postulante_Evaluacion
	ADD CONSTRAINT R_16 FOREIGN KEY (IdPostulante) REFERENCES Postulante(IdPostulante)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Postulante_Evaluacion
	ADD CONSTRAINT R_17 FOREIGN KEY (IdEvaluacion,CodOferta) REFERENCES Oferta_Evaluacion(IdEvaluacion,CodOferta)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Referencias
	ADD CONSTRAINT R_25 FOREIGN KEY (IdPostulante) REFERENCES Postulante(IdPostulante)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Requerimiento
	ADD CONSTRAINT R_13 FOREIGN KEY (CodOferta) REFERENCES Oferta(CodOferta)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE Software
	ADD CONSTRAINT R_24 FOREIGN KEY (IdPostulante) REFERENCES Postulante(IdPostulante)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




CREATE TRIGGER tD_Area ON Area FOR DELETE AS
/* ERwin Builtin Trigger */
/* DELETE trigger on Area */
BEGIN
  DECLARE  @errno   int,
           @errmsg  varchar(255)
    /* ERwin Builtin Trigger */
    /* Area  Oferta on parent delete no action */
    /* ERWIN_RELATION:CHECKSUM="0001e0d4", PARENT_OWNER="", PARENT_TABLE="Area"
    CHILD_OWNER="", CHILD_TABLE="Oferta"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_31", FK_COLUMNS="IdArea" */
    IF EXISTS (
      SELECT * FROM deleted,Oferta
      WHERE
        /*  %JoinFKPK(Oferta,deleted," = "," AND") */
        Oferta.IdArea = deleted.IdArea
    )
    BEGIN
      SELECT @errno  = 30001,
             @errmsg = 'Cannot delete Area because Oferta exists.'
      GOTO ERROR
    END

    /* ERwin Builtin Trigger */
    /* Area  ExperienciaLaboral on parent delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Area"
    CHILD_OWNER="", CHILD_TABLE="ExperienciaLaboral"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_33", FK_COLUMNS="IdArea" */
    IF EXISTS (
      SELECT * FROM deleted,ExperienciaLaboral
      WHERE
        /*  %JoinFKPK(ExperienciaLaboral,deleted," = "," AND") */
        ExperienciaLaboral.IdArea = deleted.IdArea
    )
    BEGIN
      SELECT @errno  = 30001,
             @errmsg = 'Cannot delete Area because ExperienciaLaboral exists.'
      GOTO ERROR
    END


    /* ERwin Builtin Trigger */
    RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END

go


CREATE TRIGGER tU_Area ON Area FOR UPDATE AS
/* ERwin Builtin Trigger */
/* UPDATE trigger on Area */
BEGIN
  DECLARE  @NUMROWS int,
           @nullcnt int,
           @validcnt int,
           @insIdArea char(4),
           @errno   int,
           @errmsg  varchar(255)

  SELECT @NUMROWS = @@rowcount
  /* ERwin Builtin Trigger */
  /* Area  Oferta on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="000216fa", PARENT_OWNER="", PARENT_TABLE="Area"
    CHILD_OWNER="", CHILD_TABLE="Oferta"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_31", FK_COLUMNS="IdArea" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(IdArea)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,Oferta
      WHERE
        /*  %JoinFKPK(Oferta,deleted," = "," AND") */
        Oferta.IdArea = deleted.IdArea
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update Area because Oferta exists.'
      GOTO ERROR
    END
  END

  /* ERwin Builtin Trigger */
  /* Area  ExperienciaLaboral on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Area"
    CHILD_OWNER="", CHILD_TABLE="ExperienciaLaboral"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_33", FK_COLUMNS="IdArea" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(IdArea)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,ExperienciaLaboral
      WHERE
        /*  %JoinFKPK(ExperienciaLaboral,deleted," = "," AND") */
        ExperienciaLaboral.IdArea = deleted.IdArea
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update Area because ExperienciaLaboral exists.'
      GOTO ERROR
    END
  END


  /* ERwin Builtin Trigger */
  RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END

go




CREATE TRIGGER tD_Beneficios ON Beneficios FOR DELETE AS
/* ERwin Builtin Trigger */
/* DELETE trigger on Beneficios */
BEGIN
  DECLARE  @errno   int,
           @errmsg  varchar(255)
    /* ERwin Builtin Trigger */
    /* Oferta  Beneficios on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="00012f8a", PARENT_OWNER="", PARENT_TABLE="Oferta"
    CHILD_OWNER="", CHILD_TABLE="Beneficios"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_3", FK_COLUMNS="CodOferta" */
    IF EXISTS (SELECT * FROM deleted,Oferta
      WHERE
        /* %JoinFKPK(deleted,Oferta," = "," AND") */
        deleted.CodOferta = Oferta.CodOferta AND
        NOT EXISTS (
          SELECT * FROM Beneficios
          WHERE
            /* %JoinFKPK(Beneficios,Oferta," = "," AND") */
            Beneficios.CodOferta = Oferta.CodOferta
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last Beneficios because Oferta exists.'
      GOTO ERROR
    END


    /* ERwin Builtin Trigger */
    RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END

go


CREATE TRIGGER tU_Beneficios ON Beneficios FOR UPDATE AS
/* ERwin Builtin Trigger */
/* UPDATE trigger on Beneficios */
BEGIN
  DECLARE  @NUMROWS int,
           @nullcnt int,
           @validcnt int,
           @insCodOferta int, 
           @insCodBeneficios int,
           @errno   int,
           @errmsg  varchar(255)

  SELECT @NUMROWS = @@rowcount
  /* ERwin Builtin Trigger */
  /* Oferta  Beneficios on child update no action */
  /* ERWIN_RELATION:CHECKSUM="00014f45", PARENT_OWNER="", PARENT_TABLE="Oferta"
    CHILD_OWNER="", CHILD_TABLE="Beneficios"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_3", FK_COLUMNS="CodOferta" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(CodOferta)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,Oferta
        WHERE
          /* %JoinFKPK(inserted,Oferta) */
          inserted.CodOferta = Oferta.CodOferta
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    
    IF @validcnt + @nullcnt != @NUMROWS
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update Beneficios because Oferta does not exist.'
      GOTO ERROR
    END
  END


  /* ERwin Builtin Trigger */
  RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END

go




CREATE TRIGGER tD_ContactoEmpresa ON ContactoEmpresa FOR DELETE AS
/* ERwin Builtin Trigger */
/* DELETE trigger on ContactoEmpresa */
BEGIN
  DECLARE  @errno   int,
           @errmsg  varchar(255)
    /* ERwin Builtin Trigger */
    /* ContactoEmpresa  Empresa on parent delete no action */
    /* ERWIN_RELATION:CHECKSUM="0000f2d7", PARENT_OWNER="", PARENT_TABLE="ContactoEmpresa"
    CHILD_OWNER="", CHILD_TABLE="Empresa"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_19", FK_COLUMNS="DNIContacto" */
    IF EXISTS (
      SELECT * FROM deleted,Empresa
      WHERE
        /*  %JoinFKPK(Empresa,deleted," = "," AND") */
        Empresa.DNIContacto = deleted.DNIContacto
    )
    BEGIN
      SELECT @errno  = 30001,
             @errmsg = 'Cannot delete ContactoEmpresa because Empresa exists.'
      GOTO ERROR
    END


    /* ERwin Builtin Trigger */
    RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END

go


CREATE TRIGGER tU_ContactoEmpresa ON ContactoEmpresa FOR UPDATE AS
/* ERwin Builtin Trigger */
/* UPDATE trigger on ContactoEmpresa */
BEGIN
  DECLARE  @NUMROWS int,
           @nullcnt int,
           @validcnt int,
           @insDNIContacto char(8),
           @errno   int,
           @errmsg  varchar(255)

  SELECT @NUMROWS = @@rowcount
  /* ERwin Builtin Trigger */
  /* ContactoEmpresa  Empresa on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="00011cd0", PARENT_OWNER="", PARENT_TABLE="ContactoEmpresa"
    CHILD_OWNER="", CHILD_TABLE="Empresa"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_19", FK_COLUMNS="DNIContacto" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(DNIContacto)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,Empresa
      WHERE
        /*  %JoinFKPK(Empresa,deleted," = "," AND") */
        Empresa.DNIContacto = deleted.DNIContacto
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update ContactoEmpresa because Empresa exists.'
      GOTO ERROR
    END
  END


  /* ERwin Builtin Trigger */
  RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END

go




CREATE TRIGGER tD_Director_RRHH ON Director_RRHH FOR DELETE AS
/* ERwin Builtin Trigger */
/* DELETE trigger on Director_RRHH */
BEGIN
  DECLARE  @errno   int,
           @errmsg  varchar(255)
    /* ERwin Builtin Trigger */
    /* Director_RRHH  Postulacion_Seleccion on parent delete no action */
    /* ERWIN_RELATION:CHECKSUM="00011eb8", PARENT_OWNER="", PARENT_TABLE="Director_RRHH"
    CHILD_OWNER="", CHILD_TABLE="Postulacion_Seleccion"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_34", FK_COLUMNS="CodDirector" */
    IF EXISTS (
      SELECT * FROM deleted,Postulacion_Seleccion
      WHERE
        /*  %JoinFKPK(Postulacion_Seleccion,deleted," = "," AND") */
        Postulacion_Seleccion.CodDirector = deleted.CodDirector
    )
    BEGIN
      SELECT @errno  = 30001,
             @errmsg = 'Cannot delete Director_RRHH because Postulacion_Seleccion exists.'
      GOTO ERROR
    END


    /* ERwin Builtin Trigger */
    RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END

go


CREATE TRIGGER tU_Director_RRHH ON Director_RRHH FOR UPDATE AS
/* ERwin Builtin Trigger */
/* UPDATE trigger on Director_RRHH */
BEGIN
  DECLARE  @NUMROWS int,
           @nullcnt int,
           @validcnt int,
           @insCodDirector char(4),
           @errno   int,
           @errmsg  varchar(255)

  SELECT @NUMROWS = @@rowcount
  /* ERwin Builtin Trigger */
  /* Director_RRHH  Postulacion_Seleccion on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="000130b7", PARENT_OWNER="", PARENT_TABLE="Director_RRHH"
    CHILD_OWNER="", CHILD_TABLE="Postulacion_Seleccion"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_34", FK_COLUMNS="CodDirector" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(CodDirector)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,Postulacion_Seleccion
      WHERE
        /*  %JoinFKPK(Postulacion_Seleccion,deleted," = "," AND") */
        Postulacion_Seleccion.CodDirector = deleted.CodDirector
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update Director_RRHH because Postulacion_Seleccion exists.'
      GOTO ERROR
    END
  END


  /* ERwin Builtin Trigger */
  RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END

go




CREATE TRIGGER tD_Empresa ON Empresa FOR DELETE AS
/* ERwin Builtin Trigger */
/* DELETE trigger on Empresa */
BEGIN
  DECLARE  @errno   int,
           @errmsg  varchar(255)
    /* ERwin Builtin Trigger */
    /* Empresa  Oferta on parent delete no action */
    /* ERWIN_RELATION:CHECKSUM="00023cbf", PARENT_OWNER="", PARENT_TABLE="Empresa"
    CHILD_OWNER="", CHILD_TABLE="Oferta"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_26", FK_COLUMNS="IdEmpresa" */
    IF EXISTS (
      SELECT * FROM deleted,Oferta
      WHERE
        /*  %JoinFKPK(Oferta,deleted," = "," AND") */
        Oferta.IdEmpresa = deleted.IdEmpresa
    )
    BEGIN
      SELECT @errno  = 30001,
             @errmsg = 'Cannot delete Empresa because Oferta exists.'
      GOTO ERROR
    END

    /* ERwin Builtin Trigger */
    /* ContactoEmpresa  Empresa on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="ContactoEmpresa"
    CHILD_OWNER="", CHILD_TABLE="Empresa"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_19", FK_COLUMNS="DNIContacto" */
    IF EXISTS (SELECT * FROM deleted,ContactoEmpresa
      WHERE
        /* %JoinFKPK(deleted,ContactoEmpresa," = "," AND") */
        deleted.DNIContacto = ContactoEmpresa.DNIContacto AND
        NOT EXISTS (
          SELECT * FROM Empresa
          WHERE
            /* %JoinFKPK(Empresa,ContactoEmpresa," = "," AND") */
            Empresa.DNIContacto = ContactoEmpresa.DNIContacto
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last Empresa because ContactoEmpresa exists.'
      GOTO ERROR
    END


    /* ERwin Builtin Trigger */
    RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END

go


CREATE TRIGGER tU_Empresa ON Empresa FOR UPDATE AS
/* ERwin Builtin Trigger */
/* UPDATE trigger on Empresa */
BEGIN
  DECLARE  @NUMROWS int,
           @nullcnt int,
           @validcnt int,
           @insIdEmpresa char(4),
           @errno   int,
           @errmsg  varchar(255)

  SELECT @NUMROWS = @@rowcount
  /* ERwin Builtin Trigger */
  /* Empresa  Oferta on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="00027dda", PARENT_OWNER="", PARENT_TABLE="Empresa"
    CHILD_OWNER="", CHILD_TABLE="Oferta"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_26", FK_COLUMNS="IdEmpresa" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(IdEmpresa)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,Oferta
      WHERE
        /*  %JoinFKPK(Oferta,deleted," = "," AND") */
        Oferta.IdEmpresa = deleted.IdEmpresa
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update Empresa because Oferta exists.'
      GOTO ERROR
    END
  END

  /* ERwin Builtin Trigger */
  /* ContactoEmpresa  Empresa on child update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="ContactoEmpresa"
    CHILD_OWNER="", CHILD_TABLE="Empresa"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_19", FK_COLUMNS="DNIContacto" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(DNIContacto)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,ContactoEmpresa
        WHERE
          /* %JoinFKPK(inserted,ContactoEmpresa) */
          inserted.DNIContacto = ContactoEmpresa.DNIContacto
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    select @nullcnt = count(*) from inserted where
      inserted.DNIContacto IS NULL
    IF @validcnt + @nullcnt != @NUMROWS
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update Empresa because ContactoEmpresa does not exist.'
      GOTO ERROR
    END
  END


  /* ERwin Builtin Trigger */
  RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END

go




CREATE TRIGGER tD_Estudios ON Estudios FOR DELETE AS
/* ERwin Builtin Trigger */
/* DELETE trigger on Estudios */
BEGIN
  DECLARE  @errno   int,
           @errmsg  varchar(255)
    /* ERwin Builtin Trigger */
    /* Postulante  Estudios on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="00013bda", PARENT_OWNER="", PARENT_TABLE="Postulante"
    CHILD_OWNER="", CHILD_TABLE="Estudios"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_21", FK_COLUMNS="IdPostulante" */
    IF EXISTS (SELECT * FROM deleted,Postulante
      WHERE
        /* %JoinFKPK(deleted,Postulante," = "," AND") */
        deleted.IdPostulante = Postulante.IdPostulante AND
        NOT EXISTS (
          SELECT * FROM Estudios
          WHERE
            /* %JoinFKPK(Estudios,Postulante," = "," AND") */
            Estudios.IdPostulante = Postulante.IdPostulante
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last Estudios because Postulante exists.'
      GOTO ERROR
    END


    /* ERwin Builtin Trigger */
    RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END

go


CREATE TRIGGER tU_Estudios ON Estudios FOR UPDATE AS
/* ERwin Builtin Trigger */
/* UPDATE trigger on Estudios */
BEGIN
  DECLARE  @NUMROWS int,
           @nullcnt int,
           @validcnt int,
           @insIdPostulante char(4), 
           @insCodEstudios int,
           @errno   int,
           @errmsg  varchar(255)

  SELECT @NUMROWS = @@rowcount
  /* ERwin Builtin Trigger */
  /* Postulante  Estudios on child update no action */
  /* ERWIN_RELATION:CHECKSUM="000156c7", PARENT_OWNER="", PARENT_TABLE="Postulante"
    CHILD_OWNER="", CHILD_TABLE="Estudios"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_21", FK_COLUMNS="IdPostulante" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(IdPostulante)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,Postulante
        WHERE
          /* %JoinFKPK(inserted,Postulante) */
          inserted.IdPostulante = Postulante.IdPostulante
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    
    IF @validcnt + @nullcnt != @NUMROWS
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update Estudios because Postulante does not exist.'
      GOTO ERROR
    END
  END


  /* ERwin Builtin Trigger */
  RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END

go




CREATE TRIGGER tD_EstudiosPostgrado ON EstudiosPostgrado FOR DELETE AS
/* ERwin Builtin Trigger */
/* DELETE trigger on EstudiosPostgrado */
BEGIN
  DECLARE  @errno   int,
           @errmsg  varchar(255)
    /* ERwin Builtin Trigger */
    /* Postulante  EstudiosPostgrado on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="00015756", PARENT_OWNER="", PARENT_TABLE="Postulante"
    CHILD_OWNER="", CHILD_TABLE="EstudiosPostgrado"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_22", FK_COLUMNS="IdPostulante" */
    IF EXISTS (SELECT * FROM deleted,Postulante
      WHERE
        /* %JoinFKPK(deleted,Postulante," = "," AND") */
        deleted.IdPostulante = Postulante.IdPostulante AND
        NOT EXISTS (
          SELECT * FROM EstudiosPostgrado
          WHERE
            /* %JoinFKPK(EstudiosPostgrado,Postulante," = "," AND") */
            EstudiosPostgrado.IdPostulante = Postulante.IdPostulante
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last EstudiosPostgrado because Postulante exists.'
      GOTO ERROR
    END


    /* ERwin Builtin Trigger */
    RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END

go


CREATE TRIGGER tU_EstudiosPostgrado ON EstudiosPostgrado FOR UPDATE AS
/* ERwin Builtin Trigger */
/* UPDATE trigger on EstudiosPostgrado */
BEGIN
  DECLARE  @NUMROWS int,
           @nullcnt int,
           @validcnt int,
           @insCodEstudiosPostgrado int, 
           @insIdPostulante char(4),
           @errno   int,
           @errmsg  varchar(255)

  SELECT @NUMROWS = @@rowcount
  /* ERwin Builtin Trigger */
  /* Postulante  EstudiosPostgrado on child update no action */
  /* ERWIN_RELATION:CHECKSUM="00016572", PARENT_OWNER="", PARENT_TABLE="Postulante"
    CHILD_OWNER="", CHILD_TABLE="EstudiosPostgrado"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_22", FK_COLUMNS="IdPostulante" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(IdPostulante)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,Postulante
        WHERE
          /* %JoinFKPK(inserted,Postulante) */
          inserted.IdPostulante = Postulante.IdPostulante
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    
    IF @validcnt + @nullcnt != @NUMROWS
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update EstudiosPostgrado because Postulante does not exist.'
      GOTO ERROR
    END
  END


  /* ERwin Builtin Trigger */
  RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END

go




CREATE TRIGGER tD_Evaluacion ON Evaluacion FOR DELETE AS
/* ERwin Builtin Trigger */
/* DELETE trigger on Evaluacion */
BEGIN
  DECLARE  @errno   int,
           @errmsg  varchar(255)
    /* ERwin Builtin Trigger */
    /* Evaluacion  Oferta_Evaluacion on parent delete no action */
    /* ERWIN_RELATION:CHECKSUM="000261f4", PARENT_OWNER="", PARENT_TABLE="Evaluacion"
    CHILD_OWNER="", CHILD_TABLE="Oferta_Evaluacion"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_15", FK_COLUMNS="IdEvaluacion" */
    IF EXISTS (
      SELECT * FROM deleted,Oferta_Evaluacion
      WHERE
        /*  %JoinFKPK(Oferta_Evaluacion,deleted," = "," AND") */
        Oferta_Evaluacion.IdEvaluacion = deleted.IdEvaluacion
    )
    BEGIN
      SELECT @errno  = 30001,
             @errmsg = 'Cannot delete Evaluacion because Oferta_Evaluacion exists.'
      GOTO ERROR
    END

    /* ERwin Builtin Trigger */
    /* TipoEvaluacion  Evaluacion on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="TipoEvaluacion"
    CHILD_OWNER="", CHILD_TABLE="Evaluacion"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_32", FK_COLUMNS="IdTipoEvaluacion" */
    IF EXISTS (SELECT * FROM deleted,TipoEvaluacion
      WHERE
        /* %JoinFKPK(deleted,TipoEvaluacion," = "," AND") */
        deleted.IdTipoEvaluacion = TipoEvaluacion.IdTipoEvaluacion AND
        NOT EXISTS (
          SELECT * FROM Evaluacion
          WHERE
            /* %JoinFKPK(Evaluacion,TipoEvaluacion," = "," AND") */
            Evaluacion.IdTipoEvaluacion = TipoEvaluacion.IdTipoEvaluacion
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last Evaluacion because TipoEvaluacion exists.'
      GOTO ERROR
    END


    /* ERwin Builtin Trigger */
    RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END

go


CREATE TRIGGER tU_Evaluacion ON Evaluacion FOR UPDATE AS
/* ERwin Builtin Trigger */
/* UPDATE trigger on Evaluacion */
BEGIN
  DECLARE  @NUMROWS int,
           @nullcnt int,
           @validcnt int,
           @insIdEvaluacion int,
           @errno   int,
           @errmsg  varchar(255)

  SELECT @NUMROWS = @@rowcount
  /* ERwin Builtin Trigger */
  /* Evaluacion  Oferta_Evaluacion on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="0002b2b0", PARENT_OWNER="", PARENT_TABLE="Evaluacion"
    CHILD_OWNER="", CHILD_TABLE="Oferta_Evaluacion"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_15", FK_COLUMNS="IdEvaluacion" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(IdEvaluacion)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,Oferta_Evaluacion
      WHERE
        /*  %JoinFKPK(Oferta_Evaluacion,deleted," = "," AND") */
        Oferta_Evaluacion.IdEvaluacion = deleted.IdEvaluacion
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update Evaluacion because Oferta_Evaluacion exists.'
      GOTO ERROR
    END
  END

  /* ERwin Builtin Trigger */
  /* TipoEvaluacion  Evaluacion on child update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="TipoEvaluacion"
    CHILD_OWNER="", CHILD_TABLE="Evaluacion"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_32", FK_COLUMNS="IdTipoEvaluacion" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(IdTipoEvaluacion)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,TipoEvaluacion
        WHERE
          /* %JoinFKPK(inserted,TipoEvaluacion) */
          inserted.IdTipoEvaluacion = TipoEvaluacion.IdTipoEvaluacion
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    select @nullcnt = count(*) from inserted where
      inserted.IdTipoEvaluacion IS NULL
    IF @validcnt + @nullcnt != @NUMROWS
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update Evaluacion because TipoEvaluacion does not exist.'
      GOTO ERROR
    END
  END


  /* ERwin Builtin Trigger */
  RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END

go




CREATE TRIGGER tD_ExperienciaLaboral ON ExperienciaLaboral FOR DELETE AS
/* ERwin Builtin Trigger */
/* DELETE trigger on ExperienciaLaboral */
BEGIN
  DECLARE  @errno   int,
           @errmsg  varchar(255)
    /* ERwin Builtin Trigger */
    /* Postulante  ExperienciaLaboral on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="000282cd", PARENT_OWNER="", PARENT_TABLE="Postulante"
    CHILD_OWNER="", CHILD_TABLE="ExperienciaLaboral"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_20", FK_COLUMNS="IdPostulante" */
    IF EXISTS (SELECT * FROM deleted,Postulante
      WHERE
        /* %JoinFKPK(deleted,Postulante," = "," AND") */
        deleted.IdPostulante = Postulante.IdPostulante AND
        NOT EXISTS (
          SELECT * FROM ExperienciaLaboral
          WHERE
            /* %JoinFKPK(ExperienciaLaboral,Postulante," = "," AND") */
            ExperienciaLaboral.IdPostulante = Postulante.IdPostulante
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last ExperienciaLaboral because Postulante exists.'
      GOTO ERROR
    END

    /* ERwin Builtin Trigger */
    /* Area  ExperienciaLaboral on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Area"
    CHILD_OWNER="", CHILD_TABLE="ExperienciaLaboral"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_33", FK_COLUMNS="IdArea" */
    IF EXISTS (SELECT * FROM deleted,Area
      WHERE
        /* %JoinFKPK(deleted,Area," = "," AND") */
        deleted.IdArea = Area.IdArea AND
        NOT EXISTS (
          SELECT * FROM ExperienciaLaboral
          WHERE
            /* %JoinFKPK(ExperienciaLaboral,Area," = "," AND") */
            ExperienciaLaboral.IdArea = Area.IdArea
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last ExperienciaLaboral because Area exists.'
      GOTO ERROR
    END


    /* ERwin Builtin Trigger */
    RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END

go


CREATE TRIGGER tU_ExperienciaLaboral ON ExperienciaLaboral FOR UPDATE AS
/* ERwin Builtin Trigger */
/* UPDATE trigger on ExperienciaLaboral */
BEGIN
  DECLARE  @NUMROWS int,
           @nullcnt int,
           @validcnt int,
           @insIdPostulante char(4), 
           @insCodExperiencia int,
           @errno   int,
           @errmsg  varchar(255)

  SELECT @NUMROWS = @@rowcount
  /* ERwin Builtin Trigger */
  /* Postulante  ExperienciaLaboral on child update no action */
  /* ERWIN_RELATION:CHECKSUM="0002b84f", PARENT_OWNER="", PARENT_TABLE="Postulante"
    CHILD_OWNER="", CHILD_TABLE="ExperienciaLaboral"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_20", FK_COLUMNS="IdPostulante" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(IdPostulante)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,Postulante
        WHERE
          /* %JoinFKPK(inserted,Postulante) */
          inserted.IdPostulante = Postulante.IdPostulante
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    
    IF @validcnt + @nullcnt != @NUMROWS
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update ExperienciaLaboral because Postulante does not exist.'
      GOTO ERROR
    END
  END

  /* ERwin Builtin Trigger */
  /* Area  ExperienciaLaboral on child update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Area"
    CHILD_OWNER="", CHILD_TABLE="ExperienciaLaboral"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_33", FK_COLUMNS="IdArea" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(IdArea)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,Area
        WHERE
          /* %JoinFKPK(inserted,Area) */
          inserted.IdArea = Area.IdArea
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    select @nullcnt = count(*) from inserted where
      inserted.IdArea IS NULL
    IF @validcnt + @nullcnt != @NUMROWS
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update ExperienciaLaboral because Area does not exist.'
      GOTO ERROR
    END
  END


  /* ERwin Builtin Trigger */
  RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END

go




CREATE TRIGGER tD_Funciones ON Funciones FOR DELETE AS
/* ERwin Builtin Trigger */
/* DELETE trigger on Funciones */
BEGIN
  DECLARE  @errno   int,
           @errmsg  varchar(255)
    /* ERwin Builtin Trigger */
    /* Oferta  Funciones on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="000123b5", PARENT_OWNER="", PARENT_TABLE="Oferta"
    CHILD_OWNER="", CHILD_TABLE="Funciones"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_2", FK_COLUMNS="CodOferta" */
    IF EXISTS (SELECT * FROM deleted,Oferta
      WHERE
        /* %JoinFKPK(deleted,Oferta," = "," AND") */
        deleted.CodOferta = Oferta.CodOferta AND
        NOT EXISTS (
          SELECT * FROM Funciones
          WHERE
            /* %JoinFKPK(Funciones,Oferta," = "," AND") */
            Funciones.CodOferta = Oferta.CodOferta
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last Funciones because Oferta exists.'
      GOTO ERROR
    END


    /* ERwin Builtin Trigger */
    RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END

go


CREATE TRIGGER tU_Funciones ON Funciones FOR UPDATE AS
/* ERwin Builtin Trigger */
/* UPDATE trigger on Funciones */
BEGIN
  DECLARE  @NUMROWS int,
           @nullcnt int,
           @validcnt int,
           @insCodOferta int, 
           @insCodFuncion int,
           @errno   int,
           @errmsg  varchar(255)

  SELECT @NUMROWS = @@rowcount
  /* ERwin Builtin Trigger */
  /* Oferta  Funciones on child update no action */
  /* ERWIN_RELATION:CHECKSUM="00013de5", PARENT_OWNER="", PARENT_TABLE="Oferta"
    CHILD_OWNER="", CHILD_TABLE="Funciones"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_2", FK_COLUMNS="CodOferta" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(CodOferta)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,Oferta
        WHERE
          /* %JoinFKPK(inserted,Oferta) */
          inserted.CodOferta = Oferta.CodOferta
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    
    IF @validcnt + @nullcnt != @NUMROWS
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update Funciones because Oferta does not exist.'
      GOTO ERROR
    END
  END


  /* ERwin Builtin Trigger */
  RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END

go




CREATE TRIGGER tD_Idiomas ON Idiomas FOR DELETE AS
/* ERwin Builtin Trigger */
/* DELETE trigger on Idiomas */
BEGIN
  DECLARE  @errno   int,
           @errmsg  varchar(255)
    /* ERwin Builtin Trigger */
    /* Postulante  Idiomas on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="00013089", PARENT_OWNER="", PARENT_TABLE="Postulante"
    CHILD_OWNER="", CHILD_TABLE="Idiomas"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_23", FK_COLUMNS="IdPostulante" */
    IF EXISTS (SELECT * FROM deleted,Postulante
      WHERE
        /* %JoinFKPK(deleted,Postulante," = "," AND") */
        deleted.IdPostulante = Postulante.IdPostulante AND
        NOT EXISTS (
          SELECT * FROM Idiomas
          WHERE
            /* %JoinFKPK(Idiomas,Postulante," = "," AND") */
            Idiomas.IdPostulante = Postulante.IdPostulante
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last Idiomas because Postulante exists.'
      GOTO ERROR
    END


    /* ERwin Builtin Trigger */
    RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END

go


CREATE TRIGGER tU_Idiomas ON Idiomas FOR UPDATE AS
/* ERwin Builtin Trigger */
/* UPDATE trigger on Idiomas */
BEGIN
  DECLARE  @NUMROWS int,
           @nullcnt int,
           @validcnt int,
           @insCodIdioma int, 
           @insIdPostulante char(4),
           @errno   int,
           @errmsg  varchar(255)

  SELECT @NUMROWS = @@rowcount
  /* ERwin Builtin Trigger */
  /* Postulante  Idiomas on child update no action */
  /* ERWIN_RELATION:CHECKSUM="00015edc", PARENT_OWNER="", PARENT_TABLE="Postulante"
    CHILD_OWNER="", CHILD_TABLE="Idiomas"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_23", FK_COLUMNS="IdPostulante" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(IdPostulante)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,Postulante
        WHERE
          /* %JoinFKPK(inserted,Postulante) */
          inserted.IdPostulante = Postulante.IdPostulante
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    
    IF @validcnt + @nullcnt != @NUMROWS
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update Idiomas because Postulante does not exist.'
      GOTO ERROR
    END
  END


  /* ERwin Builtin Trigger */
  RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END

go




CREATE TRIGGER tD_Oferta ON Oferta FOR DELETE AS
/* ERwin Builtin Trigger */
/* DELETE trigger on Oferta */
BEGIN
  DECLARE  @errno   int,
           @errmsg  varchar(255)
    /* ERwin Builtin Trigger */
    /* Oferta  Funciones on parent delete no action */
    /* ERWIN_RELATION:CHECKSUM="00080ff9", PARENT_OWNER="", PARENT_TABLE="Oferta"
    CHILD_OWNER="", CHILD_TABLE="Funciones"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_2", FK_COLUMNS="CodOferta" */
    IF EXISTS (
      SELECT * FROM deleted,Funciones
      WHERE
        /*  %JoinFKPK(Funciones,deleted," = "," AND") */
        Funciones.CodOferta = deleted.CodOferta
    )
    BEGIN
      SELECT @errno  = 30001,
             @errmsg = 'Cannot delete Oferta because Funciones exists.'
      GOTO ERROR
    END

    /* ERwin Builtin Trigger */
    /* Oferta  Beneficios on parent delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Oferta"
    CHILD_OWNER="", CHILD_TABLE="Beneficios"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_3", FK_COLUMNS="CodOferta" */
    IF EXISTS (
      SELECT * FROM deleted,Beneficios
      WHERE
        /*  %JoinFKPK(Beneficios,deleted," = "," AND") */
        Beneficios.CodOferta = deleted.CodOferta
    )
    BEGIN
      SELECT @errno  = 30001,
             @errmsg = 'Cannot delete Oferta because Beneficios exists.'
      GOTO ERROR
    END

    /* ERwin Builtin Trigger */
    /* Oferta  Postulacion_Preseleccion on parent delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Oferta"
    CHILD_OWNER="", CHILD_TABLE="Postulacion_Preseleccion"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_10", FK_COLUMNS="CodOferta" */
    IF EXISTS (
      SELECT * FROM deleted,Postulacion_Preseleccion
      WHERE
        /*  %JoinFKPK(Postulacion_Preseleccion,deleted," = "," AND") */
        Postulacion_Preseleccion.CodOferta = deleted.CodOferta
    )
    BEGIN
      SELECT @errno  = 30001,
             @errmsg = 'Cannot delete Oferta because Postulacion_Preseleccion exists.'
      GOTO ERROR
    END

    /* ERwin Builtin Trigger */
    /* Oferta  Requerimiento on parent delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Oferta"
    CHILD_OWNER="", CHILD_TABLE="Requerimiento"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_13", FK_COLUMNS="CodOferta" */
    IF EXISTS (
      SELECT * FROM deleted,Requerimiento
      WHERE
        /*  %JoinFKPK(Requerimiento,deleted," = "," AND") */
        Requerimiento.CodOferta = deleted.CodOferta
    )
    BEGIN
      SELECT @errno  = 30001,
             @errmsg = 'Cannot delete Oferta because Requerimiento exists.'
      GOTO ERROR
    END

    /* ERwin Builtin Trigger */
    /* Oferta  Oferta_Evaluacion on parent delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Oferta"
    CHILD_OWNER="", CHILD_TABLE="Oferta_Evaluacion"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_14", FK_COLUMNS="CodOferta" */
    IF EXISTS (
      SELECT * FROM deleted,Oferta_Evaluacion
      WHERE
        /*  %JoinFKPK(Oferta_Evaluacion,deleted," = "," AND") */
        Oferta_Evaluacion.CodOferta = deleted.CodOferta
    )
    BEGIN
      SELECT @errno  = 30001,
             @errmsg = 'Cannot delete Oferta because Oferta_Evaluacion exists.'
      GOTO ERROR
    END

    /* ERwin Builtin Trigger */
    /* Empresa  Oferta on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Empresa"
    CHILD_OWNER="", CHILD_TABLE="Oferta"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_26", FK_COLUMNS="IdEmpresa" */
    IF EXISTS (SELECT * FROM deleted,Empresa
      WHERE
        /* %JoinFKPK(deleted,Empresa," = "," AND") */
        deleted.IdEmpresa = Empresa.IdEmpresa AND
        NOT EXISTS (
          SELECT * FROM Oferta
          WHERE
            /* %JoinFKPK(Oferta,Empresa," = "," AND") */
            Oferta.IdEmpresa = Empresa.IdEmpresa
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last Oferta because Empresa exists.'
      GOTO ERROR
    END

    /* ERwin Builtin Trigger */
    /* Region  Oferta on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Region"
    CHILD_OWNER="", CHILD_TABLE="Oferta"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_28", FK_COLUMNS="IdRegion" */
    IF EXISTS (SELECT * FROM deleted,Region
      WHERE
        /* %JoinFKPK(deleted,Region," = "," AND") */
        deleted.IdRegion = Region.IdRegion AND
        NOT EXISTS (
          SELECT * FROM Oferta
          WHERE
            /* %JoinFKPK(Oferta,Region," = "," AND") */
            Oferta.IdRegion = Region.IdRegion
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last Oferta because Region exists.'
      GOTO ERROR
    END

    /* ERwin Builtin Trigger */
    /* Area  Oferta on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Area"
    CHILD_OWNER="", CHILD_TABLE="Oferta"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_31", FK_COLUMNS="IdArea" */
    IF EXISTS (SELECT * FROM deleted,Area
      WHERE
        /* %JoinFKPK(deleted,Area," = "," AND") */
        deleted.IdArea = Area.IdArea AND
        NOT EXISTS (
          SELECT * FROM Oferta
          WHERE
            /* %JoinFKPK(Oferta,Area," = "," AND") */
            Oferta.IdArea = Area.IdArea
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last Oferta because Area exists.'
      GOTO ERROR
    END


    /* ERwin Builtin Trigger */
    RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END

go


CREATE TRIGGER tU_Oferta ON Oferta FOR UPDATE AS
/* ERwin Builtin Trigger */
/* UPDATE trigger on Oferta */
BEGIN
  DECLARE  @NUMROWS int,
           @nullcnt int,
           @validcnt int,
           @insCodOferta int,
           @errno   int,
           @errmsg  varchar(255)

  SELECT @NUMROWS = @@rowcount
  /* ERwin Builtin Trigger */
  /* Oferta  Funciones on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="00094e3b", PARENT_OWNER="", PARENT_TABLE="Oferta"
    CHILD_OWNER="", CHILD_TABLE="Funciones"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_2", FK_COLUMNS="CodOferta" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(CodOferta)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,Funciones
      WHERE
        /*  %JoinFKPK(Funciones,deleted," = "," AND") */
        Funciones.CodOferta = deleted.CodOferta
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update Oferta because Funciones exists.'
      GOTO ERROR
    END
  END

  /* ERwin Builtin Trigger */
  /* Oferta  Beneficios on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Oferta"
    CHILD_OWNER="", CHILD_TABLE="Beneficios"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_3", FK_COLUMNS="CodOferta" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(CodOferta)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,Beneficios
      WHERE
        /*  %JoinFKPK(Beneficios,deleted," = "," AND") */
        Beneficios.CodOferta = deleted.CodOferta
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update Oferta because Beneficios exists.'
      GOTO ERROR
    END
  END

  /* ERwin Builtin Trigger */
  /* Oferta  Postulacion_Preseleccion on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Oferta"
    CHILD_OWNER="", CHILD_TABLE="Postulacion_Preseleccion"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_10", FK_COLUMNS="CodOferta" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(CodOferta)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,Postulacion_Preseleccion
      WHERE
        /*  %JoinFKPK(Postulacion_Preseleccion,deleted," = "," AND") */
        Postulacion_Preseleccion.CodOferta = deleted.CodOferta
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update Oferta because Postulacion_Preseleccion exists.'
      GOTO ERROR
    END
  END

  /* ERwin Builtin Trigger */
  /* Oferta  Requerimiento on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Oferta"
    CHILD_OWNER="", CHILD_TABLE="Requerimiento"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_13", FK_COLUMNS="CodOferta" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(CodOferta)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,Requerimiento
      WHERE
        /*  %JoinFKPK(Requerimiento,deleted," = "," AND") */
        Requerimiento.CodOferta = deleted.CodOferta
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update Oferta because Requerimiento exists.'
      GOTO ERROR
    END
  END

  /* ERwin Builtin Trigger */
  /* Oferta  Oferta_Evaluacion on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Oferta"
    CHILD_OWNER="", CHILD_TABLE="Oferta_Evaluacion"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_14", FK_COLUMNS="CodOferta" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(CodOferta)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,Oferta_Evaluacion
      WHERE
        /*  %JoinFKPK(Oferta_Evaluacion,deleted," = "," AND") */
        Oferta_Evaluacion.CodOferta = deleted.CodOferta
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update Oferta because Oferta_Evaluacion exists.'
      GOTO ERROR
    END
  END

  /* ERwin Builtin Trigger */
  /* Empresa  Oferta on child update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Empresa"
    CHILD_OWNER="", CHILD_TABLE="Oferta"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_26", FK_COLUMNS="IdEmpresa" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(IdEmpresa)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,Empresa
        WHERE
          /* %JoinFKPK(inserted,Empresa) */
          inserted.IdEmpresa = Empresa.IdEmpresa
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    select @nullcnt = count(*) from inserted where
      inserted.IdEmpresa IS NULL
    IF @validcnt + @nullcnt != @NUMROWS
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update Oferta because Empresa does not exist.'
      GOTO ERROR
    END
  END

  /* ERwin Builtin Trigger */
  /* Region  Oferta on child update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Region"
    CHILD_OWNER="", CHILD_TABLE="Oferta"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_28", FK_COLUMNS="IdRegion" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(IdRegion)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,Region
        WHERE
          /* %JoinFKPK(inserted,Region) */
          inserted.IdRegion = Region.IdRegion
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    select @nullcnt = count(*) from inserted where
      inserted.IdRegion IS NULL
    IF @validcnt + @nullcnt != @NUMROWS
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update Oferta because Region does not exist.'
      GOTO ERROR
    END
  END

  /* ERwin Builtin Trigger */
  /* Area  Oferta on child update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Area"
    CHILD_OWNER="", CHILD_TABLE="Oferta"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_31", FK_COLUMNS="IdArea" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(IdArea)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,Area
        WHERE
          /* %JoinFKPK(inserted,Area) */
          inserted.IdArea = Area.IdArea
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    select @nullcnt = count(*) from inserted where
      inserted.IdArea IS NULL
    IF @validcnt + @nullcnt != @NUMROWS
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update Oferta because Area does not exist.'
      GOTO ERROR
    END
  END


  /* ERwin Builtin Trigger */
  RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END

go




CREATE TRIGGER tD_Oferta_Evaluacion ON Oferta_Evaluacion FOR DELETE AS
/* ERwin Builtin Trigger */
/* DELETE trigger on Oferta_Evaluacion */
BEGIN
  DECLARE  @errno   int,
           @errmsg  varchar(255)
    /* ERwin Builtin Trigger */
    /* Oferta_Evaluacion  Postulante_Evaluacion on parent delete no action */
    /* ERWIN_RELATION:CHECKSUM="0003c862", PARENT_OWNER="", PARENT_TABLE="Oferta_Evaluacion"
    CHILD_OWNER="", CHILD_TABLE="Postulante_Evaluacion"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_17", FK_COLUMNS="IdEvaluacion""CodOferta" */
    IF EXISTS (
      SELECT * FROM deleted,Postulante_Evaluacion
      WHERE
        /*  %JoinFKPK(Postulante_Evaluacion,deleted," = "," AND") */
        Postulante_Evaluacion.IdEvaluacion = deleted.IdEvaluacion AND
        Postulante_Evaluacion.CodOferta = deleted.CodOferta
    )
    BEGIN
      SELECT @errno  = 30001,
             @errmsg = 'Cannot delete Oferta_Evaluacion because Postulante_Evaluacion exists.'
      GOTO ERROR
    END

    /* ERwin Builtin Trigger */
    /* Oferta  Oferta_Evaluacion on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Oferta"
    CHILD_OWNER="", CHILD_TABLE="Oferta_Evaluacion"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_14", FK_COLUMNS="CodOferta" */
    IF EXISTS (SELECT * FROM deleted,Oferta
      WHERE
        /* %JoinFKPK(deleted,Oferta," = "," AND") */
        deleted.CodOferta = Oferta.CodOferta AND
        NOT EXISTS (
          SELECT * FROM Oferta_Evaluacion
          WHERE
            /* %JoinFKPK(Oferta_Evaluacion,Oferta," = "," AND") */
            Oferta_Evaluacion.CodOferta = Oferta.CodOferta
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last Oferta_Evaluacion because Oferta exists.'
      GOTO ERROR
    END

    /* ERwin Builtin Trigger */
    /* Evaluacion  Oferta_Evaluacion on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Evaluacion"
    CHILD_OWNER="", CHILD_TABLE="Oferta_Evaluacion"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_15", FK_COLUMNS="IdEvaluacion" */
    IF EXISTS (SELECT * FROM deleted,Evaluacion
      WHERE
        /* %JoinFKPK(deleted,Evaluacion," = "," AND") */
        deleted.IdEvaluacion = Evaluacion.IdEvaluacion AND
        NOT EXISTS (
          SELECT * FROM Oferta_Evaluacion
          WHERE
            /* %JoinFKPK(Oferta_Evaluacion,Evaluacion," = "," AND") */
            Oferta_Evaluacion.IdEvaluacion = Evaluacion.IdEvaluacion
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last Oferta_Evaluacion because Evaluacion exists.'
      GOTO ERROR
    END


    /* ERwin Builtin Trigger */
    RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END

go


CREATE TRIGGER tU_Oferta_Evaluacion ON Oferta_Evaluacion FOR UPDATE AS
/* ERwin Builtin Trigger */
/* UPDATE trigger on Oferta_Evaluacion */
BEGIN
  DECLARE  @NUMROWS int,
           @nullcnt int,
           @validcnt int,
           @insIdEvaluacion int, 
           @insCodOferta int,
           @errno   int,
           @errmsg  varchar(255)

  SELECT @NUMROWS = @@rowcount
  /* ERwin Builtin Trigger */
  /* Oferta_Evaluacion  Postulante_Evaluacion on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="0003f3cb", PARENT_OWNER="", PARENT_TABLE="Oferta_Evaluacion"
    CHILD_OWNER="", CHILD_TABLE="Postulante_Evaluacion"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_17", FK_COLUMNS="IdEvaluacion""CodOferta" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(IdEvaluacion) OR
    UPDATE(CodOferta)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,Postulante_Evaluacion
      WHERE
        /*  %JoinFKPK(Postulante_Evaluacion,deleted," = "," AND") */
        Postulante_Evaluacion.IdEvaluacion = deleted.IdEvaluacion AND
        Postulante_Evaluacion.CodOferta = deleted.CodOferta
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update Oferta_Evaluacion because Postulante_Evaluacion exists.'
      GOTO ERROR
    END
  END

  /* ERwin Builtin Trigger */
  /* Oferta  Oferta_Evaluacion on child update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Oferta"
    CHILD_OWNER="", CHILD_TABLE="Oferta_Evaluacion"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_14", FK_COLUMNS="CodOferta" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(CodOferta)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,Oferta
        WHERE
          /* %JoinFKPK(inserted,Oferta) */
          inserted.CodOferta = Oferta.CodOferta
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    
    IF @validcnt + @nullcnt != @NUMROWS
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update Oferta_Evaluacion because Oferta does not exist.'
      GOTO ERROR
    END
  END

  /* ERwin Builtin Trigger */
  /* Evaluacion  Oferta_Evaluacion on child update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Evaluacion"
    CHILD_OWNER="", CHILD_TABLE="Oferta_Evaluacion"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_15", FK_COLUMNS="IdEvaluacion" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(IdEvaluacion)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,Evaluacion
        WHERE
          /* %JoinFKPK(inserted,Evaluacion) */
          inserted.IdEvaluacion = Evaluacion.IdEvaluacion
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    
    IF @validcnt + @nullcnt != @NUMROWS
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update Oferta_Evaluacion because Evaluacion does not exist.'
      GOTO ERROR
    END
  END


  /* ERwin Builtin Trigger */
  RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END

go




CREATE TRIGGER tD_Postulacion_Preseleccion ON Postulacion_Preseleccion FOR DELETE AS
/* ERwin Builtin Trigger */
/* DELETE trigger on Postulacion_Preseleccion */
BEGIN
  DECLARE  @errno   int,
           @errmsg  varchar(255)
    /* ERwin Builtin Trigger */
    /* Postulacion_Preseleccion  Postulacion_Seleccion on parent delete no action */
    /* ERWIN_RELATION:CHECKSUM="0003fe66", PARENT_OWNER="", PARENT_TABLE="Postulacion_Preseleccion"
    CHILD_OWNER="", CHILD_TABLE="Postulacion_Seleccion"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_18", FK_COLUMNS="IdPostulante""CodOferta" */
    IF EXISTS (
      SELECT * FROM deleted,Postulacion_Seleccion
      WHERE
        /*  %JoinFKPK(Postulacion_Seleccion,deleted," = "," AND") */
        Postulacion_Seleccion.IdPostulante = deleted.IdPostulante AND
        Postulacion_Seleccion.CodOferta = deleted.CodOferta
    )
    BEGIN
      SELECT @errno  = 30001,
             @errmsg = 'Cannot delete Postulacion_Preseleccion because Postulacion_Seleccion exists.'
      GOTO ERROR
    END

    /* ERwin Builtin Trigger */
    /* Postulante  Postulacion_Preseleccion on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Postulante"
    CHILD_OWNER="", CHILD_TABLE="Postulacion_Preseleccion"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_9", FK_COLUMNS="IdPostulante" */
    IF EXISTS (SELECT * FROM deleted,Postulante
      WHERE
        /* %JoinFKPK(deleted,Postulante," = "," AND") */
        deleted.IdPostulante = Postulante.IdPostulante AND
        NOT EXISTS (
          SELECT * FROM Postulacion_Preseleccion
          WHERE
            /* %JoinFKPK(Postulacion_Preseleccion,Postulante," = "," AND") */
            Postulacion_Preseleccion.IdPostulante = Postulante.IdPostulante
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last Postulacion_Preseleccion because Postulante exists.'
      GOTO ERROR
    END

    /* ERwin Builtin Trigger */
    /* Oferta  Postulacion_Preseleccion on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Oferta"
    CHILD_OWNER="", CHILD_TABLE="Postulacion_Preseleccion"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_10", FK_COLUMNS="CodOferta" */
    IF EXISTS (SELECT * FROM deleted,Oferta
      WHERE
        /* %JoinFKPK(deleted,Oferta," = "," AND") */
        deleted.CodOferta = Oferta.CodOferta AND
        NOT EXISTS (
          SELECT * FROM Postulacion_Preseleccion
          WHERE
            /* %JoinFKPK(Postulacion_Preseleccion,Oferta," = "," AND") */
            Postulacion_Preseleccion.CodOferta = Oferta.CodOferta
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last Postulacion_Preseleccion because Oferta exists.'
      GOTO ERROR
    END


    /* ERwin Builtin Trigger */
    RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END

go


CREATE TRIGGER tU_Postulacion_Preseleccion ON Postulacion_Preseleccion FOR UPDATE AS
/* ERwin Builtin Trigger */
/* UPDATE trigger on Postulacion_Preseleccion */
BEGIN
  DECLARE  @NUMROWS int,
           @nullcnt int,
           @validcnt int,
           @insIdPostulante char(4), 
           @insCodOferta int,
           @errno   int,
           @errmsg  varchar(255)

  SELECT @NUMROWS = @@rowcount
  /* ERwin Builtin Trigger */
  /* Postulacion_Preseleccion  Postulacion_Seleccion on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="00042da6", PARENT_OWNER="", PARENT_TABLE="Postulacion_Preseleccion"
    CHILD_OWNER="", CHILD_TABLE="Postulacion_Seleccion"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_18", FK_COLUMNS="IdPostulante""CodOferta" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(IdPostulante) OR
    UPDATE(CodOferta)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,Postulacion_Seleccion
      WHERE
        /*  %JoinFKPK(Postulacion_Seleccion,deleted," = "," AND") */
        Postulacion_Seleccion.IdPostulante = deleted.IdPostulante AND
        Postulacion_Seleccion.CodOferta = deleted.CodOferta
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update Postulacion_Preseleccion because Postulacion_Seleccion exists.'
      GOTO ERROR
    END
  END

  /* ERwin Builtin Trigger */
  /* Postulante  Postulacion_Preseleccion on child update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Postulante"
    CHILD_OWNER="", CHILD_TABLE="Postulacion_Preseleccion"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_9", FK_COLUMNS="IdPostulante" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(IdPostulante)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,Postulante
        WHERE
          /* %JoinFKPK(inserted,Postulante) */
          inserted.IdPostulante = Postulante.IdPostulante
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    
    IF @validcnt + @nullcnt != @NUMROWS
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update Postulacion_Preseleccion because Postulante does not exist.'
      GOTO ERROR
    END
  END

  /* ERwin Builtin Trigger */
  /* Oferta  Postulacion_Preseleccion on child update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Oferta"
    CHILD_OWNER="", CHILD_TABLE="Postulacion_Preseleccion"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_10", FK_COLUMNS="CodOferta" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(CodOferta)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,Oferta
        WHERE
          /* %JoinFKPK(inserted,Oferta) */
          inserted.CodOferta = Oferta.CodOferta
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    
    IF @validcnt + @nullcnt != @NUMROWS
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update Postulacion_Preseleccion because Oferta does not exist.'
      GOTO ERROR
    END
  END


  /* ERwin Builtin Trigger */
  RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END

go




CREATE TRIGGER tD_Postulacion_Seleccion ON Postulacion_Seleccion FOR DELETE AS
/* ERwin Builtin Trigger */
/* DELETE trigger on Postulacion_Seleccion */
BEGIN
  DECLARE  @errno   int,
           @errmsg  varchar(255)
    /* ERwin Builtin Trigger */
    /* Postulacion_Preseleccion  Postulacion_Seleccion on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="0003357f", PARENT_OWNER="", PARENT_TABLE="Postulacion_Preseleccion"
    CHILD_OWNER="", CHILD_TABLE="Postulacion_Seleccion"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_18", FK_COLUMNS="IdPostulante""CodOferta" */
    IF EXISTS (SELECT * FROM deleted,Postulacion_Preseleccion
      WHERE
        /* %JoinFKPK(deleted,Postulacion_Preseleccion," = "," AND") */
        deleted.IdPostulante = Postulacion_Preseleccion.IdPostulante AND
        deleted.CodOferta = Postulacion_Preseleccion.CodOferta AND
        NOT EXISTS (
          SELECT * FROM Postulacion_Seleccion
          WHERE
            /* %JoinFKPK(Postulacion_Seleccion,Postulacion_Preseleccion," = "," AND") */
            Postulacion_Seleccion.IdPostulante = Postulacion_Preseleccion.IdPostulante AND
            Postulacion_Seleccion.CodOferta = Postulacion_Preseleccion.CodOferta
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last Postulacion_Seleccion because Postulacion_Preseleccion exists.'
      GOTO ERROR
    END

    /* ERwin Builtin Trigger */
    /* Director_RRHH  Postulacion_Seleccion on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Director_RRHH"
    CHILD_OWNER="", CHILD_TABLE="Postulacion_Seleccion"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_34", FK_COLUMNS="CodDirector" */
    IF EXISTS (SELECT * FROM deleted,Director_RRHH
      WHERE
        /* %JoinFKPK(deleted,Director_RRHH," = "," AND") */
        deleted.CodDirector = Director_RRHH.CodDirector AND
        NOT EXISTS (
          SELECT * FROM Postulacion_Seleccion
          WHERE
            /* %JoinFKPK(Postulacion_Seleccion,Director_RRHH," = "," AND") */
            Postulacion_Seleccion.CodDirector = Director_RRHH.CodDirector
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last Postulacion_Seleccion because Director_RRHH exists.'
      GOTO ERROR
    END


    /* ERwin Builtin Trigger */
    RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END

go


CREATE TRIGGER tU_Postulacion_Seleccion ON Postulacion_Seleccion FOR UPDATE AS
/* ERwin Builtin Trigger */
/* UPDATE trigger on Postulacion_Seleccion */
BEGIN
  DECLARE  @NUMROWS int,
           @nullcnt int,
           @validcnt int,
           @insIdPostulante char(4), 
           @insCodOferta int,
           @errno   int,
           @errmsg  varchar(255)

  SELECT @NUMROWS = @@rowcount
  /* ERwin Builtin Trigger */
  /* Postulacion_Preseleccion  Postulacion_Seleccion on child update no action */
  /* ERWIN_RELATION:CHECKSUM="00033f47", PARENT_OWNER="", PARENT_TABLE="Postulacion_Preseleccion"
    CHILD_OWNER="", CHILD_TABLE="Postulacion_Seleccion"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_18", FK_COLUMNS="IdPostulante""CodOferta" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(IdPostulante) OR
    UPDATE(CodOferta)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,Postulacion_Preseleccion
        WHERE
          /* %JoinFKPK(inserted,Postulacion_Preseleccion) */
          inserted.IdPostulante = Postulacion_Preseleccion.IdPostulante and
          inserted.CodOferta = Postulacion_Preseleccion.CodOferta
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    
    IF @validcnt + @nullcnt != @NUMROWS
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update Postulacion_Seleccion because Postulacion_Preseleccion does not exist.'
      GOTO ERROR
    END
  END

  /* ERwin Builtin Trigger */
  /* Director_RRHH  Postulacion_Seleccion on child update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Director_RRHH"
    CHILD_OWNER="", CHILD_TABLE="Postulacion_Seleccion"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_34", FK_COLUMNS="CodDirector" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(CodDirector)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,Director_RRHH
        WHERE
          /* %JoinFKPK(inserted,Director_RRHH) */
          inserted.CodDirector = Director_RRHH.CodDirector
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    select @nullcnt = count(*) from inserted where
      inserted.CodDirector IS NULL
    IF @validcnt + @nullcnt != @NUMROWS
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update Postulacion_Seleccion because Director_RRHH does not exist.'
      GOTO ERROR
    END
  END


  /* ERwin Builtin Trigger */
  RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END

go




CREATE TRIGGER tD_Postulante ON Postulante FOR DELETE AS
/* ERwin Builtin Trigger */
/* DELETE trigger on Postulante */
BEGIN
  DECLARE  @errno   int,
           @errmsg  varchar(255)
    /* ERwin Builtin Trigger */
    /* Postulante  Postulacion_Preseleccion on parent delete no action */
    /* ERWIN_RELATION:CHECKSUM="00092841", PARENT_OWNER="", PARENT_TABLE="Postulante"
    CHILD_OWNER="", CHILD_TABLE="Postulacion_Preseleccion"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_9", FK_COLUMNS="IdPostulante" */
    IF EXISTS (
      SELECT * FROM deleted,Postulacion_Preseleccion
      WHERE
        /*  %JoinFKPK(Postulacion_Preseleccion,deleted," = "," AND") */
        Postulacion_Preseleccion.IdPostulante = deleted.IdPostulante
    )
    BEGIN
      SELECT @errno  = 30001,
             @errmsg = 'Cannot delete Postulante because Postulacion_Preseleccion exists.'
      GOTO ERROR
    END

    /* ERwin Builtin Trigger */
    /* Postulante  Postulante_Evaluacion on parent delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Postulante"
    CHILD_OWNER="", CHILD_TABLE="Postulante_Evaluacion"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_16", FK_COLUMNS="IdPostulante" */
    IF EXISTS (
      SELECT * FROM deleted,Postulante_Evaluacion
      WHERE
        /*  %JoinFKPK(Postulante_Evaluacion,deleted," = "," AND") */
        Postulante_Evaluacion.IdPostulante = deleted.IdPostulante
    )
    BEGIN
      SELECT @errno  = 30001,
             @errmsg = 'Cannot delete Postulante because Postulante_Evaluacion exists.'
      GOTO ERROR
    END

    /* ERwin Builtin Trigger */
    /* Postulante  ExperienciaLaboral on parent delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Postulante"
    CHILD_OWNER="", CHILD_TABLE="ExperienciaLaboral"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_20", FK_COLUMNS="IdPostulante" */
    IF EXISTS (
      SELECT * FROM deleted,ExperienciaLaboral
      WHERE
        /*  %JoinFKPK(ExperienciaLaboral,deleted," = "," AND") */
        ExperienciaLaboral.IdPostulante = deleted.IdPostulante
    )
    BEGIN
      SELECT @errno  = 30001,
             @errmsg = 'Cannot delete Postulante because ExperienciaLaboral exists.'
      GOTO ERROR
    END

    /* ERwin Builtin Trigger */
    /* Postulante  Estudios on parent delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Postulante"
    CHILD_OWNER="", CHILD_TABLE="Estudios"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_21", FK_COLUMNS="IdPostulante" */
    IF EXISTS (
      SELECT * FROM deleted,Estudios
      WHERE
        /*  %JoinFKPK(Estudios,deleted," = "," AND") */
        Estudios.IdPostulante = deleted.IdPostulante
    )
    BEGIN
      SELECT @errno  = 30001,
             @errmsg = 'Cannot delete Postulante because Estudios exists.'
      GOTO ERROR
    END

    /* ERwin Builtin Trigger */
    /* Postulante  EstudiosPostgrado on parent delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Postulante"
    CHILD_OWNER="", CHILD_TABLE="EstudiosPostgrado"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_22", FK_COLUMNS="IdPostulante" */
    IF EXISTS (
      SELECT * FROM deleted,EstudiosPostgrado
      WHERE
        /*  %JoinFKPK(EstudiosPostgrado,deleted," = "," AND") */
        EstudiosPostgrado.IdPostulante = deleted.IdPostulante
    )
    BEGIN
      SELECT @errno  = 30001,
             @errmsg = 'Cannot delete Postulante because EstudiosPostgrado exists.'
      GOTO ERROR
    END

    /* ERwin Builtin Trigger */
    /* Postulante  Idiomas on parent delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Postulante"
    CHILD_OWNER="", CHILD_TABLE="Idiomas"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_23", FK_COLUMNS="IdPostulante" */
    IF EXISTS (
      SELECT * FROM deleted,Idiomas
      WHERE
        /*  %JoinFKPK(Idiomas,deleted," = "," AND") */
        Idiomas.IdPostulante = deleted.IdPostulante
    )
    BEGIN
      SELECT @errno  = 30001,
             @errmsg = 'Cannot delete Postulante because Idiomas exists.'
      GOTO ERROR
    END

    /* ERwin Builtin Trigger */
    /* Postulante  Software on parent delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Postulante"
    CHILD_OWNER="", CHILD_TABLE="Software"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_24", FK_COLUMNS="IdPostulante" */
    IF EXISTS (
      SELECT * FROM deleted,Software
      WHERE
        /*  %JoinFKPK(Software,deleted," = "," AND") */
        Software.IdPostulante = deleted.IdPostulante
    )
    BEGIN
      SELECT @errno  = 30001,
             @errmsg = 'Cannot delete Postulante because Software exists.'
      GOTO ERROR
    END

    /* ERwin Builtin Trigger */
    /* Postulante  Referencias on parent delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Postulante"
    CHILD_OWNER="", CHILD_TABLE="Referencias"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_25", FK_COLUMNS="IdPostulante" */
    IF EXISTS (
      SELECT * FROM deleted,Referencias
      WHERE
        /*  %JoinFKPK(Referencias,deleted," = "," AND") */
        Referencias.IdPostulante = deleted.IdPostulante
    )
    BEGIN
      SELECT @errno  = 30001,
             @errmsg = 'Cannot delete Postulante because Referencias exists.'
      GOTO ERROR
    END

    /* ERwin Builtin Trigger */
    /* Region  Postulante on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Region"
    CHILD_OWNER="", CHILD_TABLE="Postulante"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_30", FK_COLUMNS="IdRegion" */
    IF EXISTS (SELECT * FROM deleted,Region
      WHERE
        /* %JoinFKPK(deleted,Region," = "," AND") */
        deleted.IdRegion = Region.IdRegion AND
        NOT EXISTS (
          SELECT * FROM Postulante
          WHERE
            /* %JoinFKPK(Postulante,Region," = "," AND") */
            Postulante.IdRegion = Region.IdRegion
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last Postulante because Region exists.'
      GOTO ERROR
    END


    /* ERwin Builtin Trigger */
    RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END

go


CREATE TRIGGER tU_Postulante ON Postulante FOR UPDATE AS
/* ERwin Builtin Trigger */
/* UPDATE trigger on Postulante */
BEGIN
  DECLARE  @NUMROWS int,
           @nullcnt int,
           @validcnt int,
           @insIdPostulante char(4),
           @errno   int,
           @errmsg  varchar(255)

  SELECT @NUMROWS = @@rowcount
  /* ERwin Builtin Trigger */
  /* Postulante  Postulacion_Preseleccion on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="000a613a", PARENT_OWNER="", PARENT_TABLE="Postulante"
    CHILD_OWNER="", CHILD_TABLE="Postulacion_Preseleccion"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_9", FK_COLUMNS="IdPostulante" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(IdPostulante)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,Postulacion_Preseleccion
      WHERE
        /*  %JoinFKPK(Postulacion_Preseleccion,deleted," = "," AND") */
        Postulacion_Preseleccion.IdPostulante = deleted.IdPostulante
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update Postulante because Postulacion_Preseleccion exists.'
      GOTO ERROR
    END
  END

  /* ERwin Builtin Trigger */
  /* Postulante  Postulante_Evaluacion on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Postulante"
    CHILD_OWNER="", CHILD_TABLE="Postulante_Evaluacion"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_16", FK_COLUMNS="IdPostulante" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(IdPostulante)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,Postulante_Evaluacion
      WHERE
        /*  %JoinFKPK(Postulante_Evaluacion,deleted," = "," AND") */
        Postulante_Evaluacion.IdPostulante = deleted.IdPostulante
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update Postulante because Postulante_Evaluacion exists.'
      GOTO ERROR
    END
  END

  /* ERwin Builtin Trigger */
  /* Postulante  ExperienciaLaboral on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Postulante"
    CHILD_OWNER="", CHILD_TABLE="ExperienciaLaboral"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_20", FK_COLUMNS="IdPostulante" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(IdPostulante)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,ExperienciaLaboral
      WHERE
        /*  %JoinFKPK(ExperienciaLaboral,deleted," = "," AND") */
        ExperienciaLaboral.IdPostulante = deleted.IdPostulante
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update Postulante because ExperienciaLaboral exists.'
      GOTO ERROR
    END
  END

  /* ERwin Builtin Trigger */
  /* Postulante  Estudios on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Postulante"
    CHILD_OWNER="", CHILD_TABLE="Estudios"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_21", FK_COLUMNS="IdPostulante" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(IdPostulante)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,Estudios
      WHERE
        /*  %JoinFKPK(Estudios,deleted," = "," AND") */
        Estudios.IdPostulante = deleted.IdPostulante
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update Postulante because Estudios exists.'
      GOTO ERROR
    END
  END

  /* ERwin Builtin Trigger */
  /* Postulante  EstudiosPostgrado on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Postulante"
    CHILD_OWNER="", CHILD_TABLE="EstudiosPostgrado"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_22", FK_COLUMNS="IdPostulante" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(IdPostulante)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,EstudiosPostgrado
      WHERE
        /*  %JoinFKPK(EstudiosPostgrado,deleted," = "," AND") */
        EstudiosPostgrado.IdPostulante = deleted.IdPostulante
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update Postulante because EstudiosPostgrado exists.'
      GOTO ERROR
    END
  END

  /* ERwin Builtin Trigger */
  /* Postulante  Idiomas on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Postulante"
    CHILD_OWNER="", CHILD_TABLE="Idiomas"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_23", FK_COLUMNS="IdPostulante" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(IdPostulante)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,Idiomas
      WHERE
        /*  %JoinFKPK(Idiomas,deleted," = "," AND") */
        Idiomas.IdPostulante = deleted.IdPostulante
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update Postulante because Idiomas exists.'
      GOTO ERROR
    END
  END

  /* ERwin Builtin Trigger */
  /* Postulante  Software on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Postulante"
    CHILD_OWNER="", CHILD_TABLE="Software"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_24", FK_COLUMNS="IdPostulante" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(IdPostulante)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,Software
      WHERE
        /*  %JoinFKPK(Software,deleted," = "," AND") */
        Software.IdPostulante = deleted.IdPostulante
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update Postulante because Software exists.'
      GOTO ERROR
    END
  END

  /* ERwin Builtin Trigger */
  /* Postulante  Referencias on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Postulante"
    CHILD_OWNER="", CHILD_TABLE="Referencias"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_25", FK_COLUMNS="IdPostulante" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(IdPostulante)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,Referencias
      WHERE
        /*  %JoinFKPK(Referencias,deleted," = "," AND") */
        Referencias.IdPostulante = deleted.IdPostulante
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update Postulante because Referencias exists.'
      GOTO ERROR
    END
  END

  /* ERwin Builtin Trigger */
  /* Region  Postulante on child update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Region"
    CHILD_OWNER="", CHILD_TABLE="Postulante"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_30", FK_COLUMNS="IdRegion" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(IdRegion)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,Region
        WHERE
          /* %JoinFKPK(inserted,Region) */
          inserted.IdRegion = Region.IdRegion
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    select @nullcnt = count(*) from inserted where
      inserted.IdRegion IS NULL
    IF @validcnt + @nullcnt != @NUMROWS
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update Postulante because Region does not exist.'
      GOTO ERROR
    END
  END


  /* ERwin Builtin Trigger */
  RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END

go




CREATE TRIGGER tD_Postulante_Evaluacion ON Postulante_Evaluacion FOR DELETE AS
/* ERwin Builtin Trigger */
/* DELETE trigger on Postulante_Evaluacion */
BEGIN
  DECLARE  @errno   int,
           @errmsg  varchar(255)
    /* ERwin Builtin Trigger */
    /* Postulante  Postulante_Evaluacion on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="00030a29", PARENT_OWNER="", PARENT_TABLE="Postulante"
    CHILD_OWNER="", CHILD_TABLE="Postulante_Evaluacion"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_16", FK_COLUMNS="IdPostulante" */
    IF EXISTS (SELECT * FROM deleted,Postulante
      WHERE
        /* %JoinFKPK(deleted,Postulante," = "," AND") */
        deleted.IdPostulante = Postulante.IdPostulante AND
        NOT EXISTS (
          SELECT * FROM Postulante_Evaluacion
          WHERE
            /* %JoinFKPK(Postulante_Evaluacion,Postulante," = "," AND") */
            Postulante_Evaluacion.IdPostulante = Postulante.IdPostulante
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last Postulante_Evaluacion because Postulante exists.'
      GOTO ERROR
    END

    /* ERwin Builtin Trigger */
    /* Oferta_Evaluacion  Postulante_Evaluacion on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Oferta_Evaluacion"
    CHILD_OWNER="", CHILD_TABLE="Postulante_Evaluacion"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_17", FK_COLUMNS="IdEvaluacion""CodOferta" */
    IF EXISTS (SELECT * FROM deleted,Oferta_Evaluacion
      WHERE
        /* %JoinFKPK(deleted,Oferta_Evaluacion," = "," AND") */
        deleted.IdEvaluacion = Oferta_Evaluacion.IdEvaluacion AND
        deleted.CodOferta = Oferta_Evaluacion.CodOferta AND
        NOT EXISTS (
          SELECT * FROM Postulante_Evaluacion
          WHERE
            /* %JoinFKPK(Postulante_Evaluacion,Oferta_Evaluacion," = "," AND") */
            Postulante_Evaluacion.IdEvaluacion = Oferta_Evaluacion.IdEvaluacion AND
            Postulante_Evaluacion.CodOferta = Oferta_Evaluacion.CodOferta
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last Postulante_Evaluacion because Oferta_Evaluacion exists.'
      GOTO ERROR
    END


    /* ERwin Builtin Trigger */
    RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END

go


CREATE TRIGGER tU_Postulante_Evaluacion ON Postulante_Evaluacion FOR UPDATE AS
/* ERwin Builtin Trigger */
/* UPDATE trigger on Postulante_Evaluacion */
BEGIN
  DECLARE  @NUMROWS int,
           @nullcnt int,
           @validcnt int,
           @insIdPostulante char(4), 
           @insIdEvaluacion int, 
           @insCodOferta int,
           @errno   int,
           @errmsg  varchar(255)

  SELECT @NUMROWS = @@rowcount
  /* ERwin Builtin Trigger */
  /* Postulante  Postulante_Evaluacion on child update no action */
  /* ERWIN_RELATION:CHECKSUM="00030a45", PARENT_OWNER="", PARENT_TABLE="Postulante"
    CHILD_OWNER="", CHILD_TABLE="Postulante_Evaluacion"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_16", FK_COLUMNS="IdPostulante" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(IdPostulante)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,Postulante
        WHERE
          /* %JoinFKPK(inserted,Postulante) */
          inserted.IdPostulante = Postulante.IdPostulante
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    
    IF @validcnt + @nullcnt != @NUMROWS
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update Postulante_Evaluacion because Postulante does not exist.'
      GOTO ERROR
    END
  END

  /* ERwin Builtin Trigger */
  /* Oferta_Evaluacion  Postulante_Evaluacion on child update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Oferta_Evaluacion"
    CHILD_OWNER="", CHILD_TABLE="Postulante_Evaluacion"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_17", FK_COLUMNS="IdEvaluacion""CodOferta" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(IdEvaluacion) OR
    UPDATE(CodOferta)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,Oferta_Evaluacion
        WHERE
          /* %JoinFKPK(inserted,Oferta_Evaluacion) */
          inserted.IdEvaluacion = Oferta_Evaluacion.IdEvaluacion and
          inserted.CodOferta = Oferta_Evaluacion.CodOferta
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    
    IF @validcnt + @nullcnt != @NUMROWS
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update Postulante_Evaluacion because Oferta_Evaluacion does not exist.'
      GOTO ERROR
    END
  END


  /* ERwin Builtin Trigger */
  RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END

go




CREATE TRIGGER tD_Referencias ON Referencias FOR DELETE AS
/* ERwin Builtin Trigger */
/* DELETE trigger on Referencias */
BEGIN
  DECLARE  @errno   int,
           @errmsg  varchar(255)
    /* ERwin Builtin Trigger */
    /* Postulante  Referencias on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="0001493a", PARENT_OWNER="", PARENT_TABLE="Postulante"
    CHILD_OWNER="", CHILD_TABLE="Referencias"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_25", FK_COLUMNS="IdPostulante" */
    IF EXISTS (SELECT * FROM deleted,Postulante
      WHERE
        /* %JoinFKPK(deleted,Postulante," = "," AND") */
        deleted.IdPostulante = Postulante.IdPostulante AND
        NOT EXISTS (
          SELECT * FROM Referencias
          WHERE
            /* %JoinFKPK(Referencias,Postulante," = "," AND") */
            Referencias.IdPostulante = Postulante.IdPostulante
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last Referencias because Postulante exists.'
      GOTO ERROR
    END


    /* ERwin Builtin Trigger */
    RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END

go


CREATE TRIGGER tU_Referencias ON Referencias FOR UPDATE AS
/* ERwin Builtin Trigger */
/* UPDATE trigger on Referencias */
BEGIN
  DECLARE  @NUMROWS int,
           @nullcnt int,
           @validcnt int,
           @insIdPostulante char(4), 
           @insCodReferencia int,
           @errno   int,
           @errmsg  varchar(255)

  SELECT @NUMROWS = @@rowcount
  /* ERwin Builtin Trigger */
  /* Postulante  Referencias on child update no action */
  /* ERWIN_RELATION:CHECKSUM="00015f55", PARENT_OWNER="", PARENT_TABLE="Postulante"
    CHILD_OWNER="", CHILD_TABLE="Referencias"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_25", FK_COLUMNS="IdPostulante" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(IdPostulante)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,Postulante
        WHERE
          /* %JoinFKPK(inserted,Postulante) */
          inserted.IdPostulante = Postulante.IdPostulante
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    
    IF @validcnt + @nullcnt != @NUMROWS
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update Referencias because Postulante does not exist.'
      GOTO ERROR
    END
  END


  /* ERwin Builtin Trigger */
  RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END

go




CREATE TRIGGER tD_Region ON Region FOR DELETE AS
/* ERwin Builtin Trigger */
/* DELETE trigger on Region */
BEGIN
  DECLARE  @errno   int,
           @errmsg  varchar(255)
    /* ERwin Builtin Trigger */
    /* Region  Oferta on parent delete no action */
    /* ERWIN_RELATION:CHECKSUM="0001cc02", PARENT_OWNER="", PARENT_TABLE="Region"
    CHILD_OWNER="", CHILD_TABLE="Oferta"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_28", FK_COLUMNS="IdRegion" */
    IF EXISTS (
      SELECT * FROM deleted,Oferta
      WHERE
        /*  %JoinFKPK(Oferta,deleted," = "," AND") */
        Oferta.IdRegion = deleted.IdRegion
    )
    BEGIN
      SELECT @errno  = 30001,
             @errmsg = 'Cannot delete Region because Oferta exists.'
      GOTO ERROR
    END

    /* ERwin Builtin Trigger */
    /* Region  Postulante on parent delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Region"
    CHILD_OWNER="", CHILD_TABLE="Postulante"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_30", FK_COLUMNS="IdRegion" */
    IF EXISTS (
      SELECT * FROM deleted,Postulante
      WHERE
        /*  %JoinFKPK(Postulante,deleted," = "," AND") */
        Postulante.IdRegion = deleted.IdRegion
    )
    BEGIN
      SELECT @errno  = 30001,
             @errmsg = 'Cannot delete Region because Postulante exists.'
      GOTO ERROR
    END


    /* ERwin Builtin Trigger */
    RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END

go


CREATE TRIGGER tU_Region ON Region FOR UPDATE AS
/* ERwin Builtin Trigger */
/* UPDATE trigger on Region */
BEGIN
  DECLARE  @NUMROWS int,
           @nullcnt int,
           @validcnt int,
           @insIdRegion char(4),
           @errno   int,
           @errmsg  varchar(255)

  SELECT @NUMROWS = @@rowcount
  /* ERwin Builtin Trigger */
  /* Region  Oferta on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="000208af", PARENT_OWNER="", PARENT_TABLE="Region"
    CHILD_OWNER="", CHILD_TABLE="Oferta"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_28", FK_COLUMNS="IdRegion" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(IdRegion)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,Oferta
      WHERE
        /*  %JoinFKPK(Oferta,deleted," = "," AND") */
        Oferta.IdRegion = deleted.IdRegion
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update Region because Oferta exists.'
      GOTO ERROR
    END
  END

  /* ERwin Builtin Trigger */
  /* Region  Postulante on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Region"
    CHILD_OWNER="", CHILD_TABLE="Postulante"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_30", FK_COLUMNS="IdRegion" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(IdRegion)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,Postulante
      WHERE
        /*  %JoinFKPK(Postulante,deleted," = "," AND") */
        Postulante.IdRegion = deleted.IdRegion
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update Region because Postulante exists.'
      GOTO ERROR
    END
  END


  /* ERwin Builtin Trigger */
  RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END

go




CREATE TRIGGER tD_Requerimiento ON Requerimiento FOR DELETE AS
/* ERwin Builtin Trigger */
/* DELETE trigger on Requerimiento */
BEGIN
  DECLARE  @errno   int,
           @errmsg  varchar(255)
    /* ERwin Builtin Trigger */
    /* Oferta  Requerimiento on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="00012f90", PARENT_OWNER="", PARENT_TABLE="Oferta"
    CHILD_OWNER="", CHILD_TABLE="Requerimiento"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_13", FK_COLUMNS="CodOferta" */
    IF EXISTS (SELECT * FROM deleted,Oferta
      WHERE
        /* %JoinFKPK(deleted,Oferta," = "," AND") */
        deleted.CodOferta = Oferta.CodOferta AND
        NOT EXISTS (
          SELECT * FROM Requerimiento
          WHERE
            /* %JoinFKPK(Requerimiento,Oferta," = "," AND") */
            Requerimiento.CodOferta = Oferta.CodOferta
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last Requerimiento because Oferta exists.'
      GOTO ERROR
    END


    /* ERwin Builtin Trigger */
    RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END

go


CREATE TRIGGER tU_Requerimiento ON Requerimiento FOR UPDATE AS
/* ERwin Builtin Trigger */
/* UPDATE trigger on Requerimiento */
BEGIN
  DECLARE  @NUMROWS int,
           @nullcnt int,
           @validcnt int,
           @insCodOferta int, 
           @insCodRequerimiento int,
           @errno   int,
           @errmsg  varchar(255)

  SELECT @NUMROWS = @@rowcount
  /* ERwin Builtin Trigger */
  /* Oferta  Requerimiento on child update no action */
  /* ERWIN_RELATION:CHECKSUM="00014abd", PARENT_OWNER="", PARENT_TABLE="Oferta"
    CHILD_OWNER="", CHILD_TABLE="Requerimiento"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_13", FK_COLUMNS="CodOferta" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(CodOferta)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,Oferta
        WHERE
          /* %JoinFKPK(inserted,Oferta) */
          inserted.CodOferta = Oferta.CodOferta
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    
    IF @validcnt + @nullcnt != @NUMROWS
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update Requerimiento because Oferta does not exist.'
      GOTO ERROR
    END
  END


  /* ERwin Builtin Trigger */
  RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END

go




CREATE TRIGGER tD_Software ON Software FOR DELETE AS
/* ERwin Builtin Trigger */
/* DELETE trigger on Software */
BEGIN
  DECLARE  @errno   int,
           @errmsg  varchar(255)
    /* ERwin Builtin Trigger */
    /* Postulante  Software on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="0001326c", PARENT_OWNER="", PARENT_TABLE="Postulante"
    CHILD_OWNER="", CHILD_TABLE="Software"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_24", FK_COLUMNS="IdPostulante" */
    IF EXISTS (SELECT * FROM deleted,Postulante
      WHERE
        /* %JoinFKPK(deleted,Postulante," = "," AND") */
        deleted.IdPostulante = Postulante.IdPostulante AND
        NOT EXISTS (
          SELECT * FROM Software
          WHERE
            /* %JoinFKPK(Software,Postulante," = "," AND") */
            Software.IdPostulante = Postulante.IdPostulante
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last Software because Postulante exists.'
      GOTO ERROR
    END


    /* ERwin Builtin Trigger */
    RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END

go


CREATE TRIGGER tU_Software ON Software FOR UPDATE AS
/* ERwin Builtin Trigger */
/* UPDATE trigger on Software */
BEGIN
  DECLARE  @NUMROWS int,
           @nullcnt int,
           @validcnt int,
           @insCodSoftware int, 
           @insIdPostulante char(4),
           @errno   int,
           @errmsg  varchar(255)

  SELECT @NUMROWS = @@rowcount
  /* ERwin Builtin Trigger */
  /* Postulante  Software on child update no action */
  /* ERWIN_RELATION:CHECKSUM="00015004", PARENT_OWNER="", PARENT_TABLE="Postulante"
    CHILD_OWNER="", CHILD_TABLE="Software"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_24", FK_COLUMNS="IdPostulante" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(IdPostulante)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,Postulante
        WHERE
          /* %JoinFKPK(inserted,Postulante) */
          inserted.IdPostulante = Postulante.IdPostulante
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    
    IF @validcnt + @nullcnt != @NUMROWS
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update Software because Postulante does not exist.'
      GOTO ERROR
    END
  END


  /* ERwin Builtin Trigger */
  RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END

go




CREATE TRIGGER tD_TipoEvaluacion ON TipoEvaluacion FOR DELETE AS
/* ERwin Builtin Trigger */
/* DELETE trigger on TipoEvaluacion */
BEGIN
  DECLARE  @errno   int,
           @errmsg  varchar(255)
    /* ERwin Builtin Trigger */
    /* TipoEvaluacion  Evaluacion on parent delete no action */
    /* ERWIN_RELATION:CHECKSUM="00010190", PARENT_OWNER="", PARENT_TABLE="TipoEvaluacion"
    CHILD_OWNER="", CHILD_TABLE="Evaluacion"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_32", FK_COLUMNS="IdTipoEvaluacion" */
    IF EXISTS (
      SELECT * FROM deleted,Evaluacion
      WHERE
        /*  %JoinFKPK(Evaluacion,deleted," = "," AND") */
        Evaluacion.IdTipoEvaluacion = deleted.IdTipoEvaluacion
    )
    BEGIN
      SELECT @errno  = 30001,
             @errmsg = 'Cannot delete TipoEvaluacion because Evaluacion exists.'
      GOTO ERROR
    END


    /* ERwin Builtin Trigger */
    RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END

go


CREATE TRIGGER tU_TipoEvaluacion ON TipoEvaluacion FOR UPDATE AS
/* ERwin Builtin Trigger */
/* UPDATE trigger on TipoEvaluacion */
BEGIN
  DECLARE  @NUMROWS int,
           @nullcnt int,
           @validcnt int,
           @insIdTipoEvaluacion char(4),
           @errno   int,
           @errmsg  varchar(255)

  SELECT @NUMROWS = @@rowcount
  /* ERwin Builtin Trigger */
  /* TipoEvaluacion  Evaluacion on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="00011f7e", PARENT_OWNER="", PARENT_TABLE="TipoEvaluacion"
    CHILD_OWNER="", CHILD_TABLE="Evaluacion"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_32", FK_COLUMNS="IdTipoEvaluacion" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(IdTipoEvaluacion)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,Evaluacion
      WHERE
        /*  %JoinFKPK(Evaluacion,deleted," = "," AND") */
        Evaluacion.IdTipoEvaluacion = deleted.IdTipoEvaluacion
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update TipoEvaluacion because Evaluacion exists.'
      GOTO ERROR
    END
  END


  /* ERwin Builtin Trigger */
  RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END

go


