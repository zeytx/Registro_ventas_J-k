using Microsoft.VisualBasic;
using registro.contenedor;
using registro.ventana;
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

namespace registro
{

	public partial class contenedo : Form
	{
		
		public contenedo()
		{
			InitializeComponent();
			StreamWriter swr = new StreamWriter(@"C:\Users\alvar\Documents\UPN\ciclo 5\Estructura de datos\Semana 14\inventario.txt", true);
			swr.Close();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Registro regis = new Registro();
			regis.Show();

		}

		private void contenedo_Load(object sender, EventArgs e)
		{

		}

		private void visualizar_Click(object sender, EventArgs e)
		{
			visual visu = new visual();
			visu.Show();

		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			Global.codi = Interaction.InputBox("Ingrese el código para editar: ");
			StreamReader srr;
			string registro;
			bool encontrado = false;
			string[] espacios = new string[8];
			try
			{
				srr = File.OpenText(@"C:\\Users\\alvar\\Documents\\UPN\\ciclo 5\\Estructura de datos\\Semana 14\\inventario.txt");
				int enco = int.Parse(Global.codi);
				registro = srr.ReadLine();
				while (registro != null)
				{
					espacios = registro.Split(char.Parse(","));
					if (int.Parse(espacios[0]) == enco)
					{
						encontrado = true;
						modificar mod = new modificar();
						mod.Show();
					}

					registro = srr.ReadLine();
				}
				if (encontrado == false) { MessageBox.Show("Código no encontrado","AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error); }
				srr.Close();
			}
			catch (Exception)
			{

				MessageBox.Show("Archivo no existe","ADVERTENCIA",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Global.codi = Interaction.InputBox("Ingrese el código a eliminar: ");
			StreamReader sr;
			StreamWriter swr;
			string registro;
			bool encontrado = false;
			string[] espacios = new string[8];
			try
			{
				sr = File.OpenText(@"C:\\Users\\alvar\\Documents\\UPN\\ciclo 5\\Estructura de datos\\Semana 14\\inventario.txt");
				swr = new StreamWriter(@"C:\\Users\\alvar\\Documents\\UPN\\ciclo 5\\Estructura de datos\\Semana 14\\auxs.txt");
				registro = sr.ReadLine();
				while (registro != null)
				{
					int Codigo = int.Parse(Global.codi);
					espacios = registro.Split(char.Parse(","));
					if (int.Parse(espacios[0]) == Codigo)
					{
						encontrado = true;
						MessageBox.Show("Datos eliminados", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
					else
					{
						swr.WriteLine(espacios[0] + "," + espacios[1] + "," + espacios[2] + "," + espacios[3] + "," + espacios[4] + "," + espacios[5] + "," + espacios[6] + "," + espacios[7]);
					}
					registro = sr.ReadLine();
				}
				if (encontrado == false)
				{
					MessageBox.Show("Código no existe");
				}
				sr.Close();
				File.Delete(@"C:\\Users\\alvar\\Documents\\UPN\\ciclo 5\\Estructura de datos\\Semana 14\\inventario.txt");
				swr.Close();
				File.Move(@"C:\\Users\\alvar\\Documents\\UPN\\ciclo 5\\Estructura de datos\\Semana 14\\auxs.txt", @"C:\\Users\\alvar\\Documents\\UPN\\ciclo 5\\Estructura de datos\\Semana 14\\inventario.txt");
			}
			catch (Exception)
			{

				MessageBox.Show("Archivo no existe", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
	}
}
