Imports System.Data.OleDb
Public Class Form5
    Dim conn As OleDbConnection 'koneksi
    Dim da As OleDbDataAdapter 'penghubung
    Dim ds As DataSet 'membaca database
    Dim rd As OleDbDataReader 'melihat data di database
    Dim cmd As OleDbCommand 'eksekusi query


    Dim LokasiDB As String
    Sub koneksi()
        LokasiDB = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=tivi.mdb;Jet OLEDB:Database Password=123;"

        conn = New OleDbConnection(LokasiDB)
        If conn.State = ConnectionState.Closed Then
            conn.Open()

        End If
    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Form10.Label1.Text = 1 Then 'jika index 0 di form 4
            pertanyaan("T1")
            lblid.Text = "T1"
        ElseIf Form10.Label1.Text = 0 Then
            pertanyaan("T10")
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
    Sub pertanyaan(ByVal X1 As String) 'ketika memilih 1 masalah pada ic program dan membuka rule nya

        koneksi()

        'da = New OleDbDataAdapter("select kerusakan from knowledge", conn)
        ds = New DataSet
        ds.Clear()
        'da.Fill(ds, "knowledge") 'error????
        'DataGridView1.DataSource = (ds.Tables("knowledge"))
        cmd = New OleDbCommand("select pertanyaan,FaktaYa,FaktaTidak from knowledge where id='" & X1 & "'", conn) 'untuk ditampilkan intinya kalau dia klik ya idnya yang jadi acuan
        rd = cmd.ExecuteReader

        Do While rd.Read
            'ComboBox1.Items.Add(rd.Item(1))
            lblpertanyaan.Text = rd.GetValue(0) 'MENAMPILKAN DATABASE KE LABEL DI VB
            Labelfaktaya.Text = rd.GetValue(1) 'fakta ya
            Labelfaktatidak.Text = rd.GetValue(2)
            

        Loop

    End Sub 'ketika memanggil database selanjutnya by id
    Sub databasefaktaya()
        Try
            koneksi()
            'da = New OleDbDataAdapter("select kerusakan from knowledge", conn)
            ds = New DataSet
            ds.Clear()
            'da.Fill(ds, "knowledge")
            'DataGridView1.DataSource = (ds.Tables("knowledge"))
            cmd = New OleDbCommand("insert into temp (id_temp,fakta,cf) values ('" & lblid.Text & "','" & Labelfaktaya.Text & "','" & Form7.Label2.Text & "')", conn)
            rd = cmd.ExecuteReader
            'conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            'conn.Dispose()
        End Try
        
    End Sub 'memanggil fakta ya di database knowledge
    Sub databasefaktatidak()
        Try
            koneksi()
            'da = New OleDbDataAdapter("select kerusakan from knowledge", conn)
            ds = New DataSet
            ds.Clear()
            'da.Fill(ds, "knowledge")
            'DataGridView1.DataSource = (ds.Tables("knowledge"))
            cmd = New OleDbCommand("insert into temp (id_temp,fakta,cf) values ('" & lblid.Text & "','" & Labelfaktatidak.Text & "','" & Form7.Label2.Text & "')", conn)
            rd = cmd.ExecuteReader
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
       

    End Sub 'memanggil fakta tidak di database knowledge
    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'ya button
        Form7.ShowDialog()

        'UNTUK MEMANGGIL RULE NYA BEGINI CODENYA
        If lblid.Text = "T1" Then
            databasefaktaya()
            lblid.Text = "T2" 'LIHAT RULE

            pertanyaan(lblid.Text)

        ElseIf lblid.Text = "T2" Then
            databasefaktaya()
            lblid.Text = "S1"

            Me.Close()
            conn.Close()
            Form6.ShowDialog()
        ElseIf lblid.Text = "T3" Then
            databasefaktaya()
            lblid.Text = "S2"
            Me.Close()
            Form6.ShowDialog()
        ElseIf lblid.Text = "T4" Then
            databasefaktaya()
            lblid.Text = "T8"
            pertanyaan(lblid.Text)
        ElseIf lblid.Text = "T5" Then
            databasefaktaya()
            lblid.Text = "S4"
            Me.Close()
            Form6.ShowDialog()
        ElseIf lblid.Text = "T6" Then
            databasefaktaya()
            lblid.Text = "T7"
            pertanyaan(lblid.Text)
        ElseIf lblid.Text = "T7" Then
            databasefaktaya()
            lblid.Text = "S7"
            Me.Close()
            Form6.ShowDialog()

        ElseIf lblid.Text = "T8" Then
            databasefaktaya()
            lblid.Text = "S6"
            Me.Close()
            Form6.ShowDialog()

        ElseIf lblid.Text = "T9" Then
            databasefaktaya()
            lblid.Text = "S9"
            Me.Close()
            Form6.ShowDialog()
            'END OF JENIS KERUSAKAN 1
            'START KERUSAKAN JENIS KE 2
        ElseIf lblid.Text = "T10" Then
            databasefaktaya()
            lblid.Text = "T11"
            pertanyaan(lblid.text)
        ElseIf lblid.Text = "T11" Then
            databasefaktaya()
            lblid.Text = "T12"
            pertanyaan(lblid.Text)
        ElseIf lblid.Text = "T12" Then
            databasefaktaya()
            lblid.Text = "T13"
            pertanyaan(lblid.Text)
        ElseIf lblid.Text = "T13" Then
            databasefaktaya()
            lblid.Text = "T16"
            pertanyaan(lblid.Text)
        ElseIf lblid.Text = "T14" Then
            databasefaktaya()
            lblid.Text = "T16"
            pertanyaan(lblid.Text)
        ElseIf lblid.Text = "T15" Then
            databasefaktaya()
            lblid.Text = "S13"
            Me.Close()
            Form6.ShowDialog()
        ElseIf lblid.Text = "T16" Then
            databasefaktaya()
            lblid.Text = "S16"
            Me.Close()
            Form6.ShowDialog()
        ElseIf lblid.Text = "T17" Then
            databasefaktaya()
            lblid.Text = "S15"
            Me.Close()
            Form6.ShowDialog()
        ElseIf lblid.Text = "T18" Then
            databasefaktaya()
            lblid.Text = "T19"
            pertanyaan(lblid.Text)
        ElseIf lblid.Text = "T19" Then
            databasefaktaya()
            lblid.Text = "T20"
            pertanyaan(lblid.Text)
        ElseIf lblid.Text = "T20" Then
            databasefaktaya()
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
            databasefaktatidak()
            lblid.Text = "T4" 'id pertanyaan untuk ditampilkan selanjutnya
            pertanyaan(lblid.Text) 'menampilkan pertanyaan berdasarkan id
        ElseIf lblid.Text = "T2" Then
            databasefaktatidak()
            lblid.Text = "T3"
            pertanyaan(lblid.Text)
        ElseIf lblid.Text = "T3" Then
            databasefaktatidak()
            lblid.Text = "S3"
            Me.Close()
            Form6.ShowDialog()
        ElseIf lblid.Text = "T4" Then 'ID DARI TABEL KNOWLEDGE

            databasefaktatidak()
            lblid.Text = "T5"
            pertanyaan(lblid.Text) 'menampilkan pertanyaan berdasarkan id
        ElseIf lblid.Text = "T5" Then
            databasefaktatidak()
            lblid.Text = "S5" ' id tabel solusi (kondisi false) 
            Me.Close()
            Form6.ShowDialog()
        ElseIf lblid.Text = "T6" Then
            databasefaktatidak()
            lblid.Text = "T9"
            pertanyaan(lblid.Text)
        ElseIf lblid.Text = "T7" Then
            databasefaktatidak()
            lblid.Text = "S8"
            Me.Close()
            Form6.ShowDialog()
        ElseIf lblid.Text = "T8" Then
            databasefaktatidak()
            lblid.Text = "T6"
            pertanyaan(lblid.Text)
        ElseIf lblid.Text = "T9" Then
            databasefaktatidak()
            lblid.Text = "S10"
            Me.Close()
            Form6.ShowDialog()
            '(R1)----------------------------------------------------------------
        ElseIf lblid.Text = "T10" Then
            databasefaktatidak()
            lblid.Text = "T18"
            pertanyaan(lblid.Text)
        ElseIf lblid.Text = "T11" Then
            databasefaktatidak()
            lblid.Text = "S17"
            Me.Close()
            Form6.ShowDialog()
        ElseIf lblid.Text = "T12" Then
            databasefaktatidak()
            lblid.Text = "S12"
            Me.Close()
            Form6.ShowDialog()
        ElseIf lblid.Text = "T13" Then
            databasefaktatidak()
            lblid.Text = "T15"
            pertanyaan(lblid.Text)
        ElseIf lblid.Text = "T14" Then
            databasefaktatidak()
            lblid.Text = "T17"
            pertanyaan(lblid.Text)
        ElseIf lblid.Text = "T15" Then
            databasefaktatidak()
            lblid.Text = "S14"
            Me.Close()
            Form6.ShowDialog()
        ElseIf lblid.Text = "T16" Then
            databasefaktatidak()
            lblid.Text = "S15"
            Me.Close()
            Form6.ShowDialog()
        ElseIf lblid.Text = "T17" Then
            databasefaktatidak()
            lblid.Text = "S15"
            Me.Close()
            Form6.ShowDialog()
        ElseIf lblid.Text = "T18" Then
            databasefaktatidak()
            lblid.Text = "S20"
            Me.Close()
            Form6.ShowDialog()
        ElseIf lblid.Text = "T19" Then
            databasefaktatidak()
            lblid.Text = "S19"
            Me.Close()
            Form6.ShowDialog()
        ElseIf lblid.Text = "T20" Then
            databasefaktatidak()
            lblid.Text = "S17"
            Me.Close()
            Form6.ShowDialog()
        End If
    End Sub

    
End Class