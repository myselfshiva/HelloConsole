using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloConsole
{
    public class ClsAdd
    {
       public string AddName(string Fname, string Lname)
        {
            string Cname = null;
            Cname = Fname + " " + Lname;

            return Cname;
        }
    }
}
