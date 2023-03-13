/// <summary>
/// Kelas untuk mengelola array dan looping
/// </summary>
namespace Menggunakan_Array_Dan_Looping
{
    /// <summary>
    /// Kelas untuk mengelola array
    /// </summary>
    public class Array1
    {
        public void Arraysatu()
        {
            /// <summary>
            /// Metode untuk memproses data nilai mahasiswa
            /// </summary>
            // Meminta input nim, nama, dan kelas mahasiswa
            Console.Write("Masukkan NIM: ");
            string str1 = Console.ReadLine();
            Console.Write("Masukkan Nama: ");
            string str2 = Console.ReadLine();
            Console.Write("Masukkan Kelas: ");
            string str3 = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("--------------------------");

            // Mendeklarasikan sebuah array 2 dimensi dengan ukuran 6 baris dan 3 kolom
            string[,] strArray = new string[6, 3];

            // Melakukan iterasi sebanyak 6 kali untuk setiap baris pada array
            for (int index1 = 0; index1 < 6; ++index1)
            {
                // Melakukan iterasi sebanyak 3 kali untuk setiap kolom pada array
                for (int index2 = 0; index2 < 3; ++index2)
                {
                    // Jika kolom pertama, maka meminta pengguna memasukkan nama matakuliah dan memasukkannya ke dalam array
                    if (index2 == 0)
                    {
                        Console.Write("Masukkan Nama Matakuliah: ");
                        strArray[index1, index2] = Console.ReadLine();
                    }
                    // Jika kolom kedua, maka meminta pengguna memasukkan nilai angka dan memasukkannya ke dalam array
                    else if (index2 == 1)
                    {
                        Console.Write("Masukkan Nilai Angka: ");
                        strArray[index1, index2] = Console.ReadLine();
                    }
                    // Jika kolom ketiga, maka meminta pengguna memasukkan nilai huruf dan memasukkannya ke dalam array, kemudian menambahkan baris baru
                    else
                    {
                        Console.Write("Masukkan Nilai Huruf: ");
                        strArray[index1, index2] = Console.ReadLine();
                        Console.WriteLine();
                    }
                }
            }
            // Menampilkan hasil transkrip kuliah
            Console.WriteLine("\n\n");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Transkrip Kuliah");
            Console.WriteLine("--------------------------");
            Console.WriteLine("\nNIM: " + str1);
            Console.WriteLine("Nama: " + str2);
            Console.WriteLine("Kelas: " + str3);
            Console.WriteLine("--------------------------");
            Console.WriteLine();
            Console.Write("\nTranskrip Mahasiswa dengan nim: " + str1 + " \n");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Mata Kuliah \t Nilai Angka \t Nilai Huruf");
            for (int index3 = 0; index3 < 6; ++index3)
            {
                Console.Write("\n");
                for (int index4 = 0; index4 < 3; ++index4)
                    Console.Write("{0}\t", (object)strArray[index3, index4]);
            }
            // Menunggu input dari pengguna sebelum menutup program
            Console.Write("\n\n");
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Kelas untuk mengelola array multidimensi
    /// </summary>
    public class Array2
    {
        /// <summary>
        /// Metode untuk memproses data kartu keluarga
        /// </summary>
        public void Arraydua()
        {
            Console.Write("Masukkan Jumlah Anggota Keluarga");

            // Membuat array dua dimensi dengan jumlah baris yang ditentukan oleh pengguna
            // dan kolom sebanyak tiga, yaitu Nama Lengkap, Pendidikan Terakhir, dan Status
            string[][] strArray = new string[Convert.ToInt32(Console.ReadLine())][];
            int length = 3;

            // Looping untuk mengisi setiap baris dan kolom di array strArray
            for (int index1 = 0; index1 < strArray.Length; ++index1)
            {
                // Menginisialisasi array di indeks baris saat ini dengan panjang tiga
                strArray[index1] = new string[length];

                // Looping untuk mengisi setiap kolom di baris saat ini
                for (int index2 = 0; index2 < strArray[index1].Length; ++index2)
                {
                    // Switch statement untuk meminta input data sesuai dengan kolom yang sedang diisi
                    switch (index2)
                    {
                        case 0:
                            Console.Write("Masukkan Nama Lengkap: ");
                            strArray[index1][index2] = Console.ReadLine();
                            break;
                        case 1:
                            Console.Write("Masukkan Pendidikan Terakhir: ");
                            strArray[index1][index2] = Console.ReadLine();
                            break;
                        default:
                            Console.Write("Masukkan Status: ");
                            strArray[index1][index2] = Console.ReadLine();
                            Console.WriteLine();
                            break;
                    }
                }
            }
            // Output untuk data Kartu Keluarga
            Console.WriteLine("Data Kartu Keluarga");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Nama Lengkap \t Pendidikan Terakhir \t Status \t");

            // Loop melalui array strArray
            for (int index3 = 0; index3 < strArray.Length; ++index3)
            {
                // Loop melalui array dalam strArray
                for (int index4 = 0; index4 < strArray[index3].Length; ++index4)

                    // Output nilai dari array strArray dengan memberikan jarak 1 tab antar kolom
                    Console.Write(strArray[index3][index4] + "           ");
                Console.WriteLine();
            }
            Console.ReadKey();
        }

    }

    /// <summary>
    /// Kelas utama program
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Metode utama program
        /// </summary>
        /// <param name="args">Argumen baris perintah</param>
        private static void Main(string[] args)
        {
            // Membuat instance dari kelas Array1 dan Array2
            Array1 array1 = new Array1();
            Array2 array2 = new Array2();
            string str;

            // Melakukan perulangan untuk menampilkan menu utama dan memilih opsi
            do
            {
                Console.WriteLine("=================Menu Utama=================");
                Console.WriteLine("============================================");
                Console.WriteLine("1. IPK\n2. Kartu Keluarga");
                Console.WriteLine("============================================");
                Console.WriteLine();
                Console.Write("Silahkan Pilih menu = ");

                // Membaca opsi yang dipilih oleh pengguna
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("=================IPK=================");
                        Console.WriteLine("=====================================");

                        // Memanggil method Arraysatu() dari instance array1
                        array1.Arraysatu();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("=================Kartu Keluarga=============");
                        Console.WriteLine("============================================");

                        // Memanggil method Arraydua() dari instance array2
                        array2.Arraydua();
                        break;
                }
                // Menanyakan kepada pengguna apakah ingin kembali ke menu utama atau tidak
                Console.Write("Apakah akan kembali ke menu utama (Y/N)");
                str = Convert.ToString(Console.ReadLine().ToUpper());
                Console.Clear();
            }
            while (str == "Y");
        }
    }
}
