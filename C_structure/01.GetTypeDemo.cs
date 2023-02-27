using System;

class GetTypeDemo{
	static void Main(){
		int i = 1234;
		string s = "gd.";
		char c = 'A';
		double d = 3.14;
		object o = new Object(); // 객체를 생성하는 구문
		Console.WriteLine(i.GetType());
		Console.WriteLine(s.GetType());
		Console.WriteLine(c.GetType());
		Console.WriteLine(d.GetType());
		Console.WriteLine(o.GetType());
	}
}