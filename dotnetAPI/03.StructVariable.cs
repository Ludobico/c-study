using System;

class StructVariable{
	static void Main(){
		Product pstr;
		
		pstr.Id = 1;
		pstr.Title = "좋은 책";
		pstr.Price = 10000M; // M이 없으면 해당 타입은 double로 인식함
		
		// 구조체 형식 변수 사용
		string message = $"번호 : {pstr.Id}, 상품명 : {pstr.Title}, 가격 : {pstr.Price}";
		Console.WriteLine(message);
	}
}

struct Product{
	public int Id;
	public string Title;
	public decimal Price; // 부동 소수점 타입
}