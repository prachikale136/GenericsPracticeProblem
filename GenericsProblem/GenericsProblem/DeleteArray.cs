using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblem
{
    internal class DeleteArray
    {
        public static void DeleteElement(int []arr ,int n, int x)  // here x is element in array
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
            
        }
    }
}
