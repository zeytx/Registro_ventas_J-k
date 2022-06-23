namespace registro.ventana
{
	partial class visual
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
			this.label2 = new System.Windows.Forms.Label();
			this.bus = new System.Windows.Forms.TextBox();
			this.but = new System.Windows.Forms.Button();
			this.data = new System.Windows.Forms.DataGridView();
			this.exp = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(23, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(179, 27);
			this.label2.TabIndex = 17;
			this.label2.Text = "Buscar por código:";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// bus
			// 
			this.bus.Location = new System.Drawing.Point(232, 26);
			this.bus.Name = "bus";
			this.bus.Size = new System.Drawing.Size(175, 22);
			this.bus.TabIndex = 21;
			// 
			// but
			// 
			this.but.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.but.Location = new System.Drawing.Point(449, 21);
			this.but.Name = "but";
			this.but.Size = new System.Drawing.Size(88, 34);
			this.but.TabIndex = 22;
			this.but.Text = "Buscar";
			this.but.UseVisualStyleBackColor = true;
			this.but.Click += new System.EventHandler(this.but_Click);
			// 
			// data
			// 
			this.data.AllowUserToAddRows = false;
			this.data.AllowUserToDeleteRows = false;
			this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.data.Location = new System.Drawing.Point(28, 114);
			this.data.Name = "data";
			this.data.ReadOnly = true;
			this.data.RowHeadersWidth = 51;
			this.data.RowTemplate.Height = 24;
			this.data.Size = new System.Drawing.Size(1127, 555);
			this.data.TabIndex = 23;
			// 
			// exp
			// 
			this.exp.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exp.Location = new System.Drawing.Point(1018, 74);
			this.exp.Name = "exp";
			this.exp.Size = new System.Drawing.Size(137, 34);
			this.exp.TabIndex = 24;
			this.exp.Text = "Exportar datos";
			this.exp.UseVisualStyleBackColor = true;
			this.exp.Click += new System.EventHandler(this.exp_Click);
			// 
			// visual
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.ClientSize = new System.Drawing.Size(1182, 688);
			this.Controls.Add(this.exp);
			this.Controls.Add(this.data);
			this.Controls.Add(this.but);
			this.Controls.Add(this.bus);
			this.Controls.Add(this.label2);
			this.Name = "visual";
			this.Text = "visual";
			this.Load += new System.EventHandler(this.visual_Load);
			((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox bus;
		private System.Windows.Forms.Button but;
		private System.Windows.Forms.DataGridView data;
		private System.Windows.Forms.Button exp;
	}
}