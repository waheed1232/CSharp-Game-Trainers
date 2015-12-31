﻿namespace Final_Fantasy_VII
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.char1_maxTime = new System.Windows.Forms.CheckBox();
            this.char1_maxLimit = new System.Windows.Forms.CheckBox();
            this.char1_infMP = new System.Windows.Forms.CheckBox();
            this.char1_infHP = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.char2_maxTime = new System.Windows.Forms.CheckBox();
            this.char2_maxLimit = new System.Windows.Forms.CheckBox();
            this.char2_infMP = new System.Windows.Forms.CheckBox();
            this.char2_infHP = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.char3_maxTime = new System.Windows.Forms.CheckBox();
            this.char3_maxLimit = new System.Windows.Forms.CheckBox();
            this.char3_infMP = new System.Windows.Forms.CheckBox();
            this.char3_infHP = new System.Windows.Forms.CheckBox();
            this.maxQty = new System.Windows.Forms.CheckBox();
            this.maxGil = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ProcessID = new System.Windows.Forms.Label();
            this.maxHP = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.char1_maxTime);
            this.groupBox1.Controls.Add(this.char1_maxLimit);
            this.groupBox1.Controls.Add(this.char1_infMP);
            this.groupBox1.Controls.Add(this.char1_infHP);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(103, 109);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Character Slot 1";
            // 
            // char1_maxTime
            // 
            this.char1_maxTime.AutoSize = true;
            this.char1_maxTime.Location = new System.Drawing.Point(6, 88);
            this.char1_maxTime.Name = "char1_maxTime";
            this.char1_maxTime.Size = new System.Drawing.Size(72, 17);
            this.char1_maxTime.TabIndex = 3;
            this.char1_maxTime.Text = "Max Time";
            this.char1_maxTime.UseVisualStyleBackColor = true;
            // 
            // char1_maxLimit
            // 
            this.char1_maxLimit.AutoSize = true;
            this.char1_maxLimit.Location = new System.Drawing.Point(6, 65);
            this.char1_maxLimit.Name = "char1_maxLimit";
            this.char1_maxLimit.Size = new System.Drawing.Size(70, 17);
            this.char1_maxLimit.TabIndex = 2;
            this.char1_maxLimit.Text = "Max Limit";
            this.char1_maxLimit.UseVisualStyleBackColor = true;
            // 
            // char1_infMP
            // 
            this.char1_infMP.AutoSize = true;
            this.char1_infMP.Checked = true;
            this.char1_infMP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.char1_infMP.Location = new System.Drawing.Point(6, 42);
            this.char1_infMP.Name = "char1_infMP";
            this.char1_infMP.Size = new System.Drawing.Size(76, 17);
            this.char1_infMP.TabIndex = 1;
            this.char1_infMP.Text = "Infinite MP";
            this.char1_infMP.UseVisualStyleBackColor = true;
            // 
            // char1_infHP
            // 
            this.char1_infHP.AutoSize = true;
            this.char1_infHP.Checked = true;
            this.char1_infHP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.char1_infHP.Location = new System.Drawing.Point(6, 19);
            this.char1_infHP.Name = "char1_infHP";
            this.char1_infHP.Size = new System.Drawing.Size(75, 17);
            this.char1_infHP.TabIndex = 0;
            this.char1_infHP.Text = "Infinite HP";
            this.char1_infHP.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.char2_maxTime);
            this.groupBox2.Controls.Add(this.char2_maxLimit);
            this.groupBox2.Controls.Add(this.char2_infMP);
            this.groupBox2.Controls.Add(this.char2_infHP);
            this.groupBox2.Location = new System.Drawing.Point(121, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(105, 109);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Character Slot 2";
            // 
            // char2_maxTime
            // 
            this.char2_maxTime.AutoSize = true;
            this.char2_maxTime.Location = new System.Drawing.Point(6, 88);
            this.char2_maxTime.Name = "char2_maxTime";
            this.char2_maxTime.Size = new System.Drawing.Size(72, 17);
            this.char2_maxTime.TabIndex = 3;
            this.char2_maxTime.Text = "Max Time";
            this.char2_maxTime.UseVisualStyleBackColor = true;
            // 
            // char2_maxLimit
            // 
            this.char2_maxLimit.AutoSize = true;
            this.char2_maxLimit.Location = new System.Drawing.Point(6, 65);
            this.char2_maxLimit.Name = "char2_maxLimit";
            this.char2_maxLimit.Size = new System.Drawing.Size(70, 17);
            this.char2_maxLimit.TabIndex = 2;
            this.char2_maxLimit.Text = "Max Limit";
            this.char2_maxLimit.UseVisualStyleBackColor = true;
            // 
            // char2_infMP
            // 
            this.char2_infMP.AutoSize = true;
            this.char2_infMP.Checked = true;
            this.char2_infMP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.char2_infMP.Location = new System.Drawing.Point(6, 42);
            this.char2_infMP.Name = "char2_infMP";
            this.char2_infMP.Size = new System.Drawing.Size(76, 17);
            this.char2_infMP.TabIndex = 1;
            this.char2_infMP.Text = "Infinite MP";
            this.char2_infMP.UseVisualStyleBackColor = true;
            // 
            // char2_infHP
            // 
            this.char2_infHP.AutoSize = true;
            this.char2_infHP.Checked = true;
            this.char2_infHP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.char2_infHP.Location = new System.Drawing.Point(6, 19);
            this.char2_infHP.Name = "char2_infHP";
            this.char2_infHP.Size = new System.Drawing.Size(75, 17);
            this.char2_infHP.TabIndex = 0;
            this.char2_infHP.Text = "Infinite HP";
            this.char2_infHP.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.char3_maxTime);
            this.groupBox3.Controls.Add(this.char3_maxLimit);
            this.groupBox3.Controls.Add(this.char3_infMP);
            this.groupBox3.Controls.Add(this.char3_infHP);
            this.groupBox3.Location = new System.Drawing.Point(232, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(106, 109);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Character Slot 3";
            // 
            // char3_maxTime
            // 
            this.char3_maxTime.AutoSize = true;
            this.char3_maxTime.Location = new System.Drawing.Point(6, 88);
            this.char3_maxTime.Name = "char3_maxTime";
            this.char3_maxTime.Size = new System.Drawing.Size(72, 17);
            this.char3_maxTime.TabIndex = 3;
            this.char3_maxTime.Text = "Max Time";
            this.char3_maxTime.UseVisualStyleBackColor = true;
            // 
            // char3_maxLimit
            // 
            this.char3_maxLimit.AutoSize = true;
            this.char3_maxLimit.Location = new System.Drawing.Point(6, 65);
            this.char3_maxLimit.Name = "char3_maxLimit";
            this.char3_maxLimit.Size = new System.Drawing.Size(70, 17);
            this.char3_maxLimit.TabIndex = 2;
            this.char3_maxLimit.Text = "Max Limit";
            this.char3_maxLimit.UseVisualStyleBackColor = true;
            // 
            // char3_infMP
            // 
            this.char3_infMP.AutoSize = true;
            this.char3_infMP.Checked = true;
            this.char3_infMP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.char3_infMP.Location = new System.Drawing.Point(6, 42);
            this.char3_infMP.Name = "char3_infMP";
            this.char3_infMP.Size = new System.Drawing.Size(76, 17);
            this.char3_infMP.TabIndex = 1;
            this.char3_infMP.Text = "Infinite MP";
            this.char3_infMP.UseVisualStyleBackColor = true;
            // 
            // char3_infHP
            // 
            this.char3_infHP.AutoSize = true;
            this.char3_infHP.Checked = true;
            this.char3_infHP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.char3_infHP.Location = new System.Drawing.Point(6, 19);
            this.char3_infHP.Name = "char3_infHP";
            this.char3_infHP.Size = new System.Drawing.Size(75, 17);
            this.char3_infHP.TabIndex = 0;
            this.char3_infHP.Text = "Infinite HP";
            this.char3_infHP.UseVisualStyleBackColor = true;
            // 
            // maxQty
            // 
            this.maxQty.AutoSize = true;
            this.maxQty.Location = new System.Drawing.Point(176, 127);
            this.maxQty.Name = "maxQty";
            this.maxQty.Size = new System.Drawing.Size(164, 17);
            this.maxQty.TabIndex = 6;
            this.maxQty.Text = "99 qty of all items in inventory";
            this.maxQty.UseVisualStyleBackColor = true;
            // 
            // maxGil
            // 
            this.maxGil.AutoSize = true;
            this.maxGil.Location = new System.Drawing.Point(176, 150);
            this.maxGil.Name = "maxGil";
            this.maxGil.Size = new System.Drawing.Size(71, 17);
            this.maxGil.TabIndex = 7;
            this.maxGil.Text = "99999 Gil";
            this.maxGil.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // ProcessID
            // 
            this.ProcessID.AutoSize = true;
            this.ProcessID.Location = new System.Drawing.Point(12, 127);
            this.ProcessID.Name = "ProcessID";
            this.ProcessID.Size = new System.Drawing.Size(49, 13);
            this.ProcessID.TabIndex = 8;
            this.ProcessID.Text = "Proc: (id)";
            // 
            // maxHP
            // 
            this.maxHP.AutoSize = true;
            this.maxHP.Location = new System.Drawing.Point(15, 150);
            this.maxHP.Name = "maxHP";
            this.maxHP.Size = new System.Drawing.Size(108, 17);
            this.maxHP.TabIndex = 9;
            this.maxHP.Text = "Increase Max HP";
            this.maxHP.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(268, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "NewAgeSoldier";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 178);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxHP);
            this.Controls.Add(this.ProcessID);
            this.Controls.Add(this.maxGil);
            this.Controls.Add(this.maxQty);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Final Fantasy VII Trainer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox char1_maxTime;
        private System.Windows.Forms.CheckBox char1_maxLimit;
        private System.Windows.Forms.CheckBox char1_infMP;
        private System.Windows.Forms.CheckBox char1_infHP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox char2_maxTime;
        private System.Windows.Forms.CheckBox char2_maxLimit;
        private System.Windows.Forms.CheckBox char2_infMP;
        private System.Windows.Forms.CheckBox char2_infHP;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox char3_maxTime;
        private System.Windows.Forms.CheckBox char3_maxLimit;
        private System.Windows.Forms.CheckBox char3_infMP;
        private System.Windows.Forms.CheckBox char3_infHP;
        private System.Windows.Forms.CheckBox maxQty;
        private System.Windows.Forms.CheckBox maxGil;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label ProcessID;
        private System.Windows.Forms.CheckBox maxHP;
        private System.Windows.Forms.Label label1;
    }
}

