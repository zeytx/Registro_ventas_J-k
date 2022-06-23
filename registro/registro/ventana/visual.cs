using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registro.ventana
{
	public partial class visual : Form
	{
		public visual()
		{
			InitializeComponent();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void visual_Load(object sender, EventArgs e)
		{
			funciones fun = new funciones();
			data.DataSource = fun.ConvertToDataTable(@"C:\\Users\\alvar\\Documents\\UPN\\ciclo 5\\Estructura de datos\\Semana 14\\inventario.txt", 8);
		}

		private void but_Click(object sender, EventArgs e)
		{
			StreamReader srr;
			string registro;
			bool encontrado = false;
			string[] espacios = new string[8];
			try
			{
				srr = File.OpenText(@"C:\\Users\\alvar\\Documents\\UPN\\ciclo 5\\Estructura de datos\\Semana 14\\inventario.txt");
				int Bus = int.Parse(bus.Text);
				registro = srr.ReadLine();
				while (registro != null)
				{
					espacios = registro.Split(char.Parse(","));
					if (int.Parse(espacios[0]) == Bus)
					{
						encontrado = true;
						MessageBox.Show(espacios[0] + " | " + espacios[1] + " | " + espacios[2] + " | " + espacios[3] + " | " + espacios[4] + " | " + espacios[5] + " | " + espacios[6] + " | " + espacios[7], "Datos", MessageBoxButtons.OK);
					}

					registro = srr.ReadLine();
				}
				if (encontrado == false) { MessageBox.Show("Código no encontrado"); }
				srr.Close();
			}
			catch (Exception)
			{

				MessageBox.Show("Archivo no existe");
			}
		}

		private void exp_Click(object sender, EventArgs e)
		{
			try
			{
				File.Copy(@"C:\\Users\\alvar\\Documents\\UPN\\ciclo 5\\Estructura de datos\\Semana 14\\inventario.txt", @"C:\Users\alvar\Desktop\inven.txt");
				MessageBox.Show("Archivo exportado al escritorio", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			catch (Exception ex)
			{

				MessageBox.Show("Archivo ya exportado", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			
		}
	}
}
