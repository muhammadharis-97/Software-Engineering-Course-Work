using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace class_interface
{
    
    public class Class1 : IMYInterface
    {
        public void save(string filePath)
        {

        }
    
        public void load(string filePath)
        {
           
        }
        public double train(List<double> data)
        {
            double sum;
            sum = 0;
            foreach (float i in data)
            {
                sum += i;
            }

            if (sum > 100)
            {
                //Console.WriteLine("The Total Sum is " + sum);
                //Console.WriteLine("The Total sum is greater than 100");
                return 1;
                //Console.WriteLine(1);
            }

            else
            {
                //Console.WriteLine("The Total Sum is " + sum);
                //Console.WriteLine("The Total sum is less than 100");
                return 0;
                //Console.WriteLine(0);

            }

        }

        
    
    

    }

}

