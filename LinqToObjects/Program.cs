namespace LinqToObjects
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            //Filters.LinqWhere();
            //Filters.LinqOfType();
            //ProjectionOperations.SelectOperator();
            //ProjectionOperations.SelectManyOperator();
            ProjectionOperations.ZipOperator();
        }
    }
}