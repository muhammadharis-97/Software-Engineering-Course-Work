using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using static class_interface.Result;

namespace class_interface
{
    internal class Class2 : IMYInterface
    {
        Result result = new Result();
        
        public double train(List<double> data)
        {

            double avg = 0;
            avg = data.Average();
            
            result.average=avg;
            double median = Median(data);

            // Calculating variance
            double difference = 0;
            double sumOfSquaresDEfferences = 0;
            double Variance = 0;

            foreach (int value in data)
            {
                difference = value - avg;
                sumOfSquaresDEfferences += (difference * difference);
                Variance = sumOfSquaresDEfferences / data.Count;

            }


            result.average = avg;
            result.Median = median;
            result.Variance = Variance;

            return 0;

        }

        public double Median(List<double> data)
        {
            //First step is sorting the algorithm
            data.Sort();

            int index = 0;
            double _median = 0;

            //even case
            if ((data.Count) % 2 == 0)
            {

                index = (data.Count) / 2;

                _median = (data[index] + data[index - 1]) / 2;
                return _median;
            }

            else
            {

                index = (data.Count) / 2;

                _median = data[index];
                return _median;
            }
        }

        public void save(string filePath)
        {

            // Save the result to a file (serialization can be used for more complex structures)
            File.WriteAllText(filePath, $"{result.average}, {result.Median}, {result.Variance}");
            Console.WriteLine($"Result saved to {filePath}");
        }

        public void load(string filePath)
        {
            if (File.Exists(filePath))
            {
                string content = File.ReadAllText(filePath);
                string[] parts = content.Split(',');

                if (parts.Length == 3)
                {
                    Result resultClass = new Result
                    {
                        average = double.Parse(parts[0]),
                        Median = double.Parse(parts[1]),
                        Variance = double.Parse(parts[2])
                    };
                    Console.WriteLine($"Result loaded from {filePath}");
                    Console.WriteLine($"Average is: {resultClass.average},Median is: {resultClass.Median},Variance is: {resultClass.Variance}");
                }
                else
                {
                    Console.WriteLine($"Error: Invalid file content in {filePath}");
                }
            }
            else
            {
                Console.WriteLine("File does not Exist...!");
            }

        }
        public Result GetResult()
        {
            
            return result;


        }


     

    }
}
