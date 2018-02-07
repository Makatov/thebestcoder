using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadFromFileMaxMin
{
    class Program
    {
        static void Main(string[] args)
        {
            string ans = "";
            string text = System.IO.File.ReadAllText(@"/Users/samat/Desktop/Programing_P2/Second_Lab/INforMaxandMin.txt");

            string[] arr = text.Split(' ');
            int min = int.Parse(arr[0]);
            int max = int.Parse(arr[0]);
            int sum = 0;
            string mn = "", mx = "";
            for(int i = 0;i<=(arr.Length)-1;i++)
            {
                sum = int.Parse(arr[i]);
                if (sum <= min)
                {
                    min = sum;
                    mn = arr[i];
                }
                if (sum >= max)
                {
                    max = sum;
                    mx = arr[i];
                }
                
            }
            ans = mn + " " + mx;
            System.IO.File.WriteAllText(@"/Users/samat/Desktop/Programing_P2/Second_Lab/OUTforMaxandMin.txt", ans);
        }
    }
}
