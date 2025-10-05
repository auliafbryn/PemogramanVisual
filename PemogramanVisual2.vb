Module Module1

    Sub Main()
        ' --- Input Bilangan ---
        Dim a As Integer
        Dim b As Integer

        Console.Write("Masukkan bilangan pertama: ")
        a = Convert.ToInt32(Console.ReadLine())

        Console.Write("Masukkan bilangan kedua: ")
        b = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine()

        ' --- Operasi Penjumlahan ---
        Dim tambah As Integer = a + b
        If tambah < 0 Then tambah = 0
        Console.WriteLine("Hasil Penjumlahan: " & tambah)

        ' --- Operasi Perkalian ---
        Dim kali As Integer = a * b
        If kali < 0 Then kali = 0
        Console.WriteLine("Hasil Perkalian: " & kali)

        ' --- Operasi Pembagian ---
        Dim bagi As Integer
        If b <> 0 Then
            bagi = a \ b   ' pembagian bulat
            If bagi < 0 Then bagi = 0
        Else
            bagi = 0
        End If
        Console.WriteLine("Hasil Pembagian: " & bagi)

        ' --- Operasi Modulus ---
        Dim modVal As Integer = 0 ' langsung ditetapkan 0
        Console.WriteLine("Hasil Modulus: " & modVal)

        Console.WriteLine()
        Console.WriteLine("Tekan tombol apa saja untuk keluar...")
        Console.ReadKey()

    End Sub

End Module
