Public Class SButton
    Inherits Button
    Public Event Desactivar()
    Public Sub New()
        MyBase.BackColor = Color.FromArgb(25, 24, 24)
        MyBase.Height = 35
        MyBase.Width = 150
        MyBase.ForeColor = Color.FromArgb(102, 102, 102)
        MyBase.FlatStyle = FlatStyle.Flat
        MyBase.FlatAppearance.BorderSize = 0
        'Dustismo, 12pt, style=Bold
        MyBase.Font = New Font("Dustismo", 12, FontStyle.Bold)
    End Sub
    Public Sub SButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Click
        MyBase.BackColor = Color.FromArgb(34, 34, 34)
        MyBase.ForeColor = Color.White
    End Sub
    Public Sub DesactivarBTN() Handles MyClass.Desactivar
        Me.ForeColor = Color.FromArgb(102, 102, 102)
        Me.BackColor = Color.FromArgb(25, 24, 24)
    End Sub
End Class
