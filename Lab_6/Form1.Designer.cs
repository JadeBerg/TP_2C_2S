namespace Lab_6
{
    partial class Form1
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
            this.Dig_clock = new System.Windows.Forms.Button();
            this.Face_clock = new System.Windows.Forms.Button();
            this.Author = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Hour = new System.Windows.Forms.Button();
            this.Minute = new System.Windows.Forms.Button();
            this.Second = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dig_clock
            // 
            this.Dig_clock.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Dig_clock.Location = new System.Drawing.Point(12, 12);
            this.Dig_clock.Name = "Dig_clock";
            this.Dig_clock.Size = new System.Drawing.Size(223, 47);
            this.Dig_clock.TabIndex = 0;
            this.Dig_clock.Text = "Цифровые часы";
            this.Dig_clock.UseVisualStyleBackColor = true;
            this.Dig_clock.Click += new System.EventHandler(this.Dig_clock_Click);
            // 
            // Face_clock
            // 
            this.Face_clock.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Face_clock.Location = new System.Drawing.Point(12, 65);
            this.Face_clock.Name = "Face_clock";
            this.Face_clock.Size = new System.Drawing.Size(223, 47);
            this.Face_clock.TabIndex = 1;
            this.Face_clock.Text = "Циферблат";
            this.Face_clock.UseVisualStyleBackColor = true;
            this.Face_clock.Click += new System.EventHandler(this.Face_clock_Click);
            // 
            // Author
            // 
            this.Author.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Author.Location = new System.Drawing.Point(12, 204);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(223, 47);
            this.Author.TabIndex = 2;
            this.Author.Text = "Об авторе";
            this.Author.UseVisualStyleBackColor = true;
            this.Author.Click += new System.EventHandler(this.Author_Click);
            // 
            // Save
            // 
            this.Save.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Save.Location = new System.Drawing.Point(12, 118);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(223, 47);
            this.Save.TabIndex = 4;
            this.Save.Text = "Сохранить настройки в файл";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Back
            // 
            this.Back.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Back.Location = new System.Drawing.Point(49, 21);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(126, 47);
            this.Back.TabIndex = 7;
            this.Back.Text = "Цвет фона";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Hour
            // 
            this.Hour.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Hour.Location = new System.Drawing.Point(49, 74);
            this.Hour.Name = "Hour";
            this.Hour.Size = new System.Drawing.Size(126, 47);
            this.Hour.TabIndex = 8;
            this.Hour.Text = "Цвет часовой стрелки";
            this.Hour.UseVisualStyleBackColor = true;
            this.Hour.Click += new System.EventHandler(this.Hour_Click);
            // 
            // Minute
            // 
            this.Minute.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Minute.Location = new System.Drawing.Point(49, 127);
            this.Minute.Name = "Minute";
            this.Minute.Size = new System.Drawing.Size(126, 47);
            this.Minute.TabIndex = 9;
            this.Minute.Text = "Цвет минутной стрелки";
            this.Minute.UseVisualStyleBackColor = true;
            this.Minute.Click += new System.EventHandler(this.Minute_Click);
            // 
            // Second
            // 
            this.Second.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Second.Location = new System.Drawing.Point(49, 180);
            this.Second.Name = "Second";
            this.Second.Size = new System.Drawing.Size(126, 47);
            this.Second.TabIndex = 10;
            this.Second.Text = "Цвет секундной стрелки";
            this.Second.UseVisualStyleBackColor = true;
            this.Second.Click += new System.EventHandler(this.Second_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Second);
            this.groupBox1.Controls.Add(this.Minute);
            this.groupBox1.Controls.Add(this.Hour);
            this.groupBox1.Controls.Add(this.Back);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(241, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 239);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(467, 264);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.Face_clock);
            this.Controls.Add(this.Dig_clock);
            this.Name = "Form1";
            this.Text = "Настройка и выбор часов";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Dig_clock;
        private System.Windows.Forms.Button Face_clock;
        private System.Windows.Forms.Button Author;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Hour;
        private System.Windows.Forms.Button Minute;
        private System.Windows.Forms.Button Second;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

