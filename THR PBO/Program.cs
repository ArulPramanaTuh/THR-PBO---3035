using System;

// Kelas induk Karyawan
class Karyawan
{
    // Atribut dengan enkapsulasi manual
    private string nama;
    private string id;
    private double gajiPokok;

    // Getter dan setter manual
    public string GetNama() { return nama; }
    public void SetNama(string value) { nama = value; }

    public string GetID() { return id; }
    public void SetID(string value) { id = value; }

    public double GetGajiPokok() { return gajiPokok; }
    public void SetGajiPokok(double value) { gajiPokok = value; }

    // Metode untuk menghitung gaji
    public virtual double HitungGaji()
    {
        return gajiPokok;
    }
}

// Subclass Karyawan Tetap
class KaryawanTetap : Karyawan
{
    public override double HitungGaji()
    {
        return base.GetGajiPokok() + 500000;
    }
}

// Subclass Karyawan Kontrak
class KaryawanKontrak : Karyawan
{
    public override double HitungGaji()
    {
        return base.GetGajiPokok() - 200000;
    }
}

// Subclass Karyawan Magang
class KaryawanMagang : Karyawan
{
    public override double HitungGaji()
    {
        return base.GetGajiPokok();
    }
}

// Program utama
class Program
{
    static void Main()
    {
        // Input jenis karyawan
        Console.WriteLine("Pilih jenis karyawan:");
        Console.WriteLine("1. Karyawan Tetap");
        Console.WriteLine("2. Karyawan Kontrak");
        Console.WriteLine("3. Karyawan Magang");
        int pilihan = int.Parse(Console.ReadLine());

        // Input data
        Console.Write("Masukkan Nama: ");
        string nama = Console.ReadLine();
        Console.Write("Masukkan ID: ");
        string id = Console.ReadLine();
        Console.Write("Masukkan Gaji Pokok: ");
        double gajiPokok = double.Parse(Console.ReadLine());

        // Buat objek sesuai pilihan
        Karyawan karyawan = null;
        if (pilihan == 1)
        {
            karyawan = new KaryawanTetap();
        }
        else if (pilihan == 2)
        {
            karyawan = new KaryawanKontrak();
        }
        else if (pilihan == 3)
        {
            karyawan = new KaryawanMagang();
        }
        else
        {
            Console.WriteLine("Pilihan tidak valid!");
            return;
        }

        // Set data ke objek
        karyawan.SetNama(nama);
        karyawan.SetID(id);
        karyawan.SetGajiPokok(gajiPokok);

        // Tampilkan hasil
        Console.WriteLine("\n=== Hasil Perhitungan ===");
        Console.WriteLine("Nama: " + karyawan.GetNama());
        Console.WriteLine("ID: " + karyawan.GetID());
        Console.WriteLine("Gaji Akhir: " + karyawan.HitungGaji().ToString("N0"));
    }
}