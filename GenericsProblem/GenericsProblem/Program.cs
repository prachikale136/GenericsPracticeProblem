using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblem
{
    internal class Program
    {
        static void Main(string[] args) 
        {
          //  DeleteArray deleteArray = new DeleteArray();
            int[] arr = { 10, 20, 30, 5, 45, 6, 250 };
            int n = arr.Length;
            DeleteArray.DeleteElement(arr, n, 45);
            Console.WriteLine("Array after delete elements");
            for(int i =0;i<n-1;i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
        }
         
    }
}
