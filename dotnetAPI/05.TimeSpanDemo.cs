using System;

class TimeSpanDemo{
	static void Main(){
		//TimeSpan 날짜 관련 내장 구조체
		TimeSpan dday = Convert.ToDateTime("2023-12-25") - DateTime.Now;
		Console.WriteLine($"{DateTime.Now.Year}년도 크리스마스는 {(int)dday.TotalDays}일 남음");
		
		//지난 시간 구하기
		TimeSpan times = DateTime.Now - Convert.ToDateTime("1998-02-15");
		Console.WriteLine($"지금까지 {(int)times.TotalDays} 살아옴");
	}
}