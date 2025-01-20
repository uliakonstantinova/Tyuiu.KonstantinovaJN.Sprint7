
namespace Tyuiu.KonstantinovaJN.Sprint7.Project.V11
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonOpenFile_KJN = new Button();
            panelFunc_KJN = new Panel();
            buttonOpenFormStatistic_KJN = new Button();
            buttonHelp_KJN = new Button();
            panelMain_KJN = new Panel();
            groupBox4 = new GroupBox();
            buttonLoadActorsByFilm_KJN = new Button();
            dataGridViewActors_KJN = new DataGridView();
            groupBox3 = new GroupBox();
            textBoxFilter_KJN = new TextBox();
            comboBoxFilter_KJN = new ComboBox();
            buttonSaveToFileFilms_KJN = new Button();
            dataGridViewFilms_KJN = new DataGridView();
            toolTipTop_KJN = new ToolTip(components);
            openFileDialogTask = new OpenFileDialog();
            saveFileDialogD = new SaveFileDialog();
            panelFunc_KJN.SuspendLayout();
            panelMain_KJN.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewActors_KJN).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFilms_KJN).BeginInit();
            SuspendLayout();
            // 
            // buttonOpenFile_KJN
            // 
            buttonOpenFile_KJN.BackColor = SystemColors.Control;
            buttonOpenFile_KJN.FlatStyle = FlatStyle.Flat;
            buttonOpenFile_KJN.Image = (Image)resources.GetObject("buttonOpenFile_KJN.Image");
            buttonOpenFile_KJN.Location = new Point(11, 11);
            buttonOpenFile_KJN.Name = "buttonOpenFile_KJN";
            buttonOpenFile_KJN.Size = new Size(68, 52);
            buttonOpenFile_KJN.TabIndex = 0;
            toolTipTop_KJN.SetToolTip(buttonOpenFile_KJN, "Открыть файл  \r\nОткрыть файл для обработки данных в формате CSV");
            buttonOpenFile_KJN.UseVisualStyleBackColor = false;
            buttonOpenFile_KJN.Click += buttonOpenFile_KJN_Click;
            // 
            // panelFunc_KJN
            // 
            panelFunc_KJN.BackColor = SystemColors.InactiveCaption;
            panelFunc_KJN.Controls.Add(buttonOpenFormStatistic_KJN);
            panelFunc_KJN.Controls.Add(buttonHelp_KJN);
            panelFunc_KJN.Controls.Add(buttonOpenFile_KJN);
            panelFunc_KJN.Dock = DockStyle.Top;
            panelFunc_KJN.Location = new Point(0, 0);
            panelFunc_KJN.Name = "panelFunc_KJN";
            panelFunc_KJN.Size = new Size(991, 75);
            panelFunc_KJN.TabIndex = 3;
            // 
            // buttonOpenFormStatistic_KJN
            // 
            buttonOpenFormStatistic_KJN.BackColor = SystemColors.Control;
            buttonOpenFormStatistic_KJN.FlatStyle = FlatStyle.Flat;
            buttonOpenFormStatistic_KJN.Image = (Image)resources.GetObject("buttonOpenFormStatistic_KJN.Image");
            buttonOpenFormStatistic_KJN.Location = new Point(85, 11);
            buttonOpenFormStatistic_KJN.Name = "buttonOpenFormStatistic_KJN";
            buttonOpenFormStatistic_KJN.Size = new Size(68, 52);
            buttonOpenFormStatistic_KJN.TabIndex = 4;
            toolTipTop_KJN.SetToolTip(buttonOpenFormStatistic_KJN, "Статистика\r\nОткрыть статистику");
            buttonOpenFormStatistic_KJN.UseVisualStyleBackColor = false;
            buttonOpenFormStatistic_KJN.Click += buttonOpenFormStatistic_KJN_Click;
            // 
            // buttonHelp_KJN
            // 
            buttonHelp_KJN.BackColor = SystemColors.Control;
            buttonHelp_KJN.FlatStyle = FlatStyle.Flat;
            buttonHelp_KJN.Image = (Image)resources.GetObject("buttonHelp_KJN.Image");
            buttonHelp_KJN.Location = new Point(911, 11);
            buttonHelp_KJN.Name = "buttonHelp_KJN";
            buttonHelp_KJN.Size = new Size(68, 52);
            buttonHelp_KJN.TabIndex = 3;
            toolTipTop_KJN.SetToolTip(buttonHelp_KJN, "Справка\r\nСведение о программе");
            buttonHelp_KJN.UseVisualStyleBackColor = false;
            buttonHelp_KJN.Click += buttonHelp_KJN_Click;
            // 
            // panelMain_KJN
            // 
            panelMain_KJN.BackColor = Color.Silver;
            panelMain_KJN.Controls.Add(groupBox4);
            panelMain_KJN.Controls.Add(groupBox3);
            panelMain_KJN.Location = new Point(-12, 70);
            panelMain_KJN.Name = "panelMain_KJN";
            panelMain_KJN.Size = new Size(1003, 475);
            panelMain_KJN.TabIndex = 5;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(buttonLoadActorsByFilm_KJN);
            groupBox4.Controls.Add(dataGridViewActors_KJN);
            groupBox4.Location = new Point(581, 7);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(419, 461);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Актеры:";
            // 
            // buttonLoadActorsByFilm_KJN
            // 
            buttonLoadActorsByFilm_KJN.BackColor = SystemColors.InactiveCaption;
            buttonLoadActorsByFilm_KJN.BackgroundImage = (Image)resources.GetObject("buttonLoadActorsByFilm_KJN.BackgroundImage");
            buttonLoadActorsByFilm_KJN.BackgroundImageLayout = ImageLayout.Zoom;
            buttonLoadActorsByFilm_KJN.FlatStyle = FlatStyle.Flat;
            buttonLoadActorsByFilm_KJN.Location = new Point(379, 424);
            buttonLoadActorsByFilm_KJN.Name = "buttonLoadActorsByFilm_KJN";
            buttonLoadActorsByFilm_KJN.Size = new Size(34, 31);
            buttonLoadActorsByFilm_KJN.TabIndex = 5;
            toolTipTop_KJN.SetToolTip(buttonLoadActorsByFilm_KJN, "Поиск актеров\r\nПоиск актеров по выбранному фильму ");
            buttonLoadActorsByFilm_KJN.UseVisualStyleBackColor = false;
            buttonLoadActorsByFilm_KJN.Click += buttonLoadActorsByFilm_KJN_Click;
            // 
            // dataGridViewActors_KJN
            // 
            dataGridViewActors_KJN.BackgroundColor = SystemColors.Control;
            dataGridViewActors_KJN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewActors_KJN.Location = new Point(6, 26);
            dataGridViewActors_KJN.Name = "dataGridViewActors_KJN";
            dataGridViewActors_KJN.RowHeadersVisible = false;
            dataGridViewActors_KJN.RowHeadersWidth = 51;
            dataGridViewActors_KJN.Size = new Size(407, 397);
            dataGridViewActors_KJN.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxFilter_KJN);
            groupBox3.Controls.Add(comboBoxFilter_KJN);
            groupBox3.Controls.Add(buttonSaveToFileFilms_KJN);
            groupBox3.Controls.Add(dataGridViewFilms_KJN);
            groupBox3.Location = new Point(23, 7);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(552, 461);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Фильмы:";
            // 
            // textBoxFilter_KJN
            // 
            textBoxFilter_KJN.Location = new Point(163, 424);
            textBoxFilter_KJN.Multiline = true;
            textBoxFilter_KJN.Name = "textBoxFilter_KJN";
            textBoxFilter_KJN.Size = new Size(83, 28);
            textBoxFilter_KJN.TabIndex = 5;
            textBoxFilter_KJN.TextChanged += textBoxFilter_KJN_TextChanged;
            // 
            // comboBoxFilter_KJN
            // 
            comboBoxFilter_KJN.FlatStyle = FlatStyle.Flat;
            comboBoxFilter_KJN.FormattingEnabled = true;
            comboBoxFilter_KJN.Items.AddRange(new object[] { "Год выхода", "Длительность", "Жанр" });
            comboBoxFilter_KJN.Location = new Point(6, 424);
            comboBoxFilter_KJN.Name = "comboBoxFilter_KJN";
            comboBoxFilter_KJN.Size = new Size(151, 28);
            comboBoxFilter_KJN.TabIndex = 4;
            // 
            // buttonSaveToFileFilms_KJN
            // 
            buttonSaveToFileFilms_KJN.BackColor = SystemColors.InactiveCaption;
            buttonSaveToFileFilms_KJN.BackgroundImage = (Image)resources.GetObject("buttonSaveToFileFilms_KJN.BackgroundImage");
            buttonSaveToFileFilms_KJN.BackgroundImageLayout = ImageLayout.Zoom;
            buttonSaveToFileFilms_KJN.FlatStyle = FlatStyle.Flat;
            buttonSaveToFileFilms_KJN.Location = new Point(512, 424);
            buttonSaveToFileFilms_KJN.Name = "buttonSaveToFileFilms_KJN";
            buttonSaveToFileFilms_KJN.Size = new Size(34, 31);
            buttonSaveToFileFilms_KJN.TabIndex = 4;
            toolTipTop_KJN.SetToolTip(buttonSaveToFileFilms_KJN, "Сохранить данные\r\nСохранить введенные данные в файл");
            buttonSaveToFileFilms_KJN.UseVisualStyleBackColor = false;
            buttonSaveToFileFilms_KJN.Click += buttonSaveToFileFilms_KJN_Click;
            // 
            // dataGridViewFilms_KJN
            // 
            dataGridViewFilms_KJN.BackgroundColor = SystemColors.Control;
            dataGridViewFilms_KJN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFilms_KJN.Location = new Point(6, 26);
            dataGridViewFilms_KJN.Name = "dataGridViewFilms_KJN";
            dataGridViewFilms_KJN.RowHeadersVisible = false;
            dataGridViewFilms_KJN.RowHeadersWidth = 51;
            dataGridViewFilms_KJN.Size = new Size(540, 397);
            dataGridViewFilms_KJN.TabIndex = 0;
            // 
            // toolTipTop_KJN
            // 
            toolTipTop_KJN.ToolTipIcon = ToolTipIcon.Info;
            toolTipTop_KJN.ToolTipTitle = "Подсказка";
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 544);
            Controls.Add(panelMain_KJN);
            Controls.Add(panelFunc_KJN);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Проект | Спринт 7 | Вариант 11 | Константинова Ю. Н.";
            panelFunc_KJN.ResumeLayout(false);
            panelMain_KJN.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewActors_KJN).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFilms_KJN).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOpenFile_KJN;
        private Panel panelFunc_KJN;
        private Button buttonHelp_KJN;
        private Panel panelMain_KJN;
        private DataGridView dataGridViewFilms_KJN;
        private GroupBox groupBox3;
        private ToolTip toolTipTop_KJN;
        private OpenFileDialog openFileDialogTask;
        private SaveFileDialog saveFileDialogD;
        private Button buttonSaveToFileFilms_KJN;
        private ComboBox comboBoxFilter_KJN;
        private TextBox textBoxFilter_KJN;
        private Button buttonOpenFormStatistic_KJN;
        private GroupBox groupBox4;
        private Button buttonLoadActorsByFilm_KJN;
        private DataGridView dataGridViewActors_KJN;
    }
}
