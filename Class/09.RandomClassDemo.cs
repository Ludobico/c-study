using System;

class RandomClassDemo{
	static void Main(){
		Console.Write("이번 주의 로또 : ");
		Random ran = new Random();
		
		int[] arr = new int[6]; // 데이터 6개
		int temp = 0;
		for (int i = 0; i < 6; i++){
			temp = ran.Next(45) + 1; // 1~45
			bool flag = false;
			if (i > 0 && i < 6){
				for (int j = 0; j <= i; j++){
					if (arr[j] == temp){
						flag = true; // 중복되면 true로 설정
					}
				}
			}
			if (flag){
				--i;
			}
			else{
				arr[i] = temp;
			}
		}
		for (int i = 0; i < 6; i++){
			Console.Write("{0} ", arr[i]);
		}
		Console.WriteLine();
	}
}