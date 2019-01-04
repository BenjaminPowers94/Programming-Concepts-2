namespace Polymorphism1
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
            this.outputLabel = new System.Windows.Forms.Label();
            this.ProcessedGroupBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_radius = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Z1 = new System.Windows.Forms.TextBox();
            this.textBox_Z2 = new System.Windows.Forms.TextBox();
            this.textBox_sqWidth = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_sqLength = new System.Windows.Forms.TextBox();
            this.textBox_Z3 = new System.Windows.Forms.TextBox();
            this.textBox_triHeight = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_triBase = new System.Windows.Forms.TextBox();
            this.ProcessedGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.Black;
            this.outputLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.outputLabel.Location = new System.Drawing.Point(6, 16);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(584, 213);
            this.outputLabel.TabIndex = 7;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProcessedGroupBox
            // 
            this.ProcessedGroupBox.Controls.Add(this.button1);
            this.ProcessedGroupBox.Controls.Add(this.outputLabel);
            this.ProcessedGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessedGroupBox.ForeColor = System.Drawing.Color.Blue;
            this.ProcessedGroupBox.Location = new System.Drawing.Point(12, 203);
            this.ProcessedGroupBox.Name = "ProcessedGroupBox";
            this.ProcessedGroupBox.Size = new System.Drawing.Size(596, 275);
            this.ProcessedGroupBox.TabIndex = 26;
            this.ProcessedGroupBox.TabStop = false;
            this.ProcessedGroupBox.Text = "Processed";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 26);
            this.button1.TabIndex = 8;
            this.button1.Text = "display";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Label2.Location = new System.Drawing.Point(10, 481);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(598, 23);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "From the Desk of Mark McCaulay";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(22, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(586, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "polymorphism-1";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_radius
            // 
            this.textBox_radius.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_radius.Location = new System.Drawing.Point(138, 53);
            this.textBox_radius.Name = "textBox_radius";
            this.textBox_radius.Size = new System.Drawing.Size(49, 26);
            this.textBox_radius.TabIndex = 28;
            this.textBox_radius.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 26);
            this.label4.TabIndex = 31;
            this.label4.Text = "Circle radius";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(418, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 26);
            this.label6.TabIndex = 33;
            this.label6.Text = "sphere height";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_Z1
            // 
            this.textBox_Z1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Z1.Location = new System.Drawing.Point(560, 52);
            this.textBox_Z1.Name = "textBox_Z1";
            this.textBox_Z1.Size = new System.Drawing.Size(48, 26);
            this.textBox_Z1.TabIndex = 35;
            this.textBox_Z1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_Z2
            // 
            this.textBox_Z2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Z2.Location = new System.Drawing.Point(560, 94);
            this.textBox_Z2.Name = "textBox_Z2";
            this.textBox_Z2.Size = new System.Drawing.Size(48, 26);
            this.textBox_Z2.TabIndex = 42;
            this.textBox_Z2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_sqWidth
            // 
            this.textBox_sqWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_sqWidth.Location = new System.Drawing.Point(310, 94);
            this.textBox_sqWidth.Name = "textBox_sqWidth";
            this.textBox_sqWidth.Size = new System.Drawing.Size(48, 26);
            this.textBox_sqWidth.TabIndex = 41;
            this.textBox_sqWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(418, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 26);
            this.label9.TabIndex = 40;
            this.label9.Text = "box height";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.DimGray;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(252, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 26);
            this.label10.TabIndex = 39;
            this.label10.Text = "width";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(22, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 26);
            this.label11.TabIndex = 38;
            this.label11.Text = "square length";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_sqLength
            // 
            this.textBox_sqLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_sqLength.Location = new System.Drawing.Point(138, 94);
            this.textBox_sqLength.Name = "textBox_sqLength";
            this.textBox_sqLength.Size = new System.Drawing.Size(49, 26);
            this.textBox_sqLength.TabIndex = 37;
            this.textBox_sqLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_Z3
            // 
            this.textBox_Z3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Z3.Location = new System.Drawing.Point(560, 131);
            this.textBox_Z3.Name = "textBox_Z3";
            this.textBox_Z3.Size = new System.Drawing.Size(48, 26);
            this.textBox_Z3.TabIndex = 49;
            this.textBox_Z3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_triHeight
            // 
            this.textBox_triHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_triHeight.Location = new System.Drawing.Point(310, 130);
            this.textBox_triHeight.Name = "textBox_triHeight";
            this.textBox_triHeight.Size = new System.Drawing.Size(48, 26);
            this.textBox_triHeight.TabIndex = 48;
            this.textBox_triHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label12.Location = new System.Drawing.Point(418, 131);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 26);
            this.label12.TabIndex = 47;
            this.label12.Text = "pyramid height";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.DimGray;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(252, 130);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 26);
            this.label13.TabIndex = 46;
            this.label13.Text = "height";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Black;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(22, 132);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 26);
            this.label14.TabIndex = 45;
            this.label14.Text = "triangle base";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_triBase
            // 
            this.textBox_triBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_triBase.Location = new System.Drawing.Point(138, 132);
            this.textBox_triBase.Name = "textBox_triBase";
            this.textBox_triBase.Size = new System.Drawing.Size(49, 26);
            this.textBox_triBase.TabIndex = 44;
            this.textBox_triBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 511);
            this.Controls.Add(this.textBox_Z3);
            this.Controls.Add(this.textBox_triHeight);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox_triBase);
            this.Controls.Add(this.textBox_Z2);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.textBox_sqWidth);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox_sqLength);
            this.Controls.Add(this.textBox_Z1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_radius);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProcessedGroupBox);
            this.Name = "Form1";
            this.Text = "polymorphism";
            this.ProcessedGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label outputLabel;
        internal System.Windows.Forms.GroupBox ProcessedGroupBox;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_radius;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Z1;
        private System.Windows.Forms.TextBox textBox_Z2;
        private System.Windows.Forms.TextBox textBox_sqWidth;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_sqLength;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_Z3;
        private System.Windows.Forms.TextBox textBox_triHeight;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_triBase;
    }
}

