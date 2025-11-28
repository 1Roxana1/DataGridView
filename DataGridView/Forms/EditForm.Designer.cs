namespace DataGridViewProject.Forms
{
    partial class EditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            buttonSave = new System.Windows.Forms.Button();
            panelTop = new System.Windows.Forms.Panel();
            labelTitle = new System.Windows.Forms.Label();
            labelFullName = new System.Windows.Forms.Label();
            labelGender = new System.Windows.Forms.Label();
            labelBirthDate = new System.Windows.Forms.Label();
            labelFormEducation = new System.Windows.Forms.Label();
            labelMathScore = new System.Windows.Forms.Label();
            labelRussianScore = new System.Windows.Forms.Label();
            labelInformaticsScore = new System.Windows.Forms.Label();
            textBoxFullName = new System.Windows.Forms.TextBox();
            comboBoxGender = new System.Windows.Forms.ComboBox();
            errorProvider = new System.Windows.Forms.ErrorProvider(components);
            comboBoxFormEducation = new System.Windows.Forms.ComboBox();
            numericUpDownMath = new System.Windows.Forms.NumericUpDown();
            numericUpDownRussian = new System.Windows.Forms.NumericUpDown();
            numericUpDownInformatics = new System.Windows.Forms.NumericUpDown();
            birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMath).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRussian).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownInformatics).BeginInit();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            buttonSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            buttonSave.Location = new System.Drawing.Point(0, 307);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(330, 23);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Сохранить";
            buttonSave.Click += btnSave_Click;
            // 
            // panelTop
            // 
            panelTop.BackColor = System.Drawing.Color.PaleGreen;
            panelTop.Controls.Add(labelTitle);
            panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            panelTop.Location = new System.Drawing.Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new System.Drawing.Size(330, 40);
            panelTop.TabIndex = 1;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            labelTitle.Location = new System.Drawing.Point(20, 10);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new System.Drawing.Size(289, 19);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Добавить / Редактировать абитуриента";
            // 
            // labelFullName
            // 
            labelFullName.Location = new System.Drawing.Point(20, 60);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new System.Drawing.Size(100, 23);
            labelFullName.TabIndex = 2;
            labelFullName.Text = "ФИО:";
            // 
            // labelGender
            // 
            labelGender.Location = new System.Drawing.Point(20, 95);
            labelGender.Name = "labelGender";
            labelGender.Size = new System.Drawing.Size(100, 23);
            labelGender.TabIndex = 4;
            labelGender.Text = "Пол:";
            // 
            // labelBirthDate
            // 
            labelBirthDate.Location = new System.Drawing.Point(20, 130);
            labelBirthDate.Name = "labelBirthDate";
            labelBirthDate.Size = new System.Drawing.Size(100, 23);
            labelBirthDate.TabIndex = 6;
            labelBirthDate.Text = "Дата рождения:";
            // 
            // labelFormEducation
            // 
            labelFormEducation.Location = new System.Drawing.Point(20, 165);
            labelFormEducation.Name = "labelFormEducation";
            labelFormEducation.Size = new System.Drawing.Size(100, 23);
            labelFormEducation.TabIndex = 8;
            labelFormEducation.Text = "Форма обучения:";
            // 
            // labelMathScore
            // 
            labelMathScore.Location = new System.Drawing.Point(20, 200);
            labelMathScore.Name = "labelMathScore";
            labelMathScore.Size = new System.Drawing.Size(100, 23);
            labelMathScore.TabIndex = 10;
            labelMathScore.Text = "ЕГЭ Математика:";
            // 
            // labelRussianScore
            // 
            labelRussianScore.Location = new System.Drawing.Point(20, 235);
            labelRussianScore.Name = "labelRussianScore";
            labelRussianScore.Size = new System.Drawing.Size(100, 23);
            labelRussianScore.TabIndex = 12;
            labelRussianScore.Text = "ЕГЭ Русский:";
            // 
            // labelInformaticsScore
            // 
            labelInformaticsScore.Location = new System.Drawing.Point(20, 270);
            labelInformaticsScore.Name = "labelInformaticsScore";
            labelInformaticsScore.Size = new System.Drawing.Size(100, 23);
            labelInformaticsScore.TabIndex = 14;
            labelInformaticsScore.Text = "ЕГЭ Информатика:";
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new System.Drawing.Point(150, 60);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new System.Drawing.Size(150, 23);
            textBoxFullName.TabIndex = 3;
            // 
            // comboBoxGender
            // 
            comboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxGender.Location = new System.Drawing.Point(150, 95);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new System.Drawing.Size(150, 23);
            comboBoxGender.TabIndex = 5;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // comboBoxFormEducation
            // 
            comboBoxFormEducation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxFormEducation.Location = new System.Drawing.Point(150, 165);
            comboBoxFormEducation.Name = "comboBoxFormEducation";
            comboBoxFormEducation.Size = new System.Drawing.Size(150, 23);
            comboBoxFormEducation.TabIndex = 9;
            // 
            // numericUpDownMath
            // 
            numericUpDownMath.Location = new System.Drawing.Point(150, 200);
            numericUpDownMath.Name = "numericUpDownMath";
            numericUpDownMath.Size = new System.Drawing.Size(60, 23);
            numericUpDownMath.TabIndex = 11;
            // 
            // numericUpDownRussian
            // 
            numericUpDownRussian.Location = new System.Drawing.Point(150, 235);
            numericUpDownRussian.Name = "numericUpDownRussian";
            numericUpDownRussian.Size = new System.Drawing.Size(60, 23);
            numericUpDownRussian.TabIndex = 13;
            // 
            // numericUpDownInformatics
            // 
            numericUpDownInformatics.Location = new System.Drawing.Point(150, 270);
            numericUpDownInformatics.Name = "numericUpDownInformatics";
            numericUpDownInformatics.Size = new System.Drawing.Size(60, 23);
            numericUpDownInformatics.TabIndex = 15;
            // 
            // birthdayDateTimePicker
            // 
            birthdayDateTimePicker.Location = new System.Drawing.Point(150, 130);
            birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            birthdayDateTimePicker.Size = new System.Drawing.Size(150, 23);
            birthdayDateTimePicker.TabIndex = 16;
            birthdayDateTimePicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // EditForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(330, 330);
            Controls.Add(birthdayDateTimePicker);
            Controls.Add(buttonSave);
            Controls.Add(panelTop);
            Controls.Add(labelFullName);
            Controls.Add(textBoxFullName);
            Controls.Add(labelGender);
            Controls.Add(comboBoxGender);
            Controls.Add(labelBirthDate);
            Controls.Add(labelFormEducation);
            Controls.Add(comboBoxFormEducation);
            Controls.Add(labelMathScore);
            Controls.Add(numericUpDownMath);
            Controls.Add(labelRussianScore);
            Controls.Add(numericUpDownRussian);
            Controls.Add(labelInformaticsScore);
            Controls.Add(numericUpDownInformatics);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Добавить / Редактировать абитуриента";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMath).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRussian).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownInformatics).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private Panel panelTop;
        private Label labelTitle;
        private Label labelFullName;
        private Label labelGender;
        private Label labelBirthDate;
        private Label labelFormEducation;
        private Label labelMathScore;
        private Label labelRussianScore;
        private Label labelInformaticsScore;

        private TextBox textBoxFullName;
        private ComboBox comboBoxGender;
        private ComboBox comboBoxFormEducation;
        private NumericUpDown numericUpDownMath;
        private NumericUpDown numericUpDownRussian;
        private NumericUpDown numericUpDownInformatics;

        private ErrorProvider errorProvider;
        private System.Windows.Forms.DateTimePicker birthdayDateTimePicker;
    }
}