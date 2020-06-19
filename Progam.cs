using System;
using System.Collections.Generic;
using PolymorphCollection.ClassAnak;
using PolymorphCollection.ClassInduk;

namespace PolymorphCollection_2668
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tugas Lab 8 - Polymorphism, Abstraction, Collection\n");
            //object declaration
            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.Nik = "19.11.2668";
            karyawanTetap.Nama = "Hoiru";
            karyawanTetap.GajiBulanan = 3000000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.Nik = "19.12.1214";
            karyawanHarian.Nama = "Bambang";
            karyawanHarian.JumlahJamKerja = 8;
            karyawanHarian.UpahPerJam = 650000;

            Sales sales = new Sales();
            sales.Nik = "19.13.1432";
            sales.Nama = "Rury";
            sales.JumlahPenjualan = 200;
            sales.Komisi = 1400;
            //

            //Object class collective
            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);
            //

            //looping output
            int i = 1;
            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine(" {0}.\tNIK: {1}\n\tNama: {2} \n\tGaji: {3:N0}\n",
                    i, karyawan.Nik, karyawan.Nama, karyawan.Gaji());
                i++;
            }
            
            Console.ReadKey();

        }
    }
}