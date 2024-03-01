namespace PowerPaint
{
    partial class MainWin
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
            this.ResizePanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.какФалйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.какJpegToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.какФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.какJpegToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PicPanel = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.свойстваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResizePanel
            // 
            this.ResizePanel.BackColor = System.Drawing.SystemColors.Control;
            this.ResizePanel.Location = new System.Drawing.Point(8, 23);
            this.ResizePanel.Margin = new System.Windows.Forms.Padding(4);
            this.ResizePanel.Name = "ResizePanel";
            this.ResizePanel.Size = new System.Drawing.Size(967, 400);
            this.ResizePanel.TabIndex = 0;
            this.ResizePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.ResizePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ResizePanel_MouseMove);
            this.ResizePanel.Resize += new System.EventHandler(this.ResizePanel_Resize);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1685, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйФайлToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem,
            this.выходToolStripMenuItem1});
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.выходToolStripMenuItem.Text = "Файл";
            // 
            // новыйФайлToolStripMenuItem
            // 
            this.новыйФайлToolStripMenuItem.Name = "новыйФайлToolStripMenuItem";
            this.новыйФайлToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.новыйФайлToolStripMenuItem.Text = "Новый файл";
            this.новыйФайлToolStripMenuItem.Click += new System.EventHandler(this.новыйФайлToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.какФалйToolStripMenuItem,
            this.какJpegToolStripMenuItem});
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // какФалйToolStripMenuItem
            // 
            this.какФалйToolStripMenuItem.Name = "какФалйToolStripMenuItem";
            this.какФалйToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.какФалйToolStripMenuItem.Text = "Как фалй";
            this.какФалйToolStripMenuItem.Click += new System.EventHandler(this.какФалйToolStripMenuItem_Click);
            // 
            // какJpegToolStripMenuItem
            // 
            this.какJpegToolStripMenuItem.Name = "какJpegToolStripMenuItem";
            this.какJpegToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.какJpegToolStripMenuItem.Text = "Как изображение";
            this.какJpegToolStripMenuItem.Click += new System.EventHandler(this.какJpegToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.какФайлToolStripMenuItem,
            this.какJpegToolStripMenuItem1});
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            // 
            // какФайлToolStripMenuItem
            // 
            this.какФайлToolStripMenuItem.Name = "какФайлToolStripMenuItem";
            this.какФайлToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.какФайлToolStripMenuItem.Text = "Как файл";
            this.какФайлToolStripMenuItem.Click += new System.EventHandler(this.какФайлToolStripMenuItem_Click);
            // 
            // какJpegToolStripMenuItem1
            // 
            this.какJpegToolStripMenuItem1.Name = "какJpegToolStripMenuItem1";
            this.какJpegToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.какJpegToolStripMenuItem1.Text = "Как изображение";
            this.какJpegToolStripMenuItem1.Click += new System.EventHandler(this.какJpegToolStripMenuItem1_Click);
            // 
            // выходToolStripMenuItem1
            // 
            this.выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            this.выходToolStripMenuItem1.Size = new System.Drawing.Size(179, 26);
            this.выходToolStripMenuItem1.Text = "Выход";
            this.выходToolStripMenuItem1.Click += new System.EventHandler(this.выходToolStripMenuItem1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Items.AddRange(new object[] {
            "Прямоугольник",
            "Круг",
            "Треугольник",
            "Линия",
            "Текст",
            "Картинка"});
            this.comboBox1.Location = new System.Drawing.Point(306, 15);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(119, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Инструменты";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 32);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 52);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(20, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(586, 95);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Панель инструментов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Палитра";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(182, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(75, 20);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.Text = "Курсор";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(182, 16);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(117, 20);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.Text = "Инструменты";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.PicPanel);
            this.groupBox2.Controls.Add(this.ResizePanel);
            this.groupBox2.Location = new System.Drawing.Point(20, 135);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1649, 688);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // PicPanel
            // 
            this.PicPanel.BackColor = System.Drawing.SystemColors.Window;
            this.PicPanel.Location = new System.Drawing.Point(8, 23);
            this.PicPanel.Margin = new System.Windows.Forms.Padding(4);
            this.PicPanel.Name = "PicPanel";
            this.PicPanel.Size = new System.Drawing.Size(953, 388);
            this.PicPanel.TabIndex = 0;
            this.PicPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PicPanel_Paint);
            this.PicPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PicPanel_MouseClick);
            this.PicPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicPanel_MouseDown);
            this.PicPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PicPanel_MouseMove);
            this.PicPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PicPanel_MouseUp);
            this.PicPanel.Resize += new System.EventHandler(this.PicPanel_Resize);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.цветToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.свойстваToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(163, 124);
            this.contextMenuStrip1.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.contextMenuStrip1_Closed);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.копироватьToolStripMenuItem_Click);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.вставитьToolStripMenuItem_Click);
            // 
            // цветToolStripMenuItem
            // 
            this.цветToolStripMenuItem.Name = "цветToolStripMenuItem";
            this.цветToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.цветToolStripMenuItem.Text = "Цвет";
            this.цветToolStripMenuItem.Click += new System.EventHandler(this.цветToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // свойстваToolStripMenuItem
            // 
            this.свойстваToolStripMenuItem.Name = "свойстваToolStripMenuItem";
            this.свойстваToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.свойстваToolStripMenuItem.Text = "Свойства";
            this.свойстваToolStripMenuItem.Click += new System.EventHandler(this.свойстваToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(182, 68);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(78, 20);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.Text = "Размер";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWin";
            this.Text = "PowerPant";
            this.Resize += new System.EventHandler(this.MainWin_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ResizePanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem новыйФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel PicPanel;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem какФалйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem какJpegToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem какФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem какJpegToolStripMenuItem1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem свойстваToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}

