Imports System.Net.Mail
Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Imports System.Data.DataTable

Public Class email
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Documents\contactdatabase.accdb")
    Dim command As New OleDbDataAdapter
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        Try

            Dim smtp_server As New SmtpClient
            Dim e_mail As New MailMessage
            smtp_server.UseDefaultCredentials = False
            smtp_server.Credentials = New Net.NetworkCredential("skyrootmam123@gmail.com", "ganestole123")
            smtp_server.Port = 587
            smtp_server.EnableSsl = True
            smtp_server.Host = "smtp.gmail.com"
            e_mail = New MailMessage()
            e_mail.From = New MailAddress(txtfrom.Text)
            e_mail.To.Add(txtto.Text)
            e_mail.Subject = txtsubject.Text
            e_mail.IsBodyHtml = False
            e_mail.Body = message.Text
            smtp_server.Send(e_mail)
            MsgBox("Email sent, thank you!!!!")




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtsubject_TextChanged(sender As Object, e As EventArgs) Handles txtsubject.TextChanged

    End Sub

    Private Sub txtfrom_TextChanged(sender As Object, e As EventArgs) Handles txtfrom.TextChanged

    End Sub

    Private Sub email_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        Dim email1 As String
        Dim cmd As OleDbCommand = New OleDbCommand("select email from [register] where username='" & usernamemv & "' and password='" & passwordmv & "'", con)

        Dim myreader As OleDbDataReader
        myreader = cmd.ExecuteReader
        myreader.Read()

        email1 = myreader("email")
        txtfrom.Text = email1
        myreader.Close()
        con.Close()
    End Sub
End Class