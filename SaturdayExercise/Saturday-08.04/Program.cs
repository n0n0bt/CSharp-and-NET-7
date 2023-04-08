using Saturday_08._04;
// 1
WriteLine(FunctionsSaturday.sumOfTwoNum(23,34));

// 2
WriteLine(FunctionsSaturday.numOfSpaces("Naumche saka da jadi kifli!"));

// 3
int[] someArr = { 2, 3, 5, 6, 56, 77, 8 };
int sum = FunctionsSaturday.CalculateSum(someArr);
WriteLine($"The sum of the given array is: {sum}");

// 4
int num1 = 23;
int num2 = 50;
WriteLine($"Before swaping: num1 = {num1} and num2 = {num2}");
SwapingValues.Swap(ref num1, ref num2);
WriteLine($"After swaping: num1 = {num1} and num2 = {num2}");

// 5

int baseNum = 5;
int exponent = 3;
int res = CalcRaisingNum.TheCalc(baseNum, exponent);
WriteLine($"{baseNum}^{exponent} = {res}");

// 6
int n = 10;

/*for (int i = 0; i < n; i++)
{
    WriteLine($"{Fibonacci.Process(i)}");
}*/

// 7

int num = 123445;
int sum1 = IndividualDigits.DigitsSum(num);
WriteLine($"The digits of the given number is: {sum1}");

// 8

int number = RecursiveFunction.Factorial(5);

WriteLine(number);


