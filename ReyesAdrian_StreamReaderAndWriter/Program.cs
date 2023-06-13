using System.Linq;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReyesAdrian_StreamReaderAndWriter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(@"C:\C#_Midterm\Midterm.txt"))
            {
                while (!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine());
                }

                sr.Close();
            }

            using (StreamWriter sw = new StreamWriter(@"C:\C#_Midterm\Midterm.txt", true))
            {
                sw.WriteLine("Logging details " + DateTime.Now);

                sw.Close();
            }

            Console.ReadLine();
        }
    }
}