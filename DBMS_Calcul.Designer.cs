using System.Drawing;

namespace DBMS_Calcul
{
    partial class SysClacul
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SysClacul));
            this.Binary = new System.Windows.Forms.Button();
            this.Octal = new System.Windows.Forms.Button();
            this.Hexadecimal = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Ternary = new System.Windows.Forms.Button();
            this.Run = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.binary_r = new System.Windows.Forms.RadioButton();
            this.ternary_r = new System.Windows.Forms.RadioButton();
            this.octal_r = new System.Windows.Forms.RadioButton();
            this.hexadecimal_r = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Binary
            // 
            this.Binary.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Binary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Binary.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Binary.Location = new System.Drawing.Point(15, 12);
            this.Binary.Name = "Binary";
            this.Binary.Size = new System.Drawing.Size(62, 33);
            this.Binary.TabIndex = 0;
            this.Binary.Text = "Binary";
            this.Binary.UseVisualStyleBackColor = false;
            this.Binary.Click += new System.EventHandler(this.button1_Click);
            // 
            // Octal
            // 
            this.Octal.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Octal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Octal.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Octal.Location = new System.Drawing.Point(164, 12);
            this.Octal.Name = "Octal";
            this.Octal.Size = new System.Drawing.Size(64, 33);
            this.Octal.TabIndex = 1;
            this.Octal.Text = "Octal";
            this.Octal.UseVisualStyleBackColor = false;
            this.Octal.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Hexadecimal
            // 
            this.Hexadecimal.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Hexadecimal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Hexadecimal.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hexadecimal.Location = new System.Drawing.Point(234, 12);
            this.Hexadecimal.Name = "Hexadecimal";
            this.Hexadecimal.Size = new System.Drawing.Size(98, 33);
            this.Hexadecimal.TabIndex = 2;
            this.Hexadecimal.Text = "Hexadecimal";
            this.Hexadecimal.UseVisualStyleBackColor = false;
            this.Hexadecimal.Click += new System.EventHandler(this.Hexadecimal_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.Ternary);
            this.panel1.Controls.Add(this.Run);
            this.panel1.Controls.Add(this.Binary);
            this.panel1.Controls.Add(this.Hexadecimal);
            this.panel1.Controls.Add(this.Octal);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 59);
            this.panel1.TabIndex = 3;
            // 
            // Ternary
            // 
            this.Ternary.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Ternary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ternary.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ternary.Location = new System.Drawing.Point(83, 12);
            this.Ternary.Name = "Ternary";
            this.Ternary.Size = new System.Drawing.Size(75, 33);
            this.Ternary.TabIndex = 4;
            this.Ternary.Text = "Ternary";
            this.Ternary.UseVisualStyleBackColor = false;
            this.Ternary.Click += new System.EventHandler(this.Ternary_Click);
            // 
            // Run
            // 
            this.Run.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Run.BackgroundImage = global::DBMS_Calcul.Properties.Resources.Run;
            this.Run.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Run.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Run.FlatAppearance.BorderSize = 0;
            this.Run.Location = new System.Drawing.Point(370, 12);
            this.Run.Margin = new System.Windows.Forms.Padding(0);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(33, 33);
            this.Run.TabIndex = 3;
            this.Run.UseVisualStyleBackColor = false;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(-3, 103);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(422, 255);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(-3, 408);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(422, 145);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Input:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Output:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // binary_r
            // 
            this.binary_r.AutoSize = true;
            this.binary_r.Location = new System.Drawing.Point(130, 83);
            this.binary_r.Name = "binary_r";
            this.binary_r.Size = new System.Drawing.Size(54, 17);
            this.binary_r.TabIndex = 13;
            this.binary_r.TabStop = true;
            this.binary_r.Text = "Binary";
            this.binary_r.UseVisualStyleBackColor = true;
            this.binary_r.CheckedChanged += new System.EventHandler(this.binary_r_CheckedChanged);
            // 
            // ternary_r
            // 
            this.ternary_r.AutoSize = true;
            this.ternary_r.Location = new System.Drawing.Point(190, 83);
            this.ternary_r.Name = "ternary_r";
            this.ternary_r.Size = new System.Drawing.Size(61, 17);
            this.ternary_r.TabIndex = 14;
            this.ternary_r.TabStop = true;
            this.ternary_r.Text = "Ternary";
            this.ternary_r.UseVisualStyleBackColor = true;
            this.ternary_r.CheckedChanged += new System.EventHandler(this.ternary_r_CheckedChanged);
            // 
            // octal_r
            // 
            this.octal_r.AutoSize = true;
            this.octal_r.Location = new System.Drawing.Point(257, 83);
            this.octal_r.Name = "octal_r";
            this.octal_r.Size = new System.Drawing.Size(50, 17);
            this.octal_r.TabIndex = 15;
            this.octal_r.TabStop = true;
            this.octal_r.Text = "Octal";
            this.octal_r.UseVisualStyleBackColor = true;
            this.octal_r.CheckedChanged += new System.EventHandler(this.octal_r_CheckedChanged);
            // 
            // hexadecimal_r
            // 
            this.hexadecimal_r.AutoSize = true;
            this.hexadecimal_r.Location = new System.Drawing.Point(313, 83);
            this.hexadecimal_r.Name = "hexadecimal_r";
            this.hexadecimal_r.Size = new System.Drawing.Size(86, 17);
            this.hexadecimal_r.TabIndex = 16;
            this.hexadecimal_r.TabStop = true;
            this.hexadecimal_r.Text = "Hexadecimal";
            this.hexadecimal_r.UseVisualStyleBackColor = true;
            this.hexadecimal_r.CheckedChanged += new System.EventHandler(this.hexadecimal_r_CheckedChanged);
            // 
            // SysClacul
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(415, 565);
            this.Controls.Add(this.hexadecimal_r);
            this.Controls.Add(this.octal_r);
            this.Controls.Add(this.ternary_r);
            this.Controls.Add(this.binary_r);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(431, 604);
            this.MaximumSize = new System.Drawing.Size(431, 604);
            this.Name = "SysClacul";
            this.Text = "DBMS Calculator";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Binary;
        private System.Windows.Forms.Button Octal;
        private System.Windows.Forms.Button Hexadecimal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.Button Ternary;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton binary_r;
        private System.Windows.Forms.RadioButton ternary_r;
        private System.Windows.Forms.RadioButton octal_r;
        private System.Windows.Forms.RadioButton hexadecimal_r;
    }
}

