namespace OdestEmployee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dataLength = 0;
            do
            {
                Console.WriteLine("Enter number of employees: ");
                dataLength = Int32.Parse(Console.ReadLine());
            } while (!(dataLength >= 1 && dataLength <= 100));

            int[] age = new int[dataLength];
            int[] salary = new int[dataLength];

            for (int i = 0; i < dataLength;)
            {
                Console.WriteLine("Enter proper age and salary: ");
                string input = Console.ReadLine();
                age[i] = Convert.ToInt32(input.Split(' ')[0]);
                salary[i] = Convert.ToInt32(input.Split(' ')[1]);
                if (age[i] >= 1 && age[i] <= 100 && salary[i] >= 1 && salary[i] <= 2000000)
                {
                    i++;
                }
                /*else
                {
                    Console.WriteLine("Wrong input!");
                }*/
            }

            int maxIndex = 0;

            for (int i = 1; i < dataLength; i++)
            {
                if (age[i] > age[maxIndex])
                {
                    maxIndex = i;
                }
            }

            int salaryForMaxVal = salary[maxIndex];
            //Console.WriteLine(salaryForMaxVal);
            Console.WriteLine("Salary of the oldest employee " + salaryForMaxVal);
        }

    }
};