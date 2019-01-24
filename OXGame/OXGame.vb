Public Class OXGame

    Private grid(2, 2) As Char
    Private player As Char


    Public Sub New()

        NewGame()

    End Sub

    Public Sub Click(Row As Integer, Column As Integer)

        If grid(Row, Column) = " " Then
            grid(Row, Column) = player

            If player = "X" Then
                player = "O"
            Else
                player = "X"
            End If
        End If

    End Sub

    Public Sub Draw(g As Graphics)

        ' draw the grid
        Dim pen As New Pen(Brushes.Black, 5)

        g.DrawLine(pen, 100, 0, 100, 300)
        g.DrawLine(pen, 200, 0, 200, 300)
        g.DrawLine(pen, 0, 100, 300, 100)
        g.DrawLine(pen, 0, 200, 300, 200)

        For Row = 0 To 2
            For Column = 0 To 2
                Dim X As Integer = Column * 100
                Dim Y As Integer = Row * 100
                If grid(Row, Column) = "X" Then
                    g.DrawLine(pen, X + 20, Y + 20, X + 80, Y + 80)
                    g.DrawLine(pen, X + 80, Y + 20, X + 20, Y + 80)
                ElseIf grid(Row, Column) = "O" Then
                    g.DrawEllipse(pen, X + 20, Y + 20, 60, 60)
                End If
            Next
        Next

        ShowPlayer()

    End Sub

    Private Sub ShowPlayer()
        MainForm.PlayerLabel.Text = String.Format("Player {0} it's your turn", player)
    End Sub

    Public Sub NewGame()

        For R = 0 To 2
            For C = 0 To 2
                grid(R, C) = " "
            Next
        Next

        player = "X"

    End Sub



End Class
