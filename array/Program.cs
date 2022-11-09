using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Program
    {
      static void Main(string[] args)
        {
            Array arr=new Array();
            int[] arra = new int[5];
            Console.Write(arr.Sinc(arr.Dinc(arra)));
            Console.ReadKey();
        }
    }
   

        

}
