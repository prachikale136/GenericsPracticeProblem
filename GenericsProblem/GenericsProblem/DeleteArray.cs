using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblem
{
    public class DeleteArray<T>
    {
        /*public static void DeleteElement(int []arr ,int n, int x)  // here x is element in array
        {
            int i;
            for (i = 0;i<n;i++) 
            {
                if (arr[i] == x)
                    break;
            }
            //if x found in array then 
            if(i < n)   
            {
                //redude size of array and move element one space ahead
                n = n - 1;
                for(int j = i;j<n;j++) 
                {
                    arr[j] = arr[j + 1];
                }
                //return n;
            }
            
        }*/

        public void DeleteMethod( T[] arr1, T x)
        {
            int i;
            int count = 0;
            for(i=0;i<arr1.Length;i++)
            { 
                if (arr1[i].Equals(x))
                {
                    count++;
                }
                else if (i < arr1.Length)
                 {
                    arr1[i -count] = arr1[i];
                 }
            }
            Array.Resize( ref arr1, arr1.Length - count);
            Console.WriteLine("After deleting elemnt");
            foreach (T obj in arr1)
            {
                
                Console.WriteLine(obj + "");
            }
            Console.WriteLine();
        }
    }
}
