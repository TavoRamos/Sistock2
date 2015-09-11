Public Class SLabel
    Inherits Label
    Public Sub New()
        'Dustismo, 48pt, style=Italic
        MyBase.Font = New Font("Dustismo", 48, FontStyle.Italic)
        'MyBase.ForeColor = Color.FromArgb(221, 221, 221)
        MyBase.ForeColor = Color.FromArgb(0, 191, 221)
        MyBase.BackColor = Color.Transparent
    End Sub
End Class
