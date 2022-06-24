namespace Escrito
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.txtBox3 = new System.Windows.Forms.TextBox();
            this.Boton = new System.Windows.Forms.Button();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.listaBox = new System.Windows.Forms.ListBox();
            this.boton2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.boton3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(82, 73);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(100, 20);
            this.txtBox1.TabIndex = 3;
            // 
            // txtBox3
            // 
            this.txtBox3.Location = new System.Drawing.Point(82, 153);
            this.txtBox3.Name = "txtBox3";
            this.txtBox3.Size = new System.Drawing.Size(100, 20);
            this.txtBox3.TabIndex = 4;
            // 
            // Boton
            // 
            this.Boton.Location = new System.Drawing.Point(82, 200);
            this.Boton.Name = "Boton";
            this.Boton.Size = new System.Drawing.Size(100, 23);
            this.Boton.TabIndex = 5;
            this.Boton.Text = "Agregar";
            this.Boton.UseVisualStyleBackColor = true;
            this.Boton.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBox2
            // 
            this.txtBox2.Location = new System.Drawing.Point(82, 111);
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(100, 20);
            this.txtBox2.TabIndex = 6;
            // 
            // listaBox
            // 
            this.listaBox.FormattingEnabled = true;
            this.listaBox.Location = new System.Drawing.Point(234, 65);
            this.listaBox.Name = "listaBox";
            this.listaBox.Size = new System.Drawing.Size(325, 134);
            this.listaBox.TabIndex = 7;
            // 
            // boton2
            // 
            this.boton2.Location = new System.Drawing.Point(94, 256);
            this.boton2.Name = "boton2";
            this.boton2.Size = new System.Drawing.Size(75, 23);
            this.boton2.TabIndex = 8;
            this.boton2.Text = "Mostar";
            this.boton2.UseVisualStyleBackColor = true;
            this.boton2.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(319, 225);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(319, 273);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(319, 317);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 11;
            // 
            // boton3
            // 
            this.boton3.Location = new System.Drawing.Point(329, 361);
            this.boton3.Name = "boton3";
            this.boton3.Size = new System.Drawing.Size(75, 23);
            this.boton3.TabIndex = 12;
            this.boton3.Text = "Compilar";
            this.boton3.UseVisualStyleBackColor = true;
            this.boton3.Click += new System.EventHandler(this.boton3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boton3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.boton2);
            this.Controls.Add(this.listaBox);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.Boton);
            this.Controls.Add(this.txtBox3);
            this.Controls.Add(this.txtBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.TextBox txtBox3;
        private System.Windows.Forms.Button Boton;
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.ListBox listaBox;
        private System.Windows.Forms.Button boton2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button boton3;
    }
}

