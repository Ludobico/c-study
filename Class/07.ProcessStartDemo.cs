using System;
using System.Diagnostics;

namespace DotNet{
	class ProcessStartDemo{
		static void Main(){
			Process.Start("Notepad.exe"); // 메모장 실행
			Process.Start("Explorer.exe", "https://www.naver.com"); // 웹 브라우저를 열고 매개변수로 url을 전달
		}
	}
}