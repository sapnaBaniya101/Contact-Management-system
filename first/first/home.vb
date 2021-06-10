Public Class home
    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click
        With contact
            .TopLevel = False
            homepnl.Controls.Add(contact)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Guna2GradientButton5_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton5.Click
        With group
            .TopLevel = False
            homepnl.Controls.Add(group)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Guna2GradientButton6_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton6.Click
        With setting
            .TopLevel = False
            homepnl.Controls.Add(setting)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        With profile
            .TopLevel = False
            homepnl.Controls.Add(profile)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        With Me
            .TopLevel = False
            homepnl.Controls.Add(Me)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click
        With email
            .TopLevel = False
            homepnl.Controls.Add(email)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub close_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Dispose()
    End Sub

    Private Sub maximize_Click(sender As Object, e As EventArgs) Handles maximize.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub minimize_Click(sender As Object, e As EventArgs) Handles minimize.Click
        If Me.WindowState = FormWindowState.Minimized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Minimized
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        Me.Hide()
        login.Show()
        login.Activate()

    End Sub
End Class