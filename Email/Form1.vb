Imports System.Net.Mail
Public Class Form1
    Sub Kirim()
        If Tbemail.Text = "" Or TbPesan.Text = "" Then
            MsgBox("Somethin wrong")
        Else
            Dim Mail As New MailMessage
            Dim SMTP As New SmtpClient("smtp.gmail.com")
            Mail.Subject = "Test Kirim Email"
            Mail.From = New MailAddress("email@email.com")
            SMTP.Credentials = New System.Net.NetworkCredential("pc15smeaku@gmail.com", "pnadfubyyirqbhdq") '<-- Password Here
            Mail.To.Add(Tbemail.Text) 'Alamat Email Tujuan
            If Not TbSubject.Text = "" Then

                Mail.Bcc.Add(TbSubject.Text) 'BCC
            End If

            'Mail.IsBodyHtml = True -> digunakan untuk mengirim pesan dalam format HTML
            Mail.Body = TbPesan.Text  'isi pesan

            SMTP.EnableSsl = True
            SMTP.Port = "587"
            SMTP.Send(Mail)

            MsgBox("Email Berhasil Dikirim")
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btnklik_Click(sender As Object, e As EventArgs) Handles Btnklik.Click
        'Try
        Kirim()
        'Catch ex As Exception
        'MsgBox(ex.ToString)
        'End Try
    End Sub
End Class
