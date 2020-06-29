using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperasiCRUD
{
  class Sales : Karyawan
  {
    public double Jmljual {get; set;}
    public double Komisi {get; set;}
    public override double Gaji()
    {
      return Jmljual*Komisi;
    }
  }
}
