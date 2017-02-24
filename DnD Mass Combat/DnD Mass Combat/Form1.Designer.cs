namespace DnD_Mass_Combat {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.reset = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.Unit3 = new DnD_Mass_Combat.Unit();
            this.Unit2 = new DnD_Mass_Combat.Unit();
            this.Unit1 = new DnD_Mass_Combat.Unit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "A vs B";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(153, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "B vs A";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(285, 171);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "C vs B";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(12, 203);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(399, 213);
            this.log.TabIndex = 7;
            this.log.Text = "";
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(179, 422);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 8;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(226, 171);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(53, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "B vs C";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 171);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(54, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "A vs C";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(358, 171);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(53, 23);
            this.button6.TabIndex = 11;
            this.button6.Text = "C vs A";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Unit3
            // 
            this.Unit3.BattleRating = 100;
            this.Unit3.BattleRatingMax = 100;
            this.Unit3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Unit3.FightsBack = true;
            this.Unit3.Location = new System.Drawing.Point(285, 27);
            this.Unit3.Morale = 4;
            this.Unit3.Name = "Unit3";
            this.Unit3.Size = new System.Drawing.Size(126, 138);
            this.Unit3.TabIndex = 5;
            // 
            // Unit2
            // 
            this.Unit2.BattleRating = 100;
            this.Unit2.BattleRatingMax = 100;
            this.Unit2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Unit2.FightsBack = true;
            this.Unit2.Location = new System.Drawing.Point(153, 27);
            this.Unit2.Morale = 4;
            this.Unit2.Name = "Unit2";
            this.Unit2.Size = new System.Drawing.Size(126, 138);
            this.Unit2.TabIndex = 4;
            // 
            // Unit1
            // 
            this.Unit1.BattleRating = 100;
            this.Unit1.BattleRatingMax = 100;
            this.Unit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Unit1.FightsBack = true;
            this.Unit1.Location = new System.Drawing.Point(12, 27);
            this.Unit1.Morale = 4;
            this.Unit1.Name = "Unit1";
            this.Unit1.Size = new System.Drawing.Size(126, 138);
            this.Unit1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "A (Unit1)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(191, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "B (Unit2)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(320, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "C (Unit3)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 446);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.log);
            this.Controls.Add(this.Unit3);
            this.Controls.Add(this.Unit2);
            this.Controls.Add(this.Unit1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "DnD Combat Sim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private Unit Unit1;
        private Unit Unit2;
        private Unit Unit3;
        private System.Windows.Forms.RichTextBox log;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

