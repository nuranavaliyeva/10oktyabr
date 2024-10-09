namespace _10oktyabr1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 3, 4,0, 5 };
            Console.WriteLine(GetMin(arr));
        }
        
         public static int GetMin(int[]arr)
        {
           int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
              
            }
            return min;
        }
      
            }

        }
