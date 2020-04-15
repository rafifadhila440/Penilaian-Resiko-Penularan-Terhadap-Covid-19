Public Class Form2
    Dim sqlnya As String
    Dim ya As Integer
    Sub panggildata()
        koneksi()
        DA = New OleDb.OleDbDataAdapter("SELECT * FROM data", conn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "data")
        DataGridView1.DataSource = DS.Tables("data")
        DataGridView1.Enabled = True
    End Sub

    Sub jalan()
        Dim objcmd As New System.Data.OleDb.OleDbCommand
        Call koneksi()
        objcmd.Connection = conn
        objcmd.CommandType = CommandType.Text
        objcmd.CommandText = sqlnya
        objcmd.ExecuteNonQuery()
        objcmd.Dispose()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        Label5.Text = ""
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call panggildata()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True Then
            ya = +1
        End If

        If CheckBox2.Checked = True Then
            ya = +1
        End If

        If CheckBox3.Checked = True Then
            ya = +1
        End If

        If CheckBox4.Checked = True Then
            ya = +1
        End If

        If CheckBox5.Checked = True Then
            ya = +1
        End If

        If CheckBox6.Checked = True Then
            ya = +1
        End If

        If CheckBox7.Checked = True Then
            ya = +1
        End If

        If CheckBox8.Checked = True Then
            ya = +1
        End If

        If CheckBox9.Checked = True Then
            ya = +1
        End If

        If CheckBox10.Checked = True Then
            ya = +1
        End If

        If CheckBox11.Checked = True Then
            ya = +1
        End If

        If CheckBox12.Checked = True Then
            ya = +1
        End If

        If CheckBox13.Checked = True Then
            ya = +1
        End If

        If CheckBox14.Checked = True Then
            ya = +1
        End If

        If CheckBox15.Checked = True Then
            ya = +1
        End If

        If CheckBox16.Checked = True Then
            ya = +1
        End If

        If CheckBox17.Checked = True Then
            ya = +1
        End If

        If CheckBox18.Checked = True Then
            ya = +1
        End If

        If CheckBox19.Checked = True Then
            ya = +1
        End If

        If CheckBox20.Checked = True Then
            ya = +1
        End If

        If CheckBox21.Checked = True Then
            ya = +1
        End If

        If ya <= 7 Then
            MsgBox("SELAMAT RESIKO ANDA RENDAH")
            Label5.Text = "Resiko Rendah"
        ElseIf ya <= 14 Then
            MsgBox("RESIKO ANDA SEDANG")
            Label5.Text = "Resiko Sedang"
        ElseIf ya <= 21 Then
            MsgBox("RESIKO ANDA TINGGI")
            Label5.Text = "Resiko Tinggi"
        End If
        sqlnya = "insert into data (Nama,NIS,Rombel,Keterangan) values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & Label5.Text & "')"
        Call jalan()
        MsgBox("Data Berhasil Tersimpan")
        Call panggildata()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Close()
        Me.Close()
    End Sub
    'Disables Close Button Window'
    Private Const CP_NOCLOSE_BUTTON As Integer = &H200
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim myCp As CreateParams = MyBase.CreateParams
            myCp.ClassStyle = myCp.ClassStyle Or CP_NOCLOSE_BUTTON
            Return myCp
        End Get
    End Property
    'Disables Maximize Button'
    Public Function DisableMaximise(ByVal WindowHandle As IntPtr) As Boolean
        Try
            Dim f As Form = Form.FromHandle(WindowHandle)
            f.MaximizeBox = False
            Return True
        Catch
            Return False
        End Try
    End Function

End Class