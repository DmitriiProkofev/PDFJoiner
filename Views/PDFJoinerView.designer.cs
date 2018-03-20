namespace PDFJoiner.Views
{
    partial class PDFJoinerView
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonClearFiles = new System.Windows.Forms.Button();
            this.buttonDowloadFiles = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBoxFileNames = new System.Windows.Forms.ListBox();
            this.buttonJoinFiles = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 362);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 362F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 362F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(546, 362);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // buttonClearFiles
            // 
            this.buttonClearFiles.Font = new System.Drawing.Font("Arial", 9F);
            this.buttonClearFiles.Location = new System.Drawing.Point(8, 60);
            this.buttonClearFiles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonClearFiles.Name = "buttonClearFiles";
            this.buttonClearFiles.Size = new System.Drawing.Size(110, 43);
            this.buttonClearFiles.TabIndex = 1;
            this.buttonClearFiles.Text = "Очистить";
            this.buttonClearFiles.UseVisualStyleBackColor = true;
            this.buttonClearFiles.Click += new System.EventHandler(this.buttonClearFiles_Click);
            // 
            // buttonDowloadFiles
            // 
            this.buttonDowloadFiles.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDowloadFiles.Location = new System.Drawing.Point(8, 9);
            this.buttonDowloadFiles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDowloadFiles.Name = "buttonDowloadFiles";
            this.buttonDowloadFiles.Size = new System.Drawing.Size(110, 43);
            this.buttonDowloadFiles.TabIndex = 0;
            this.buttonDowloadFiles.Text = "Загрузить";
            this.buttonDowloadFiles.UseVisualStyleBackColor = true;
            this.buttonDowloadFiles.Click += new System.EventHandler(this.buttonDowloadFiles_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 354);
            this.panel2.TabIndex = 1;
            // 
            // listBoxFileNames
            // 
            this.listBoxFileNames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxFileNames.Font = new System.Drawing.Font("Arial", 9F);
            this.listBoxFileNames.FormattingEnabled = true;
            this.listBoxFileNames.HorizontalScrollbar = true;
            this.listBoxFileNames.ItemHeight = 17;
            this.listBoxFileNames.Location = new System.Drawing.Point(3, 4);
            this.listBoxFileNames.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.listBoxFileNames.Name = "listBoxFileNames";
            this.listBoxFileNames.Size = new System.Drawing.Size(401, 300);
            this.listBoxFileNames.TabIndex = 2;
            // 
            // buttonJoinFiles
            // 
            this.buttonJoinFiles.Font = new System.Drawing.Font("Arial", 9F);
            this.buttonJoinFiles.Location = new System.Drawing.Point(8, 135);
            this.buttonJoinFiles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonJoinFiles.Name = "buttonJoinFiles";
            this.buttonJoinFiles.Size = new System.Drawing.Size(110, 43);
            this.buttonJoinFiles.TabIndex = 3;
            this.buttonJoinFiles.Text = "Объединить";
            this.buttonJoinFiles.UseVisualStyleBackColor = true;
            this.buttonJoinFiles.Click += new System.EventHandler(this.buttonJoinFiles_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonDowloadFiles);
            this.panel3.Controls.Add(this.buttonClearFiles);
            this.panel3.Controls.Add(this.buttonJoinFiles);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(416, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(127, 354);
            this.panel3.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.listBoxFileNames, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(407, 354);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonDown);
            this.panel4.Controls.Add(this.buttonUp);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 307);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(401, 44);
            this.panel4.TabIndex = 3;
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(6, 10);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(75, 29);
            this.buttonUp.TabIndex = 0;
            this.buttonUp.Text = "вверх";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(87, 10);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(75, 29);
            this.buttonDown.TabIndex = 1;
            this.buttonDown.Text = "вниз";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // PDFJoinerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 362);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PDFJoinerView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDFJoiner";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PDFJoinerView_FormClosed);
            this.Load += new System.EventHandler(this.PDFJoinerView_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBoxFileNames;
        private System.Windows.Forms.Button buttonJoinFiles;
        private System.Windows.Forms.Button buttonClearFiles;
        private System.Windows.Forms.Button buttonDowloadFiles;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
    }
}

