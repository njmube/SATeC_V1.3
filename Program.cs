using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;

namespace SATeC {
    static class Program {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main() 
        {
            EmbeddedAssembly.Load("SATeC.ExpandableGridView.dll", "ExpandableGridView.dll");
            EmbeddedAssembly.Load("SATeC.ICSharpCode.SharpZipLib.dll", "ICSharpCode.SharpZipLib.dll");
            EmbeddedAssembly.Load("SATeC.Microsoft.ReportViewer.WinForms.dll", "Microsoft.ReportViewer.WinForms.dll");
            EmbeddedAssembly.Load("SATeC.Microsoft.reportviewer.common.dll", "Microsoft.reportviewer.common.dll");
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);
            Application.EnableVisualStyles();
            Application.DoEvents();
            Application.Run(new frmLogin());
        }
        static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            return EmbeddedAssembly.Get(args.Name);
        }
    }
}
