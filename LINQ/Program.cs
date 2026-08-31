namespace LINQ
{
    public class LINQPractice
    {
        public static void Main(string[] args)
        {
            List<int> Numbers = new List<int> { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            Console.WriteLine(".Net For Loop");

            // Full control {Imperative} - result matters
            for (int i = 0; i < Numbers.Count; i++) 
            {
                if(Numbers[i] < 70)
                {
                    Console.WriteLine(Numbers[i]);
                }
            }

            Console.WriteLine("\n---------------------------------");
            Console.WriteLine(".Net Foreach loop");


            //loop-safer Imperative
            foreach (var number in Numbers)
            {
                if (number < 70)
                {
                    Console.WriteLine(number + " , ");
                }
            }

            // what you want (Declarative) - valuew matters

            var query = from n in Numbers //DataSource
                        where n < 70 //Filter
                        select n; // Select

            foreach (var number in query) {  Console.Write(number + ","); }

            Console.WriteLine("\n------------------------------");
            Console.WriteLine("Using Linq method");

            //var queryMethod = Numbers.Where(CheckNumber).Select(x => x);
            //var queryMethod = Numbers.Where(n => n<70).Select(x => x);
            var queryMethod = Numbers.Where(n => n < 70);
            foreach(var numbers in queryMethod) {  Console.WriteLine(numbers); }

        }

        static bool CheckNumber(int number)
        {
            return number > 70;
        }
    }
}