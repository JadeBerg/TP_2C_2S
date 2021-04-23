
namespace Lab4_tp
{
    partial class Form2
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
            this.N1 = new System.Windows.Forms.TextBox();
            this.A1 = new System.Windows.Forms.TextBox();
            this.B1 = new System.Windows.Forms.TextBox();
            this.Generate_Matrix = new System.Windows.Forms.Button();
            this.Matrix = new System.Windows.Forms.DataGridView();
            this.Op_number = new System.Windows.Forms.TextBox();
            this.Save_Matrix = new System.Windows.Forms.Button();
            this.Read_Matrix = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Operations = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Write_Res = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Matrix)).BeginInit();
            this.SuspendLayout();
            // 
            // N1
            // 
            this.N1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.N1.Location = new System.Drawing.Point(164, 12);
            this.N1.Name = "N1";
            this.N1.ReadOnly = true;
            this.N1.Size = new System.Drawing.Size(100, 20);
            this.N1.TabIndex = 1;
            // 
            // A1
            // 
            this.A1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.A1.Location = new System.Drawing.Point(164, 38);
            this.A1.Name = "A1";
            this.A1.ReadOnly = true;
            this.A1.Size = new System.Drawing.Size(100, 20);
            this.A1.TabIndex = 2;
            // 
            // B1
            // 
            this.B1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.B1.Location = new System.Drawing.Point(164, 64);
            this.B1.Name = "B1";
            this.B1.ReadOnly = true;
            this.B1.Size = new System.Drawing.Size(100, 20);
            this.B1.TabIndex = 3;
            // 
            // Generate_Matrix
            // 
            this.Generate_Matrix.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Generate_Matrix.Location = new System.Drawing.Point(22, 177);
            this.Generate_Matrix.Name = "Generate_Matrix";
            this.Generate_Matrix.Size = new System.Drawing.Size(242, 41);
            this.Generate_Matrix.TabIndex = 4;
            this.Generate_Matrix.Text = "Генерация массива";
            this.Generate_Matrix.UseVisualStyleBackColor = true;
            this.Generate_Matrix.Click += new System.EventHandler(this.Generate_Matrix_Click);
            // 
            // Matrix
            // 
            this.Matrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Matrix.Location = new System.Drawing.Point(270, 12);
            this.Matrix.Name = "Matrix";
            this.Matrix.Size = new System.Drawing.Size(357, 254);
            this.Matrix.TabIndex = 5;
            // 
            // Op_number
            // 
            this.Op_number.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Op_number.Location = new System.Drawing.Point(135, 272);
            this.Op_number.Multiline = true;
            this.Op_number.Name = "Op_number";
            this.Op_number.ReadOnly = true;
            this.Op_number.Size = new System.Drawing.Size(492, 42);
            this.Op_number.TabIndex = 6;
            // 
            // Save_Matrix
            // 
            this.Save_Matrix.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Save_Matrix.Location = new System.Drawing.Point(22, 119);
            this.Save_Matrix.Name = "Save_Matrix";
            this.Save_Matrix.Size = new System.Drawing.Size(242, 23);
            this.Save_Matrix.TabIndex = 7;
            this.Save_Matrix.Text = "Сохранить массив в файл";
            this.Save_Matrix.UseVisualStyleBackColor = true;
            this.Save_Matrix.Click += new System.EventHandler(this.Save_Matrix_Click);
            // 
            // Read_Matrix
            // 
            this.Read_Matrix.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Read_Matrix.Location = new System.Drawing.Point(22, 90);
            this.Read_Matrix.Name = "Read_Matrix";
            this.Read_Matrix.Size = new System.Drawing.Size(242, 23);
            this.Read_Matrix.TabIndex = 8;
            this.Read_Matrix.Text = "Считать размерность и массив из файла";
            this.Read_Matrix.UseVisualStyleBackColor = true;
            this.Read_Matrix.Click += new System.EventHandler(this.Read_Matrix_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Размерность массива N=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(20, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Минимальная граница A=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(20, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Максимальная граница B=";
            // 
            // Operations
            // 
            this.Operations.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Operations.Location = new System.Drawing.Point(23, 225);
            this.Operations.Name = "Operations";
            this.Operations.Size = new System.Drawing.Size(242, 41);
            this.Operations.TabIndex = 12;
            this.Operations.Text = "Выполнение выбранной операции";
            this.Operations.UseVisualStyleBackColor = true;
            this.Operations.Click += new System.EventHandler(this.Operations_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(20, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Выбрана операция :";
            // 
            // Write_Res
            // 
            this.Write_Res.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Write_Res.Location = new System.Drawing.Point(23, 148);
            this.Write_Res.Name = "Write_Res";
            this.Write_Res.Size = new System.Drawing.Size(242, 23);
            this.Write_Res.TabIndex = 14;
            this.Write_Res.Text = "Сохранить результат в файл";
            this.Write_Res.UseVisualStyleBackColor = true;
            this.Write_Res.Click += new System.EventHandler(this.Write_Res_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(639, 326);
            this.Controls.Add(this.Write_Res);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Operations);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Read_Matrix);
            this.Controls.Add(this.Save_Matrix);
            this.Controls.Add(this.Op_number);
            this.Controls.Add(this.Matrix);
            this.Controls.Add(this.Generate_Matrix);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.N1);
            this.Name = "Form2";
            this.Text = "Вычисления";
            ((System.ComponentModel.ISupportInitialize)(this.Matrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox N1;
        public System.Windows.Forms.TextBox A1;
        public System.Windows.Forms.TextBox B1;
        private System.Windows.Forms.Button Generate_Matrix;
        private System.Windows.Forms.DataGridView Matrix;
        public System.Windows.Forms.TextBox Op_number;
        private System.Windows.Forms.Button Save_Matrix;
        private System.Windows.Forms.Button Read_Matrix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Operations;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Write_Res;
    }
}