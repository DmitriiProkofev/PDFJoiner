using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDFJoiner.IPresenters;
using PDFJoiner.Views;
using PDFJoiner.Models;

namespace PDFJoiner.Presenters 
{
    /// <summary>
    /// Класс представителя "PDFJoiner".
    /// </summary>
    public class PDFJoinerPresenter : IPDFJoinerPresenter
    {
        #region Private Fields

        private PDFJoinerView _view;
        private PDFJoinerModel _model;

        #endregion

        #region Public Methods

        /// <summary>
        /// Инициализация.
        /// </summary>
        /// <param name="view">Представление.</param>
        /// <param name="model">Модель.</param> 
        public void Init(PDFJoinerView view, PDFJoinerModel model)
        {
            _view = view;
            _model = model;

            SubscribeEvents();
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Подписаться на события.
        /// </summary>
        private void SubscribeEvents()
        {
            _view.ViewClosed += UnsubscribeEvents;
            _view.MerdgePDFs += MerdgePDFsHandler;
            _view.AddImageCheckToPDF += AddImageCheckToPDFHandler;

        }

        /// <summary>
        /// Отписаться от событий.
        /// </summary>
        private void UnsubscribeEvents()
        {
            _view.MerdgePDFs -= MerdgePDFsHandler;
            _view.AddImageCheckToPDF -= AddImageCheckToPDFHandler;
            _view.ViewClosed -= UnsubscribeEvents;
        }

        #endregion

        #region Event Handlers

        private void MerdgePDFsHandler(List<string> fileNames, string targetPdf)
        {
            _view.IsMerged = _model.MerdgePDFs(fileNames, targetPdf);
        }

        private void AddImageCheckToPDFHandler(string fileName)
        {
            _view.IsAdded = _model.AddImageCheckToPDF(fileName);
        }

        #endregion
    }
}
