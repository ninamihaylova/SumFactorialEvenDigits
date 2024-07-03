class Program {
    static void Main() {
        int n = int.Parse(Console.ReadLine());
        int result = SumFactorialEvenDigits(n);
        Console.WriteLine(result);
    }

    static int Factorial(int n) {
        int result = 1;
        for (int i = 1; i <= n; i++) {
            result *= i;
        }
        return result;
    }

    static int SumFactorialEvenDigits(int number) {
        string digits = number.ToString();
        int sum = 0;
        
        foreach (char digitChar in digits) {
            int digit = int.Parse(digitChar.ToString());
            
            if (digit % 2 == 0) {
                sum += Factorial(digit);
            }
        }
        
        return sum;
    }
}


