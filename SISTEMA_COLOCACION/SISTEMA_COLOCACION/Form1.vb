Public Class frmPrincipal

    Private Sub EstudiosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstudiosToolStripMenuItem.Click
        Dim ObjEstudios As New Estudios
        ObjEstudios.MdiParent = Me
        ObjEstudios.Show()
    End Sub

    Private Sub EstudiosPosgradoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstudiosPosgradoToolStripMenuItem.Click
        Dim ObjEstudiosPosgrado As New EstudiosPosgrado
        ObjEstudiosPosgrado.MdiParent = Me
        ObjEstudiosPosgrado.Show()
    End Sub

    Private Sub ExperienciaLaboralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExperienciaLaboralToolStripMenuItem.Click
        Dim ObjExperiencia As New ExperienciaLaboral
        ObjExperiencia.MdiParent = Me
        ObjExperiencia.Show()
    End Sub

    Private Sub ReferenciasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReferenciasToolStripMenuItem.Click
        Dim ObjReferencias As New Referencias
        ObjReferencias.MdiParent = Me
        ObjReferencias.Show()
    End Sub

    Private Sub SoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SoToolStripMenuItem.Click
        Dim ObjSoft As New Softwares
        ObjSoft.MdiParent = Me
        ObjSoft.Show()
    End Sub

    Private Sub IdiomasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IdiomasToolStripMenuItem.Click
        Dim ObjIdiomas As New Idiomas
        ObjIdiomas.MdiParent = Me
        ObjIdiomas.Show()
    End Sub

    Private Sub PostulanteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PostulanteToolStripMenuItem.Click
        Dim ObjPostulantes As New Postulante
        ObjPostulantes.MdiParent = Me
        ObjPostulantes.Show()
    End Sub

    Private Sub ContactoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactoToolStripMenuItem.Click
        Dim ObjContacto As New Contacto
        ObjContacto.MdiParent = Me
        ObjContacto.Show()
    End Sub

    Private Sub EmpresaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EmpresaToolStripMenuItem1.Click
        Dim ObjEmpresa As New Empresa
        ObjEmpresa.MdiParent = Me
        ObjEmpresa.Show()
    End Sub

    Private Sub RequerimientosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RequerimientosToolStripMenuItem.Click
        Dim ObjRequerimientos As New Requerimientos
        ObjRequerimientos.MdiParent = Me
        ObjRequerimientos.Show()
    End Sub

    Private Sub FuncionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FuncionesToolStripMenuItem.Click
        Dim ObjFunciones As New Funciones
        ObjFunciones.MdiParent = Me
        ObjFunciones.Show()
    End Sub

    Private Sub BeneficiosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeneficiosToolStripMenuItem.Click
        Dim ObjBeneficios As New Beneficios
        ObjBeneficios.MdiParent = Me
        ObjBeneficios.Show()
    End Sub

    Private Sub AreaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AreaToolStripMenuItem1.Click
        Dim ObjArea As New Area
        ObjArea.MdiParent = Me
        ObjArea.Show()
    End Sub

    Private Sub RegionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegionToolStripMenuItem.Click
        Dim ObjRegion As New Region
        ObjRegion.MdiParent = Me
        ObjRegion.Show()
    End Sub

    Private Sub OfertaToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles OfertaToolStripMenuItem2.Click
        Dim ObjOferta As New Oferta
        ObjOferta.MdiParent = Me
        ObjOferta.Show()
    End Sub

    Private Sub TipoDeEvaluaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDeEvaluaciónToolStripMenuItem.Click
        Dim ObjTipoEvaluacion As New TipoEvaluacion
        ObjTipoEvaluacion.MdiParent = Me
        ObjTipoEvaluacion.Show()
    End Sub

    Private Sub EvaluaciónToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EvaluaciónToolStripMenuItem1.Click
        Dim ObjEvaluacion As New Evaluacion
        ObjEvaluacion.MdiParent = Me
        ObjEvaluacion.Show()
    End Sub

    Private Sub EvaluaciónPorOferToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EvaluaciónPorOferToolStripMenuItem.Click
        Dim ObjEvaluacionOferta As New OfertaEvaluacion
        ObjEvaluacionOferta.MdiParent = Me
        ObjEvaluacionOferta.Show()
    End Sub

    Private Sub EvaluaciónPorPostulanteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EvaluaciónPorPostulanteToolStripMenuItem.Click
        Dim ObjEvaluacionPostulante As New EvaluacionPostulante
        ObjEvaluacionPostulante.MdiParent = Me
        ObjEvaluacionPostulante.Show()
    End Sub

    Private Sub DirectoraDeRRHHToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DirectoraDeRRHHToolStripMenuItem.Click
        Dim ObjDirectorRRHH As New DirectorRRHH
        ObjDirectorRRHH.MdiParent = Me
        ObjDirectorRRHH.Show()
    End Sub

    Private Sub PreselecciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreselecciónToolStripMenuItem.Click
        Dim ObjPreseleccion As New Preseleccion
        ObjPreseleccion.MdiParent = Me
        ObjPreseleccion.Show()
    End Sub

    Private Sub SelecciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelecciónToolStripMenuItem.Click
        Dim ObjSeleccion As New Seleccion
        ObjSeleccion.MdiParent = Me
        ObjSeleccion.Show()
    End Sub

    Private Sub VigenciaDeOfertasPublicadasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VigenciaDeOfertasPublicadasToolStripMenuItem.Click
        Dim ObjVigenciaOfertasPublicadas As New VigenciaOfertasPublicadas
        ObjVigenciaOfertasPublicadas.MdiParent = Me
        ObjVigenciaOfertasPublicadas.Show()
    End Sub

    Private Sub CalificaciónYSalarioDePostulantesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalificaciónYSalarioDePostulantesToolStripMenuItem.Click
        Dim ObjCalificacionSalarioPostulantes As New CalificacionSalarioPostulantes
        ObjCalificacionSalarioPostulantes.MdiParent = Me
        ObjCalificacionSalarioPostulantes.Show()
    End Sub

    Private Sub PostulantesSeleccionadosPorOfertaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PostulantesSeleccionadosPorOfertaToolStripMenuItem.Click
        Dim ObjPostulantesSeleccionadosOferta As New PostulantesSeleccionadosOferta
        ObjPostulantesSeleccionadosOferta.MdiParent = Me
        ObjPostulantesSeleccionadosOferta.Show()
    End Sub

    Private Sub DetallesDeCargoPorPostulanteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetallesDeCargoPorPostulanteToolStripMenuItem.Click
        Dim ObjDetallesCargoPostulantes As New DetallesCargoPostulantes
        ObjDetallesCargoPostulantes.MdiParent = Me
        ObjDetallesCargoPostulantes.Show()
    End Sub

    Private Sub EvaluaciónRealizada5OMásVecesPorOfertaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EvaluaciónRealizada5OMásVecesPorOfertaToolStripMenuItem.Click
        Dim ObjEvaluacionesOferta As New EvaluacionesOferta
        ObjEvaluacionesOferta.MdiParent = Me
        ObjEvaluacionesOferta.Show()
    End Sub

    Private Sub PostulantesConExperienciaEnAlgúnSoftwareEIdiomaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PostulantesConExperienciaEnAlgúnSoftwareEIdiomaToolStripMenuItem.Click
        Dim ObjPostulantesExperienciaSoftIdioma As New PostulantesExperienciaSoftIdioma
        ObjPostulantesExperienciaSoftIdioma.MdiParent = Me
        ObjPostulantesExperienciaSoftIdioma.Show()
    End Sub

    Private Sub ListaEvaluacionesPostulanteToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim ObjEvaluacionesPostulante As New EvaluacionesPostulante
        ObjEvaluacionesPostulante.MdiParent = Me
        ObjEvaluacionesPostulante.Show()
    End Sub

    Private Sub ListaDePostulantesSeleccionadosONoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDePostulantesSeleccionadosONoToolStripMenuItem.Click
        Dim ObjPostulantesOferta As New PostulantesOferta
        ObjPostulantesOferta.MdiParent = Me
        ObjPostulantesOferta.Show()
    End Sub

    Private Sub ListaDePostulantesConExperienciaEnUnÁreaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDePostulantesConExperienciaEnUnÁreaToolStripMenuItem.Click
        Dim ObjPostulantesExperienciaArea As New PostulantesExperienciaArea
        ObjPostulantesExperienciaArea.MdiParent = Me
        ObjPostulantesExperienciaArea.Show()
    End Sub



    Private Sub DetallesDeUnaOfertaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetallesDeUnaOfertaToolStripMenuItem.Click
        Dim ObjDetallesOferta As New DetallesOferta
        ObjDetallesOferta.MdiParent = Me
        ObjDetallesOferta.Show()
    End Sub

    Private Sub DetallesDeUnPostulanteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetallesDeUnPostulanteToolStripMenuItem.Click
        Dim ObjDetallesPostulante As New DetallesPostulante
        ObjDetallesPostulante.MdiParent = Me
        ObjDetallesPostulante.Show()
    End Sub

    Private Sub OfertasPorEmpresaConPostulanteContratadoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim ObjOfertasEmpresa As New OfertasEmpresa
        ObjOfertasEmpresa.MdiParent = Me
        ObjOfertasEmpresa.Show()
    End Sub

    Private Sub HorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HorizontalToolStripMenuItem.Click
        Me.LayoutMdi(1)
    End Sub

    Private Sub VerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerticalToolStripMenuItem.Click
        Me.LayoutMdi(2)
    End Sub

    Private Sub CascadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CascadaToolStripMenuItem.Click
        Me.LayoutMdi(0)
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub


End Class
