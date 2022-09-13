using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        //Объявляем объект класса Process
        Process process = new Process();

        //устанавливаем имя файла, который будет запущен в рамках процесса
        process.StartInfo.FileName = "notepad.exe";

        //запускаем процесс
        process.Start();

        //выводим имя процесса
        Console.WriteLine("Запущен процесс: " + process.ProcessName);

        //ожидаем закрытия процесса
        process.WaitForExit();

        //выводим код, с которым завершился процесс
        Console.WriteLine("Процесс завершился с кодом: " + process.ExitCode);

        //выводим имя текущего процесса
        Console.WriteLine("Текущий процесс имеет имя: " + Process.GetCurrentProcess().ProcessName);
    }
}