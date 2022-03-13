
namespace Prueba1Git
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
            this.btnClickThis = new System.Windows.Forms.Button();
            this.lblHelloWorld = new System.Windows.Forms.Label();
            this.btnPulsaeste = new System.Windows.Forms.Button();
            this.lblHolaMundo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClickThis
            // 
            this.btnClickThis.Location = new System.Drawing.Point(95, 102);
            this.btnClickThis.Name = "btnClickThis";
            this.btnClickThis.Size = new System.Drawing.Size(75, 23);
            this.btnClickThis.TabIndex = 0;
            this.btnClickThis.Text = "Click this";
            this.btnClickThis.UseVisualStyleBackColor = true;
            this.btnClickThis.Click += new System.EventHandler(this.btnClickThis_Click);
            // 
            // lblHelloWorld
            // 
            this.lblHelloWorld.AutoSize = true;
            this.lblHelloWorld.Location = new System.Drawing.Point(92, 159);
            this.lblHelloWorld.Name = "lblHelloWorld";
            this.lblHelloWorld.Size = new System.Drawing.Size(35, 13);
            this.lblHelloWorld.TabIndex = 1;
            this.lblHelloWorld.Text = "label1";
            // 
            // btnPulsaeste
            // 
            this.btnPulsaeste.Location = new System.Drawing.Point(246, 101);
            this.btnPulsaeste.Name = "btnPulsaeste";
            this.btnPulsaeste.Size = new System.Drawing.Size(75, 23);
            this.btnPulsaeste.TabIndex = 2;
            this.btnPulsaeste.Text = "Pulsa este";
            this.btnPulsaeste.UseVisualStyleBackColor = true;
            this.btnPulsaeste.Click += new System.EventHandler(this.btnPulsaeste_Click);
            // 
            // lblHolaMundo
            // 
            this.lblHolaMundo.AutoSize = true;
            this.lblHolaMundo.Location = new System.Drawing.Point(246, 158);
            this.lblHolaMundo.Name = "lblHolaMundo";
            this.lblHolaMundo.Size = new System.Drawing.Size(35, 13);
            this.lblHolaMundo.TabIndex = 3;
            this.lblHolaMundo.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 304);
            this.Controls.Add(this.lblHolaMundo);
            this.Controls.Add(this.btnPulsaeste);
            this.Controls.Add(this.lblHelloWorld);
            this.Controls.Add(this.btnClickThis);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClickThis;
        private System.Windows.Forms.Label lblHelloWorld;
        private System.Windows.Forms.Button btnPulsaeste;
        private System.Windows.Forms.Label lblHolaMundo;
    }
}

