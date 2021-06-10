Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Public Class group
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Documents\contactdatabase.accdb")
    Dim command As New OleDbDataAdapter
    Dim command1 As New OleDbDataAdapter
    Dim dt As New DataTable
    Dim dt1 As New DataTable
    Dim comm As String
    Dim index As Integer
    Dim cmd As OleDbCommand
    Dim newdatarow As DataGridViewRow
    Dim sql1 As String


    Private Sub dataload()
        con.Close()
        con.Open()
        command = New OleDbDataAdapter("select * from [group] where r_id=" & Val(rid) & "", con)
        command.Fill(dt)
        DataGridView.DataSource = dt.DefaultView
        con.Close()
    End Sub
    Private Sub group_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView.Visible = False
        updategrouppanel.Hide()
        insertgrouppanel.Hide()
        deletegrouppanel.Hide()
        dataload()


    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        DataGridView.Visible = True
    End Sub

    Private Sub DataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView.CellClick

        index = e.RowIndex
        Dim selectedrow As DataGridViewRow
        selectedrow = DataGridView.Rows(index)
        txtid.Text = selectedrow.Cells(0).Value.ToString()
        txtgroupname.Text = selectedrow.Cells(1).Value.ToString()
        txtcontactname.Text = selectedrow.Cells(2).Value.ToString()
        txtid1.Text = selectedrow.Cells(0).Value.ToString()
        txtgroupname1.Text = selectedrow.Cells(1).Value.ToString()
        txtcontactname1.Text = selectedrow.Cells(2).Value.ToString()
        txtcontactid.Text = selectedrow.Cells(3).Value.ToString()

    End Sub

    Private Sub Guna2GradientButton5_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton5.Click

        newdatarow = DataGridView.Rows(index)
        newdatarow.Cells(0).Value = txtid.Text
        newdatarow.Cells(1).Value = txtgroupname.Text
        newdatarow.Cells(2).Value = txtcontactname.Text
        con.Open()
        comm = "update [group] set [group_name]='" & txtgroupname.Text & "', [cont_name]='" & txtcontactname.Text & "' where [group_id]=" & txtid.Text & ""
        cmd = New OleDbCommand(comm, con)

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            MsgBox("Updated Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        insertgrouppanel.Hide()
        deletegrouppanel.Hide()
        updategrouppanel.Show()

    End Sub

    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click

        updategrouppanel.Hide()
        deletegrouppanel.Hide()
        insertgrouppanel.Show()
    End Sub

    Private Sub Guna2GradientButton6_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton6.Click
        con.Open()


        sql1 = "select r_id from [register] where username='" & usernamemv & "' and password='" & passwordmv & "'"

        Dim cmda As New OleDbCommand(sql1, con)
        Dim myreader As OleDbDataReader

        myreader = cmda.ExecuteReader
        myreader.Read()

        rid = myreader("r_id")
        myreader.Close()
        con.Close()
        Dim sql As String

        con.Open()

        Dim cmd1 As OleDbCommand = New OleDbCommand("select count(*) from [contact] where contact_name=?", con)
        cmd1.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = txtcontact.Text

        Dim count = Convert.ToInt32(cmd1.ExecuteScalar())
        If count > 0 Then
            Dim cmd2 As OleDbCommand = New OleDbCommand("select c_id from [contact] where contact_name=?", con)
            cmd2.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = txtcontact.Text
            Dim myreader1 As OleDbDataReader
            myreader1 = cmd2.ExecuteReader()
            myreader1.Read()

            sql = myreader1("c_id")
            Dim cmd3 As OleDbCommand = New OleDbCommand("select count(*) from [group] where group_name=? and cont_name=?", con)
            cmd3.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = txtgroupname.Text
            cmd3.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = txtcontactname.Text

            Dim count1 = Convert.ToInt32(cmd3.ExecuteScalar())
            If count1 > 0 Then
                MsgBox("Group already exist")
            Else

                comm = "insert into [group](group_name,cont_name,c_id,r_id) values(@groupname,@contactname,@cid," & Val(rid) & ")"
                cmd = New OleDbCommand(comm, con)
                cmd.Parameters.AddWithValue("@groupname", txtname.Text)
                cmd.Parameters.AddWithValue("@contactname", txtcontact.Text)
                cmd.Parameters.AddWithValue("@cid", sql)

                cmd.ExecuteNonQuery()

                txtname.Clear()
                txtcontact.Clear()
                dataload()
            End If

        Else
            MsgBox("Contact not found", MsgBoxStyle.Exclamation)
        End If
        con.Close()

    End Sub

    Private Sub Guna2GradientButton7_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton7.Click
        con.Open()
        comm = "delete * from [group] where group_id=" & Val(txtid1.Text) & " AND r_id=" & Val(rid) & ""
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
    End Sub

    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click

        updategrouppanel.Hide()
        insertgrouppanel.Hide()
        deletegrouppanel.Show()
    End Sub

    Private Sub Guna2GradientButton8_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton8.Click

        con.Open()


        command1 = New OleDbDataAdapter("select * from [group] where group_name='" & txtsearch.Text & "'", con)
        command1.Fill(dt1)
        DataGridView.DataSource = dt1.DefaultView
        con.Close()
        DataGridView.Visible = True
        txtsearch.Clear()
    End Sub
End Class