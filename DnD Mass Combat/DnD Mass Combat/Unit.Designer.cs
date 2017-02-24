namespace DnD_Mass_Combat {
    partial class Unit {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.BR = new System.Windows.Forms.NumericUpDown();
            this.BRMax = new System.Windows.Forms.NumericUpDown();
            this.morale = new System.Windows.Forms.NumericUpDown();
            this.fightback = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BD = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.BR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BRMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.morale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BD)).BeginInit();
            this.SuspendLayout();
            // 
            // BR
            // 
            this.BR.Location = new System.Drawing.Point(41, 48);
            this.BR.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.BR.Name = "BR";
            this.BR.Size = new System.Drawing.Size(67, 20);
            this.BR.TabIndex = 1;
            this.BR.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.BR.ValueChanged += new System.EventHandler(this.BattleRating_ValueChanged);
            // 
            // BRMax
            // 
            this.BRMax.Location = new System.Drawing.Point(41, 22);
            this.BRMax.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.BRMax.Name = "BRMax";
            this.BRMax.Size = new System.Drawing.Size(67, 20);
            this.BRMax.TabIndex = 0;
            this.BRMax.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.BRMax.ValueChanged += new System.EventHandler(this.BattleRatingMax_ValueChanged);
            // 
            // morale
            // 
            this.morale.Location = new System.Drawing.Point(6, 89);
            this.morale.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.morale.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.morale.Name = "morale";
            this.morale.Size = new System.Drawing.Size(36, 20);
            this.morale.TabIndex = 2;
            this.morale.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // fightback
            // 
            this.fightback.AutoSize = true;
            this.fightback.Checked = true;
            this.fightback.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fightback.Location = new System.Drawing.Point(15, 115);
            this.fightback.Name = "fightback";
            this.fightback.Size = new System.Drawing.Size(82, 17);
            this.fightback.TabIndex = 3;
            this.fightback.TabStop = false;
            this.fightback.Text = "Fights Back";
            this.fightback.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Battle Rating";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Max";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Current";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Morale";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Battle Damage";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BD
            // 
            this.BD.Location = new System.Drawing.Point(49, 89);
            this.BD.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.BD.Name = "BD";
            this.BD.ReadOnly = true;
            this.BD.Size = new System.Drawing.Size(70, 20);
            this.BD.TabIndex = 13;
            this.BD.TabStop = false;
            this.BD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BD.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Unit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.BD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fightback);
            this.Controls.Add(this.morale);
            this.Controls.Add(this.BRMax);
            this.Controls.Add(this.BR);
            this.Name = "Unit";
            this.Size = new System.Drawing.Size(126, 138);
            ((System.ComponentModel.ISupportInitialize)(this.BR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BRMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.morale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown BR;
        private System.Windows.Forms.NumericUpDown BRMax;
        private System.Windows.Forms.NumericUpDown morale;
        private System.Windows.Forms.CheckBox fightback;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown BD;
    }
}
