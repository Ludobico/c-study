using System;

class CharStruct{
	static void Main(){
		char a = 'A';
		char b = 'a';
		char c = '1';
		char d = '\t'; // 이스케이프 시퀀스도 하나의 문자로 인식
		
		if (char.IsUpper(a)) {
			Console.WriteLine($"{a}는 대문자");
		}
		if (char.IsLower(b)){
			Console.WriteLine($"{b}는 소문자");
		}
		if (char.IsNumber(c)){
			Console.WriteLine($"{c}는 숫자형");
		}
		if (char.IsWhiteSpace(d)){
			Console.WriteLine($"{d}는 공백 문자");
		}
		
		Console.WriteLine(char.ToLower(a)); // A -> a
		Console.WriteLine(char.ToUpper(b)); // a -> A
		
		string s = "abc";
		if (char.IsUpper(s[0]))
		{
			Console.WriteLine("첫 글자가 대문자로 시작한다.");
		}
		else{
			Console.WriteLine("첫 글자가 소문자로 시작한다.");
		}
		
		Console.WriteLine(char.MinValue); //문자의 최솟값
		Console.WriteLine(char.MaxValue); //문자의 최댓값
	}
}