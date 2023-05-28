namespace task3
{
    class Solver
    {
        public static void Main(string[] args)
        {

            var tokens = Console.ReadLine()
                .Split(' ');
            Console.WriteLine(Calc(tokens));
            Console.ReadLine();
        }

        public static int Calc(string[] tokens)
        {
            Stack<int> numbers = new Stack<int>();
            int firstNum;
            int secondNum;

            foreach (var token in tokens)
            {
                switch (token)
                {
                    case "/":
                        secondNum = numbers.Pop();
                        firstNum = numbers.Pop();
                        numbers.Push(firstNum / secondNum);
                        break;
                    case "*":
                        secondNum = numbers.Pop();
                        firstNum = numbers.Pop();
                        numbers.Push(firstNum * secondNum);
                        break;
                    case "+":
                        secondNum = numbers.Pop();
                        firstNum = numbers.Pop();
                        numbers.Push(firstNum + secondNum);
                        break;
                    case "-":
                        secondNum = numbers.Pop();
                        firstNum = numbers.Pop();
                        numbers.Push(firstNum - secondNum);
                        break;
                    default:
                        int.TryParse(token, out int num);
                        numbers.Push(num);
                        break;
                }
            }
            return numbers.Pop();
        }
    }
}