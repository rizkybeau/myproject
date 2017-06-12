Imports System.Data.OleDb
Public Class Form6
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
    Protected Overrides Sub WndProc(ByRef m As Message)
        If (m.Msg = &H112) AndAlso (m.WParam.ToInt32() = &HF010) Then
            Return
        End If
        If (m.Msg = &HA1) AndAlso (m.WParam.ToInt32() = &H2) Then
            Return
        End If
        MyBase.WndProc(m)
    End Sub
    'Dim temp As Integer


    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Form5.lblid.Text = "S1" Then

            'lblcf.Text = Form7.Label2.Text
            lblidkes.Text = "S1" 'id s1
            kes1(Form5.lblid.Text)
        ElseIf Form5.lblid.Text = "S2" Then
            'lblcf.Text = Form7.Label2.Text * 0.6 'certain factor s2
            lblidkes.Text = "S2"
            kes1(Form5.lblid.Text)
        ElseIf Form5.lblid.Text = "S3" Then
            'lblcf.Text = Form7.Label2.Text * 0.7 'certain factor s3
            lblidkes.Text = "S3"
            kes1(lblidkes.Text)
        ElseIf Form5.lblid.Text = "S4" Then
            'lblcf.Text = Form7.Label2.Text * 0.6 'certain factor s4
            lblidkes.Text = "S4"
            kes1(lblidkes.Text)
        ElseIf Form5.lblid.Text = "S5" Then
            'lblcf.Text = Form7.Label2.Text * 0.8 'certain factor s1
            lblidkes.Text = "S5"
            kes1(lblidkes.Text)
        ElseIf Form5.lblid.Text = "S6" Then
            'lblcf.Text = Form7.Label2.Text * 0.8 'certain factor s1
            lblidkes.Text = "S6"
            kes1(lblidkes.Text)
        ElseIf Form5.lblid.Text = "S7" Then
            'lblcf.Text = Form7.Label2.Text * 0.6 'certain factor s1
            lblidkes.Text = "S7"
            kes1(lblidkes.Text)
        ElseIf Form5.lblid.Text = "S8" Then
            'lblcf.Text = Form7.Label2.Text * 0.8 'certain factor s1
            lblidkes.Text = "S8"
            kes1(lblidkes.Text)
        ElseIf Form5.lblid.Text = "S9" Then
            'lblcf.Text = Form7.Label2.Text * 0.8 'certain factor s1
            lblidkes.Text = "S9"
            kes1(lblidkes.Text)
        ElseIf Form5.lblid.Text = "S10" Then
            lblidkes.Text = "S10"
            kes1(lblidkes.Text)
            'lblcf.Text = Form7.Label2.Text * 0.6 'certain factor s1
        ElseIf Form5.lblid.Text = "S11" Then
            'lblcf.Text = Form7.Label2.Text * 0.8 'certain factor s1
            lblidkes.Text = "S11"
            kes1(lblidkes.Text)
        ElseIf Form5.lblid.Text = "S12" Then
            'lblcf.Text = Form7.Label2.Text * 0.7 'certain factor s1
            lblidkes.Text = "S12"
            kes1(lblidkes.Text)
        ElseIf Form5.lblid.Text = "S13" Then
            lblidkes.Text = "S13"
            kes1(lblidkes.Text)
            'lblcf.Text = Form7.Label2.Text * 0.5 'certain factor s1
        ElseIf Form5.lblid.Text = "S14" Then
            lblidkes.Text = "S14"
            kes1(lblidkes.Text)
            'lblcf.Text = Form7.Label2.Text * 0.6 'certain factor s1
        ElseIf Form5.lblid.Text = "S15" Then
            lblidkes.Text = "S15"
            kes1(lblidkes.Text)
            'lblcf.Text = Form7.Label2.Text * 0.8 'certain factor s1
        ElseIf Form5.lblid.Text = "S16" Then
            lblidkes.Text = "S16"
            kes1(lblidkes.Text)
            'lblcf.Text = Form7.Label2.Text * 0.8 'certain factor s1
        ElseIf Form5.lblid.Text = "S17" Then
            lblidkes.Text = "S17"
            kes1(lblidkes.Text)
            'lblcf.Text = Form7.Label2.Text * 0.6 'certain factor s1
        ElseIf Form5.lblid.Text = "S18" Then
            lblidkes.Text = "S18"
            kes1(lblidkes.Text)
            'lblcf.Text = Form7.Label2.Text * 0.5 'certain factor s1
        ElseIf Form5.lblid.Text = "S19" Then
            lblidkes.Text = "S19"
            kes1(lblidkes.Text)
            'lblcf.Text = Form7.Label2.Text * 0.6 'certain factor s1
        ElseIf Form5.lblid.Text = "S20" Then
            lblidkes.Text = "S20"
            kes1(lblidkes.Text)
            'lblcf.Text = Form7.Label2.Text * 0.7 'certain factor s1
        ElseIf Form5.lblid.Text = "S21" Then
            lblidkes.Text = "S21"
            kes1(lblidkes.Text)
            'lblcf.Text = Form7.Label2.Text * 0.7 'certain factor s1
        End If
    End Sub
    Sub kes1(ByVal X1 As String)
        koneksi()
        'da = New OleDbDataAdapter("select kerusakan from knowledge", conn)
        ds = New DataSet
        ds.Clear()
        'da.Fill(ds, "knowledge") 'error????
        'DataGridView1.DataSource = (ds.Tables("knowledge"))
        cmd = New OleDbCommand("select solusi from solusi where id_solusi='" & X1 & "'", conn) 'untuk ditampilkan intinya kalau dia klik ya idnya yang jadi acuan
        rd = cmd.ExecuteReader

        Do While rd.Read
            'label1.Text = rd.GetValue(0)
            'Label5.Text = rd.Item(0)
            ComboBox1.Items.Add(rd.Item(0))
            lblkesimpulan.Text = rd.GetValue(0)
        Loop
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form7.Label2.Text = 0
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form9.ShowDialog()
    End Sub
End Class