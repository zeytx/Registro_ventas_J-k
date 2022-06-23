namespace registro.contenedor
{
	partial class Registro
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
			this.components = new System.ComponentModel.Container();
			this.agregar = new System.Windows.Forms.Button();
			this.cant = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.preci = new System.Windows.Forms.TextBox();
			this.produc = new System.Windows.Forms.TextBox();
			this.mail = new System.Windows.Forms.TextBox();
			this.ape = new System.Windows.Forms.TextBox();
			this.nom = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.error = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
			this.SuspendLayout();
			// 
			// agregar
			// 
			this.agregar.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.agregar.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.agregar.Font = new System.Drawing.Font("Russo One", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.agregar.Image = global::registro.Properties.Resources.agregarpng;
			this.agregar.Location = new System.Drawing.Point(106, 373);
			this.agregar.Name = "agregar";
			this.agregar.Size = new System.Drawing.Size(156, 47);
			this.agregar.TabIndex = 29;
			this.agregar.UseVisualStyleBackColor = false;
			this.agregar.Click += new System.EventHandler(this.button1_Click);
			// 
			// cant
			// 
			this.cant.Location = new System.Drawing.Point(168, 296);
			this.cant.Name = "cant";
			this.cant.Size = new System.Drawing.Size(175, 22);
			this.cant.TabIndex = 28;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(22, 291);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 27);
			this.label7.TabIndex = 27;
			this.label7.Text = "Cantidad:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(25, 237);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(73, 27);
			this.label6.TabIndex = 26;
			this.label6.Text = "Precio:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(22, 185);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(99, 27);
			this.label5.TabIndex = 25;
			this.label5.Text = "Producto:";
			// 
			// preci
			// 
			this.preci.Location = new System.Drawing.Point(168, 242);
			this.preci.Name = "preci";
			this.preci.Size = new System.Drawing.Size(175, 22);
			this.preci.TabIndex = 24;
			// 
			// produc
			// 
			this.produc.Location = new System.Drawing.Point(168, 190);
			this.produc.Name = "produc";
			this.produc.Size = new System.Drawing.Size(175, 22);
			this.produc.TabIndex = 23;
			// 
			// mail
			// 
			this.mail.Location = new System.Drawing.Point(168, 134);
			this.mail.Name = "mail";
			this.mail.Size = new System.Drawing.Size(175, 22);
			this.mail.TabIndex = 22;
			// 
			// ape
			// 
			this.ape.Location = new System.Drawing.Point(168, 80);
			this.ape.Name = "ape";
			this.ape.Size = new System.Drawing.Size(175, 22);
			this.ape.TabIndex = 21;
			// 
			// nom
			// 
			this.nom.Location = new System.Drawing.Point(168, 29);
			this.nom.Name = "nom";
			this.nom.Size = new System.Drawing.Size(175, 22);
			this.nom.TabIndex = 20;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(22, 129);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 27);
			this.label4.TabIndex = 18;
			this.label4.Text = "E-mail:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(22, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 27);
			this.label3.TabIndex = 17;
			this.label3.Text = "Apellido:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(22, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 27);
			this.label2.TabIndex = 16;
			this.label2.Text = "Nombre:";
			// 
			// error
			// 
			this.error.ContainerControl = this;
			// 
			// Registro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(370, 439);
			this.Controls.Add(this.agregar);
			this.Controls.Add(this.cant);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.preci);
			this.Controls.Add(this.produc);
			this.Controls.Add(this.mail);
			this.Controls.Add(this.ape);
			this.Controls.Add(this.nom);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Name = "Registro";
			this.Text = "Registro";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Registro_FormClosed);
			this.Load += new System.EventHandler(this.Registro_Load);
			((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button agregar;
		private System.Windows.Forms.TextBox cant;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox preci;
		private System.Windows.Forms.TextBox produc;
		private System.Windows.Forms.TextBox mail;
		private System.Windows.Forms.TextBox ape;
		private System.Windows.Forms.TextBox nom;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ErrorProvider error;
	}
}