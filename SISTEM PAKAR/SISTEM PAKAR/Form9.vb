Imports System.Data.OleDb
Public Class Form9
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
    Dim cf As Double
    Private Sub Form9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TvDataSet2.temp' table. You can move, or remove it, as needed.
        Me.TempTableAdapter1.Fill(Me.TvDataSet2.temp)
        'TODO: This line of code loads data into the 'TvDataSet.temp' table. You can move, or remove it, as needed.
        Me.TempTableAdapter.Fill(Me.TvDataSet.temp)
        'TODO: This line of code loads data into the 'TvDataSet1.knowledge' table. You can move, or remove it, as needed.
        Me.KnowledgeTableAdapter.Fill(Me.TvDataSet1.knowledge)
        initialized() 'CERTAIN FACTOR DARI SOLUSI
        Label3.Text = Form6.lblkesimpulan.Text
        Label9.Text = Form6.lblidkes.Text
        Label6.Text = Form7.Label2.Text
        Label7.Text = Val(Label5.Text) * Val(Label6.Text)

        'Label6.text menampilkan cf min

        If Label9.Text = "S2" Then
            'SELECT TEMP DATABASE
        End If
        DataGridView1.Refresh()
        datagridview()

    End Sub
    Sub datagridview()
        koneksi()

        da = New OleDbDataAdapter("select * from temp", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "temp") 'error????
        DataGridView1.DataSource = (ds.Tables("temp"))
        'da.Update(ds)
        conn.Close()
        conn.Dispose()
    End Sub

    Sub initialized()
        If Form5.lblid.Text = "S1" Then
            Label5.Text = 0.8 'nilai cf hipotesis
        ElseIf Form5.lblid.Text = "S2" Then
            'Label5.Text = 0.6
        ElseIf Form5.lblid.Text = "S3" Then
            Label5.Text = 0.7
        ElseIf Form5.lblid.Text = "S4" Then
            Label5.Text = 0.6
        ElseIf Form5.lblid.Text = "S5" Then
            Label5.Text = 0.8
        ElseIf Form5.lblid.Text = "S6" Then
            Label5.Text = 0.8
        ElseIf Form5.lblid.Text = "S7" Then
            Label5.Text = 0.6
        ElseIf Form5.lblid.Text = "S8" Then
            Label5.Text = 0.8
        ElseIf Form5.lblid.Text = "S9" Then
            Label5.Text = 0.8
        ElseIf Form5.lblid.Text = "S10" Then
            Label5.Text = 0.6
        ElseIf Form5.lblid.Text = "S11" Then
            Label5.Text = 0.8
        ElseIf Form5.lblid.Text = "S12" Then
            Label5.Text = 0.7
        ElseIf Form5.lblid.Text = "S13" Then
            Label5.Text = 0.7
        ElseIf Form5.lblid.Text = "S14" Then
            Label5.Text = 0.7
        ElseIf Form5.lblid.Text = "S15" Then
            Label5.Text = 0.7
        ElseIf Form5.lblid.Text = "S16" Then
            Label5.Text = 0.7
        ElseIf Form5.lblid.Text = "S17" Then
            Label5.Text = 0.7
        ElseIf Form5.lblid.Text = "S18" Then
            Label5.Text = 0.7
        ElseIf Form5.lblid.Text = "S19" Then
            Label5.Text = 0.7
        ElseIf Form5.lblid.Text = "S20" Then
            Label5.Text = 0.7
        End If
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        datagridview()

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MsgBox("CF(H,E) (hipotesis) * dengan min cf(E,e) (Evidence) (pilihan user)", MsgBoxStyle.Information)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Form10.ShowDialog()
        Me.Close()
        conn.Dispose()
        conn.Close()
    End Sub
End Class