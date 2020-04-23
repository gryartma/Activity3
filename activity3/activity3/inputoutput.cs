using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity3
{
    class inputoutput
    {
        public double mat, ipa;
        public void input()
        {
            Console.WriteLine("masukkan nilai matematika=");
            mat = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("masukan nilai ipa= ");
            ipa = Convert.ToDouble(Console.ReadLine());
        }

        public double ratarata(double m, double ip)
        {
            return (m + ip) / 2;
        }

        public string keterangan()
        {
            string status;
            if (mat >= 80 && ratarata(mat, ipa) >= 75)
            {
                status = "lulus";
            }
            else
            {
                status = "tidak lulus";
            }
            return status;
        }
        public void tampilan()
        {
            Console.WriteLine("nilai rata-rata = {0} \nStatus kelulusan = {1}", ratarata(mat, ipa),keterangan
                ());
            Console.ReadKey();
        }
    }
}



