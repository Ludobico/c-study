using System;

class Shift{
static void Main(){
	byte num1 = 4; // 4: 0000_0100
	num1 &= 5; // 5(0101) & 4(0100) => 4(0000_0100)
	Console.WriteLine(num1);
	
	byte num2 = 4;
	num2 |= 1;
	Console.WriteLine(num2);
	
	byte num3 = 4;
	num3 ^= 2;
	Console.WriteLine(num3);
	
	byte num4 = 4;
	num4 <<= 1;
	Console.WriteLine(num4);
	
	byte num5 = 4;
	num5 >>= 1;
	Console.WriteLine(num5);
}
}