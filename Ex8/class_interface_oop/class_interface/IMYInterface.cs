using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace class_interface
{
    internal interface IMYInterface
    {
        double train(List<double> data);
        void save (string filePath);
        void load(string filePath);
       

    }
}
