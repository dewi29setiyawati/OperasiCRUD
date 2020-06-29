using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperasiCRUD
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Tugas Lab 9 - Polymorphsim, Inheritance, Abstraction & Collection Part 2";
      int pilihan;
      List<Karyawan> listKaryawan = new List<Karyawan>();

      do
      {
        Console.Clear();
        Console.WriteLine("Pilih Menu Aplikasi");
        Console.WriteLine("\n1. Tambah Data Karyawan \n2. Hapus Data Karyawan \n3. Tampilkan Data Karyawan \n4. Keluar");
        Console.Write("\nNomor Pilihan Menu [1...4] : ");
        pilihan = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        if (pilihan==1)
        {
          Console.WriteLine();
          Console.WriteLine("Tambah Data Karyawan\n");
          Console.WriteLine("Jenis Karyawan : \n1. Karyawan Tetap \n2. Karyawan Harian \n3. Sales");
          Console.Write("\nPilihan [1...3] : ");
          int pilih = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine();

          if (pilih==1)
          {
            KaryawanTetap karyawanTetap = new KaryawanTetap();
            Console.Write("NIK  : ");
            karyawanTetap.NIK = Console.ReadLine();
            Console.Write("Nama : ");
            karyawanTetap.Nama = Console.ReadLine();
            Console.Write("Gaji Bulanan : ");
            karyawanTetap.GajiBulanan = Convert.ToDouble(Console.ReadLine());
            listKaryawan.Add(karyawanTetap);
          }
          else if (pilih==2)
          {
            KaryawanHarian karyawanHarian = new KaryawanHarian();
            Console.Write("NIK  : ");
            karyawanHarian.NIK = Console.ReadLine();
            Console.Write("Nama : ");
            karyawanHarian.Nama = Console.ReadLine();
            Console.Write("Jumlah Jam Kerja : ");
            karyawanHarian.JmlJamKerja = Convert.ToDouble(Console.ReadLine());
            Console.Write("Upah Per Jam : ");
            karyawanHarian.UpahPerJam = Convert.ToDouble(Console.ReadLine());
            listKaryawan.Add(karyawanHarian);
          }
          else if (pilih==3)
          {
            Sales sales = new Sales();
            Console.Write("NIK  : ");
            sales.NIK = Console.ReadLine();
            Console.Write("Nama : ");
            sales.Nama = Console.ReadLine();
            Console.Write("Jumlah Jam Kerja : ");
            sales.Jmljual = Convert.ToDouble(Console.ReadLine());
            Console.Write("Upah Per Jam : ");
            sales.Komisi = Convert.ToDouble(Console.ReadLine());
            listKaryawan.Add(sales);
          }
          else
          {
            Console.WriteLine("Pilihan yang Anda Masukkan Salah :( ");
          }
        }

        else if (pilihan==2)
        {
          int nomor = -1, hapus = -1;
          Console.WriteLine();
          Console.WriteLine("Hapus Data Karyawan\n");
          Console.Write("NIK : ");
          string nik = Console.ReadLine();
          foreach (Karyawan karyawan in listKaryawan)
          {
            nomor++;
            if(karyawan.NIK == nik)
            {
              hapus = nomor;
            }
          }
          if (hapus!=-1)
          {
            listKaryawan.RemoveAt(hapus);
            Console.Write("\nData Karyawan dengan NIK : ");
            Console.Write(nik);
            Console.Write(" Berhasil Dihapus :) ");
          }
          else
          {
            Console.WriteLine("\nTerjadi Kesalahan :( ");
          }
        }

        else if(pilihan==3)
        {
          int urutan = 0;
          string jeniskaryawan = " ";
          Console.WriteLine();
          Console.WriteLine("Data Karyawan\n");

          foreach (Karyawan karyawan in listKaryawan)
          {
            if(karyawan is KaryawanTetap)
            {
              jeniskaryawan = "Karyawan Tetap";
            }
            else if(karyawan is KaryawanHarian)
            {
              jeniskaryawan = "Karyawan Harian";
            }
            else
            {
              jeniskaryawan = "Sales";
            }
            urutan++;
            Console.WriteLine("{0}. NIK   : {1} \n   Nama  : {2} \n   Gaji  : {3:N0} \n   {4}", urutan, karyawan.NIK, karyawan.Nama, karyawan.Gaji(), jeniskaryawan);
          }
          if (urutan<1)
          {
            Console.WriteLine("\nData Karyawan Kosong :( \n");
          }
        }

        else if(pilihan==4){}

        else
        {
          Console.WriteLine("\nPilihan yang Anda Masukkan Salah :( ");
        }

        Console.WriteLine("\nTekan Enter untuk kembali ke Menu\n");
        Console.ReadKey();
      }
      while (pilihan!=4);
    }
  }
}
