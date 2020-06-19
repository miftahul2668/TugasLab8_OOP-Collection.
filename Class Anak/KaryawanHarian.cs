using System;
using System.Collections.Generic;
using System.Text;
using PolymorphCollection.ClassInduk;

namespace PolymorphCollection_ClassAnak
{
    class KaryawanHarian : Karyawan
    {
        public double UpahPerJam { get; set; }
        public double JumlahJamKerja { get; set; }
        public override double Gaji() => UpahPerJam * JumlahJamKerja;
    }
}