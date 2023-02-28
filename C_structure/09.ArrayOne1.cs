using System;

class ArrayOne1{
	static void Main(){
		int[] intArray; // 1차원 배열 선언
		intArray = new int[3]; // 메모리 영역 확보(0,1,2)
		
		int[] intArray2 = new int[3] {1,2,3}; // 배열 선언, 요소 생성, 초기화를 동시에
		int[] numbers = { 4, 5, 6, 1, 2, 3, -2, -1, 0 };
		
		intArray[0] = 1;
		intArray[1] = 2;
		intArray[2] = 3;
		
		for (int i = 0; i < intArray.Length + 1; i++){
			Console.WriteLine($"{i}번째 인덱스 : {intArray[i]}");
		}
		
        foreach (int eachvalue in numbers)
        {
            Console.WriteLine($"{eachvalue}");
        }
	}
}