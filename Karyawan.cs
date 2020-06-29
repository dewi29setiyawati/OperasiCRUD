using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperasiCRUD
{
  public abstract class Karyawan
  {
    public string NIK {get; set;}
    public string Nama {get; set;}
    public string pilih {get; set;}
    public abstract double Gaji();
  }
}
