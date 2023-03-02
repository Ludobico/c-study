using System;

class MethodOverloadNumber{
	static void GetNumber(int number)
	{
		Console.WriteLine($"Int32 : {number}");
	}
	
	static void GetNumber(long number)
	{
		Console.WriteLine($"Int64 : {number}");
	}
	
	static void Main(){
		GetNumber(1234);
		GetNumber(1234L); //L을 접미사로 넣어주면 long으로 받음
	}
}