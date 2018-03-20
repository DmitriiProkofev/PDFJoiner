using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PDFJoiner.Presenters;
using PDFJoiner.Models;
using PDFJoiner.Views;

namespace PDFJoiner
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            PDFJoinerPresenter presenter = new PDFJoinerPresenter();
            PDFJoinerModel model = new PDFJoinerModel();

            Application.Run(new PDFJoinerView(presenter, model));
        }
    }
}
