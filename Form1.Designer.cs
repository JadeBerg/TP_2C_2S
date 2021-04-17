
namespace Lab_3
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Tabl = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Op_4 = new System.Windows.Forms.RadioButton();
            this.Op_3 = new System.Windows.Forms.RadioButton();
            this.Op_2 = new System.Windows.Forms.RadioButton();
            this.Op_1 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Operations = new System.Windows.Forms.Button();
            this.Write_F1 = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.Write_F2 = new System.Windows.Forms.Button();
            this.Read_F1 = new System.Windows.Forms.Button();
            this.Generate = new System.Windows.Forms.Button();
            this.Arr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.N = new System.Windows.Forms.TextBox();
            this.A = new System.Windows.Forms.TextBox();
            this.B = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.K = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Tabl)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Размерность массива n = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(254, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "A =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(368, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "B =";
            // 
            // Tabl
            // 
            this.Tabl.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.Tabl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Tabl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabl.Location = new System.Drawing.Point(442, 58);
            this.Tabl.Name = "Tabl";
            this.Tabl.RowTemplate.Height = 25;
            this.Tabl.Size = new System.Drawing.Size(225, 392);
            this.Tabl.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(15, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 392);
            this.panel1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Op_4);
            this.groupBox1.Controls.Add(this.Op_3);
            this.groupBox1.Controls.Add(this.Op_2);
            this.groupBox1.Controls.Add(this.Op_1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(178, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 364);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Операции";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Op_4
            // 
            this.Op_4.AutoSize = true;
            this.Op_4.Location = new System.Drawing.Point(6, 292);
            this.Op_4.Name = "Op_4";
            this.Op_4.Size = new System.Drawing.Size(190, 49);
            this.Op_4.TabIndex = 3;
            this.Op_4.TabStop = true;
            this.Op_4.Text = "Определить количество\r\nпростых чисел массива\r\nметодом пробных делителей.";
            this.Op_4.UseVisualStyleBackColor = true;
            // 
            // Op_3
            // 
            this.Op_3.AutoSize = true;
            this.Op_3.Location = new System.Drawing.Point(6, 199);
            this.Op_3.Name = "Op_3";
            this.Op_3.Size = new System.Drawing.Size(200, 94);
            this.Op_3.TabIndex = 2;
            this.Op_3.TabStop = true;
            this.Op_3.Text = "Определить сумму и \r\nколичество элементов массива\r\nу которых число,\r\nсоставленное" +
    " из двух \r\nпоследних цифр числа,\r\nделится на 3.\r\n";
            this.Op_3.UseVisualStyleBackColor = true;
            // 
            // Op_2
            // 
            this.Op_2.AutoSize = true;
            this.Op_2.Location = new System.Drawing.Point(6, 69);
            this.Op_2.Name = "Op_2";
            this.Op_2.Size = new System.Drawing.Size(197, 124);
            this.Op_2.TabIndex = 1;
            this.Op_2.TabStop = true;
            this.Op_2.Text = "Диапазон определения \r\nчисел массива [А, В] \r\nразбить на k \r\nравных подинтервалов" +
    ".\r\nОпределить количество чисел \r\nи процент чисел, \r\nпопадающих в каждый\r\nподинте" +
    "рвал.";
            this.Op_2.UseVisualStyleBackColor = true;
            // 
            // Op_1
            // 
            this.Op_1.AutoSize = true;
            this.Op_1.Location = new System.Drawing.Point(6, 35);
            this.Op_1.Name = "Op_1";
            this.Op_1.Size = new System.Drawing.Size(174, 19);
            this.Op_1.TabIndex = 0;
            this.Op_1.TabStop = true;
            this.Op_1.Text = "Сортировать по убыванию";
            this.Op_1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.Operations);
            this.panel2.Controls.Add(this.Write_F1);
            this.panel2.Controls.Add(this.Close);
            this.panel2.Controls.Add(this.Write_F2);
            this.panel2.Controls.Add(this.Read_F1);
            this.panel2.Controls.Add(this.Generate);
            this.panel2.Location = new System.Drawing.Point(7, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 293);
            this.panel2.TabIndex = 8;
            // 
            // Operations
            // 
            this.Operations.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Operations.Location = new System.Drawing.Point(6, 70);
            this.Operations.Name = "Operations";
            this.Operations.Size = new System.Drawing.Size(134, 42);
            this.Operations.TabIndex = 7;
            this.Operations.Text = "Выполнить";
            this.Operations.UseVisualStyleBackColor = true;
            this.Operations.Click += new System.EventHandler(this.Operations_Click);
            // 
            // Write_F1
            // 
            this.Write_F1.BackColor = System.Drawing.SystemColors.Control;
            this.Write_F1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Write_F1.Location = new System.Drawing.Point(6, 188);
            this.Write_F1.Name = "Write_F1";
            this.Write_F1.Size = new System.Drawing.Size(134, 23);
            this.Write_F1.TabIndex = 4;
            this.Write_F1.Text = "Записать массив";
            this.Write_F1.UseVisualStyleBackColor = false;
            this.Write_F1.Click += new System.EventHandler(this.Write_F1_Click);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.SystemColors.Control;
            this.Close.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Close.Location = new System.Drawing.Point(6, 118);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(134, 44);
            this.Close.TabIndex = 2;
            this.Close.Text = "Завершить";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Write_F2
            // 
            this.Write_F2.BackColor = System.Drawing.SystemColors.Control;
            this.Write_F2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Write_F2.Location = new System.Drawing.Point(6, 217);
            this.Write_F2.Name = "Write_F2";
            this.Write_F2.Size = new System.Drawing.Size(134, 23);
            this.Write_F2.TabIndex = 5;
            this.Write_F2.Text = "Записать результат";
            this.Write_F2.UseVisualStyleBackColor = false;
            this.Write_F2.Click += new System.EventHandler(this.Write_F2_Click);
            // 
            // Read_F1
            // 
            this.Read_F1.BackColor = System.Drawing.SystemColors.Control;
            this.Read_F1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Read_F1.Location = new System.Drawing.Point(6, 246);
            this.Read_F1.Name = "Read_F1";
            this.Read_F1.Size = new System.Drawing.Size(134, 23);
            this.Read_F1.TabIndex = 6;
            this.Read_F1.Text = "Считать массив";
            this.Read_F1.UseVisualStyleBackColor = false;
            this.Read_F1.Click += new System.EventHandler(this.Read_F1_Click);
            // 
            // Generate
            // 
            this.Generate.BackColor = System.Drawing.SystemColors.Control;
            this.Generate.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Generate.Location = new System.Drawing.Point(6, 20);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(134, 44);
            this.Generate.TabIndex = 0;
            this.Generate.Text = "Генерация";
            this.Generate.UseVisualStyleBackColor = false;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // Arr
            // 
            this.Arr.Location = new System.Drawing.Point(128, 467);
            this.Arr.Name = "Arr";
            this.Arr.ReadOnly = true;
            this.Arr.Size = new System.Drawing.Size(534, 23);
            this.Arr.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(15, 470);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Исходный массив:";
            // 
            // N
            // 
            this.N.Location = new System.Drawing.Point(161, 24);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(86, 23);
            this.N.TabIndex = 10;
            this.N.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.N_KeyPress);
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(286, 24);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(76, 23);
            this.A.TabIndex = 11;
            this.A.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.A_KeyPress);
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(399, 24);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(76, 23);
            this.B.TabIndex = 12;
            this.B.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.B_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(495, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "k =";
            // 
            // K
            // 
            this.K.Location = new System.Drawing.Point(525, 24);
            this.K.Name = "K";
            this.K.Size = new System.Drawing.Size(76, 23);
            this.K.TabIndex = 14;
            this.K.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.K_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(674, 513);
            this.Controls.Add(this.K);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.Controls.Add(this.N);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Arr);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Tabl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Генерация массивов";
            ((System.ComponentModel.ISupportInitialize)(this.Tabl)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Tabl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Op_4;
        private System.Windows.Forms.RadioButton Op_3;
        private System.Windows.Forms.RadioButton Op_2;
        private System.Windows.Forms.RadioButton Op_1;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.TextBox Arr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox N;
        private System.Windows.Forms.TextBox A;
        private System.Windows.Forms.TextBox B;
        private System.Windows.Forms.Button Write_F1;
        private System.Windows.Forms.Button Read_F1;
        private System.Windows.Forms.Button Write_F2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Operations;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox K;
    }
}

