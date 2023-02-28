using System;

class ArrayTwo{
	static void Main(){
		int[,] intArray; // 2차원 배열 선언
		intArray = new int[2,3]; // 2 * 3 개의 요소 생성
		
		intArray[0,0] = 1;
		intArray[0,1] = 2;
		intArray[0,2] = 3;
		intArray[1,0] = 4;
		intArray[1,1] = 5;
		intArray[1,2] = 6;
		
		int[,] intArray2 = new int[2,3] {{1,2,3}, [4,5,6]}; //배열 선언과 동시에 초기화
		
		for (int i = 0; i < 2; i++){
			for (int j = 0; j < 3; j++){
				Console.Write($"{intArray[i,j]}\t");
			}
			Console.WriteLine();
		}
	}
}