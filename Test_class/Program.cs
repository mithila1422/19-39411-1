using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_class
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n,j,k,sum=0;
            int[] a = new int[100];
            int[] arr1 = new int[100];
            int[] a2 = new int[100];
            int[] a3 = new int[100];
            int  mm = 1, ctr = 0;
            int  isUnique;

            Console.Write("Input the number of elements to store in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} number of elements in the array :", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.Write("The values store into the array are : ");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", a[i]);
            }
            Console.Write("\n\n");

            Console.Write("The values store into the array in reverse are :");
            for (i = n - 1; i >= 0; i--)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.Write("\n\n");

           

            for (i = 0; i < n; i++)
            {
                 sum += a[i];
            }
            Console.Write("\n\n");


            
            Console.Write("Sum of all elements stored in the array is : {0}\n\n", sum);

            for (i = 0; i < n; i++)
            {
                a2[i] = a[i];
            }
            Console.Write("\nThe elements stored in the first array are :\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", a[i]);
            }
            
            
            Console.Write("\n\nThe elements copied into the second array are :\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", a2[i]);
            }
            Console.Write("\n\n");





            for (i = 0; i < a[i]; i++)
            {
                a2[i] = a[i];
                a3[i] = 0;
            }
            
            for (i = 0; i < a[i]; i++)
            {
                for (j = 0; j < a[i]; j++)
                {
                    if (a[i] == a2[j])
                    {
                        a3[j] = mm;
                        mm++;
                    }
                }
                mm = 1;
            }
            
            for (i = 0; i < a[i]; i++)
            {
                if (a3[i] == 2) { ctr++; }
            }
            Console.Write("The number of duplicate elements is: {0} \n", ctr);
            Console.Write("\n\n");



          

            for (i = 0; i < a[i]; i++)
            {
                isUnique = 1;

                for (j = i + 1; j < a[i]; j++)
                {


                    if (a[i] == a[j])
                    {
                        
                        for (k = j; k < a[i] - 1; k++)
                        {
                            a[k] = a[k + 1];
                        }

                        a[i]--;
                        j--;
                        isUnique = 0;
                    }
                }

               
                if (isUnique != 1)
                {
                    for (j = i; j < a[i] - 1; j++)
                    {
                        a[j] = a[j + 1];
                    }

                    a[i]--;
                    i--;
                }
            }

            
            Console.WriteLine("All unique elements in the array are: ");
            for (i = 0; i < a[i]; i++)
            {
                Console.WriteLine(a[i] + "\t");
            }
            Console.ReadLine();
        }
    }
}
