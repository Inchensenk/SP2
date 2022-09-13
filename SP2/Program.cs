using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        //Объявляем объект класса Process
        Process process = new Process();


        /*StartInfo – возвращает или устанавливает объект класса ProcessStartInfo, который содержит набор значений, используемых для запуска процесса. 
        Это свойство передаётся как аргумент при вызове метода Start класса Process (метода, запускающего процесс).

        FileName – возвращает или устанавливает путь к приложению (документу), которое запускается в рамкахпроцесса.*/
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