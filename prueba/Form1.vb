Imports Infoware.Datos

Public Class Form1

  Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
   
  End Sub

  Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    'Dim _operadordatos As OperadorDatos = OperadorDatosFactory.CrearInstancia(enumProveedorDatos.SQL, "(local)\sqlexpress", "rednegocios", "sa", "lindoecuador", True)
    '_operadordatos.GuardarContrasena = False


    'MsgBox(_operadordatos.CadenaConexion)

    'Dim _operadordatoslist As New OperadorDatosList
    '_operadordatoslist.Add(_operadordatos)
    '_operadordatoslist.axml("prueba.xml")

    'MsgBox("serializado")

    '_operadordatoslist = OperadorDatosList.dexml("prueba.xml")

    '    MsgBox("deserializado")

    '    Dim _usuario As New Infoware.Reglas.General.Usuario(_operadordatos, "admin")
    '    _usuario.Usuari_Mensaje = "cambio"
    '    If Not _usuario.Guardar() Then
    '        MsgBox("no guardo")
    '    End If

    '    _usuario.Restricciones(0).Restri_Eliminacion = True


    '    Dim _usuariolista As Infoware.Reglas.General.UsuarioList.obtenerlista(_operadordatos, "juan")

  End Sub
End Class
