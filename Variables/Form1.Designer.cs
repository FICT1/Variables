namespace Variables
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbNombre = new System.Windows.Forms.TextBox();
            this.TbCodigo = new System.Windows.Forms.TextBox();
            this.BtnVerificar = new System.Windows.Forms.Button();
            this.lblVariableLocal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TbNombre
            // 
            this.TbNombre.Location = new System.Drawing.Point(118, 81);
            this.TbNombre.Name = "TbNombre";
            this.TbNombre.Size = new System.Drawing.Size(218, 22);
            this.TbNombre.TabIndex = 2;
            // 
            // TbCodigo
            // 
            this.TbCodigo.Location = new System.Drawing.Point(117, 138);
            this.TbCodigo.Name = "TbCodigo";
            this.TbCodigo.Size = new System.Drawing.Size(175, 22);
            this.TbCodigo.TabIndex = 3;
            this.TbCodigo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // BtnVerificar
            // 
            this.BtnVerificar.Location = new System.Drawing.Point(170, 188);
            this.BtnVerificar.Name = "BtnVerificar";
            this.BtnVerificar.Size = new System.Drawing.Size(281, 60);
            this.BtnVerificar.TabIndex = 4;
            this.BtnVerificar.Text = "Verificar";
            this.BtnVerificar.UseVisualStyleBackColor = true;
            this.BtnVerificar.Click += new System.EventHandler(this.BtnVerificar_Click);
            // 
            // lblVariableLocal
            // 
            this.lblVariableLocal.AutoSize = true;
            this.lblVariableLocal.Location = new System.Drawing.Point(185, 287);
            this.lblVariableLocal.Name = "lblVariableLocal";
            this.lblVariableLocal.Size = new System.Drawing.Size(94, 16);
            this.lblVariableLocal.TabIndex = 5;
            this.lblVariableLocal.Text = "Variable Local";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Variable Global";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 559);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblVariableLocal);
            this.Controls.Add(this.BtnVerificar);
            this.Controls.Add(this.TbCodigo);
            this.Controls.Add(this.TbNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbNombre;
        private System.Windows.Forms.TextBox TbCodigo;
        private System.Windows.Forms.Button BtnVerificar;
        private System.Windows.Forms.Label lblVariableLocal;
        private System.Windows.Forms.Label label3;
    }
}

