using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Responsi_Hilman_2656
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek produk
        static List<Produk> daftarProduk = new List<Produk>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";
            while (true)
            {
                TampilMenu();
                int nomorMenu = Convert.ToInt32(Console.ReadLine());
                switch (nomorMenu)
                {
                    case 1:
                        TambahProduk();
                        break;

                    case 2:
                        HapusProduk();
                        break;

                    case 3:
                        TampilProduk();
                        break;
                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine("\n=========================================");
            Console.WriteLine("1. Tambah Produk");
            Console.WriteLine("2. Hapus Produk");
            Console.WriteLine("3. Tampilkan Produk");
            Console.WriteLine("4. Keluar");
            Console.WriteLine("=========================================");
            Console.Write("\nNomor Menu [1..4]: ");
        }

        static void TambahProduk()
        {
            Console.Clear();

            Produk produk = new Produk();
            Console.WriteLine("Tambah Data Produk");
            Console.Write("\nKode Produk : ");
            produk.kode = Console.ReadLine();
            Console.Write("Nama Produk : ");
            produk.nama = Console.ReadLine();
            Console.Write("Harga Beli : ");
            produk.beli = Convert.ToDouble(Console.ReadLine());
            Console.Write("Harga Jual : ");
            produk.jual = Convert.ToDouble(Console.ReadLine());
            daftarProduk.Add(produk);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusProduk()
        {
            Console.Clear();

            int no = -1, hapus = -1;
            Console.WriteLine("Hapus Data Produk");
            Console.Write("\nKode Produk : ");
            string kode = Console.ReadLine();
            foreach (Produk produk in daftarProduk)
            {
                no++;
                if (produk.kode == kode)
                {
                    hapus = no;
                }
            }
            if (hapus != -1)
            {
                daftarProduk.RemoveAt(hapus);
                Console.WriteLine("\nData produk berhasil dihapus");
            }
            else
            {
                Console.WriteLine("\nKode produk tidak ditemukan");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilProduk()
        {
            Console.Clear();

            int noUrut = 0;
            Console.WriteLine("Data Produk\n");
            foreach (Produk produk in daftarProduk)
            {
                noUrut++;
                Console.WriteLine("{0}. {1}, {2}, {3}, {4}", noUrut, produk.kode, produk.nama, produk.beli, produk.jual);
            }
            if (noUrut < 1)
            {
                Console.WriteLine("Data Produk Kosong");
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
