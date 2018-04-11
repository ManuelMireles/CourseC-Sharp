namespace CourseC_Sharp.Excercises
{
    partial class FrmArrays
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
            this.txtResults = new System.Windows.Forms.TextBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.lblStar = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChars = new System.Windows.Forms.Button();
            this.btnWords = new System.Windows.Forms.Button();
            this.grbArray = new System.Windows.Forms.GroupBox();
            this.btnNumbers = new System.Windows.Forms.Button();
            this.grbList = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtValueList = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReorder = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grbArray.SuspendLayout();
            this.grbList.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtResults);
            this.groupBox1.Location = new System.Drawing.Point(15, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 243);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultados";
            // 
            // txtResults
            // 
            this.txtResults.BackColor = System.Drawing.Color.Black;
            this.txtResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResults.ForeColor = System.Drawing.Color.White;
            this.txtResults.Location = new System.Drawing.Point(3, 16);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtResults.Size = new System.Drawing.Size(381, 224);
            this.txtResults.TabIndex = 0;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(124, 13);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(237, 20);
            this.txtValue.TabIndex = 5;
            // 
            // lblStar
            // 
            this.lblStar.AutoSize = true;
            this.lblStar.Location = new System.Drawing.Point(6, 16);
            this.lblStar.Name = "lblStar";
            this.lblStar.Size = new System.Drawing.Size(77, 13);
            this.lblStar.TabIndex = 6;
            this.lblStar.Text = "Modificar Valor";
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(124, 39);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(237, 20);
            this.txtPosition.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Posicion:";
            // 
            // btnChars
            // 
            this.btnChars.Location = new System.Drawing.Point(124, 65);
            this.btnChars.Name = "btnChars";
            this.btnChars.Size = new System.Drawing.Size(75, 23);
            this.btnChars.TabIndex = 10;
            this.btnChars.Text = "Letras";
            this.btnChars.UseVisualStyleBackColor = true;
            this.btnChars.Click += new System.EventHandler(this.btnChars_Click);
            // 
            // btnWords
            // 
            this.btnWords.Location = new System.Drawing.Point(205, 65);
            this.btnWords.Name = "btnWords";
            this.btnWords.Size = new System.Drawing.Size(75, 23);
            this.btnWords.TabIndex = 11;
            this.btnWords.Text = "Palabras";
            this.btnWords.UseVisualStyleBackColor = true;
            this.btnWords.Click += new System.EventHandler(this.btnWords_Click);
            // 
            // grbArray
            // 
            this.grbArray.Controls.Add(this.btnNumbers);
            this.grbArray.Controls.Add(this.lblStar);
            this.grbArray.Controls.Add(this.btnWords);
            this.grbArray.Controls.Add(this.txtValue);
            this.grbArray.Controls.Add(this.btnChars);
            this.grbArray.Controls.Add(this.label1);
            this.grbArray.Controls.Add(this.txtPosition);
            this.grbArray.Location = new System.Drawing.Point(15, 12);
            this.grbArray.Name = "grbArray";
            this.grbArray.Size = new System.Drawing.Size(384, 100);
            this.grbArray.TabIndex = 12;
            this.grbArray.TabStop = false;
            this.grbArray.Text = "Arreglos";
            // 
            // btnNumbers
            // 
            this.btnNumbers.Location = new System.Drawing.Point(286, 65);
            this.btnNumbers.Name = "btnNumbers";
            this.btnNumbers.Size = new System.Drawing.Size(75, 23);
            this.btnNumbers.TabIndex = 12;
            this.btnNumbers.Text = "Numeros";
            this.btnNumbers.UseVisualStyleBackColor = true;
            this.btnNumbers.Click += new System.EventHandler(this.btnNumbers_Click);
            // 
            // grbList
            // 
            this.grbList.Controls.Add(this.btnReorder);
            this.grbList.Controls.Add(this.btnSearch);
            this.grbList.Controls.Add(this.label2);
            this.grbList.Controls.Add(this.btnDelete);
            this.grbList.Controls.Add(this.txtValueList);
            this.grbList.Controls.Add(this.btnAdd);
            this.grbList.Location = new System.Drawing.Point(15, 118);
            this.grbList.Name = "grbList";
            this.grbList.Size = new System.Drawing.Size(384, 75);
            this.grbList.TabIndex = 13;
            this.grbList.TabStop = false;
            this.grbList.Text = "Listas";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(286, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Valor";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(205, 39);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtValueList
            // 
            this.txtValueList.Location = new System.Drawing.Point(124, 13);
            this.txtValueList.Name = "txtValueList";
            this.txtValueList.Size = new System.Drawing.Size(237, 20);
            this.txtValueList.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(124, 39);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReorder
            // 
            this.btnReorder.Location = new System.Drawing.Point(43, 39);
            this.btnReorder.Name = "btnReorder";
            this.btnReorder.Size = new System.Drawing.Size(75, 23);
            this.btnReorder.TabIndex = 13;
            this.btnReorder.Text = "Reordenar";
            this.btnReorder.UseVisualStyleBackColor = true;
            this.btnReorder.Click += new System.EventHandler(this.btnReorder_Click);
            // 
            // FrmArrays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 443);
            this.Controls.Add(this.grbList);
            this.Controls.Add(this.grbArray);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmArrays";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Arreglos y listas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbArray.ResumeLayout(false);
            this.grbArray.PerformLayout();
            this.grbList.ResumeLayout(false);
            this.grbList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label lblStar;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChars;
        private System.Windows.Forms.Button btnWords;
        private System.Windows.Forms.GroupBox grbArray;
        private System.Windows.Forms.Button btnNumbers;
        private System.Windows.Forms.GroupBox grbList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtValueList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReorder;
    }
}