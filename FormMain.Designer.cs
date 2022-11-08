namespace MACD_4lab
{
    partial class FormMain
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
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.panelDate = new System.Windows.Forms.Panel();
            this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxString = new System.Windows.Forms.TextBox();
            this.labelString = new System.Windows.Forms.Label();
            this.buttonToString = new System.Windows.Forms.Button();
            this.buttonToDate = new System.Windows.Forms.Button();
            this.labelType = new System.Windows.Forms.Label();
            this.groupBoxFormat = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.comboBoxOperator = new System.Windows.Forms.ComboBox();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.buttonOk = new System.Windows.Forms.Button();
            this.comboBoxElement = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.dateTimePickerPlus = new System.Windows.Forms.DateTimePicker();
            this.panelDate.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxFormat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDate.Location = new System.Drawing.Point(12, 52);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(167, 25);
            this.dateTimePickerDate.TabIndex = 0;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDate.Location = new System.Drawing.Point(113, 9);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(66, 34);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "Date";
            // 
            // panelDate
            // 
            this.panelDate.BackColor = System.Drawing.Color.Ivory;
            this.panelDate.Controls.Add(this.dateTimePickerTime);
            this.panelDate.Controls.Add(this.dateTimePickerDate);
            this.panelDate.Controls.Add(this.labelDate);
            this.panelDate.Location = new System.Drawing.Point(12, 12);
            this.panelDate.Name = "panelDate";
            this.panelDate.Size = new System.Drawing.Size(288, 89);
            this.panelDate.TabIndex = 2;
            // 
            // dateTimePickerTime
            // 
            this.dateTimePickerTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerTime.Location = new System.Drawing.Point(185, 52);
            this.dateTimePickerTime.Name = "dateTimePickerTime";
            this.dateTimePickerTime.ShowUpDown = true;
            this.dateTimePickerTime.Size = new System.Drawing.Size(90, 25);
            this.dateTimePickerTime.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Ivory;
            this.panel1.Controls.Add(this.textBoxString);
            this.panel1.Controls.Add(this.labelString);
            this.panel1.Location = new System.Drawing.Point(498, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 89);
            this.panel1.TabIndex = 3;
            // 
            // textBoxString
            // 
            this.textBoxString.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxString.Location = new System.Drawing.Point(13, 52);
            this.textBoxString.Name = "textBoxString";
            this.textBoxString.Size = new System.Drawing.Size(263, 25);
            this.textBoxString.TabIndex = 2;
            this.textBoxString.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelString
            // 
            this.labelString.AutoSize = true;
            this.labelString.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelString.Location = new System.Drawing.Point(104, 9);
            this.labelString.Name = "labelString";
            this.labelString.Size = new System.Drawing.Size(82, 34);
            this.labelString.TabIndex = 1;
            this.labelString.Text = "String";
            // 
            // buttonToString
            // 
            this.buttonToString.BackColor = System.Drawing.Color.MistyRose;
            this.buttonToString.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonToString.Location = new System.Drawing.Point(306, 12);
            this.buttonToString.Name = "buttonToString";
            this.buttonToString.Size = new System.Drawing.Size(186, 33);
            this.buttonToString.TabIndex = 4;
            this.buttonToString.Text = "----->";
            this.buttonToString.UseVisualStyleBackColor = false;
            this.buttonToString.Click += new System.EventHandler(this.buttonToString_Click);
            // 
            // buttonToDate
            // 
            this.buttonToDate.BackColor = System.Drawing.Color.MistyRose;
            this.buttonToDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonToDate.Location = new System.Drawing.Point(306, 68);
            this.buttonToDate.Name = "buttonToDate";
            this.buttonToDate.Size = new System.Drawing.Size(186, 33);
            this.buttonToDate.TabIndex = 5;
            this.buttonToDate.Text = "<-----";
            this.buttonToDate.UseVisualStyleBackColor = false;
            this.buttonToDate.Click += new System.EventHandler(this.buttonToDate_Click);
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelType.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelType.Location = new System.Drawing.Point(315, 48);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(167, 17);
            this.labelType.TabIndex = 6;
            this.labelType.Text = "(перевод типов данных)";
            // 
            // groupBoxFormat
            // 
            this.groupBoxFormat.BackColor = System.Drawing.SystemColors.Info;
            this.groupBoxFormat.Controls.Add(this.radioButton5);
            this.groupBoxFormat.Controls.Add(this.radioButton3);
            this.groupBoxFormat.Controls.Add(this.radioButton4);
            this.groupBoxFormat.Controls.Add(this.radioButton2);
            this.groupBoxFormat.Controls.Add(this.radioButton1);
            this.groupBoxFormat.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxFormat.Location = new System.Drawing.Point(498, 110);
            this.groupBoxFormat.Name = "groupBoxFormat";
            this.groupBoxFormat.Size = new System.Drawing.Size(186, 155);
            this.groupBoxFormat.TabIndex = 7;
            this.groupBoxFormat.TabStop = false;
            this.groupBoxFormat.Text = "Формат даты";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(12, 128);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(69, 21);
            this.radioButton5.TabIndex = 12;
            this.radioButton5.Text = "hh:mm";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(12, 74);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(120, 21);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.Text = "DD MM YYYY г.";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(12, 101);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(84, 21);
            this.radioButton4.TabIndex = 10;
            this.radioButton4.Text = "hh:mm:ss";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(12, 49);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(105, 21);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "DD.MM.YYYY";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(167, 21);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.Text = "DD.MM.YYYY hh:mm:ss";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // comboBoxOperator
            // 
            this.comboBoxOperator.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxOperator.FormattingEnabled = true;
            this.comboBoxOperator.Location = new System.Drawing.Point(12, 193);
            this.comboBoxOperator.Name = "comboBoxOperator";
            this.comboBoxOperator.Size = new System.Drawing.Size(40, 25);
            this.comboBoxOperator.TabIndex = 8;
            // 
            // numericUpDown
            // 
            this.numericUpDown.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown.Location = new System.Drawing.Point(69, 193);
            this.numericUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(57, 25);
            this.numericUpDown.TabIndex = 9;
            this.numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.Color.MistyRose;
            this.buttonOk.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOk.Location = new System.Drawing.Point(12, 224);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(288, 43);
            this.buttonOk.TabIndex = 10;
            this.buttonOk.Text = "ОК";
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // comboBoxElement
            // 
            this.comboBoxElement.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxElement.FormattingEnabled = true;
            this.comboBoxElement.Location = new System.Drawing.Point(142, 193);
            this.comboBoxElement.Name = "comboBoxElement";
            this.comboBoxElement.Size = new System.Drawing.Size(158, 25);
            this.comboBoxElement.TabIndex = 11;
            this.comboBoxElement.SelectedIndexChanged += new System.EventHandler(this.comboBoxElement_SelectedIndexChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.MistyRose;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.Location = new System.Drawing.Point(690, 224);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(96, 43);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Выйти";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.MistyRose;
            this.buttonClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClear.Location = new System.Drawing.Point(690, 175);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(96, 43);
            this.buttonClear.TabIndex = 13;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // dateTimePickerPlus
            // 
            this.dateTimePickerPlus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerPlus.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerPlus.Location = new System.Drawing.Point(142, 162);
            this.dateTimePickerPlus.Name = "dateTimePickerPlus";
            this.dateTimePickerPlus.ShowUpDown = true;
            this.dateTimePickerPlus.Size = new System.Drawing.Size(158, 25);
            this.dateTimePickerPlus.TabIndex = 14;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(793, 272);
            this.Controls.Add(this.dateTimePickerPlus);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.comboBoxElement);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.comboBoxOperator);
            this.Controls.Add(this.groupBoxFormat);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.buttonToDate);
            this.Controls.Add(this.buttonToString);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDate);
            this.Name = "FormMain";
            this.Text = "Блог Анаталия Борисовича Шамшева";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelDate.ResumeLayout(false);
            this.panelDate.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxFormat.ResumeLayout(false);
            this.groupBoxFormat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dateTimePickerDate;
        private Label labelDate;
        private Panel panelDate;
        private Panel panel1;
        private TextBox textBoxString;
        private Label labelString;
        private Button buttonToString;
        private Button buttonToDate;
        private Label labelType;
        private GroupBox groupBoxFormat;
        private RadioButton radioButton5;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private DateTimePicker dateTimePickerTime;
        private ComboBox comboBoxOperator;
        private NumericUpDown numericUpDown;
        private Button buttonOk;
        private ComboBox comboBoxElement;
        private Button buttonCancel;
        private Button buttonClear;
        private DateTimePicker dateTimePickerPlus;
    }
}