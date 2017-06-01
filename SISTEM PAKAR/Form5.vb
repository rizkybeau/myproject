Imports System.Data.OleDb
Public Class Form5
    Dim conn As OleDbConnection 'koneksi
    Dim da As OleDbDataAdapter 'penghubung
    Dim ds As DataSet 'membaca database
    Dim rd As OleDbDataReader 'melihat data di database
    Dim cmd As OleDbCommand 'eksekusi query
    Dim cmd2 As OleDbCommand

    Dim LokasiDB As String
    Sub koneksi()
        LokasiDB = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=tivi.mdb"
        conn = New OleDbConnection(LokasiDB)
        If conn.State = ConnectionState.Closed Then
            conn.Open()

        End If
    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Form4.Label1.Text = 1 Then 'jika index 0 di form 4
            kondisi1("T1")
            lblid.Text = "T1"
        ElseIf Form4.Label1.Text = 0 Then
            kondisi1("T10")
            lblid.Text = "T10"
        End If


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
    Sub kondisi1(ByVal X1 As String) 'ketika memilih 1 masalah pada ic program dan membuka rule nya

        koneksi()
        'da = New OleDbDataAdapter("select kerusakan from knowledge", conn)
        ds = New DataSet
        ds.Clear()
        'da.Fill(ds, "knowledge") 'error????
        'DataGridView1.DataSource = (ds.Tables("knowledge"))
        cmd = New OleDbCommand("select pertanyaan from knowledge where id='" & X1 & "'", conn) 'untuk ditampilkan intinya kalau dia klik ya idnya yang jadi acuan
        rd = cmd.ExecuteReader

        Do While rd.Read
            'label1.Text = rd.GetValue(0)
            'Label5.Text = rd.Item(0)
            ComboBox1.Items.Add(rd.Item(0))
            lblpertanyaan.Text = rd.GetValue(0)
        Loop

    End Sub 'ketika memilih 1 buat id
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'ya button
        Form7.ShowDialog()

        'UNTUK MEMANGGIL RULE NYA BEGINI CODENYA
        If lblid.Text = "T1" Then
            lblid.Text = "T2" 'LIHAT RULE
            kondisi1(lblid.Text)
        ElseIf lblid.Text = "T2" Then
            lblid.Text = "S1"
            Me.Close()
            conn.Close()
            Form6.ShowDialog()
        ElseIf lblid.Text = "T3" Then
            lblid.Text = "S2"
            Me.Close()
            Form6.ShowDialog()
        ElseIf lblid.Text = "T4" Then
            lblid.Text = "T8"
            kondisi1(lblid.Text)
        ElseIf lblid.Text = "T5" Then
            lblid.Text = "S5"
            Me.Close()
            Form6.ShowDialog()
        ElseIf lblid.Text = "T6" Then
            lblid.Text = "T7"
            kondisi1(lblid.Text)
        ElseIf lblid.Text = "T7" Then
            lblid.Text = "S7"
            Me.Close()
            Form6.ShowDialog()

        ElseIf lblid.Text = "T8" Then
            lblid.Text = "S4"
            Me.Close()
            Form6.ShowDialog()

        ElseIf lblid.Text = "T9" Then
            lblid.Text = "S9"
            Me.Close()
            Form6.ShowDialog()
            'END OF JENIS KERUSAKAN 1
            'START KERUSAKAN JENIS KE 2
        ElseIf lblid.Text = "T10" Then
            lblid.Text = "T11"
            kondisi1(lblid.text)
        ElseIf lblid.Text = "T11" Then
            lblid.Text = "T12"
            kondisi1(lblid.Text)
        ElseIf lblid.Text = "T12" Then
            lblid.Text = "T13"
            kondisi1(lblid.Text)
        ElseIf lblid.Text = "T13" Then
            lblid.Text = "T14"
            kondisi1(lblid.Text)
        ElseIf lblid.Text = "T14" Then
            lblid.Text = "T16"
            kondisi1(lblid.Text)
        ElseIf lblid.Text = "T15" Then
            lblid.Text = "S21"
            Me.Close()
            Form6.ShowDialog()
        ElseIf lblid.Text = "T16" Then
            lblid.Text = "S18"
            Me.Close()
            Form6.ShowDialog()
        ElseIf lblid.Text = "T17" Then
            lblid.Text = "S15"
            Me.Close()
            Form6.ShowDialog()
        ElseIf lblid.Text = "T18" Then
            lblid.Text = "T19"
            kondisi1(lblid.Text)
        ElseIf lblid.Text = "T19" Then
            lblid.Text = "T20"
            kondisi1(lblid.Text)
        ElseIf lblid.Text = "T20" Then
            lblid.Text = "S18"
            Me.Close()
            Form6.ShowDialog()
        End If
        


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'false button
        'UNTUK MEMANGGIL RULE NYA BEGINI CODENYA
        '(R1)-------------------------------------------------------------------
        Form7.ShowDialog()
        If lblid.Text = "T1" Then 'id pertanyaan yang ditampilkan sebelum menjawab ya atau tidak
            lblid.Text = "T4" 'id pertanyaan untuk ditampilkan selanjutnya
            kondisi1(lblid.Text) 'menampilkan pertanyaan berdasarkan id
        ElseIf lblid.Text = "T2" Then
            lblid.Text = "T3"
            kondisi1(lblid.Text)
        ElseIf lblid.Text = "T3" Then
            lblid.Text = "S3"
            Me.Close()
            Form6.ShowDialog()
        ElseIf lblid.Text = "T4" Then 'ID DARI TABEL KNOWLEDGE
            lblid.Text = "T5"
            kondisi1(lblid.Text) 'menampilkan pertanyaan berdasarkan id
        ElseIf lblid.Text = "T5" Then
            lblid.Text = "S6" ' id tabel solusi (kondisi false) 
            Me.Close()
            Form6.ShowDialog()
        ElseIf lblid.Text = "T6" Then
            lblid.Text = "T9"
            kondisi1(lblid.Text)
        ElseIf lblid.Text = "T7" Then
            lblid.Text = "S8"
            Me.Close()
            Form6.ShowDialog()
        ElseIf lblid.Text = "T8" Then
            lblid.Text = "T6"
            kondisi1(lblid.Text)
        ElseIf lblid.Text = "T9" Then
            lblid.Text = "S10"
            Me.Close()
            Form6.ShowDialog()
            '(R1)----------------------------------------------------------------
        ElseIf lblid.Text = "T10" Then
            lblid.Text = "T18"
            kondisi1(lblid.Text)
        ElseIf lblid.Text = "T11" Then
            lblid.Text = "S12"
            Me.Close()
            Form6.ShowDialog()
        ElseIf lblid.Text = "T12" Then
            lblid.Text = "S13"
            Me.Close()
            Form6.ShowDialog()
        ElseIf lblid.Text = "T13" Then
            lblid.Text = "T15"
            kondisi1(lblid.Text)
        ElseIf lblid.Text = "T14" Then
            lblid.Text = "T17"
            kondisi1(lblid.Text)
        ElseIf lblid.Text = "T15" Then
            lblid.Text = "S17"
            Me.Close()
            Form6.ShowDialog()
        ElseIf lblid.Text = "T16" Then
            lblid.Text = "S14"
            Me.Close()
            Form6.ShowDialog()
        ElseIf lblid.Text = "T17" Then
            lblid.Text = "S16"
            Me.Close()
            Form6.ShowDialog()
        ElseIf lblid.Text = "T18" Then
            lblid.Text = "S20"
            Me.Close()
            Form6.ShowDialog()
        ElseIf lblid.Text = "T19" Then
            lblid.Text = "S19"
            Me.Close()
            Form6.ShowDialog()
        ElseIf lblid.Text = "T20" Then
            lblid.Text = "S11"
            Me.Close()
            Form6.ShowDialog()
        End If
            End Sub
End Class