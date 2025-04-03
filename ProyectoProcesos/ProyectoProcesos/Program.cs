using System.Diagnostics;

namespace ProyectoProcesos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] compresores =
            {
                "winrar.exe", "7z.exe"
            };
            Process proc = Process.Start("notepad.exe");
        }
    }
}
