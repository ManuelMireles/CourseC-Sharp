namespace CourseC_Sharp
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.rdbExerciseCicles = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbForms = new System.Windows.Forms.RadioButton();
            this.rdbPoliform = new System.Windows.Forms.RadioButton();
            this.rdbArraysList = new System.Windows.Forms.RadioButton();
            this.rdbConditionals = new System.Windows.Forms.RadioButton();
            this.rdbExercisePOO = new System.Windows.Forms.RadioButton();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnAction = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbExerciseCicles
            // 
            this.rdbExerciseCicles.AutoSize = true;
            this.rdbExerciseCicles.Checked = true;
            this.rdbExerciseCicles.Location = new System.Drawing.Point(6, 19);
            this.rdbExerciseCicles.Name = "rdbExerciseCicles";
            this.rdbExerciseCicles.Size = new System.Drawing.Size(111, 17);
            this.rdbExerciseCicles.TabIndex = 1;
            this.rdbExerciseCicles.TabStop = true;
            this.rdbExerciseCicles.Text = "Ejercicio 1: Ciclos ";
            this.rdbExerciseCicles.UseVisualStyleBackColor = true;
            this.rdbExerciseCicles.CheckedChanged += new System.EventHandler(this.rdbExercise1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rdbForms);
            this.groupBox1.Controls.Add(this.rdbPoliform);
            this.groupBox1.Controls.Add(this.rdbArraysList);
            this.groupBox1.Controls.Add(this.rdbConditionals);
            this.groupBox1.Controls.Add(this.rdbExercisePOO);
            this.groupBox1.Controls.Add(this.rdbExerciseCicles);
            this.groupBox1.Controls.Add(this.pbImage);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 192);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ejercicios";
            // 
            // rdbForms
            // 
            this.rdbForms.AutoSize = true;
            this.rdbForms.Location = new System.Drawing.Point(6, 134);
            this.rdbForms.Name = "rdbForms";
            this.rdbForms.Size = new System.Drawing.Size(148, 17);
            this.rdbForms.TabIndex = 6;
            this.rdbForms.Text = "Ejercicio 6: Base de datos";
            this.rdbForms.UseVisualStyleBackColor = true;
            this.rdbForms.CheckedChanged += new System.EventHandler(this.rdbExercise1_CheckedChanged);
            // 
            // rdbPoliform
            // 
            this.rdbPoliform.AutoSize = true;
            this.rdbPoliform.Location = new System.Drawing.Point(6, 111);
            this.rdbPoliform.Name = "rdbPoliform";
            this.rdbPoliform.Size = new System.Drawing.Size(138, 17);
            this.rdbPoliform.TabIndex = 5;
            this.rdbPoliform.Text = "Ejercicio 5: Polimorfismo";
            this.rdbPoliform.UseVisualStyleBackColor = true;
            this.rdbPoliform.CheckedChanged += new System.EventHandler(this.rdbExercise1_CheckedChanged);
            // 
            // rdbArraysList
            // 
            this.rdbArraysList.AutoSize = true;
            this.rdbArraysList.Location = new System.Drawing.Point(6, 65);
            this.rdbArraysList.Name = "rdbArraysList";
            this.rdbArraysList.Size = new System.Drawing.Size(147, 17);
            this.rdbArraysList.TabIndex = 4;
            this.rdbArraysList.Text = "Ejercicio 3: Arrays y Listas";
            this.rdbArraysList.UseVisualStyleBackColor = true;
            this.rdbArraysList.CheckedChanged += new System.EventHandler(this.rdbExercise1_CheckedChanged);
            // 
            // rdbConditionals
            // 
            this.rdbConditionals.AutoSize = true;
            this.rdbConditionals.Location = new System.Drawing.Point(6, 42);
            this.rdbConditionals.Name = "rdbConditionals";
            this.rdbConditionals.Size = new System.Drawing.Size(146, 17);
            this.rdbConditionals.TabIndex = 3;
            this.rdbConditionals.Text = "Ejercicio 2: Condicionales";
            this.rdbConditionals.UseVisualStyleBackColor = true;
            this.rdbConditionals.CheckedChanged += new System.EventHandler(this.rdbExercise1_CheckedChanged);
            // 
            // rdbExercisePOO
            // 
            this.rdbExercisePOO.AutoSize = true;
            this.rdbExercisePOO.Location = new System.Drawing.Point(6, 88);
            this.rdbExercisePOO.Name = "rdbExercisePOO";
            this.rdbExercisePOO.Size = new System.Drawing.Size(244, 17);
            this.rdbExercisePOO.TabIndex = 2;
            this.rdbExercisePOO.Text = "Ejercicio 4: Programación orientada a objectos";
            this.rdbExercisePOO.UseVisualStyleBackColor = true;
            this.rdbExercisePOO.CheckedChanged += new System.EventHandler(this.rdbExercise1_CheckedChanged);
            // 
            // pbImage
            // 
            this.pbImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImage.Image = global::CourseC_Sharp.Properties.Resources.c_;
            this.pbImage.Location = new System.Drawing.Point(368, 17);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(157, 168);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // btnAction
            // 
            this.btnAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAction.Location = new System.Drawing.Point(439, 210);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(104, 23);
            this.btnAction.TabIndex = 3;
            this.btnAction.Text = "Ir a Ejercicio";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(552, 245);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Curso básico de C#";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.RadioButton rdbExerciseCicles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.RadioButton rdbExercisePOO;
        private System.Windows.Forms.RadioButton rdbConditionals;
        private System.Windows.Forms.RadioButton rdbArraysList;
        private System.Windows.Forms.RadioButton rdbPoliform;
        private System.Windows.Forms.RadioButton rdbForms;
    }
}

