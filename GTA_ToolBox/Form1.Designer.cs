namespace GTA_ToolBox
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
            this.runButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pssTextbox = new System.Windows.Forms.TextBox();
            this.toolsLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.armorTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mmiTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mmiTicksTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mechTicksTextbox = new System.Windows.Forms.TextBox();
            this.mechTextbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lesterTicksTextbox = new System.Windows.Forms.TextBox();
            this.lesterTextbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.killTextbox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.killInternetTextbox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.afkTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // runButton
            // 
            this.runButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runButton.Location = new System.Drawing.Point(15, 296);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(250, 32);
            this.runButton.TabIndex = 0;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "GTA Process Status:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.Red;
            this.statusLabel.Location = new System.Drawing.Point(194, 9);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(72, 20);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "Inactive";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Public solo session:";
            // 
            // pssTextbox
            // 
            this.pssTextbox.Location = new System.Drawing.Point(122, 52);
            this.pssTextbox.Name = "pssTextbox";
            this.pssTextbox.Size = new System.Drawing.Size(142, 20);
            this.pssTextbox.TabIndex = 4;
            this.pssTextbox.Text = "Control+P";
            // 
            // toolsLabel
            // 
            this.toolsLabel.AutoSize = true;
            this.toolsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolsLabel.ForeColor = System.Drawing.Color.Red;
            this.toolsLabel.Location = new System.Drawing.Point(194, 29);
            this.toolsLabel.Name = "toolsLabel";
            this.toolsLabel.Size = new System.Drawing.Size(72, 20);
            this.toolsLabel.TabIndex = 6;
            this.toolsLabel.Text = "Inactive";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tools Active:";
            // 
            // armorTextbox
            // 
            this.armorTextbox.Location = new System.Drawing.Point(122, 78);
            this.armorTextbox.Name = "armorTextbox";
            this.armorTextbox.Size = new System.Drawing.Size(142, 20);
            this.armorTextbox.TabIndex = 8;
            this.armorTextbox.Text = "Control+U";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Equip Armor:";
            // 
            // mmiTextbox
            // 
            this.mmiTextbox.Location = new System.Drawing.Point(122, 102);
            this.mmiTextbox.Name = "mmiTextbox";
            this.mmiTextbox.Size = new System.Drawing.Size(142, 20);
            this.mmiTextbox.TabIndex = 10;
            this.mmiTextbox.Text = "Control+N";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Call MMI:";
            // 
            // mmiTicksTextbox
            // 
            this.mmiTicksTextbox.Location = new System.Drawing.Point(329, 102);
            this.mmiTicksTextbox.MaxLength = 2;
            this.mmiTicksTextbox.Name = "mmiTicksTextbox";
            this.mmiTicksTextbox.Size = new System.Drawing.Size(23, 20);
            this.mmiTicksTextbox.TabIndex = 11;
            this.mmiTicksTextbox.Text = "9";
            this.mmiTicksTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ticks Up:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(270, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ticks Up:";
            // 
            // mechTicksTextbox
            // 
            this.mechTicksTextbox.Location = new System.Drawing.Point(329, 128);
            this.mechTicksTextbox.MaxLength = 2;
            this.mechTicksTextbox.Name = "mechTicksTextbox";
            this.mechTicksTextbox.Size = new System.Drawing.Size(23, 20);
            this.mechTicksTextbox.TabIndex = 15;
            this.mechTicksTextbox.Text = "11";
            this.mechTicksTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mechTextbox
            // 
            this.mechTextbox.Location = new System.Drawing.Point(122, 128);
            this.mechTextbox.Name = "mechTextbox";
            this.mechTextbox.Size = new System.Drawing.Size(142, 20);
            this.mechTextbox.TabIndex = 14;
            this.mechTextbox.Text = "Control+I";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Call Mechanic:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(270, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Ticks Up:";
            // 
            // lesterTicksTextbox
            // 
            this.lesterTicksTextbox.Location = new System.Drawing.Point(329, 154);
            this.lesterTicksTextbox.MaxLength = 2;
            this.lesterTicksTextbox.Name = "lesterTicksTextbox";
            this.lesterTicksTextbox.Size = new System.Drawing.Size(23, 20);
            this.lesterTicksTextbox.TabIndex = 19;
            this.lesterTicksTextbox.Text = "14";
            this.lesterTicksTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lesterTextbox
            // 
            this.lesterTextbox.Location = new System.Drawing.Point(122, 154);
            this.lesterTextbox.Name = "lesterTextbox";
            this.lesterTextbox.Size = new System.Drawing.Size(142, 20);
            this.lesterTextbox.TabIndex = 18;
            this.lesterTextbox.Text = "Control+L";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Call Lester:";
            // 
            // killTextbox
            // 
            this.killTextbox.Location = new System.Drawing.Point(122, 180);
            this.killTextbox.Name = "killTextbox";
            this.killTextbox.Size = new System.Drawing.Size(142, 20);
            this.killTextbox.TabIndex = 22;
            this.killTextbox.Text = "Control+Delete";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Kill GTA:";
            // 
            // killInternetTextbox
            // 
            this.killInternetTextbox.Location = new System.Drawing.Point(122, 206);
            this.killInternetTextbox.Name = "killInternetTextbox";
            this.killInternetTextbox.Size = new System.Drawing.Size(142, 20);
            this.killInternetTextbox.TabIndex = 24;
            this.killInternetTextbox.Text = "Control+End";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Kill Internet:";
            // 
            // afkTextBox
            // 
            this.afkTextBox.Location = new System.Drawing.Point(122, 232);
            this.afkTextBox.Name = "afkTextBox";
            this.afkTextBox.Size = new System.Drawing.Size(142, 20);
            this.afkTextBox.TabIndex = 26;
            this.afkTextBox.Text = "Control+K";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 235);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "AFK:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 340);
            this.Controls.Add(this.afkTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.killInternetTextbox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.killTextbox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lesterTicksTextbox);
            this.Controls.Add(this.lesterTextbox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mechTicksTextbox);
            this.Controls.Add(this.mechTextbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mmiTicksTextbox);
            this.Controls.Add(this.mmiTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.armorTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toolsLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pssTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.runButton);
            this.Name = "Form1";
            this.Text = "GTA Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label toolsLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox pssTextbox;
        public System.Windows.Forms.TextBox armorTextbox;
        public System.Windows.Forms.TextBox mmiTextbox;
        public System.Windows.Forms.TextBox mmiTicksTextbox;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox mechTicksTextbox;
        public System.Windows.Forms.TextBox mechTextbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox lesterTicksTextbox;
        public System.Windows.Forms.TextBox lesterTextbox;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox killTextbox;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox killInternetTextbox;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox afkTextBox;
        private System.Windows.Forms.Label label13;
    }
}

