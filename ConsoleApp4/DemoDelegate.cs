using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public delegate void PrintfMessager(string msg);
    internal class DemoDelegate
    {
        
        public void ShowInfo (string s) { 
            Console.WriteLine("Show msg : " + s); 
        
        }
    }
}
