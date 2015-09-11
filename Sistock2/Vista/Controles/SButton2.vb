Public Class SButton2
    Inherits Button
    Public Sub New()
        MyBase.BackColor = Color.FromArgb(0, 191, 221)
        MyBase.Font = New Font("Dustismo", 12, FontStyle.Bold)
        MyBase.FlatStyle = FlatStyle.Flat
        MyBase.FlatAppearance.BorderSize = 0
        MyBase.ForeColor = Color.White
        MyBase.Height = 25
    End Sub
End Class
