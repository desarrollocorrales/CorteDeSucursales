using System;
using System.IO;

namespace CorteDeSucursales.Modelos
{
    public static class Logger
    {
        public static void AgregarLog(string Mensaje)
        {
            string sFileName = "Log" + DateTime.Now.ToString("ddMMyyyy") + ".log";
            StreamWriter swFile = new StreamWriter(Environment.CurrentDirectory + "\\Logs\\" + sFileName, true);
            swFile.WriteLine(DateTime.Now + ": " + Mensaje);
            swFile.Close();
        }

        public static void AgregarLog()
        {
            string sFileName = "Log" + DateTime.Now.ToString("ddMMyyyy") + ".log";
            StreamWriter swFile = new StreamWriter(Environment.CurrentDirectory + "\\Logs\\" + sFileName, true);
            swFile.WriteLine();
            swFile.Close();
        }
    }
}
