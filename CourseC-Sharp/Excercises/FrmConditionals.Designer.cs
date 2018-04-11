namespace CourseC_Sharp.Excercises
{
    partial class FrmConditionals
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
            this.btnSwitch = new System.Windows.Forms.Button();
            this.btnMultiple = new System.Windows.Forms.Button();
            this.btnSimple = new System.Windows.Forms.Button();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStar = new System.Windows.Forms.TextBox();
            this.lblStar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(238, 64);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(75, 23);
            this.btnSwitch.TabIndex = 12;
            this.btnSwitch.Text = "Switch";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // btnMultiple
            // 
            this.btnMultiple.Location = new System.Drawing.Point(157, 64);
            this.btnMultiple.Name = "btnMultiple";
            this.btnMultiple.Size = new System.Drawing.Size(75, 23);
            this.btnMultiple.TabIndex = 11;
            this.btnMultiple.Text = "IF Multiple";
            this.btnMultiple.UseVisualStyleBackColor = true;
            this.btnMultiple.Click += new System.EventHandler(this.btnMultiple_Click);
            // 
            // btnSimple
            // 
            this.btnSimple.Location = new System.Drawing.Point(76, 64);
            this.btnSimple.Name = "btnSimple";
            this.btnSimple.Size = new System.Drawing.Size(75, 23);
            this.btnSimple.TabIndex = 9;
            this.btnSimple.Text = "IF simple";
            this.btnSimple.UseVisualStyleBackColor = true;
            this.btnSimple.Click += new System.EventHandler(this.btnSimple_Click);
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(76, 38);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(318, 20);
            this.txtEnd.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Valor Y:";
            // 
            // txtStar
            // 
            this.txtStar.Location = new System.Drawing.Point(76, 12);
            this.txtStar.Name = "txtStar";
            this.txtStar.Size = new System.Drawing.Size(318, 20);
            this.txtStar.TabIndex = 6;
            // 
            // lblStar
            // 
            this.lblStar.AutoSize = true;
            this.lblStar.Location = new System.Drawing.Point(6, 12);
            this.lblStar.Name = "lblStar";
            this.lblStar.Size = new System.Drawing.Size(47, 13);
            this.lblStar.TabIndex = 7;
            this.lblStar.Text = "Valor  X:";
            // 
            // FrmConditionals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 99);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.btnMultiple);
            this.Controls.Add(this.btnSimple);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStar);
            this.Controls.Add(this.lblStar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmConditionals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Condicionales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Button btnMultiple;
        private System.Windows.Forms.Button btnSimple;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStar;
        private System.Windows.Forms.Label lblStar;
    }
}