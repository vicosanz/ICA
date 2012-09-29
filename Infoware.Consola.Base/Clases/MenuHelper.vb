Imports System.Windows.Forms
Imports System.Runtime.InteropServices

Public Class MenuHelper
#Region "Menu Edicion"
  Public Enum enumOpcionesEdicion
    Deshacer = 0
    Rehacer = 1
    Cortar = 2
    Copiar = 3
    Pegar = 4
    SeleccionarTodo = 5
  End Enum

#Region "Botones"
  Private DeshacerToolStripMenuItem As ToolStripMenuItem
  Private RehacerToolStripMenuItem As ToolStripMenuItem
  Private SeparadorToolStripMenuItem As ToolStripSeparator
  Private CortarToolStripMenuItem As ToolStripMenuItem
  Private CopiarToolStripMenuItem As ToolStripMenuItem
  Private PegarToolStripMenuItem As ToolStripMenuItem
  Private SeparadorToolStripMenuItem1 As ToolStripSeparator
  Private SelectallToolStripMenuItem As ToolStripMenuItem
#End Region

  Public Sub CrearMenuEdicion(ByRef EdicionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem, Optional ByRef CortarButton As System.Windows.Forms.ToolStripButton = Nothing, Optional ByRef CopiarButton As System.Windows.Forms.ToolStripButton = Nothing, Optional ByRef PegarButton As System.Windows.Forms.ToolStripButton = Nothing)
    DeshacerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    RehacerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    SeparadorToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator
    CortarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    PegarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    SeparadorToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
    SelectallToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem

    DeshacerToolStripMenuItem.Image = My.Resources.Resources.undo.ToBitmap
    RehacerToolStripMenuItem.Image = My.Resources.Resources.Redo
    CortarToolStripMenuItem.Image = My.Resources.Resources.Cut
    CopiarToolStripMenuItem.Image = My.Resources.Resources.Copy
    PegarToolStripMenuItem.Image = My.Resources.Resources.Paste

    DeshacerToolStripMenuItem.Name = "DeshacerToolStripMenuItem"
    RehacerToolStripMenuItem.Name = "RehacerToolStripMenuItem"
    SeparadorToolStripMenuItem.Name = "SeparadorToolStripMenuItem"
    CortarToolStripMenuItem.Name = "CortarToolStripMenuItem"
    CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
    PegarToolStripMenuItem.Name = "PegarToolStripMenuItem"
    SeparadorToolStripMenuItem1.Name = "SeparadorToolStripMenuItem1"
    SelectallToolStripMenuItem.Name = "SelectallToolStripMenuItem"

    DeshacerToolStripMenuItem.Text = "&Deshacer"
    RehacerToolStripMenuItem.Text = "&Rehacer"
    CortarToolStripMenuItem.Text = "Cor&tar"
    CopiarToolStripMenuItem.Text = "&Copiar"
    PegarToolStripMenuItem.Text = "&Pegar"
    SelectallToolStripMenuItem.Text = "S&eleccionar todo"

    DeshacerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
    RehacerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
    CortarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
    CopiarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
    PegarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
    SelectallToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)

    EdicionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {DeshacerToolStripMenuItem, RehacerToolStripMenuItem, SeparadorToolStripMenuItem, CortarToolStripMenuItem, CopiarToolStripMenuItem, PegarToolStripMenuItem, SeparadorToolStripMenuItem1, SelectallToolStripMenuItem})

    DeshacerToolStripMenuItem.Tag = enumOpcionesEdicion.Deshacer
    RehacerToolStripMenuItem.Tag = enumOpcionesEdicion.Rehacer
    CortarToolStripMenuItem.Tag = enumOpcionesEdicion.Cortar
    CopiarToolStripMenuItem.Tag = enumOpcionesEdicion.Copiar
    PegarToolStripMenuItem.Tag = enumOpcionesEdicion.Pegar
    SelectallToolStripMenuItem.Tag = enumOpcionesEdicion.SeleccionarTodo

    DeshacerToolStripMenuItem.Enabled = True
    RehacerToolStripMenuItem.Enabled = True
    CortarToolStripMenuItem.Enabled = True
    CopiarToolStripMenuItem.Enabled = True
    PegarToolStripMenuItem.Enabled = True
    SelectallToolStripMenuItem.Enabled = True

    AddHandler DeshacerToolStripMenuItem.Click, AddressOf AccionEdicion
    AddHandler RehacerToolStripMenuItem.Click, AddressOf AccionEdicion
    AddHandler CortarToolStripMenuItem.Click, AddressOf AccionEdicion
    AddHandler CopiarToolStripMenuItem.Click, AddressOf AccionEdicion
    AddHandler PegarToolStripMenuItem.Click, AddressOf AccionEdicion
    AddHandler SelectallToolStripMenuItem.Click, AddressOf AccionEdicion

    If CortarButton IsNot Nothing Then
      CortarButton.Tag = enumOpcionesEdicion.Cortar
      AddHandler CortarButton.Click, AddressOf AccionEdicion
    End If
    If CopiarButton IsNot Nothing Then
      CopiarButton.Tag = enumOpcionesEdicion.Copiar
      AddHandler CopiarButton.Click, AddressOf AccionEdicion
    End If
    If PegarButton IsNot Nothing Then
      PegarButton.Tag = enumOpcionesEdicion.Pegar
      AddHandler PegarButton.Click, AddressOf AccionEdicion
    End If

    AddHandler EdicionToolStripMenuItem.DropDownOpening, AddressOf Opening
    AddHandler EdicionToolStripMenuItem.DropDownClosed, AddressOf Closed
  End Sub

  Public Sub Opening(ByVal sender As System.Object, ByVal e As System.EventArgs)
    DeshacerToolStripMenuItem.Enabled = PuedeEdicion()
    RehacerToolStripMenuItem.Enabled = PuedeEdicion()
    CortarToolStripMenuItem.Enabled = PuedeEdicion()
    CopiarToolStripMenuItem.Enabled = PuedeEdicion()
    PegarToolStripMenuItem.Enabled = PuedeEdicion()
    SelectallToolStripMenuItem.Enabled = PuedeEdicion()
  End Sub

  Private Sub Closed(ByVal sender As System.Object, ByVal e As System.EventArgs)
    DeshacerToolStripMenuItem.Enabled = True
    RehacerToolStripMenuItem.Enabled = True
    CortarToolStripMenuItem.Enabled = True
    CopiarToolStripMenuItem.Enabled = True
    PegarToolStripMenuItem.Enabled = True
    SelectallToolStripMenuItem.Enabled = True
  End Sub

  Private Function PuedeEdicion() As Boolean
    Dim result As Boolean = False

    Dim hFocus As IntPtr = GetFocus()
    Dim ctlFocus As Control = GetFrameworkControl(hFocus)
    If (TypeOf ctlFocus Is TextBoxBase) Then
      result = True
    ElseIf (TypeOf ctlFocus Is ComboBox AndAlso (CType(ctlFocus, ComboBox)).DropDownStyle = ComboBoxStyle.DropDown) Then
      result = True
    ElseIf TypeOf ctlFocus Is DataGridView Then
      result = True
    Else
      Dim ctlEdit As ISupportsEdit = GetISupportsEditControl(ctlFocus)
      If Not ctlEdit Is Nothing Then
        result = True
      End If
    End If
    Return result
  End Function

  Private Shared Sub AccionEdicion(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Dim opcion As enumOpcionesEdicion
    opcion = CType(sender, ToolStripItem).Tag

    Dim hFocus As IntPtr = GetFocus()
    Dim ctlFocus As Control = GetFrameworkControl(hFocus)
    If (TypeOf ctlFocus Is TextBoxBase) Then
      DoTextBoxCommand(CType(ctlFocus, TextBoxBase), opcion)
    ElseIf (TypeOf ctlFocus Is ComboBox AndAlso (CType(ctlFocus, ComboBox)).DropDownStyle = ComboBoxStyle.DropDown) Then
      DoComboBoxCommand(hFocus, CType(ctlFocus, ComboBox), opcion)
    Else
      Dim ctlEdit As ISupportsEdit = GetISupportsEditControl(ctlFocus)
      If Not ctlEdit Is Nothing Then
        DoISupportsEditCommand(ctlEdit, opcion)
      End If
    End If
  End Sub

  Private Shared Sub DoTextBoxCommand(ByVal textbox As TextBoxBase, ByVal opcion As enumOpcionesEdicion)
    Select Case opcion
      Case enumOpcionesEdicion.Deshacer
        textbox.Undo()
      Case enumOpcionesEdicion.Rehacer
        If (TypeOf textbox Is RichTextBox) Then
          Dim rt As RichTextBox = CType(textbox, RichTextBox)
          rt.Redo()
        End If
      Case enumOpcionesEdicion.Cortar
        textbox.Cut()
      Case enumOpcionesEdicion.Copiar
        textbox.Copy()
      Case enumOpcionesEdicion.Pegar
        textbox.Paste()
        'Case eliminar
        'textbox.SelectedText = ""
      Case enumOpcionesEdicion.SeleccionarTodo
        textbox.SelectAll()
        'Case menuIndex.Properties
    End Select
  End Sub

  Private Shared Sub DoComboBoxCommand(ByVal hEdit As IntPtr, ByVal combobox As ComboBox, ByVal opcion As enumOpcionesEdicion)
    Select Case opcion
      Case enumOpcionesEdicion.Deshacer
        Undo(hEdit)
      Case enumOpcionesEdicion.Cortar
        Cut(hEdit)
      Case enumOpcionesEdicion.Copiar
        Copy(hEdit)
      Case enumOpcionesEdicion.Pegar
        Paste(hEdit)
      Case enumOpcionesEdicion.SeleccionarTodo
        combobox.SelectAll()
        'Case menuIndex.Delete
        '  combobox.SelectedText = ""
    End Select
  End Sub

  Private Shared Sub DoISupportsEditCommand(ByVal control As ISupportsEdit, ByVal opcion As enumOpcionesEdicion)
    Select Case opcion
      Case enumOpcionesEdicion.Deshacer
        control.Undo()
      Case enumOpcionesEdicion.Rehacer
        control.Redo()
      Case enumOpcionesEdicion.Cortar
        control.Cut()
      Case enumOpcionesEdicion.Copiar
        control.Copy()
      Case enumOpcionesEdicion.Pegar
        control.Paste()
      Case enumOpcionesEdicion.SeleccionarTodo
        control.SelectAll()
        'Case menuIndex.Delete
        '  control.Delete()
        'Case menuIndex.Properties
        '  control.ShowProperties()
    End Select
  End Sub
#End Region

#Region "Interno"
  <DllImport("user32.dll")> _
  Public Shared Function GetFocus() As IntPtr
  End Function

  <DllImport("user32", SetLastError:=True)> _
Public Shared Function GetParent(ByVal hwnd As IntPtr) As IntPtr
  End Function

  <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)> _
Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
  End Function

  <StructLayout(LayoutKind.Sequential)> _
   Public Structure GETTEXTLENGTHEX
    Public uiFlags As Int32
    Public uiCodePage As Int32
  End Structure

  <DllImport("user32.dll", EntryPoint:="SendMessage", CharSet:=CharSet.Auto)> _
  Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByRef wParam As GETTEXTLENGTHEX, ByVal lParam As IntPtr) As Integer
  End Function

  Public Enum EditState
    None = 0
    UndoVisible = 1
    RedoVisible = 2
    UndoEnabled = 4
    RedoEnabled = 8
    CutEnabled = 16
    CopyEnabled = 32
    PasteEnabled = 64
    SelectAllEnabled = 128
    DeleteEnabled = 256
    RenameEnabled = 512
    PropertiesEnabled = 1024
  End Enum

  Public Const WM_USER = &H400
  Public Const EM_CUT = &H300
  Public Const EM_COPY = &H301
  Public Const EM_PASTE = &H302
  Public Const EM_CLEAR = &H303
  Public Const EM_UNDO = &H304

  Public Const EM_CANUNDO = &HC6
  Public Const EM_CANPASTE = WM_USER + 50
  Public Const EM_GETTEXTLENGTHEX = WM_USER + 95

  Public Shared Sub Undo(ByVal hEdit As IntPtr)
    SendMessage(hEdit, EM_UNDO, 0, 0)
  End Sub
  Public Shared Sub Cut(ByVal hEdit As IntPtr)
    SendMessage(hEdit, EM_CUT, 0, 0)
  End Sub
  Public Shared Sub Copy(ByVal hEdit As IntPtr)
    SendMessage(hEdit, EM_COPY, 0, 0)
  End Sub
  Public Shared Sub Paste(ByVal hEdit As IntPtr)
    SendMessage(hEdit, EM_PASTE, 0, 0)
  End Sub
  Public Function CanUndo(ByVal hEdit As IntPtr) As Boolean
    Return Not SendMessage(hEdit, EM_CANUNDO, 0, 0) = 0
  End Function

  Public Shared Function GetFrameworkControl(ByVal hControl As IntPtr) As Control
    Dim rv As Control = Nothing

    If hControl.ToInt32() <> 0 Then
      rv = Control.FromHandle(hControl)
      If rv Is Nothing Then
        rv = GetFrameworkControl(GetParent(hControl))
      End If
    End If
    Return rv
  End Function

  Public Shared Function GetISupportsEditControl(ByVal ctlFocus As Control) As ISupportsEdit
    While (Not (TypeOf ctlFocus Is ISupportsEdit) And Not ctlFocus Is Nothing)
      ctlFocus = ctlFocus.Parent
    End While
    Return CType(ctlFocus, ISupportsEdit)
  End Function

  Private Function GetISupportsEditState(ByVal control As ISupportsEdit) As EditState
    Dim eState As EditState = EditState.None
    If (control.UndoVisible) Then eState = eState Or EditState.UndoVisible
    If (control.CanUndo) Then eState = eState Or EditState.UndoEnabled
    If (control.RedoVisible) Then eState = eState Or EditState.RedoVisible
    If (control.CanRedo) Then eState = eState Or EditState.RedoEnabled
    If (control.CanCut) Then eState = eState Or EditState.CutEnabled
    If (control.CanCopy) Then eState = eState Or EditState.CopyEnabled
    If (control.CanPaste) Then eState = eState Or EditState.PasteEnabled
    If (control.CanSelectAll) Then eState = eState Or EditState.SelectAllEnabled
    If (control.CanDelete) Then eState = eState Or EditState.DeleteEnabled
    If (control.CanShowProperties) Then eState = eState Or EditState.PropertiesEnabled
    Return eState
  End Function
#End Region

End Class
