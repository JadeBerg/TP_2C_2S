
namespace Lab4_tp
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.B = new System.Windows.Forms.TextBox();
            this.A = new System.Windows.Forms.TextBox();
            this.N = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Op_3 = new System.Windows.Forms.RadioButton();
            this.Op_2 = new System.Windows.Forms.RadioButton();
            this.Op_1 = new System.Windows.Forms.RadioButton();
            this.Close = new System.Windows.Forms.Button();
            this.Author = new System.Windows.Forms.Button();
            this.Input_data = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.B);
            this.groupBox1.Controls.Add(this.A);
            this.groupBox1.Controls.Add(this.N);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Исходные данные";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Максимальная граница B=";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Минимальная граница A=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Размерность массива N=";
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(162, 109);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(100, 20);
            this.B.TabIndex = 1;
            this.B.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.B_KeyPress);
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(162, 68);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(100, 20);
            this.A.TabIndex = 1;
            this.A.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.A_KeyPress);
            // 
            // N
            // 
            this.N.Location = new System.Drawing.Point(162, 32);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(100, 20);
            this.N.TabIndex = 0;
            this.N.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.N_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Op_3);
            this.groupBox2.Controls.Add(this.Op_2);
            this.groupBox2.Controls.Add(this.Op_1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(296, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 182);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Операции";
            // 
            // Op_3
            // 
            this.Op_3.AutoSize = true;
            this.Op_3.Location = new System.Drawing.Point(21, 147);
            this.Op_3.Name = "Op_3";
            this.Op_3.Size = new System.Drawing.Size(209, 17);
            this.Op_3.TabIndex = 2;
            this.Op_3.TabStop = true;
            this.Op_3.Text = "Отцентрировать элементы массива";
            this.Op_3.UseVisualStyleBackColor = true;
            // 
            // Op_2
            // 
            this.Op_2.AutoSize = true;
            this.Op_2.Location = new System.Drawing.Point(20, 86);
            this.Op_2.Name = "Op_2";
            this.Op_2.Size = new System.Drawing.Size(210, 43);
            this.Op_2.TabIndex = 1;
            this.Op_2.TabStop = true;
            this.Op_2.Text = "Определить минимальный элемент \r\nсреди элементов с четной суммой\r\nиндексов массив" +
    "а";
            this.Op_2.UseVisualStyleBackColor = true;
            // 
            // Op_1
            // 
            this.Op_1.AutoSize = true;
            this.Op_1.Location = new System.Drawing.Point(21, 32);
            this.Op_1.Name = "Op_1";
            this.Op_1.Size = new System.Drawing.Size(223, 43);
            this.Op_1.TabIndex = 0;
            this.Op_1.TabStop = true;
            this.Op_1.Text = "Отсортировать элементы массива \r\nпо возрастанию в строках,\r\nпредставить их в квад" +
    "ратном массиве";
            this.Op_1.UseVisualStyleBackColor = true;
            // 
            // Close
            // 
            this.Close.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Close.Location = new System.Drawing.Point(12, 201);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(72, 45);
            this.Close.TabIndex = 2;
            this.Close.Text = "Закрыть";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Author
            // 
            this.Author.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Author.Location = new System.Drawing.Point(428, 206);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(130, 45);
            this.Author.TabIndex = 5;
            this.Author.Text = "Об авторе";
            this.Author.UseVisualStyleBackColor = true;
            this.Author.Click += new System.EventHandler(this.Author_Click);
            // 
            // Input_data
            // 
            this.Input_data.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Input_data.Location = new System.Drawing.Point(195, 201);
            this.Input_data.Name = "Input_data";
            this.Input_data.Size = new System.Drawing.Size(95, 45);
            this.Input_data.TabIndex = 7;
            this.Input_data.Text = "Вычисления";
            this.Input_data.UseVisualStyleBackColor = true;
            this.Input_data.Click += new System.EventHandler(this.Input_data_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(573, 263);
            this.Controls.Add(this.Input_data);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Ввод данных и выбор операции";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Op_3;
        private System.Windows.Forms.RadioButton Op_2;
        private System.Windows.Forms.RadioButton Op_1;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Author;
        public System.Windows.Forms.TextBox B;
        public System.Windows.Forms.TextBox A;
        public System.Windows.Forms.TextBox N;
        private System.Windows.Forms.Button Input_data;
    }
}

