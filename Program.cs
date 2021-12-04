using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marks_
{
    class Program
    {
        public class Marks
        {
            public int marksSubject1;
            public int marksSubject2;
            public int marksSubject3;
       
        public void sum()
            {
                int s = marksSubject1 + marksSubject2 + marksSubject3;
                Console.WriteLine("The sum of marks of all three subjects is " + s);
            }
        public void average()
            {
                int s = marksSubject1 + marksSubject2 + marksSubject3;
                int avg = s / 3;
                Console.WriteLine("The average marks are " + avg);

            }
        }
       static void Main(string[] args)
       {
            Marks number = new Marks();
            Console.WriteLine("Enter the marks of subject 1");
            string q = Console.ReadLine();
            int m1 = Convert.ToInt32(q);
            number.marksSubject1 = m1;   
            
                   Console.WriteLine("Enter the marks of subject 2");
                   string q1 = Console.ReadLine();
                   int m2 = Convert.ToInt32(q);
                   number.marksSubject2 = m2;

                          Console.WriteLine("Enter the marks of subject 3");
                          string q2 = Console.ReadLine();
                          int m3 = Convert.ToInt32(q);
                          number.marksSubject3 = m3;

            number.sum();
            number.average();           
       }
    }
}
