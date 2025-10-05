Module Module1

    Sub Main()
        ' --- Input Data dari User ---
        Dim nama As String
        Dim prodi As String
        Dim kampus As String
        Dim hobi As String

        Console.Write("Masukkan Nama: ")
        nama = Console.ReadLine()

        Console.Write("Masukkan Program Studi: ")
        prodi = Console.ReadLine()

        Console.Write("Masukkan Nama Kampus: ")
        kampus = Console.ReadLine()

        Console.Write("Masukkan Hobi: ")
        hobi = Console.ReadLine()

        ' --- Output Hasil ---
        Console.WriteLine()
        Console.WriteLine("Halo, nama saya adalah " & nama)
        Console.WriteLine("Saya kuliah pada jurusan " & prodi & " di " & kampus)
        Console.WriteLine("Saya memiliki hobi " & hobi)

        Console.WriteLine()
        Console.WriteLine("Tekan tombol apa saja untuk keluar...")
        Console.ReadKey()


    End Sub

End Module
