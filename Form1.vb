Public Class Form1

    Friend Hasil As Single = 0
    Dim operasi As String = ""
    Dim operasiHitung As Boolean = False


    Private Sub SimpleCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        operasiHitung = False
        operasi = ""
        Hasil = 0
        TxtHasil.Text = "0"

    End Sub

    Private Sub BtnSatu_Click(sender As Object, e As EventArgs) Handles BtnSatu.Click

        If operasiHitung = True Or TxtHasil.Text = "0" Then
            TxtHasil.Text = "1"
            operasiHitung = False
        Else
            TxtHasil.Text = TxtHasil.Text + "1"
        End If

    End Sub

    Private Sub BtnDua_Click(sender As Object, e As EventArgs) Handles BtnDua.Click

        If operasiHitung = True Or TxtHasil.Text = "0" Then
            TxtHasil.Text = "2"
            operasiHitung = False
        Else
            TxtHasil.Text = TxtHasil.Text + "2"
        End If

    End Sub

    Private Sub BtnTiga_Click(sender As Object, e As EventArgs) Handles BtnTiga.Click

        If operasiHitung = True Or TxtHasil.Text = "0" Then
            TxtHasil.Text = "3"
            operasiHitung = False
        Else
            TxtHasil.Text = TxtHasil.Text + "3"
        End If


    End Sub

    Private Sub BtnEmpat_Click(sender As Object, e As EventArgs) Handles BtnEmpat.Click

        If operasiHitung = True Or TxtHasil.Text = "0" Then
            TxtHasil.Text = "4"
            operasiHitung = False
        Else
            TxtHasil.Text = TxtHasil.Text + "4"
        End If


    End Sub

    Private Sub BtnLima_Click(sender As Object, e As EventArgs) Handles BtnLima.Click

        If operasiHitung = True Or TxtHasil.Text = "0" Then
            TxtHasil.Text = "5"
            operasiHitung = False
        Else
            TxtHasil.Text = TxtHasil.Text + "5"
        End If


    End Sub

    Private Sub BtnEnam_Click(sender As Object, e As EventArgs) Handles BtnEnam.Click

        If operasiHitung = True Or TxtHasil.Text = "0" Then
            TxtHasil.Text = "6"
            operasiHitung = False
        Else
            TxtHasil.Text = TxtHasil.Text + "6"
        End If


    End Sub

    Private Sub BtnTujuh_Click(sender As Object, e As EventArgs) Handles BtnTujuh.Click

        If operasiHitung = True Or TxtHasil.Text = "0" Then
            TxtHasil.Text = "7"
            operasiHitung = False
        Else
            TxtHasil.Text = TxtHasil.Text + "7"
        End If


    End Sub

    Private Sub BtnDelapan_Click(sender As Object, e As EventArgs) Handles BtnDelapan.Click

        If operasiHitung = True Or TxtHasil.Text = "0" Then
            TxtHasil.Text = "8"
            operasiHitung = False
        Else
            TxtHasil.Text = TxtHasil.Text + "8"
        End If


    End Sub

    Private Sub BtnSembilan_Click(sender As Object, e As EventArgs) Handles BtnSembilan.Click

        If operasiHitung = True Or TxtHasil.Text = "0" Then
            TxtHasil.Text = "9"
            operasiHitung = False
        Else
            TxtHasil.Text = TxtHasil.Text + "9"
        End If


    End Sub

    Private Sub BtnKosong_Click(sender As Object, e As EventArgs) Handles BtnKosong.Click

        If operasiHitung = True Or TxtHasil.Text = "0" Then
            TxtHasil.Text = "0"
            operasiHitung = False
        Else
            TxtHasil.Text = TxtHasil.Text + "0"
        End If


    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click

        operasi = "tambah"
        Hasil = Val(TxtHasil.Text)
        operasiHitung = True

    End Sub

    Private Sub BtnKurang_Click(sender As Object, e As EventArgs) Handles BtnKurang.Click

        operasi = "kurang"
        Hasil = Val(TxtHasil.Text)
        operasiHitung = True

    End Sub

    Private Sub BtnKali_Click(sender As Object, e As EventArgs) Handles BtnKali.Click

        operasi = "kali"
        Hasil = Val(TxtHasil.Text)
        operasiHitung = True

    End Sub

    Private Sub BtnBagi_Click(sender As Object, e As EventArgs) Handles BtnBagi.Click

        operasi = "bagi"
        Hasil = Val(TxtHasil.Text)
        operasiHitung = True

    End Sub

    Private Sub BtnEquals_Click(sender As Object, e As EventArgs) Handles BtnEquals.Click

        Select Case operasi
            Case "tambah"
                Hasil += Val(TxtHasil.Text)
            Case "kurang"
                Hasil -= Val(TxtHasil.Text)
            Case "kali"
                Hasil *= Val(TxtHasil.Text)
            Case "bagi"
                Hasil /= Val(TxtHasil.Text)
        End Select

        TxtHasil.Text = Hasil
        operasiHitung = True

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click

        TxtHasil.Text = "0"
        operasi = ""

    End Sub

    Private Sub BtnClearEntry_Click(sender As Object, e As EventArgs) Handles BtnClearEntry.Click

        If TxtHasil.Text.Length <> 0 Then
            TxtHasil.Text = TxtHasil.Text.Remove(TxtHasil.Text.Length - 1)
        End If

    End Sub
End Class
