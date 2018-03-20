using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFJoiner.IModels
{
    /// <summary>
    /// Интерфейс модели "PDFJoiner".
    /// </summary>
    public interface IPDFJoinerModel
    {
        /// <summary>
        /// Объединение файлов.
        /// </summary>
        /// <param name="fileNames">Список имен файлов.</param>
        /// <param name="targetPdf">Имя выходного файла.</param>
        /// <returns>Признак указывающий на создание файла.</returns>
        bool MerdgePDFs(List<string> fileNames, string targetPdf);

        /// <summary>
        /// Добавление картинки в файл.
        /// </summary>
        /// <param name="fileName">Имя файла.</param>
        /// <returns>Признак указывает на добавление картинки.</returns>
        bool AddImageCheckToPDF(string fileName);
    }
}
