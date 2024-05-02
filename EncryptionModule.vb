Imports System.Security.Cryptography
Imports System.Text

Module EncryptionModule
    Private rsa As RSACryptoServiceProvider

    ' Fungsi untuk melakukan enkripsi menggunakan algoritma RSA
    Public Function Encrypt(data As String) As String
        ' Inisialisasi RSA dengan panjang kunci 2048 bit
        rsa = New RSACryptoServiceProvider(2048)

        ' Konversi string ke byte array
        Dim bytesToEncrypt As Byte() = Encoding.UTF8.GetBytes(data)

        ' Enkripsi data menggunakan kunci publik RSA
        Dim encryptedBytes As Byte() = rsa.Encrypt(bytesToEncrypt, False)

        ' Konversi byte array hasil enkripsi ke dalam bentuk Base64 string
        Dim encryptedString As String = Convert.ToBase64String(encryptedBytes)

        Return encryptedString
    End Function

    ' Fungsi untuk melakukan dekripsi menggunakan algoritma RSA
    Public Function Decrypt(encryptedData As String) As String
        ' Konversi Base64 string kembali ke byte array
        Dim encryptedBytes As Byte() = Convert.FromBase64String(encryptedData)

        ' Dekripsi data menggunakan kunci privat RSA
        Dim decryptedBytes As Byte() = rsa.Decrypt(encryptedBytes, False)

        ' Konversi byte array hasil dekripsi ke dalam bentuk string
        Dim decryptedString As String = Encoding.UTF8.GetString(decryptedBytes)

        Return decryptedString
    End Function
End Module
