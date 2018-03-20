using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFJoiner.IViews
{
    /// <summary>
    /// Интерфейс представления "PDFJoiner".
    /// </summary>
    public interface IPDFJoinerView
    {
        /// <summary>
        /// Указывает на успех объединения.
        /// </summary>
        bool IsMerged { get; set; }

        /// <summary>
        /// Указывает на успех добавления картинки.
        /// </summary>
        bool IsAdded { get; set; }

        /// <summary>
        /// Закрывает форму.
        /// </summary>
        void CloseView();

        /// <summary>
        /// Событие закрытия формы.
        /// </summary>
        event Action ViewClosed;

        /// <summary>
        /// Событие объединения файлов.
        /// </summary>
        event Action<List<string>, string> MerdgePDFs;

        /// <summary>
        /// Событие добавления картинки "Check".
        /// </summary>
        event Action<string> AddImageCheckToPDF;
    }
}
