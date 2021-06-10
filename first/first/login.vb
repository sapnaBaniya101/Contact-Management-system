
Imports System.IO
Imports System.Data
Imports System.Data.OleDb

Public Class login
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Documents\contactdatabase.accdb")
    ' Dim con As OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Documents\contactdatabase.accdb")
    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles username.TextChanged
        usernamemv = username.Text
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Register.Show()
        Register.Activate()
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        If username.Text = Nothing Or password.Text = Nothing Then
            MsgBox("please enter username or password", MsgBoxStyle.Exclamation)
        Else
            con.Open()
            Dim cmd As OleDbCommand = New OleDbCommand("select count(*) from register where username=? and password=?", con)
            cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = username.Text
            cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = password.Text
            Dim count = Convert.ToInt32(cmd.ExecuteScalar())
            If count > 0 Then

                MsgBox("Login Successfull", MsgBoxStyle.Information)

                Me.Hide()
                home.Show()
                home.Activate()
            Else
                MsgBox("Username not valid", MsgBoxStyle.Exclamation)
            End If
        End If


        con.Close()
    End Sub

    Private Sub password_TextChanged(sender As Object, e As EventArgs) Handles password.TextChanged
        passwordmv = password.Text
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        username.Clear()
        password.Clear()
    End Sub
End Class
