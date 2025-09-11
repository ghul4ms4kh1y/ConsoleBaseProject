using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBaseProject
{
    internal class dataumur
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukan Nama Anda: ");
            string nama = Console.ReadLine();

            Console.WriteLine("Masukan Umur Anda: ");
            int umur = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Halo " + nama + ", umur Anda " + umur + " tahun");
            Console.ReadLine();
        }
    }
}
