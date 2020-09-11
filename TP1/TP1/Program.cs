using System;
using Entidades;
using MiCalculadora;
using System.Windows.Forms;

namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormCalculadora.TestForm());
        }
    }
}
