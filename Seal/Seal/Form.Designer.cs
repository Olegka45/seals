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
            this.panelMain = new System.Windows.Forms.Panel();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxPlace = new System.Windows.Forms.TextBox();
            this.checkBoxTime = new System.Windows.Forms.CheckBox();
            this.checkBoxNumber = new System.Windows.Forms.CheckBox();
            this.checkBoxPlace = new System.Windows.Forms.CheckBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.buttonRepport = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.діїЗПломбамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxId = new System.Windows.Forms.CheckBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.panelMain.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.textBoxId);
            this.panelMain.Controls.Add(this.checkBoxId);
            this.panelMain.Controls.Add(this.textBoxTime);
            this.panelMain.Controls.Add(this.textBoxNumber);
            this.panelMain.Controls.Add(this.textBoxPlace);
            this.panelMain.Controls.Add(this.checkBoxTime);
            this.panelMain.Controls.Add(this.checkBoxNumber);
            this.panelMain.Controls.Add(this.checkBoxPlace);
            this.panelMain.Controls.Add(this.checkedListBox1);
            this.panelMain.Controls.Add(this.buttonRepport);
            this.panelMain.Location = new System.Drawing.Point(0, 31);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(593, 363);
            this.panelMain.TabIndex = 0;
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(395, 99);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(100, 22);
            this.textBoxTime.TabIndex = 7;
            this.textBoxTime.Visible = false;
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(395, 71);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(100, 22);
            this.textBoxNumber.TabIndex = 6;
            this.textBoxNumber.Visible = false;
            // 
            // textBoxPlace
            // 
            this.textBoxPlace.Location = new System.Drawing.Point(395, 43);
            this.textBoxPlace.Name = "textBoxPlace";
            this.textBoxPlace.Size = new System.Drawing.Size(100, 22);
            this.textBoxPlace.TabIndex = 5;
            this.textBoxPlace.TabStop = false;
            this.textBoxPlace.Visible = false;
            // 
            // checkBoxTime
            // 
            this.checkBoxTime.AutoSize = true;
            this.checkBoxTime.Location = new System.Drawing.Point(279, 100);
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
            this.checkBoxNumber.Location = new System.Drawing.Point(279, 73);
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
            this.checkBoxPlace.Location = new System.Drawing.Point(279, 46);
            this.checkBoxPlace.Name = "checkBoxPlace";
            this.checkBoxPlace.Size = new System.Drawing.Size(67, 21);
            this.checkBoxPlace.TabIndex = 2;
            this.checkBoxPlace.Text = "Місце";
            this.checkBoxPlace.UseVisualStyleBackColor = true;
            this.checkBoxPlace.CheckedChanged += new System.EventHandler(this.CheckBoxPlace_CheckedChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.AccessibleName = "";
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.checkedListBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Всі",
            "Здано",
            "Не здано"});
            this.checkedListBox1.Location = new System.Drawing.Point(12, 43);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(138, 72);
            this.checkedListBox1.TabIndex = 1;
            // 
            // buttonRepport
            // 
            this.buttonRepport.AutoSize = true;
            this.buttonRepport.Location = new System.Drawing.Point(218, 269);
            this.buttonRepport.Name = "buttonRepport";
            this.buttonRepport.Size = new System.Drawing.Size(128, 27);
            this.buttonRepport.TabIndex = 0;
            this.buttonRepport.Text = "Сформувати звіт";
            this.buttonRepport.UseVisualStyleBackColor = true;
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
            this.діїЗПломбамиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(897, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // діїЗПломбамиToolStripMenuItem
            // 
            this.діїЗПломбамиToolStripMenuItem.Name = "діїЗПломбамиToolStripMenuItem";
            this.діїЗПломбамиToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.діїЗПломбамиToolStripMenuItem.Text = "Дії з пломбами";
            // 
            // checkBoxId
            // 
            this.checkBoxId.AutoSize = true;
            this.checkBoxId.Location = new System.Drawing.Point(279, 128);
            this.checkBoxId.Name = "checkBoxId";
            this.checkBoxId.Size = new System.Drawing.Size(79, 21);
            this.checkBoxId.TabIndex = 8;
            this.checkBoxId.Text = "По айді";
            this.checkBoxId.UseVisualStyleBackColor = true;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(395, 127);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 22);
            this.textBoxId.TabIndex = 9;
            this.textBoxId.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 465);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelMain);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Пломби";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem діїЗПломбамиToolStripMenuItem;
        private System.Windows.Forms.Button buttonRepport;
        private System.Windows.Forms.CheckBox checkBoxTime;
        private System.Windows.Forms.CheckBox checkBoxNumber;
        private System.Windows.Forms.CheckBox checkBoxPlace;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxPlace;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.CheckBox checkBoxId;
    }
}

