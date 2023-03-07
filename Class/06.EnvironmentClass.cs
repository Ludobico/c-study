using System;

class EnvironmentClass{
	static void Main(){
		Console.WriteLine($"시스템 폴더 : {Environment.SystemDirectory}");
		Console.WriteLine($"닷넷 버전 : {Environment.Version}");
		Console.WriteLine($"운영 체제 : {Environment.OSVersion}");
		Console.WriteLine($"컴퓨터 이름 : {Environment.MachineName}");
		Console.WriteLine($"사용자 이름 : {Environment.UserName}");
		Console.WriteLine($"현재 폴더 : {Environment.CurrentDirectory}");
	}
}