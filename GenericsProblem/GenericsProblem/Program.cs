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
        {/*
          //  DeleteArray deleteArray = new DeleteArray();
            int [] arr = { 10, 20, 30, 5, 45, 6, 250 };
            int n = arr.Length;
            DeleteArray.DeleteElement(arr, n, 45);
            Console.WriteLine("Array after delete elements");
            for(int i =0;i<n-1;i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
*/
            //using generic method
            int[] arr1 = { 10, 20, 30, 80, 65 };
           DeleteArray<int> deleteArray = new DeleteArray<int>();
            deleteArray.DeleteMethod(arr1, 30);
            
            
        }
         
    }
}
