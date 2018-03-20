using PDFJoiner.Models;
using PDFJoiner.Views;

namespace PDFJoiner.IPresenters
{
    /// <summary>
    /// Интерфейс представителя "PDFJoiner".
    /// </summary>
    public interface IPDFJoinerPresenter
    {
        /// <summary>
        /// Инициализация.
        /// </summary>
        /// <param name="view">Представление.</param>
        /// <param name="model">Модель.</param>     
        void Init(PDFJoinerView view, PDFJoinerModel model);
    }
}
