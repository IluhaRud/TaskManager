namespace Tasks
{
    partial class MainForm
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
            this.LastNameInput = new System.Windows.Forms.TextBox();
            this.LabelAddNote = new System.Windows.Forms.Label();
            this.phoneInput = new System.Windows.Forms.TextBox();
            this.descriptionInput = new System.Windows.Forms.TextBox();
            this.titleInput = new System.Windows.Forms.TextBox();
            this.buttonAddNote = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.DeleteNoteButton = new System.Windows.Forms.Button();
            this.EditingNoteButton = new System.Windows.Forms.Button();
            this.SaveNotesInFileButton = new System.Windows.Forms.Button();
            this.FileLoadDialog = new System.Windows.Forms.OpenFileDialog();
            this.OpenDilogLoadFileButton = new System.Windows.Forms.Button();
            this.DateFrom = new System.Windows.Forms.DateTimePicker();
            this.DateTo = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ImportButton = new System.Windows.Forms.Button();
            this.ImportFieldButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // LastNameInput
            // 
            this.LastNameInput.Location = new System.Drawing.Point(26, 114);
            this.LastNameInput.Margin = new System.Windows.Forms.Padding(2, 26, 2, 2);
            this.LastNameInput.Multiline = true;
            this.LastNameInput.Name = "LastNameInput";
            this.LastNameInput.Size = new System.Drawing.Size(174, 25);
            this.LastNameInput.TabIndex = 0;
            // 
            // LabelAddNote
            // 
            this.LabelAddNote.AutoSize = true;
            this.LabelAddNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAddNote.Location = new System.Drawing.Point(55, 77);
            this.LabelAddNote.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelAddNote.Name = "LabelAddNote";
            this.LabelAddNote.Size = new System.Drawing.Size(121, 17);
            this.LabelAddNote.TabIndex = 4;
            this.LabelAddNote.Text = "Добавить запись";
            // 
            // phoneInput
            // 
            this.phoneInput.Location = new System.Drawing.Point(26, 295);
            this.phoneInput.Margin = new System.Windows.Forms.Padding(2);
            this.phoneInput.Multiline = true;
            this.phoneInput.Name = "phoneInput";
            this.phoneInput.Size = new System.Drawing.Size(174, 25);
            this.phoneInput.TabIndex = 5;
            // 
            // descriptionInput
            // 
            this.descriptionInput.Location = new System.Drawing.Point(26, 193);
            this.descriptionInput.Margin = new System.Windows.Forms.Padding(2);
            this.descriptionInput.Multiline = true;
            this.descriptionInput.Name = "descriptionInput";
            this.descriptionInput.Size = new System.Drawing.Size(174, 86);
            this.descriptionInput.TabIndex = 6;
            // 
            // titleInput
            // 
            this.titleInput.Location = new System.Drawing.Point(26, 154);
            this.titleInput.Margin = new System.Windows.Forms.Padding(2);
            this.titleInput.Multiline = true;
            this.titleInput.Name = "titleInput";
            this.titleInput.Size = new System.Drawing.Size(174, 25);
            this.titleInput.TabIndex = 7;
            // 
            // buttonAddNote
            // 
            this.buttonAddNote.Location = new System.Drawing.Point(26, 340);
            this.buttonAddNote.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddNote.Name = "buttonAddNote";
            this.buttonAddNote.Size = new System.Drawing.Size(172, 46);
            this.buttonAddNote.TabIndex = 8;
            this.buttonAddNote.Text = "Добавить запись";
            this.buttonAddNote.UseVisualStyleBackColor = true;
            this.buttonAddNote.Click += new System.EventHandler(this.buttonAddNote_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(90, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 7);
            this.label1.TabIndex = 9;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(88, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 7);
            this.label2.TabIndex = 10;
            this.label2.Text = "Заголовок";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(81, 280);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 7);
            this.label3.TabIndex = 11;
            this.label3.Text = "Описание задачи";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(80, 322);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 7);
            this.label4.TabIndex = 12;
            this.label4.Text = "Номер телефона";
            // 
            // DataGrid
            // 
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDate,
            this.ColumnLastName,
            this.ColumnTitle,
            this.ColumnDescription,
            this.ColumnPhone});
            this.DataGrid.Location = new System.Drawing.Point(238, 114);
            this.DataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.RowHeadersWidth = 51;
            this.DataGrid.RowTemplate.Height = 24;
            this.DataGrid.Size = new System.Drawing.Size(556, 206);
            this.DataGrid.TabIndex = 13;
            // 
            // ColumnDate
            // 
            this.ColumnDate.HeaderText = "Дата";
            this.ColumnDate.MinimumWidth = 6;
            this.ColumnDate.Name = "ColumnDate";
            this.ColumnDate.Width = 125;
            // 
            // ColumnLastName
            // 
            this.ColumnLastName.HeaderText = "Фамилия";
            this.ColumnLastName.MinimumWidth = 6;
            this.ColumnLastName.Name = "ColumnLastName";
            this.ColumnLastName.Width = 125;
            // 
            // ColumnTitle
            // 
            this.ColumnTitle.HeaderText = "Заголовок";
            this.ColumnTitle.MinimumWidth = 6;
            this.ColumnTitle.Name = "ColumnTitle";
            this.ColumnTitle.Width = 125;
            // 
            // ColumnDescription
            // 
            this.ColumnDescription.HeaderText = "Описание задачи";
            this.ColumnDescription.MinimumWidth = 6;
            this.ColumnDescription.Name = "ColumnDescription";
            this.ColumnDescription.Width = 125;
            // 
            // ColumnPhone
            // 
            this.ColumnPhone.HeaderText = "Номер телефона";
            this.ColumnPhone.MinimumWidth = 6;
            this.ColumnPhone.Name = "ColumnPhone";
            this.ColumnPhone.Width = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(469, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Список задач";
            // 
            // DeleteNoteButton
            // 
            this.DeleteNoteButton.Location = new System.Drawing.Point(706, 340);
            this.DeleteNoteButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteNoteButton.Name = "DeleteNoteButton";
            this.DeleteNoteButton.Size = new System.Drawing.Size(88, 46);
            this.DeleteNoteButton.TabIndex = 15;
            this.DeleteNoteButton.Text = "Удалить запись";
            this.DeleteNoteButton.UseVisualStyleBackColor = true;
            this.DeleteNoteButton.Click += new System.EventHandler(this.DeleteNoteButton_Click);
            // 
            // EditingNoteButton
            // 
            this.EditingNoteButton.Location = new System.Drawing.Point(238, 340);
            this.EditingNoteButton.Margin = new System.Windows.Forms.Padding(2);
            this.EditingNoteButton.Name = "EditingNoteButton";
            this.EditingNoteButton.Size = new System.Drawing.Size(110, 46);
            this.EditingNoteButton.TabIndex = 16;
            this.EditingNoteButton.Text = "Редактировать запись";
            this.EditingNoteButton.UseVisualStyleBackColor = true;
            this.EditingNoteButton.Click += new System.EventHandler(this.EditingNoteButton_Click);
            // 
            // SaveNotesInFileButton
            // 
            this.SaveNotesInFileButton.Location = new System.Drawing.Point(361, 340);
            this.SaveNotesInFileButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveNotesInFileButton.Name = "SaveNotesInFileButton";
            this.SaveNotesInFileButton.Size = new System.Drawing.Size(112, 46);
            this.SaveNotesInFileButton.TabIndex = 17;
            this.SaveNotesInFileButton.Text = "Сохранить записи";
            this.SaveNotesInFileButton.UseVisualStyleBackColor = true;
            this.SaveNotesInFileButton.Click += new System.EventHandler(this.SaveNotesInFileButton_Click);
            // 
            // FileLoadDialog
            // 
            this.FileLoadDialog.FileName = "FileLoadDialog";
            // 
            // OpenDilogLoadFileButton
            // 
            this.OpenDilogLoadFileButton.Location = new System.Drawing.Point(482, 340);
            this.OpenDilogLoadFileButton.Margin = new System.Windows.Forms.Padding(2);
            this.OpenDilogLoadFileButton.Name = "OpenDilogLoadFileButton";
            this.OpenDilogLoadFileButton.Size = new System.Drawing.Size(103, 46);
            this.OpenDilogLoadFileButton.TabIndex = 18;
            this.OpenDilogLoadFileButton.Text = "Загрузить записи";
            this.OpenDilogLoadFileButton.UseVisualStyleBackColor = true;
            this.OpenDilogLoadFileButton.Click += new System.EventHandler(this.OpenDilogLoadFileButton_Click);
            // 
            // DateFrom
            // 
            this.DateFrom.Location = new System.Drawing.Point(350, 77);
            this.DateFrom.Margin = new System.Windows.Forms.Padding(2);
            this.DateFrom.Name = "DateFrom";
            this.DateFrom.Size = new System.Drawing.Size(151, 22);
            this.DateFrom.TabIndex = 19;
            // 
            // DateTo
            // 
            this.DateTo.Location = new System.Drawing.Point(546, 77);
            this.DateTo.Margin = new System.Windows.Forms.Padding(2);
            this.DateTo.Name = "DateTo";
            this.DateTo.Size = new System.Drawing.Size(151, 22);
            this.DateTo.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 80);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Импорт записей с";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(514, 81);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "по";
            // 
            // ImportButton
            // 
            this.ImportButton.Location = new System.Drawing.Point(712, 72);
            this.ImportButton.Margin = new System.Windows.Forms.Padding(2);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(81, 27);
            this.ImportButton.TabIndex = 23;
            this.ImportButton.Text = "Импорт";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // ImportFieldButton
            // 
            this.ImportFieldButton.Location = new System.Drawing.Point(596, 340);
            this.ImportFieldButton.Margin = new System.Windows.Forms.Padding(2);
            this.ImportFieldButton.Name = "ImportFieldButton";
            this.ImportFieldButton.Size = new System.Drawing.Size(100, 46);
            this.ImportFieldButton.TabIndex = 24;
            this.ImportFieldButton.Text = "Импорт по полю";
            this.ImportFieldButton.UseVisualStyleBackColor = true;
            this.ImportFieldButton.Click += new System.EventHandler(this.ImportFieldButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(712, 10);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(2);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(81, 51);
            this.RefreshButton.TabIndex = 25;
            this.RefreshButton.Text = "Обновить список задач";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 473);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.ImportFieldButton);
            this.Controls.Add(this.ImportButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DateTo);
            this.Controls.Add(this.DateFrom);
            this.Controls.Add(this.OpenDilogLoadFileButton);
            this.Controls.Add(this.SaveNotesInFileButton);
            this.Controls.Add(this.EditingNoteButton);
            this.Controls.Add(this.DeleteNoteButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddNote);
            this.Controls.Add(this.titleInput);
            this.Controls.Add(this.descriptionInput);
            this.Controls.Add(this.phoneInput);
            this.Controls.Add(this.LabelAddNote);
            this.Controls.Add(this.LastNameInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Планировщик задач";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelAddNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button DeleteNoteButton;
        private System.Windows.Forms.Button EditingNoteButton;
        private System.Windows.Forms.Button SaveNotesInFileButton;
        private System.Windows.Forms.OpenFileDialog FileLoadDialog;
        private System.Windows.Forms.Button OpenDilogLoadFileButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Button ImportFieldButton;
        private System.Windows.Forms.Button RefreshButton;
        public System.Windows.Forms.DataGridView DataGrid;
        public System.Windows.Forms.TextBox LastNameInput;
        public System.Windows.Forms.TextBox phoneInput;
        public System.Windows.Forms.TextBox descriptionInput;
        public System.Windows.Forms.TextBox titleInput;
        public System.Windows.Forms.Button buttonAddNote;
        public System.Windows.Forms.DateTimePicker DateFrom;
        public System.Windows.Forms.DateTimePicker DateTo;
    }
}

