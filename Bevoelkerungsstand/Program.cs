using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bevoelkerungsstand
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Register Provider to using encoding of type "Windows-1252".
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Bevoelkerungstand());
        }
    }
}
