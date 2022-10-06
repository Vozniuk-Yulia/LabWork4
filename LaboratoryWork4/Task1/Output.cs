using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Output<T>
    {
        public virtual void Show(T value1, T value2)
        {
            Debug.WriteLine(value1);
            Debug.WriteLine(value2);
        }
    }
}