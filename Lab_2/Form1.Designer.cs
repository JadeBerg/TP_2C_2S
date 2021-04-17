namespace Lab_2
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

        #region #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.C = new System.Windows.Forms.TextBox();
            this.B = new System.Windows.Forms.TextBox();
            this.A = new System.Windows.Forms.TextBox();
            this.C_c = new System.Windows.Forms.Label();
            this.B_b = new System.Windows.Forms.Label();
            this.A_a = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.X2 = new System.Windows.Forms.TextBox();
            this.X1 = new System.Windows.Forms.TextBox();
            this.X21 = new System.Windows.Forms.Label();
            this.X12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.End = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Solut = new System.Windows.Forms.Button();
            this.Method_3 = new System.Windows.Forms.RadioButton();
            this.Method_2 = new System.Windows.Forms.RadioButton();
            this.Method_1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.C);
            this.groupBox1.Controls.Add(this.B);
            this.groupBox1.Controls.Add(this.A);
            this.groupBox1.Controls.Add(this.C_c);
            this.groupBox1.Controls.Add(this.B_b);
            this.groupBox1.Controls.Add(this.A_a);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(22, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод данных";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "=";
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(76, 144);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(288, 22);
            this.C.TabIndex = 5;
            this.C.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.C_KeyPress);
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(76, 102);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(288, 22);
            this.B.TabIndex = 4;
            this.B.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.B_KeyPress);
            // 
            // A
            // 
            this.A.BackColor = System.Drawing.SystemColors.Window;
            this.A.Location = new System.Drawing.Point(76, 58);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(288, 22);
            this.A.TabIndex = 3;
            this.A.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.A_KeyPress);
            // 
            // C_c
            // 
            this.C_c.AutoSize = true;
            this.C_c.Location = new System.Drawing.Point(31, 144);
            this.C_c.Name = "C_c";
            this.C_c.Size = new System.Drawing.Size(17, 17);
            this.C_c.TabIndex = 2;
            this.C_c.Text = "C";
            // 
            // B_b
            // 
            this.B_b.AutoSize = true;
            this.B_b.Location = new System.Drawing.Point(31, 102);
            this.B_b.Name = "B_b";
            this.B_b.Size = new System.Drawing.Size(17, 17);
            this.B_b.TabIndex = 1;
            this.B_b.Text = "B";
            // 
            // A_a
            // 
            this.A_a.AutoSize = true;
            this.A_a.Location = new System.Drawing.Point(31, 58);
            this.A_a.Name = "A_a";
            this.A_a.Size = new System.Drawing.Size(17, 17);
            this.A_a.TabIndex = 0;
            this.A_a.Text = "A";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.X2);
            this.groupBox2.Controls.Add(this.X1);
            this.groupBox2.Controls.Add(this.X21);
            this.groupBox2.Controls.Add(this.X12);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(22, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 123);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результат";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "=";
            // 
            // X2
            // 
            this.X2.Location = new System.Drawing.Point(76, 88);
            this.X2.Name = "X2";
            this.X2.ReadOnly = true;
            this.X2.Size = new System.Drawing.Size(288, 22);
            this.X2.TabIndex = 10;
            // 
            // X1
            // 
            this.X1.Location = new System.Drawing.Point(76, 42);
            this.X1.Name = "X1";
            this.X1.ReadOnly = true;
            this.X1.Size = new System.Drawing.Size(288, 22);
            this.X1.TabIndex = 9;
            // 
            // X21
            // 
            this.X21.AutoSize = true;
            this.X21.Location = new System.Drawing.Point(31, 88);
            this.X21.Name = "X21";
            this.X21.Size = new System.Drawing.Size(25, 17);
            this.X21.TabIndex = 4;
            this.X21.Text = "X2";
            // 
            // X12
            // 
            this.X12.AutoSize = true;
            this.X12.Location = new System.Drawing.Point(31, 42);
            this.X12.Name = "X12";
            this.X12.Size = new System.Drawing.Size(25, 17);
            this.X12.TabIndex = 3;
            this.X12.Text = "X1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.End);
            this.groupBox3.Controls.Add(this.Clear);
            this.groupBox3.Controls.Add(this.Solut);
            this.groupBox3.Controls.Add(this.Method_3);
            this.groupBox3.Controls.Add(this.Method_2);
            this.groupBox3.Controls.Add(this.Method_1);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox3.Location = new System.Drawing.Point(436, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(279, 314);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Управление";
            // 
            // End
            // 
            this.End.Location = new System.Drawing.Point(160, 204);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(105, 29);
            this.End.TabIndex = 5;
            this.End.Text = "Завершить";
            this.End.UseVisualStyleBackColor = true;
            this.End.Click += new System.EventHandler(this.End_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(32, 256);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(233, 29);
            this.Clear.TabIndex = 4;
            this.Clear.Text = "Очистить ввод";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Solut
            // 
            this.Solut.Location = new System.Drawing.Point(31, 204);
            this.Solut.Name = "Solut";
            this.Solut.Size = new System.Drawing.Size(105, 29);
            this.Solut.TabIndex = 3;
            this.Solut.Text = "Вычислить";
            this.Solut.UseVisualStyleBackColor = true;
            this.Solut.Click += new System.EventHandler(this.Solution_Click);
            // 
            // Method_3
            // 
            this.Method_3.AutoSize = true;
            this.Method_3.Location = new System.Drawing.Point(27, 144);
            this.Method_3.Name = "Method_3";
            this.Method_3.Size = new System.Drawing.Size(223, 21);
            this.Method_3.TabIndex = 2;
            this.Method_3.TabStop = true;
            this.Method_3.Text = "Методом в отдельном классе";
            this.Method_3.UseVisualStyleBackColor = true;
            // 
            // Method_2
            // 
            this.Method_2.AutoSize = true;
            this.Method_2.Location = new System.Drawing.Point(27, 99);
            this.Method_2.Name = "Method_2";
            this.Method_2.Size = new System.Drawing.Size(198, 21);
            this.Method_2.TabIndex = 1;
            this.Method_2.TabStop = true;
            this.Method_2.Text = "Методом в классе формы";
            this.Method_2.UseVisualStyleBackColor = true;
            // 
            // Method_1
            // 
            this.Method_1.AutoSize = true;
            this.Method_1.Location = new System.Drawing.Point(27, 55);
            this.Method_1.Name = "Method_1";
            this.Method_1.Size = new System.Drawing.Size(110, 21);
            this.Method_1.TabIndex = 0;
            this.Method_1.TabStop = true;
            this.Method_1.Text = "Обработчик";
            this.Method_1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(733, 350);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Name = "Form1";
            this.Text = "Решение квад. уравнений";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox C;
        private System.Windows.Forms.TextBox B;
        private System.Windows.Forms.TextBox A;
        private System.Windows.Forms.Label C_c;
        private System.Windows.Forms.Label B_b;
        private System.Windows.Forms.Label A_a;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox X2;
        private System.Windows.Forms.TextBox X1;
        private System.Windows.Forms.Label X21;
        private System.Windows.Forms.Label X12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button End;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Solut;
        private System.Windows.Forms.RadioButton Method_3;
        private System.Windows.Forms.RadioButton Method_2;
        private System.Windows.Forms.RadioButton Method_1;
    }
}

