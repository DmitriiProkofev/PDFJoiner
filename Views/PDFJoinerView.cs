using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PDFJoiner.IViews;
using PDFJoiner.Presenters;
using PDFJoiner.Models;
using System.Diagnostics;

namespace PDFJoiner.Views
{
    /// <summary>
    /// Класс представления "PDFJoiner".
    /// </summary>
    public partial class PDFJoinerView : Form, IPDFJoinerView
    {
        #region Private Fields

        //private List<File> _files;
        private bool _isMerged;
        private bool _isAdded;

        #endregion

        #region Constructors

        public PDFJoinerView()
        {
            InitializeComponent();
        }

        public PDFJoinerView(PDFJoinerPresenter presenter, PDFJoinerModel model)
            : this()
        {
            presenter.Init(this, model);
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Указывает на успех объединения.
        /// </summary>
        public bool IsMerged
        {
            get { return _isMerged; }
            set { _isMerged = value; }
        }

        /// <summary>
        /// Указывает на успех добавления картинки.
        /// </summary>
        public bool IsAdded
        {
            get { return _isAdded; }
            set { _isAdded = value; }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Закрывает форму.
        /// </summary>
        public void CloseView()
        {
            Close();
        }

        #endregion

        #region Events

        public event Action ViewClosed;
        public event Action<List<string>, string> MerdgePDFs;
        public event Action<string> AddImageCheckToPDF;

        #endregion


        #region Event Handlers

        private void PDFJoinerView_Load(object sender, EventArgs e)
        {
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Все файлы (*.pdf)|*.pdf";
            openFileDialog.RestoreDirectory = true;

            saveFileDialog.Filter = "Все файлы (*.pdf)|*.pdf";
            saveFileDialog.RestoreDirectory = true;
        }

        private void PDFJoinerView_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ViewClosed != null)
                ViewClosed();
        }

        private void buttonDowloadFiles_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Список файлов, которые не загрузились.
                var listErrorFiles = new List<string>();
                foreach (String fileName in openFileDialog.FileNames)
                {
                    if (AddImageCheckToPDF != null)
                        AddImageCheckToPDF(fileName);

                    if (!IsAdded)
                        listErrorFiles.Add(fileName);
                    else
                        listBoxFileNames.Items.Add(fileName);
                }
                if (listErrorFiles.Count != 0)
                    MessageBox.Show(string.Format("Следующие файлы не были загружены: {0}", string.Join(", ", listErrorFiles)), "PDFJoiner", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonClearFiles_Click(object sender, EventArgs e)
        {
            listBoxFileNames.Items.Clear();
        }

        private void buttonJoinFiles_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog.FileName;

                var nameFiles = listBoxFileNames.Items.OfType<string>().ToList();
                if (nameFiles.Count == 0)
                {
                    MessageBox.Show("Отсутствуют файлы для объединения", "PDFJoiner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (nameFiles.Count == 1)
                {
                    MessageBox.Show("Для объединения необходимо больше одного файла", "PDFJoiner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (nameFiles != null && filename != null)
                {
                    if (MerdgePDFs != null)
                        MerdgePDFs(nameFiles, filename);

                    if (!IsMerged)
                        MessageBox.Show("При объединение файлов возникли ошибки", "PDFJoiner", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        if (MessageBox.Show("Открыть созданный файл?", "PDFJoiner", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            Process.Start(filename);
                        }

                }
            }
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            int indexSelect, indexUp;

            if (listBoxFileNames.SelectedIndex != -1)
            {
                indexSelect = listBoxFileNames.SelectedIndex;
                if (indexSelect - 1 >= 0)
                {
                    indexUp = indexSelect - 1;

                    var temp = listBoxFileNames.Items[indexSelect];
                    listBoxFileNames.Items[indexSelect] = listBoxFileNames.Items[indexUp];
                    listBoxFileNames.Items[indexUp] = temp;

                    listBoxFileNames.SelectedIndex = indexUp;
                }
            }
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            int indexSelect, indexDown;

            if (listBoxFileNames.SelectedIndex != -1)
            {
                indexSelect = listBoxFileNames.SelectedIndex;
                if (indexSelect + 1 <= listBoxFileNames.Items.Count - 1)
                {
                    indexDown = indexSelect + 1;

                    var temp = listBoxFileNames.Items[indexSelect];
                    listBoxFileNames.Items[indexSelect] = listBoxFileNames.Items[indexDown];
                    listBoxFileNames.Items[indexDown] = temp;

                    listBoxFileNames.SelectedIndex = indexDown;
                }
            }
        }

        #endregion
    }
}
