using System;

class Conditional
{
	static void Main(){
		Console.WriteLine($"숫자를 입력해라 : ");
		string input = Console.ReadLine();
		int number = Convert.ToInt32(input);
		
		string result = (number % 2 == 0) ? "짝수" : "홀수";
		
		Console.WriteLine($"{number}는 {result}다.");
	}
}