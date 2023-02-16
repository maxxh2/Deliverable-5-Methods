/*
 * Name: Maxx Hernandez
 * Date: 02/16/2023
 * Description: C# Deliverable(5) Using two methods
 

*/
namespace deliverable_5_Methods
{
    class Program
    {
        static int[] random_array(int array_len)
        {
            
            Random random= new Random();
            int[] MyArray = new int[array_len];
            for(int i = 0; i < array_len; i++)
            {
                MyArray[i] = random.Next(10,50); 
            }
            return MyArray;
        }

        static int sum(int[] array)
        {
            int sum = 0;
            foreach(int item in array)
            {
                sum = sum + item;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            try
            {
                int input = 0;
                while (input < 5 || input > 15)
                {
                    Console.WriteLine("Enter an integer between 5 and 15: ");
                    input = int.Parse(Console.ReadLine());
                    if (input < 5 || input > 15)
                    {
                        Console.WriteLine("Invalid input. Please enter an integer between 5 and 15.");
                    }
                }

                int[] sampleArray = random_array(input);

                Console.WriteLine("The elements in the random array are: ");

                foreach (int element in sampleArray)
                {
                    Console.Write(element + " ");
                }

                Console.WriteLine(" ");
                Console.WriteLine("The sum is: " + sum(sampleArray));
            }
            catch
            {
                Console.WriteLine("Please enter an integer (whole number)");
            }
        }
    }
}