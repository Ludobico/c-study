using System;

public class MyClass{
	public static void MyMethod(){
		Console.WriteLine("클래스");
	}
}

class ClassDescription{
	static void Main(){
		MyClass.MyMethod(); // 클래스이름.메서드이름()
	}
}