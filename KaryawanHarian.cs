using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperasiCRUD
{
  class KaryawanHarian : Karyawan
  {
    public double JmlJamKerja {get; set;}
    public double UpahPerJam {get; set;}
    public override double Gaji()
    {
      return UpahPerJam*JmlJamKerja;
    }
  }
}
