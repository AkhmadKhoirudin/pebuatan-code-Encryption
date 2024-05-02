Public Class Form3
    Private isServerRunning As Boolean = False ' Untuk menyimpan status server (berjalan atau tidak)
    Private lastSuccessfulUID As String = ""
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Menambahkan event handler secara manual setelah membuat instance dari modul
        AddHandler ESPModule.MessageReceived, AddressOf ESPMessageReceivedHandler
    End Sub

    
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Memastikan TextBox1 tidak kosong
        If Not String.IsNullOrEmpty(TextBox1.Text) Then
            ' Melakukan enkripsi menggunakan RSA
            Dim encryptedText As String = EncryptionModule.Encrypt(TextBox1.Text)

            ' Menampilkan hasil enkripsi di TextBox2
            TextBox2.Text = encryptedText
        Else
            MessageBox.Show("Teks untuk dienkripsi tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Memastikan TextBox2 tidak kosong
        If Not String.IsNullOrEmpty(TextBox2.Text) Then
            ' Melakukan dekripsi menggunakan RSApai
            Dim decryptedText As String = EncryptionModule.Decrypt(TextBox2.Text)

            ' Menampilkan hasil dekripsi di TextBox3
            TextBox3.Text = decryptedText
        Else
            MessageBox.Show("Teks terenkripsi tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form4.Show()

    End Sub
End Class
