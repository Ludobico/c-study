using System;
using static System.Console;
using static System.Math;

class UsingStaticClassesDemo{
	static void Main(){
		WriteLine(Math.Pow(2,10)); // 기본 사용 방식
		
		WriteLine(Pow(2, 10)); // 지시문으로 줄여서 표현
		WriteLine(Max(3, 5));
	}
}