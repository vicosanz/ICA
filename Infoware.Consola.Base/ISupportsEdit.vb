Public Interface ISupportsEdit
  ReadOnly Property UndoVisible() As Boolean
  ReadOnly Property CanUndo() As Boolean
  Sub Undo()
  ReadOnly Property RedoVisible() As Boolean
  ReadOnly Property CanRedo() As Boolean
  Sub Redo()
  ReadOnly Property CanCut() As Boolean
  Sub Cut()
  ReadOnly Property CanCopy() As Boolean
  Sub Copy()
  ReadOnly Property CanPaste() As Boolean
  Sub Paste()
  ReadOnly Property CanSelectAll() As Boolean
  Sub SelectAll()
  ReadOnly Property CanDelete() As Boolean
  Sub Delete()
  ReadOnly Property CanShowProperties() As Boolean
  Sub ShowProperties()
 End Interface
