namespace ArduinoSerial.UI
{
    partial class ArduinoSerial
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            this.button1 = new System.Windows.Forms.Button();
            this.dataList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.dateField = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnShowLog = new System.Windows.Forms.Button();
            this.logBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbToDate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFromDate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Начать сеанс";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataList
            // 
            this.dataList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.dataList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.dataList.Location = new System.Drawing.Point(12, 129);
            this.dataList.Name = "dataList";
            this.dataList.Size = new System.Drawing.Size(583, 328);
            this.dataList.TabIndex = 2;
            this.dataList.UseCompatibleStateImageBehavior = false;
            this.dataList.View = System.Windows.Forms.View.Details;
            this.dataList.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Параметр";
            this.columnHeader1.Width = 255;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Значение";
            this.columnHeader2.Width = 255;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Дата:";
            // 
            // dateField
            // 
            this.dateField.AutoSize = true;
            this.dateField.Location = new System.Drawing.Point(287, 17);
            this.dateField.Name = "dateField";
            this.dateField.Size = new System.Drawing.Size(0, 13);
            this.dateField.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 41);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Завершить сеанс";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnShowLog
            // 
            this.btnShowLog.Location = new System.Drawing.Point(358, 100);
            this.btnShowLog.Name = "btnShowLog";
            this.btnShowLog.Size = new System.Drawing.Size(101, 23);
            this.btnShowLog.TabIndex = 6;
            this.btnShowLog.Text = "Показать";
            this.btnShowLog.UseVisualStyleBackColor = true;
            this.btnShowLog.Click += new System.EventHandler(this.btnShowLog_Click);
            // 
            // cmbToDate
            // 
            this.cmbToDate.DisplayMember = "Date";
            this.cmbToDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbToDate.FormattingEnabled = true;
            this.cmbToDate.Location = new System.Drawing.Point(460, 57);
            this.cmbToDate.Name = "cmbToDate";
            this.cmbToDate.Size = new System.Drawing.Size(135, 21);
            this.cmbToDate.TabIndex = 7;
            this.cmbToDate.ValueMember = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(457, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "До";
            // 
            // cmbFromDate
            // 
            this.cmbFromDate.DisplayMember = "Date";
            this.cmbFromDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFromDate.FormattingEnabled = true;
            this.cmbFromDate.Location = new System.Drawing.Point(237, 56);
            this.cmbFromDate.Name = "cmbFromDate";
            this.cmbFromDate.Size = new System.Drawing.Size(121, 21);
            this.cmbFromDate.TabIndex = 9;
            this.cmbFromDate.ValueMember = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "От";
            // 
            // ArduinoSerial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 469);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbFromDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbToDate);
            this.Controls.Add(this.btnShowLog);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dateField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataList);
            this.Controls.Add(this.button1);
            this.Name = "ArduinoSerial";
            this.Text = "ArduinoToCOM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ArduinoSerial_FormClosing);
            this.Load += new System.EventHandler(this.ArduinoSerial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView dataList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dateField;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnShowLog;
        private System.Windows.Forms.BindingSource logBindingSource;
        private System.Windows.Forms.BindingSource logBindingSource1;
        private System.Windows.Forms.ComboBox cmbToDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFromDate;
        private System.Windows.Forms.Label label3;
    }
}

