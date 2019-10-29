using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s3e2_tema
{
    class Program
    {

        static void Main(string[] args)
        {
            SumaA();

        }


        private static void Leap()
        {
            int year;
            Console.Write("Enter the year in four digits : ");
            year = Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine(year + " is a Leap Year ");
            }
            else
            {
                Console.WriteLine(year + " is not a Leap Year ");
            }
            Console.ReadLine();

        }






    private static void SumaA()
    {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Andrei\Documents\text.txt");
            for (int i=0;i<lines.Length; i++)
                for(int j=1;j<lines.Length;j++)
                {
                    lines[i] = lines[i] + lines[j];

                }


        System.Console.WriteLine("Contents of WriteLines2.txt = ");
           
        foreach (string line in lines)
        {
            // Use a tab to indent each line of the file.
            Console.WriteLine("\t" + line);
        }

           

        



        }
    }

}
