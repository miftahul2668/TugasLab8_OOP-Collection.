using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphCollection_ClassInduk
{
    abstract public class Karyawan
    {
        public string Nik { get; set; }
        public string Nama { get; set; }
        public abstract double Gaji();
    }
}