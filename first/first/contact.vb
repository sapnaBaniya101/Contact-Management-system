Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Imports System.Data.DataTable
Public Class contact
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Documents\contactdatabase.accdb")
    ' Dim con As OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Documents\contactdatabase.accdb")
    Dim cmda As OleDbCommand
    Dim cmd As OleDbCommand
    Dim comm As String
    Dim adtp As OleDbDataAdapter
    Dim sql As String
    Dim dt As New DataTable
    Dim index As Integer
    Dim abyt As Byte() = Nothing
    Dim imgpath As String
    Private Sub contact_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        addcontactpnl.Visible = False
        updatecontactpnl.Visible = False
        deletecontactpnl.Visible = False
        DVGview3.Visible = False

        Try
            con.Open()

            If con.State = ConnectionState.Open Then
                MsgBox("Connected")
            Else
                MsgBox("Not Connected!")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()

        End Try
        con.Open()


        Sql = "select r_id from [register] where username='" & usernamemv & "' and password='" & passwordmv & "'"

        Dim cmda As New OleDbCommand(sql, con)
        Dim myreader As OleDbDataReader

        myreader = cmda.ExecuteReader
        myreader.Read()

        rid = myreader("r_id")
        myreader.Close()
        con.Close()
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        addcontactpnl.Visible = True
        updatecontactpnl.Visible = False
        deletecontactpnl.Visible = False


    End Sub

    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click
        deletecontactpnl.Visible = True
        updatecontactpnl.Visible = False
        addcontactpnl.Visible = False
    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        updatecontactpnl.Visible = True
        addcontactpnl.Visible = False
        deletecontactpnl.Visible = False
    End Sub
    Private Sub dataload()
        con.Close()
        con.Open()
        adtp = New OleDbDataAdapter("select c_id,contact_name,con_number,business,email,dateofbirth,img from [contact] where r_id=" & rid & "", con)
        adtp.Fill(dt)
        DVGview3.DataSource = dt.DefaultView
        con.Close()
    End Sub
    Private Sub viewContactbtn_Click(sender As Object, e As EventArgs) Handles viewContactbtn.Click
        DVGview3.Visible = True
        dataload()

    End Sub

    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2GradientButton5_Click(sender As Object, e As EventArgs)
        ' Try
        'Dim sql As String

        'Dim i As Integer
        'con.Open()
        'Dim retrievequery = "select *from contact"
        'Dim adtp As OleDbDataAdapter = New OleDbDataAdapter(retrievequery, con)
        'Dim ds As DataSet = New DataSet
        'adtp.Fill(ds, "Student")
        'DVGview2.DataSource = ds.Tables(0)
        'Sql = " update [contact] set [contact_name]='@name', [con_number]='@number',[business]='@business',[email]='@email',[dateofbirth]='@date'"
        'cmd.Parameters.AddWithValue("@name", txtname1.Text)
        'cmd.Parameters.AddWithValue("@number", txtmobile1.Text)
        'cmd.Parameters.AddWithValue("@business", txtbusiness1.Text)
        'cmd.Parameters.AddWithValue("@email", txtemail1.Text)
        'cmd.Connection = con
        'cmd.CommandText = sql
        'i = cmd.ExecuteNonQuery
        'If i > 0 Then
        'MsgBox("record has been updated successfully!")
        'Else
        'MsgBox("record has been updated successfully!")
        'End If

        'Catch ex As Exception
        'MsgBox(ex.Message)
        'Finally
        'con.Close()

        'End Try
    End Sub

    Private Sub Guna2GradientButton6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtname_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
    End Sub

    Private Sub viewpnl_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Guna2GradientButton4_Click_1(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click

        If txtname.Text = Nothing Or txtnumber.Text = Nothing Or txtbusiness.Text = Nothing Or txtemail.Text = Nothing Or txtdate.Text = Nothing Then
            MsgBox("please enter above detail", MsgBoxStyle.Exclamation)

        Else




            Dim query As New OleDb.OleDbCommand
            con.Open()
            query.Connection = con

            query.CommandText = "insert into [contact]([contact_name],[con_number],[business],[email],[dateofbirth],[r_id],[img])values(@name,@number,@business,@email,@dateofbirth,@r,@pic)"
                query.Parameters.AddWithValue("@name", txtname.Text)
                query.Parameters.AddWithValue("@number", txtnumber.Text)
                query.Parameters.AddWithValue("@business", txtbusiness.Text)
                query.Parameters.AddWithValue("@email", txtemail.Text)
                query.Parameters.AddWithValue("@dateofbirth", txtdate.Text)
                query.Parameters.AddWithValue("@r", rid)
                query.Parameters.AddWithValue("@pic", abyt)
                Try
                    query.ExecuteNonQuery()
                    query.Dispose()

                    MsgBox("Inserted Successfully")
                dataload()
                con.Close()
            Catch ex As Exception
                    MsgBox(ex.Message)
                End Try








        End If
        con.Close()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

        Dim op As OpenFileDialog = New OpenFileDialog
        op.Filter = "JPG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|PNG(*.png)|*.png|All Files(*.*)|*.*"
        op.Title = "select image...."

        If op.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim fs As New FileStream(op.FileName, FileMode.Open)
            Dim br As New BinaryReader(fs)
            abyt = br.ReadBytes(CInt(fs.Length))
            br.Close()
            Dim ms As New MemoryStream(abyt)
            contactpicture.Image = Image.FromStream(ms)
        End If
    End Sub

    Private Sub Guna2GradientButton5_Click_1(sender As Object, e As EventArgs) Handles Guna2GradientButton5.Click
        con.Open()
        comm = "update [contact] set [contact_name]='" & name1.Text & "',[con_number]='" & number1.Text & "',[business]='" & business1.Text & "',[email]='" & email1.Text & "',[dateofbirth]='" & time1.Text & "' where c_id=" & Val(txtid.Text) & ""
        cmd = New OleDbCommand(comm, con)

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            MsgBox("Updated Successfully")

            dataload()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub DVGview3_CellClick(sender As Object, e As DataGridViewCellEventArgs)


    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles updatepic.Click

    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub Guna2GradientButton6_Click_1(sender As Object, e As EventArgs) Handles Guna2GradientButton6.Click
        con.Open()
        comm = "delete * from [contact] where c_id=" & Val(txtid1.Text) & ""
        cmd = New OleDbCommand(comm, con)

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            MsgBox("Deleted Successfully")
            dataload()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
        dataload()
    End Sub

    Private Sub DVGview3_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DVGview3.CellClick
        con.Open()
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow

        selectedrow = DVGview3.Rows(index)
        txtid.Text = selectedrow.Cells(0).Value.ToString()
        txtname.Text = selectedrow.Cells(1).Value.ToString()
        txtnumber.Text = selectedrow.Cells(2).Value.ToString()
        txtbusiness.Text = selectedrow.Cells(3).Value.ToString()
        txtemail.Text = selectedrow.Cells(4).Value.ToString()
        txtdate.Text = selectedrow.Cells(5).Value.ToString()
        txtid1.Text = selectedrow.Cells(0).Value.ToString()
        txtname1.Text = selectedrow.Cells(1).Value.ToString()
        txtnumber1.Text = selectedrow.Cells(2).Value.ToString()
        txtbusiness1.Text = selectedrow.Cells(3).Value.ToString()
        txtemail1.Text = selectedrow.Cells(4).Value.ToString()
        txtdate1.Value = selectedrow.Cells(5).Value.ToString()
        name1.Text = selectedrow.Cells(1).Value.ToString()
        number1.Text = selectedrow.Cells(2).Value.ToString()
        business1.Text = selectedrow.Cells(3).Value.ToString()
        email1.Text = selectedrow.Cells(4).Value.ToString()
        time1.Value = selectedrow.Cells(5).Value.ToString()
        Dim comm As New OleDbCommand
        Dim dataread As OleDbDataReader
        With comm
            .Connection = con
            .CommandText = "select * from [contact] where c_id=" & Val(txtid1.Text) & ""
        End With

        dataread = comm.ExecuteReader()
        While dataread.Read()
            Try
                abyt = CType(dataread("img"), Byte())
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


        End While
        Dim ms As New MemoryStream(abyt)
        updatepic.Image = Image.FromStream(ms)
        ms.Close()
        con.Close()
    End Sub

    Private Sub addcontactpnl_Paint(sender As Object, e As PaintEventArgs) Handles addcontactpnl.Paint

    End Sub

    Private Sub deletecontactpnl_Paint(sender As Object, e As PaintEventArgs) Handles deletecontactpnl.Paint

    End Sub

    Private Sub DVGview3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DVGview3.CellContentClick

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub
End Class