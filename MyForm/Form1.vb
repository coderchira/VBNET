Public Class Form1
    'Event
    'But a subroutine
    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        MessageBox.Show("Form is clicked")
    End Sub
  
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MessageBox.Show("form is loaded")
        txtName.BackColor = Color.AliceBlue
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Button clicked")
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        txtName.ForeColor = Color.Red
    End Sub
End Class
