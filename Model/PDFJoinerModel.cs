using iTextSharp.text;
using iTextSharp.text.pdf;
using PDFJoiner.IModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDFJoiner.Properties;

namespace PDFJoiner.Models
{
    /// <summary>
    /// Класс модели "PDFJoiner".
    /// </summary>
    public class PDFJoinerModel : IPDFJoinerModel
    {
        #region Public Methods

        /// <summary>
        /// Объединение файлов.
        /// </summary>
        /// <param name="fileNames">Список имен файлов.</param>
        /// <param name="targetPdf">Имя выходного файла.</param>
        /// <returns>Признак указывающий на создание файла.</returns>
        public bool MerdgePDFs(List<string> fileNames, string targetPdf)
        {
            bool isMerged = true;
            PdfReader reader = null;
            using (var document = new Document())
            {
                try
                {
                    using (FileStream stream = new FileStream(targetPdf, FileMode.Create))
                    {
                        PdfCopy pdf = new PdfCopy(document, stream);

                        document.Open();

                        //словарь для закладок.
                        var outlines = new List<Dictionary<string, object>>();
                        //номер страницы на которую будет установлена закладка.
                        var pageIndex = 1;
                        //номер файла, для формирования имени закладки.
                        var fileNumber = 1;

                        foreach (string file in fileNames)
                        {
                            reader = new PdfReader(file);
                            //кол-во страниц в файле.
                            var n = reader.NumberOfPages;

                            for (var page = 0; page < n;)
                            {
                                //создание закладки.
                                if (page == 0)
                                {
                                    var bookmark = new Dictionary<string, object>();
                                    outlines.Add(bookmark);
                                    bookmark["Title"] = string.Format("File {0}", fileNumber);
                                    bookmark["Action"] = "GoTo";
                                    bookmark["Page"] = String.Format("{0} Fit", pageIndex);
                                }
                                //добавление страницы в выходной файл.
                                pdf.AddPage(pdf.GetImportedPage(reader, ++page));
                            }

                            pageIndex += n;
                            fileNumber++;
                            reader.Close();

                        }
                        //добавление закладок в файл.
                        pdf.Outlines = outlines;
                        document.Close();
                    }
                }
                catch (Exception)
                {
                    isMerged = false;
                    if (reader != null)
                    {
                        reader.Close();
                    }
                    if (document != null)
                    {
                        document.Close();
                    }
                }
            }
            return isMerged;
        }

        /// <summary>
        /// Добавление картинки в файл.
        /// </summary>
        /// <param name="fileName">Имя файла.</param>
        /// <returns>Признак указывает на добавление картинки.</returns>
        public bool AddImageCheckToPDF(string fileName)
        {
            bool isAdded = true;
            PdfReader reader = null;
            PdfStamper stamper = null;
            try
            {
                using (Stream inputPdfStream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
                using (MemoryStream ms = new MemoryStream())
                {
                    reader = new PdfReader(inputPdfStream);
                    stamper = new PdfStamper(reader, ms);

                    //содержимое файла.
                    var pdfContentByte = stamper.GetOverContent(1);
                    var pageSize = reader.GetPageSize(1);

                    Image image = Image.GetInstance((System.Drawing.Image)Resources.Check, System.Drawing.Imaging.ImageFormat.Png);

                    //местоположение картинки в файле.
                    image.SetAbsolutePosition(10, (int)pageSize.Height - 50);
                    pdfContentByte.AddImage(image);

                    stamper.Close();
                    reader.Close();

                    File.WriteAllBytes(fileName, ms.ToArray());
                }
            }
            catch (Exception)
            {
                isAdded = false;
                if (stamper != null)
                {
                    stamper.Close();
                }
                if (reader != null)
                {
                    reader.Close();
                }
            }
            return isAdded;
        }

        #endregion
    }
}
