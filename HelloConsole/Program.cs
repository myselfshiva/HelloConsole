using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsAdd Ica = new ClsAdd();
            string CName = Ica.AddName("Shiva", "Pratap");
            System.Console.WriteLine(CName);
            //System.Console.WriteLine("Hello Pratap !!");
            System.Console.ReadLine();
             
        }

        
    }
    
}
