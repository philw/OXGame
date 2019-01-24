Public Class MainForm

    Dim game As New OXGame

    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint

        game.Draw(e.Graphics)

    End Sub


    Private Sub PictureBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseClick

        Dim Row As Integer
        Dim Column As Integer


        Column = e.X \ (PictureBox1.Width / 3)
        Row = e.Y \ (PictureBox1.Height / 3)
        game.Click(Row, Column)
        PictureBox1.Refresh()

    End Sub


    Private Sub NewGameButton_Click(sender As Object, e As EventArgs) Handles NewGameButton.Click

        game.NewGame()
        PictureBox1.Refresh()

    End Sub

End Class
