Imports System.Data.OleDb
Public Class Form10


    Dim conn As OleDbConnection 'koneksi
    Dim da As OleDbDataAdapter 'penghubung
    Dim ds As DataSet 'membaca database
    Dim rd As OleDbDataReader 'melihat data di database
    Dim cmd As OleDbCommand 'eksekusi query
    Dim cmd2 As OleDbCommand

    Dim LokasiDB As String

    Sub koneksi()
        LokasiDB = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=tivi.mdb;Jet OLEDB:Database Password=123;"
        conn = New OleDbConnection(LokasiDB)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub



    Sub kondisiawal() 'pilihan jenis kerusakan yang terjadi
        koneksi()
        da = New OleDbDataAdapter("select * from kerusakan", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "kerusakan")
        DataGridView1.DataSource = (ds.Tables("kerusakan"))
        cmd = New OleDbCommand("select jenis_kerusakan from kerusakan", conn)
        rd = cmd.ExecuteReader

        Do While rd.Read 'MENGAMBIL SEMUA DATA DATABASE KE COMBOBOX
            ComboBox1.Items.Add(rd.Item(0))
        Loop

    End Sub
    Sub deletedatabase()
        Try
            koneksi()
            'da = New OleDbDataAdapter("select kerusakan from knowledge", conn)
            ds = New DataSet
            ds.Clear()
            'da.Fill(ds, "knowledge")
            'DataGridView1.DataSource = (ds.Tables("knowledge"))
            cmd = New OleDbCommand("DELETE FROM temp WHERE 1", conn) 'untuk ditampilkan intinya kalau dia klik ya idnya yang jadi acuan
            rd = cmd.ExecuteReader
            'conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            'conn.Dispose()
        End Try

    End Sub
    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        deletedatabase()
        ComboBox1.Items.Clear()
        kondisiawal()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        deletedatabase()
        Form7.Label2.Text = 0 'mengembalikan nilai ke nol! cf
        Form7.Label3.Text = 0 ' idem
        Form5.Label3.Text = Form5.Label3.Text - 1
        If Form5.Label3.Text = 0 Then
            MsgBox("batas pemakaian sudah habis mohon maaf program akan ditutup ", MsgBoxStyle.Critical)
            End
        End If

        If ComboBox1.SelectedIndex = 1 Then
            Label1.Text = ComboBox1.SelectedIndex
            Label2.Text = ComboBox1.SelectedItem
            Form5.ShowDialog()
        ElseIf ComboBox1.SelectedIndex = 0 Then
            Label1.Text = ComboBox1.SelectedIndex
            Label2.Text = ComboBox1.SelectedItem
            Form5.ShowDialog()
        End If
       
        Me.Close()
    End Sub
    Protected Overrides Sub WndProc(ByRef m As Message)
        If (m.Msg = &H112) AndAlso (m.WParam.ToInt32() = &HF010) Then
            Return
        End If
        If (m.Msg = &HA1) AndAlso (m.WParam.ToInt32() = &H2) Then
            Return
        End If
        MyBase.WndProc(m)
    End Sub

    Private Sub Form10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()
        kondisiawal()
    End Sub
End Class
