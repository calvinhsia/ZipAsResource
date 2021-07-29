using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZipAsResource
{
    public class Program
    {
        static void Main(string[] args)
        {
            var z =Program.GetResource();

        }
        public static byte[] GetResource()
        { 
            return Properties.Resources.t;
        }
    }
}
