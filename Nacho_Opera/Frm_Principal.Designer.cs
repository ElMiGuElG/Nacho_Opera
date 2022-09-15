
namespace Nacho_Opera
{
    partial class Frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.Txt_ValorA = new System.Windows.Forms.TextBox();
            this.Txt_ValorB = new System.Windows.Forms.TextBox();
            this.Lbl_IngrseA = new System.Windows.Forms.Label();
            this.Lbl_IngresoB = new System.Windows.Forms.Label();
            this.Lbl_Resultado = new System.Windows.Forms.Label();
            this.Btn_Sumar = new System.Windows.Forms.Button();
            this.Btn_Resta = new System.Windows.Forms.Button();
            this.Btn_Multiplicar = new System.Windows.Forms.Button();
            this.Btn_Division = new System.Windows.Forms.Button();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.Lbl_Respuesta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_ValorA
            // 
            this.Txt_ValorA.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ValorA.Location = new System.Drawing.Point(222, 46);
            this.Txt_ValorA.Name = "Txt_ValorA";
            this.Txt_ValorA.Size = new System.Drawing.Size(260, 22);
            this.Txt_ValorA.TabIndex = 0;
            // 
            // Txt_ValorB
            // 
            this.Txt_ValorB.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ValorB.Location = new System.Drawing.Point(222, 92);
            this.Txt_ValorB.Name = "Txt_ValorB";
            this.Txt_ValorB.Size = new System.Drawing.Size(260, 22);
            this.Txt_ValorB.TabIndex = 1;
            // 
            // Lbl_IngrseA
            // 
            this.Lbl_IngrseA.AutoSize = true;
            this.Lbl_IngrseA.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_IngrseA.Location = new System.Drawing.Point(43, 47);
            this.Lbl_IngrseA.Name = "Lbl_IngrseA";
            this.Lbl_IngrseA.Size = new System.Drawing.Size(159, 16);
            this.Lbl_IngrseA.TabIndex = 2;
            this.Lbl_IngrseA.Text = "Ingrese El Primer Valor:";
            // 
            // Lbl_IngresoB
            // 
            this.Lbl_IngresoB.AutoSize = true;
            this.Lbl_IngresoB.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_IngresoB.Location = new System.Drawing.Point(43, 92);
            this.Lbl_IngresoB.Name = "Lbl_IngresoB";
            this.Lbl_IngresoB.Size = new System.Drawing.Size(173, 16);
            this.Lbl_IngresoB.TabIndex = 3;
            this.Lbl_IngresoB.Text = "Ingrese El Segundo Valor:";
            // 
            // Lbl_Resultado
            // 
            this.Lbl_Resultado.AutoSize = true;
            this.Lbl_Resultado.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Resultado.Location = new System.Drawing.Point(43, 223);
            this.Lbl_Resultado.Name = "Lbl_Resultado";
            this.Lbl_Resultado.Size = new System.Drawing.Size(74, 16);
            this.Lbl_Resultado.TabIndex = 4;
            this.Lbl_Resultado.Text = "Resultado:";
            // 
            // Btn_Sumar
            // 
            this.Btn_Sumar.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Sumar.Location = new System.Drawing.Point(46, 149);
            this.Btn_Sumar.Name = "Btn_Sumar";
            this.Btn_Sumar.Size = new System.Drawing.Size(90, 40);
            this.Btn_Sumar.TabIndex = 6;
            this.Btn_Sumar.Text = "Sumar";
            this.Btn_Sumar.UseVisualStyleBackColor = true;
            this.Btn_Sumar.Click += new System.EventHandler(this.Btn_Sumar_Click);
            // 
            // Btn_Resta
            // 
            this.Btn_Resta.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Resta.Location = new System.Drawing.Point(163, 149);
            this.Btn_Resta.Name = "Btn_Resta";
            this.Btn_Resta.Size = new System.Drawing.Size(90, 40);
            this.Btn_Resta.TabIndex = 7;
            this.Btn_Resta.Text = "Restar";
            this.Btn_Resta.UseVisualStyleBackColor = true;
            this.Btn_Resta.Click += new System.EventHandler(this.Btn_Resta_Click);
            // 
            // Btn_Multiplicar
            // 
            this.Btn_Multiplicar.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Multiplicar.Location = new System.Drawing.Point(277, 149);
            this.Btn_Multiplicar.Name = "Btn_Multiplicar";
            this.Btn_Multiplicar.Size = new System.Drawing.Size(90, 40);
            this.Btn_Multiplicar.TabIndex = 8;
            this.Btn_Multiplicar.Text = "Multiplicar";
            this.Btn_Multiplicar.UseVisualStyleBackColor = true;
            this.Btn_Multiplicar.Click += new System.EventHandler(this.Btn_Multiplicar_Click);
            // 
            // Btn_Division
            // 
            this.Btn_Division.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Division.Location = new System.Drawing.Point(392, 149);
            this.Btn_Division.Name = "Btn_Division";
            this.Btn_Division.Size = new System.Drawing.Size(90, 40);
            this.Btn_Division.TabIndex = 9;
            this.Btn_Division.Text = "Dividir";
            this.Btn_Division.UseVisualStyleBackColor = true;
            this.Btn_Division.Click += new System.EventHandler(this.Btn_Division_Click);
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Limpiar.Location = new System.Drawing.Point(332, 218);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(150, 29);
            this.Btn_Limpiar.TabIndex = 10;
            this.Btn_Limpiar.Text = "Limpiar Form";
            this.Btn_Limpiar.UseVisualStyleBackColor = true;
            this.Btn_Limpiar.Click += new System.EventHandler(this.Btn_Limpiar_Click);
            // 
            // Lbl_Respuesta
            // 
            this.Lbl_Respuesta.AutoSize = true;
            this.Lbl_Respuesta.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Respuesta.Location = new System.Drawing.Point(123, 221);
            this.Lbl_Respuesta.Name = "Lbl_Respuesta";
            this.Lbl_Respuesta.Size = new System.Drawing.Size(0, 20);
            this.Lbl_Respuesta.TabIndex = 11;
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 317);
            this.Controls.Add(this.Lbl_Respuesta);
            this.Controls.Add(this.Btn_Limpiar);
            this.Controls.Add(this.Btn_Division);
            this.Controls.Add(this.Btn_Multiplicar);
            this.Controls.Add(this.Btn_Resta);
            this.Controls.Add(this.Btn_Sumar);
            this.Controls.Add(this.Lbl_Resultado);
            this.Controls.Add(this.Lbl_IngresoB);
            this.Controls.Add(this.Lbl_IngrseA);
            this.Controls.Add(this.Txt_ValorB);
            this.Controls.Add(this.Txt_ValorA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Principal";
            this.Text = "Nacho_Opera";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_ValorA;
        private System.Windows.Forms.TextBox Txt_ValorB;
        private System.Windows.Forms.Label Lbl_IngrseA;
        private System.Windows.Forms.Label Lbl_IngresoB;
        private System.Windows.Forms.Label Lbl_Resultado;
        private System.Windows.Forms.Button Btn_Sumar;
        private System.Windows.Forms.Button Btn_Resta;
        private System.Windows.Forms.Button Btn_Multiplicar;
        private System.Windows.Forms.Button Btn_Division;
        private System.Windows.Forms.Button Btn_Limpiar;
        private System.Windows.Forms.Label Lbl_Respuesta;
    }
}

