using GenericType.Models;
using System;
using System.Collections.Generic;

namespace GenericType
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MyList<int> listNo1 = new MyList<int>(23);
                listNo1.Add(5);
                listNo1.Add(6);
                listNo1.Add(7);
                listNo1.Add(8);
                listNo1.Add(9);
                listNo1.Remove(7);
                listNo1.Reverse();
                //Console.WriteLine(listNo1.IndexOf(6));
                //Console.WriteLine(listNo1.Exist(6));
                for (int i = 0; i < listNo1.Count; i++)
                {
                    Console.WriteLine(listNo1[i]);
                }
                MyList<string> listNo2 = new MyList<string>(6);
                listNo2.Add("Jeyhun");
                listNo2.Add("Benedict");
                for (int i = 0; i < listNo2.Count; i++)
                {
                    Console.WriteLine(listNo2[i]);
                }
                listNo1.Clear();

            }
            catch (IndexOutOfRangeException) 
            {

                Console.WriteLine("Number is out of range of array");
            }
            catch(Exception)
            {
                Console.WriteLine("Wrong input!");
            }
            

        }
    }
}
