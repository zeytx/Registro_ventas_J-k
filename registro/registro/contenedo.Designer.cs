namespace registro
{
	partial class contenedo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(contenedo));
			this.regis = new System.Windows.Forms.Button();
			this.visualizar = new System.Windows.Forms.Button();
			this.salir = new System.Windows.Forms.Button();
			this.mod = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// regis
			// 
			this.regis.Image = ((System.Drawing.Image)(resources.GetObject("regis.Image")));
			this.regis.Location = new System.Drawing.Point(22, 119);
			this.regis.Name = "regis";
			this.regis.Size = new System.Drawing.Size(272, 236);
			this.regis.TabIndex = 0;
			this.regis.UseVisualStyleBackColor = true;
			this.regis.Click += new System.EventHandler(this.button1_Click);
			// 
			// visualizar
			// 
			this.visualizar.Image = ((System.Drawing.Image)(resources.GetObject("visualizar.Image")));
			this.visualizar.Location = new System.Drawing.Point(313, 119);
			this.visualizar.Name = "visualizar";
			this.visualizar.Size = new System.Drawing.Size(272, 236);
			this.visualizar.TabIndex = 1;
			this.visualizar.UseVisualStyleBackColor = true;
			this.visualizar.Click += new System.EventHandler(this.visualizar_Click);
			// 
			// salir
			// 
			this.salir.Image = ((System.Drawing.Image)(resources.GetObject("salir.Image")));
			this.salir.Location = new System.Drawing.Point(609, 119);
			this.salir.Name = "salir";
			this.salir.Size = new System.Drawing.Size(272, 236);
			this.salir.TabIndex = 2;
			this.salir.UseVisualStyleBackColor = true;
			this.salir.Click += new System.EventHandler(this.button3_Click);
			// 
			// mod
			// 
			this.mod.Image = ((System.Drawing.Image)(resources.GetObject("mod.Image")));
			this.mod.Location = new System.Drawing.Point(167, 421);
			this.mod.Name = "mod";
			this.mod.Size = new System.Drawing.Size(272, 236);
			this.mod.TabIndex = 3;
			this.mod.UseVisualStyleBackColor = true;
			this.mod.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// button2
			// 
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.Location = new System.Drawing.Point(485, 421);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(272, 236);
			this.button2.TabIndex = 4;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Russo One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(106, 91);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(106, 25);
			this.label1.TabIndex = 5;
			this.label1.Text = "Registrar";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Russo One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(386, 91);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(114, 25);
			this.label2.TabIndex = 6;
			this.label2.Text = "Visualizar";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Russo One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(712, 91);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 25);
			this.label3.TabIndex = 7;
			this.label3.Text = "Salir";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Russo One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(248, 393);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(109, 25);
			this.label4.TabIndex = 8;
			this.label4.Text = "Modificar";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Russo One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(561, 393);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(97, 25);
			this.label5.TabIndex = 9;
			this.label5.Text = "Eliminar";
			// 
			// contenedo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(902, 760);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.mod);
			this.Controls.Add(this.salir);
			this.Controls.Add(this.visualizar);
			this.Controls.Add(this.regis);
			this.Name = "contenedo";
			this.Text = "contenedo";
			this.Load += new System.EventHandler(this.contenedo_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button regis;
		private System.Windows.Forms.Button visualizar;
		private System.Windows.Forms.Button salir;
		private System.Windows.Forms.Button mod;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
	}
}

