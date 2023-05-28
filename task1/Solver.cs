namespace task1
{
    class Solver
    {
        public static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var hashTable = new HashTable(n);
            
            Console.ReadLine()
                .Split(new char[] {' '})
                .Select(v=> Convert.ToInt32(v))
                .ToList()
                .ForEach(v => hashTable.Insert(v));
            
            Console.WriteLine(hashTable);
        }
    }
}