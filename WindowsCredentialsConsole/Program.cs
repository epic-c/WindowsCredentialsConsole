using CredentialManagement;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("請輸入 Target ID (網際網路或網路位置): ");
       
        var targetId = Console.ReadLine();

        Console.WriteLine("-----------------------");

        //讀取帳號密碼
        var storedCred = new Credential { Target = targetId };
        if (storedCred.Load())
        {
            Console.WriteLine($"Username = {storedCred.Username}");
            Console.WriteLine($"Password = {storedCred.Password}");
        }

        // 參考: https://blog.darkthread.net/blog/windows-credentials-management/
    }
}