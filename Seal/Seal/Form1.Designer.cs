namespace Seal
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
            this.components = new System.ComponentModel.Container();
            this.panelReport = new System.Windows.Forms.Panel();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.checkBoxId = new System.Windows.Forms.CheckBox();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxPlace = new System.Windows.Forms.TextBox();
            this.checkBoxTime = new System.Windows.Forms.CheckBox();
            this.checkBoxNumber = new System.Windows.Forms.CheckBox();
            this.checkBoxPlace = new System.Windows.Forms.CheckBox();
            this.checkedListBoxReports = new System.Windows.Forms.CheckedListBox();
            this.buttonRepport = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.діїЗПломбамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.формуванняЗвітівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.основніДіїЗПломбамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelSeals = new System.Windows.Forms.Panel();
            this.textBoxSMan = new System.Windows.Forms.TextBox();
            this.checkBoxSMan = new System.Windows.Forms.CheckBox();
            this.textBoxSTime = new System.Windows.Forms.TextBox();
            this.textBoxSNumber = new System.Windows.Forms.TextBox();
            this.textBoxSPlace = new System.Windows.Forms.TextBox();
            this.checkBoxSTime = new System.Windows.Forms.CheckBox();
            this.checkBoxSNumber = new System.Windows.Forms.CheckBox();
            this.checkBoxSPlace = new System.Windows.Forms.CheckBox();
            this.buttonSeals = new System.Windows.Forms.Button();
            this.checkedListBoxSeals = new System.Windows.Forms.CheckedListBox();
            this.checkBoxDiapazon = new System.Windows.Forms.CheckBox();
            this.textBoxDiap1 = new System.Windows.Forms.TextBox();
            this.textBoxDiap2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelData = new System.Windows.Forms.Panel();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panelReport.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelSeals.SuspendLayout();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelReport
            // 
            this.panelReport.Controls.Add(this.textBoxId);
            this.panelReport.Controls.Add(this.checkBoxId);
            this.panelReport.Controls.Add(this.textBoxTime);
            this.panelReport.Controls.Add(this.textBoxNumber);
            this.panelReport.Controls.Add(this.textBoxPlace);
            this.panelReport.Controls.Add(this.checkBoxTime);
            this.panelReport.Controls.Add(this.checkBoxNumber);
            this.panelReport.Controls.Add(this.checkBoxPlace);
            this.panelReport.Controls.Add(this.checkedListBoxReports);
            this.panelReport.Controls.Add(this.buttonRepport);
            this.panelReport.Location = new System.Drawing.Point(72, 62);
            this.panelReport.Name = "panelReport";
            this.panelReport.Size = new System.Drawing.Size(608, 286);
            this.panelReport.TabIndex = 0;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(434, 106);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 22);
            this.textBoxId.TabIndex = 9;
            this.textBoxId.Visible = false;
            // 
            // checkBoxId
            // 
            this.checkBoxId.AutoSize = true;
            this.checkBoxId.Location = new System.Drawing.Point(318, 107);
            this.checkBoxId.Name = "checkBoxId";
            this.checkBoxId.Size = new System.Drawing.Size(79, 21);
            this.checkBoxId.TabIndex = 8;
            this.checkBoxId.Text = "По айді";
            this.checkBoxId.UseVisualStyleBackColor = true;
            this.checkBoxId.CheckedChanged += new System.EventHandler(this.CheckBoxId_CheckedChanged);
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(434, 78);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(100, 22);
            this.textBoxTime.TabIndex = 7;
            this.textBoxTime.Visible = false;
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(434, 50);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(100, 22);
            this.textBoxNumber.TabIndex = 6;
            this.textBoxNumber.Visible = false;
            // 
            // textBoxPlace
            // 
            this.textBoxPlace.Location = new System.Drawing.Point(434, 22);
            this.textBoxPlace.Name = "textBoxPlace";
            this.textBoxPlace.Size = new System.Drawing.Size(100, 22);
            this.textBoxPlace.TabIndex = 5;
            this.textBoxPlace.TabStop = false;
            this.textBoxPlace.Visible = false;
            // 
            // checkBoxTime
            // 
            this.checkBoxTime.AutoSize = true;
            this.checkBoxTime.Location = new System.Drawing.Point(318, 79);
            this.checkBoxTime.Name = "checkBoxTime";
            this.checkBoxTime.Size = new System.Drawing.Size(55, 21);
            this.checkBoxTime.TabIndex = 4;
            this.checkBoxTime.Text = "Час";
            this.checkBoxTime.UseVisualStyleBackColor = true;
            this.checkBoxTime.CheckedChanged += new System.EventHandler(this.CheckBoxTime_CheckedChanged);
            // 
            // checkBoxNumber
            // 
            this.checkBoxNumber.AutoSize = true;
            this.checkBoxNumber.Location = new System.Drawing.Point(318, 52);
            this.checkBoxNumber.Name = "checkBoxNumber";
            this.checkBoxNumber.Size = new System.Drawing.Size(111, 21);
            this.checkBoxNumber.TabIndex = 3;
            this.checkBoxNumber.Text = "Держ номер";
            this.checkBoxNumber.UseVisualStyleBackColor = true;
            this.checkBoxNumber.CheckedChanged += new System.EventHandler(this.CheckBoxNumber_CheckedChanged);
            // 
            // checkBoxPlace
            // 
            this.checkBoxPlace.AutoSize = true;
            this.checkBoxPlace.Location = new System.Drawing.Point(318, 25);
            this.checkBoxPlace.Name = "checkBoxPlace";
            this.checkBoxPlace.Size = new System.Drawing.Size(67, 21);
            this.checkBoxPlace.TabIndex = 2;
            this.checkBoxPlace.Text = "Місце";
            this.checkBoxPlace.UseVisualStyleBackColor = true;
            this.checkBoxPlace.CheckedChanged += new System.EventHandler(this.CheckBoxPlace_CheckedChanged);
            // 
            // checkedListBoxReports
            // 
            this.checkedListBoxReports.AccessibleName = "";
            this.checkedListBoxReports.BackColor = System.Drawing.SystemColors.Menu;
            this.checkedListBoxReports.ForeColor = System.Drawing.SystemColors.WindowText;
            this.checkedListBoxReports.FormattingEnabled = true;
            this.checkedListBoxReports.Items.AddRange(new object[] {
            "Всі",
            "Здано",
            "Не здано"});
            this.checkedListBoxReports.Location = new System.Drawing.Point(52, 23);
            this.checkedListBoxReports.Name = "checkedListBoxReports";
            this.checkedListBoxReports.Size = new System.Drawing.Size(138, 72);
            this.checkedListBoxReports.TabIndex = 1;
            this.checkedListBoxReports.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CheckedListBoxReports_ItemCheck);
            // 
            // buttonRepport
            // 
            this.buttonRepport.AutoSize = true;
            this.buttonRepport.Location = new System.Drawing.Point(257, 217);
            this.buttonRepport.Name = "buttonRepport";
            this.buttonRepport.Size = new System.Drawing.Size(128, 27);
            this.buttonRepport.TabIndex = 0;
            this.buttonRepport.Text = "Сформувати звіт";
            this.buttonRepport.UseVisualStyleBackColor = true;
            this.buttonRepport.Click += new System.EventHandler(this.ButtonRepport_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.діїЗПломбамиToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1478, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // діїЗПломбамиToolStripMenuItem
            // 
            this.діїЗПломбамиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.формуванняЗвітівToolStripMenuItem,
            this.основніДіїЗПломбамиToolStripMenuItem});
            this.діїЗПломбамиToolStripMenuItem.Name = "діїЗПломбамиToolStripMenuItem";
            this.діїЗПломбамиToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.діїЗПломбамиToolStripMenuItem.Text = "Вид";
            // 
            // формуванняЗвітівToolStripMenuItem
            // 
            this.формуванняЗвітівToolStripMenuItem.Name = "формуванняЗвітівToolStripMenuItem";
            this.формуванняЗвітівToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.формуванняЗвітівToolStripMenuItem.Text = "Формування звітів";
            this.формуванняЗвітівToolStripMenuItem.Click += new System.EventHandler(this.ФормуванняЗвітівToolStripMenuItem_Click);
            // 
            // основніДіїЗПломбамиToolStripMenuItem
            // 
            this.основніДіїЗПломбамиToolStripMenuItem.Checked = true;
            this.основніДіїЗПломбамиToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.основніДіїЗПломбамиToolStripMenuItem.Name = "основніДіїЗПломбамиToolStripMenuItem";
            this.основніДіїЗПломбамиToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.основніДіїЗПломбамиToolStripMenuItem.Text = "Основні дії з пломбами";
            this.основніДіїЗПломбамиToolStripMenuItem.Click += new System.EventHandler(this.ОсновніДіїЗПломбамиToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // panelSeals
            // 
            this.panelSeals.Controls.Add(this.label1);
            this.panelSeals.Controls.Add(this.textBoxDiap2);
            this.panelSeals.Controls.Add(this.textBoxDiap1);
            this.panelSeals.Controls.Add(this.checkBoxDiapazon);
            this.panelSeals.Controls.Add(this.textBoxSMan);
            this.panelSeals.Controls.Add(this.checkBoxSMan);
            this.panelSeals.Controls.Add(this.textBoxSTime);
            this.panelSeals.Controls.Add(this.textBoxSNumber);
            this.panelSeals.Controls.Add(this.textBoxSPlace);
            this.panelSeals.Controls.Add(this.checkBoxSTime);
            this.panelSeals.Controls.Add(this.checkBoxSNumber);
            this.panelSeals.Controls.Add(this.checkBoxSPlace);
            this.panelSeals.Controls.Add(this.buttonSeals);
            this.panelSeals.Controls.Add(this.checkedListBoxSeals);
            this.panelSeals.Location = new System.Drawing.Point(54, 448);
            this.panelSeals.Name = "panelSeals";
            this.panelSeals.Size = new System.Drawing.Size(608, 286);
            this.panelSeals.TabIndex = 3;
            // 
            // textBoxSMan
            // 
            this.textBoxSMan.Location = new System.Drawing.Point(277, 23);
            this.textBoxSMan.Name = "textBoxSMan";
            this.textBoxSMan.Size = new System.Drawing.Size(100, 22);
            this.textBoxSMan.TabIndex = 19;
            this.textBoxSMan.Visible = false;
            // 
            // checkBoxSMan
            // 
            this.checkBoxSMan.AutoSize = true;
            this.checkBoxSMan.Location = new System.Drawing.Point(161, 25);
            this.checkBoxSMan.Name = "checkBoxSMan";
            this.checkBoxSMan.Size = new System.Drawing.Size(97, 21);
            this.checkBoxSMan.TabIndex = 18;
            this.checkBoxSMan.Text = "По людині";
            this.checkBoxSMan.UseVisualStyleBackColor = true;
            this.checkBoxSMan.CheckedChanged += new System.EventHandler(this.CheckBoxSMan_CheckedChanged);
            // 
            // textBoxSTime
            // 
            this.textBoxSTime.Location = new System.Drawing.Point(277, 110);
            this.textBoxSTime.Name = "textBoxSTime";
            this.textBoxSTime.Size = new System.Drawing.Size(100, 22);
            this.textBoxSTime.TabIndex = 15;
            this.textBoxSTime.Visible = false;
            // 
            // textBoxSNumber
            // 
            this.textBoxSNumber.Location = new System.Drawing.Point(277, 51);
            this.textBoxSNumber.Name = "textBoxSNumber";
            this.textBoxSNumber.Size = new System.Drawing.Size(100, 22);
            this.textBoxSNumber.TabIndex = 14;
            this.textBoxSNumber.Visible = false;
            // 
            // textBoxSPlace
            // 
            this.textBoxSPlace.Location = new System.Drawing.Point(277, 81);
            this.textBoxSPlace.Name = "textBoxSPlace";
            this.textBoxSPlace.Size = new System.Drawing.Size(100, 22);
            this.textBoxSPlace.TabIndex = 13;
            this.textBoxSPlace.TabStop = false;
            this.textBoxSPlace.Visible = false;
            // 
            // checkBoxSTime
            // 
            this.checkBoxSTime.AutoSize = true;
            this.checkBoxSTime.Location = new System.Drawing.Point(161, 112);
            this.checkBoxSTime.Name = "checkBoxSTime";
            this.checkBoxSTime.Size = new System.Drawing.Size(55, 21);
            this.checkBoxSTime.TabIndex = 12;
            this.checkBoxSTime.Text = "Час";
            this.checkBoxSTime.UseVisualStyleBackColor = true;
            this.checkBoxSTime.Visible = false;
            this.checkBoxSTime.CheckedChanged += new System.EventHandler(this.CheckBoxSTime_CheckedChanged);
            // 
            // checkBoxSNumber
            // 
            this.checkBoxSNumber.AutoSize = true;
            this.checkBoxSNumber.Location = new System.Drawing.Point(161, 53);
            this.checkBoxSNumber.Name = "checkBoxSNumber";
            this.checkBoxSNumber.Size = new System.Drawing.Size(111, 21);
            this.checkBoxSNumber.TabIndex = 11;
            this.checkBoxSNumber.Text = "Держ номер";
            this.checkBoxSNumber.UseVisualStyleBackColor = true;
            this.checkBoxSNumber.CheckedChanged += new System.EventHandler(this.CheckBoxSNumber_CheckedChanged);
            // 
            // checkBoxSPlace
            // 
            this.checkBoxSPlace.AutoSize = true;
            this.checkBoxSPlace.Location = new System.Drawing.Point(161, 83);
            this.checkBoxSPlace.Name = "checkBoxSPlace";
            this.checkBoxSPlace.Size = new System.Drawing.Size(67, 21);
            this.checkBoxSPlace.TabIndex = 10;
            this.checkBoxSPlace.Text = "Місце";
            this.checkBoxSPlace.UseVisualStyleBackColor = true;
            this.checkBoxSPlace.CheckedChanged += new System.EventHandler(this.CheckBoxSPlace_CheckedChanged);
            // 
            // buttonSeals
            // 
            this.buttonSeals.AutoSize = true;
            this.buttonSeals.Location = new System.Drawing.Point(264, 217);
            this.buttonSeals.Name = "buttonSeals";
            this.buttonSeals.Size = new System.Drawing.Size(81, 27);
            this.buttonSeals.TabIndex = 0;
            this.buttonSeals.Text = "Виконати";
            this.buttonSeals.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxSeals
            // 
            this.checkedListBoxSeals.FormattingEnabled = true;
            this.checkedListBoxSeals.Items.AddRange(new object[] {
            "Здати ",
            "Видати"});
            this.checkedListBoxSeals.Location = new System.Drawing.Point(18, 23);
            this.checkedListBoxSeals.Name = "checkedListBoxSeals";
            this.checkedListBoxSeals.Size = new System.Drawing.Size(120, 55);
            this.checkedListBoxSeals.TabIndex = 0;
            this.checkedListBoxSeals.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CheckedListBoxSeals_ItemCheck);
            // 
            // checkBoxDiapazon
            // 
            this.checkBoxDiapazon.AutoSize = true;
            this.checkBoxDiapazon.Location = new System.Drawing.Point(422, 23);
            this.checkBoxDiapazon.Name = "checkBoxDiapazon";
            this.checkBoxDiapazon.Size = new System.Drawing.Size(136, 21);
            this.checkBoxDiapazon.TabIndex = 20;
            this.checkBoxDiapazon.Text = "Діапазон пломб";
            this.checkBoxDiapazon.UseVisualStyleBackColor = true;
            this.checkBoxDiapazon.CheckedChanged += new System.EventHandler(this.CheckBoxDiapazon_CheckedChanged);
            // 
            // textBoxDiap1
            // 
            this.textBoxDiap1.Location = new System.Drawing.Point(446, 50);
            this.textBoxDiap1.Name = "textBoxDiap1";
            this.textBoxDiap1.Size = new System.Drawing.Size(100, 22);
            this.textBoxDiap1.TabIndex = 21;
            // 
            // textBoxDiap2
            // 
            this.textBoxDiap2.Location = new System.Drawing.Point(446, 80);
            this.textBoxDiap2.Name = "textBoxDiap2";
            this.textBoxDiap2.Size = new System.Drawing.Size(100, 22);
            this.textBoxDiap2.TabIndex = 22;
            this.textBoxDiap2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(416, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "ID:";
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.DataGridView);
            this.panelData.Controls.Add(this.buttonSave);
            this.panelData.Controls.Add(this.buttonBack);
            this.panelData.Location = new System.Drawing.Point(0, 39);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(1450, 487);
            this.panelData.TabIndex = 4;
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.AllowUserToResizeColumns = false;
            this.DataGridView.AllowUserToResizeRows = false;
            this.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(91, 33);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.Size = new System.Drawing.Size(1347, 380);
            this.DataGridView.TabIndex = 0;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(757, 430);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.AutoSize = true;
            this.buttonSave.Location = new System.Drawing.Point(42, 445);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(79, 27);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Зберегти";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 550);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panelSeals);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelReport);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Пломби";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelReport.ResumeLayout(false);
            this.panelReport.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelSeals.ResumeLayout(false);
            this.panelSeals.PerformLayout();
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelReport;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem діїЗПломбамиToolStripMenuItem;
        private System.Windows.Forms.Button buttonRepport;
        private System.Windows.Forms.CheckBox checkBoxTime;
        private System.Windows.Forms.CheckBox checkBoxNumber;
        private System.Windows.Forms.CheckBox checkBoxPlace;
        private System.Windows.Forms.CheckedListBox checkedListBoxReports;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxPlace;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.CheckBox checkBoxId;
        private System.Windows.Forms.ToolStripMenuItem формуванняЗвітівToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem основніДіїЗПломбамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Panel panelSeals;
        private System.Windows.Forms.CheckedListBox checkedListBoxSeals;
        private System.Windows.Forms.TextBox textBoxSTime;
        private System.Windows.Forms.TextBox textBoxSNumber;
        private System.Windows.Forms.TextBox textBoxSPlace;
        private System.Windows.Forms.CheckBox checkBoxSTime;
        private System.Windows.Forms.CheckBox checkBoxSNumber;
        private System.Windows.Forms.CheckBox checkBoxSPlace;
        private System.Windows.Forms.Button buttonSeals;
        private System.Windows.Forms.TextBox textBoxSMan;
        private System.Windows.Forms.CheckBox checkBoxSMan;
        private System.Windows.Forms.TextBox textBoxDiap2;
        private System.Windows.Forms.TextBox textBoxDiap1;
        private System.Windows.Forms.CheckBox checkBoxDiapazon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonSave;
    }
}

