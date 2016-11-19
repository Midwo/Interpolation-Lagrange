namespace Interpolation_Lagrange
{
    partial class Form1
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
            this.tx1 = new System.Windows.Forms.TextBox();
            this.tx3 = new System.Windows.Forms.TextBox();
            this.tx2 = new System.Windows.Forms.TextBox();
            this.ty1 = new System.Windows.Forms.TextBox();
            this.ty2 = new System.Windows.Forms.TextBox();
            this.ty3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.la = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.lc = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tx1
            // 
            this.tx1.Location = new System.Drawing.Point(35, 40);
            this.tx1.Name = "tx1";
            this.tx1.Size = new System.Drawing.Size(42, 20);
            this.tx1.TabIndex = 0;
            // 
            // tx3
            // 
            this.tx3.Location = new System.Drawing.Point(35, 93);
            this.tx3.Name = "tx3";
            this.tx3.Size = new System.Drawing.Size(42, 20);
            this.tx3.TabIndex = 1;
            // 
            // tx2
            // 
            this.tx2.Location = new System.Drawing.Point(35, 67);
            this.tx2.Name = "tx2";
            this.tx2.Size = new System.Drawing.Size(42, 20);
            this.tx2.TabIndex = 2;
            // 
            // ty1
            // 
            this.ty1.Location = new System.Drawing.Point(148, 40);
            this.ty1.Name = "ty1";
            this.ty1.Size = new System.Drawing.Size(42, 20);
            this.ty1.TabIndex = 3;
            // 
            // ty2
            // 
            this.ty2.Location = new System.Drawing.Point(148, 68);
            this.ty2.Name = "ty2";
            this.ty2.Size = new System.Drawing.Size(42, 20);
            this.ty2.TabIndex = 4;
            // 
            // ty3
            // 
            this.ty3.Location = new System.Drawing.Point(148, 93);
            this.ty3.Name = "ty3";
            this.ty3.Size = new System.Drawing.Size(42, 20);
            this.ty3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "x1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "x2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "x3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "y1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "y2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "y3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(46, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "f(x) = a(x*x)+bx + c";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Policz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lc);
            this.groupBox1.Controls.Add(this.lb);
            this.groupBox1.Controls.Add(this.la);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(12, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 139);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wyniki";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "a =";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "b =";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "c =";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Nowy wzór:";
            // 
            // la
            // 
            this.la.AutoSize = true;
            this.la.Location = new System.Drawing.Point(35, 20);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(19, 13);
            this.la.TabIndex = 4;
            this.la.Text = "??";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(35, 45);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(19, 13);
            this.lb.TabIndex = 5;
            this.lb.Text = "??";
            // 
            // lc
            // 
            this.lc.AutoSize = true;
            this.lc.Location = new System.Drawing.Point(35, 69);
            this.lc.Name = "lc";
            this.lc.Size = new System.Drawing.Size(19, 13);
            this.lc.TabIndex = 6;
            this.lc.Text = "??";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 487);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ty3);
            this.Controls.Add(this.ty2);
            this.Controls.Add(this.ty1);
            this.Controls.Add(this.tx2);
            this.Controls.Add(this.tx3);
            this.Controls.Add(this.tx1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx1;
        private System.Windows.Forms.TextBox tx3;
        private System.Windows.Forms.TextBox tx2;
        private System.Windows.Forms.TextBox ty1;
        private System.Windows.Forms.TextBox ty2;
        private System.Windows.Forms.TextBox ty3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lc;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label la;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

