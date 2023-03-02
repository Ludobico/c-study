using System;

struct Point{
	public int X; // public 키워드로 외부에서 int X를 사용하도록 설정
	public int Y;
}

class StructDemo{
	static void Main(){
		Point point; // Point 구조체 형식의 변수 선언
		point.X = 100;
		point.Y = 200;
		
		Console.WriteLine($"X : {point.X}, Y : {point.Y}");
	}
}