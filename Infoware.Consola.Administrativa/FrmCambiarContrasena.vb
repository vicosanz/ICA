﻿Imports Infoware.Datos
Imports Infoware.Consola.Base
Imports Infoware.Reglas.General

Public Class FrmCambiarContrasena
  Private mUsuario As Usuario = Nothing
  Public Property Usuario() As Usuario
    Get
      Return mUsuario
    End Get
    Set(ByVal value As Usuario)
      mUsuario = value
    End Set
  End Property

	Private Sub OK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OK.Click
		Try
			If Me.txtnueva.Text = Me.txtconfirmar.Text Then
				If Me.txtnueva.Text.Trim = String.Empty Then
					Throw New Exception("La contraseña no puede estar en blanco")
				End If
				mUsuario.Usuari_Password = Me.txtnueva.Text.Trim
        If Not mUsuario.CambiarContrasena() Then
          Select Case mUsuario.ResultCode
            Case -11
              Throw New Exception("La contraseña no cumple con el mínimo requerido")
            Case -10
              Throw New Exception("La contraseña debe ser diferente de las últimas registradas")
            Case -12, -13, -14, -15
              Throw New Exception("La contraseña debe cumplir con los requisitos de complejidad")
          End Select
          Throw New Exception("La contraseña no pudo ser cambiada")
        End If
        DialogResult = DialogResult.OK
      Else
				Throw New Exception("La contraseña nueva y la confirmación deben ser iguales. Por favor redigítelas")
			End If

		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Información")
		End Try

	End Sub

	Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
    DialogResult = DialogResult.Cancel
  End Sub
End Class