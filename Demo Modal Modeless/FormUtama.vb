Public Class FormUtama

    Private Sub tombolModal_Click(sender As Object, e As EventArgs) Handles tombolModal.Click
        Dim intHitung As Integer 'Kounter
        Dim frmPesan As New FormPesan 'Instansi dari FormPesan

        'Menampilkan form pesan dengan gaya modal
        frmPesan.ShowDialog()

        'Menampilkan sejumlah angka pada kotak list pada FormUtama
        'Ini akan terjadi SETELAH user menutup FormPesan
        For intHitung = 1 To 10
            listKeluaran.Items.Add(intHitung.ToString())
        Next
    End Sub

    Private Sub tombolModeless_Click(sender As Object, e As EventArgs) Handles tombolModeless.Click
        Dim intHitung As Integer 'Kounter
        Dim frmPesan As New FormPesan 'Instansi dari FormPesan

        'Menampilkan form pesan dengan gaya modeless
        frmPesan.Show()

        'Menampilkan sejumlah angka pada kotak list pada FormUtama
        'Ini akan terjadi ketika FormPesan masih ditampilkan di layar
        For intHitung = 1 To 10
            listKeluaran.Items.Add(intHitung.ToString())
        Next
    End Sub

    Private Sub tombolBersih_Click(sender As Object, e As EventArgs) Handles tombolBersih.Click
        listKeluaran.Items.Clear()
    End Sub

    Private Sub tombolKeluar_Click(sender As Object, e As EventArgs) Handles tombolKeluar.Click
        Me.Close()
    End Sub

    Private Sub FormUtama_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

    End Sub
End Class