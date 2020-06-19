using System;
using System.Collections.Generic;
using System.Text;
using PolymorphCollection.ClassInduk;

namespace PolymorphCollection_ClassAnak
{
    class Sales : Karyawan
    {
        public double JumlahPenjualan { get; set; }
        public double Komisi { get; set; }
        public override double Gaji() => JumlahPenjualan * Komisi;
    }
}