using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SATeC
{
    public class LogErrores
    {
        public static void WriteLog(string message, Exception ex)
        {
            try
            {
                string appPath = AppDomain.CurrentDomain.BaseDirectory;

                using (StreamWriter writer = new StreamWriter(appPath + "\\LogErroresSATeC_" + DateTime.Now.ToString("dd-MM-yyyy") + ".txt", true))
                {
                    writer.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + " | " + message + " | " + "Error: [" + ex.ToString() + "]");
                    writer.WriteLine(Environment.NewLine);
                    writer.Close();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}