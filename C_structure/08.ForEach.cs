using System;

class ForEach{
	static void Main(){
		string str = "ABCD123456";
		
		foreach (char c in str){
			Console.Write($"{c}\t");
		}
		Console.WriteLine();
	}
}