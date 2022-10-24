using System;


namespace SearchAlgorithm
{
    class Program
    {
        //array to be searched
        int[] arr = new int[20];
        //number of element in the array
        int n;
        //get the number of elements to store in the array
        int i;

        public void input()
        {
            while (true)
            {
                Console.Write("Enter the number of elements in the array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 20))
                    break;
                else
                    Console.WriteLine("\n array should have mininum 1 and maximum 20 elements. \n");

                //accept array elements
                Console.WriteLine("");
                Console.WriteLine("--------------------");
                Console.WriteLine("Enter array elements");
                Console.WriteLine("--------------------");
                for (i = 0; i < n; i++)
                {
                    Console.Write("<"+ i+1 +">");
                    string s1 = Console.ReadLine();
                    arr[i] = Int32.Parse(s1);
                }

            }
            
        }
        public void BinarySearch()
        {
            char ch;
            do
            {
                //accepts the number to be searched
                Console.Write("\n enter element you want to search: \n");
                int item = Convert.ToInt32(Console.ReadLine());

                //apply the binary search 
                int lowerbound = 0;
                int upperbound = n-1;

                //obtain the index of the middle elements
                int mid = (lowerbound + upperbound) /2;
                int ctr = 1;

                //loop to search for the elements in the array
                while ((item != arr[mid]) && (lowerbound <= upperbound))
                {
                    if (item > arr[mid])
                    {
                        lowerbound = mid + 1;
                    }
                    else
                        upperbound = mid - 1;
                    mid = (lowerbound + upperbound) /2;
                    ctr++;
                }
                if (item == arr[mid])
                    Console.WriteLine("\n" + item.ToString() + "found at position" + (mid + 1).ToString());
                else
                    Console.WriteLine("\n" + item.ToString() + "not found in the array \n");
                Console.WriteLine("\n Number of comparison : " +ctr);

                Console.Write("\n Continue search (y/n):");
                ch = char.Parse(Console.ReadLine());
            } while ((ch == 'y') || (ch == 'Y'));
        }
    }
}