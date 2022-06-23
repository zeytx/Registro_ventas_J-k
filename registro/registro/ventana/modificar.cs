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
	public partial class modificar : Form
	{
		public modificar()
		{
			InitializeComponent();
		}

		private void modificar_Load(object sender, EventArgs e)
		{

			StreamReader sr;
			string registro;
			bool encontrado = false;
			string[] espacios = new string[8];
			try
			{
				sr = File.OpenText(@"C:\\Users\\alvar\\Documents\\UPN\\ciclo 5\\Estructura de datos\\Semana 14\\inventario.txt");
				registro = sr.ReadLine();
				while (registro != null)
				{
					int Codigo = int.Parse(Global.codi);
					espacios = registro.Split(char.Parse(","));
					if (int.Parse(espacios[0]) == Codigo)
					{
						encontrado = true;
						cod.Text = espacios[0];
						nom.Text = espacios[1];
						ape.Text = espacios[2];
						mail.Text = espacios[3];
						produc.Text = espacios[4];
						preci.Text = espacios[5];
						cant.Text = espacios[6];
					}
					registro = sr.ReadLine();
				}
				if (encontrado == false) { MessageBox.Show("Código no encontrado"); }
				sr.Close();
				
			}
			catch (Exception)
			{

				Console.WriteLine("Archivo no existe");
				Console.ReadKey();
			}
		}
		private bool ValidarNombre()
		{

			if (string.IsNullOrEmpty(nom.Text))

			{

				error.SetError(nom, "Debe ingresar un nombre");

				return false;

			}

			else
			{

				error.SetError(nom, "");

				return true;

			}

		}
		private bool ValidarApe()
		{

			if (string.IsNullOrEmpty(ape.Text))

			{

				error.SetError(ape, "Debe ingresar un apellido");

				return false;

			}

			else
			{

				error.SetError(ape, "");

				return true;

			}
		}
		private bool Validarmail()
		{

			if (string.IsNullOrEmpty(mail.Text))

			{

				error.SetError(mail, "Debe ingresar un E-mail");

				return false;

			}

			else
			{

				error.SetError(mail, "");

				return true;

			}
		}
		private bool Validarproduc()
		{

			if (string.IsNullOrEmpty(produc.Text))

			{

				error.SetError(produc, "Debe ingresar un apellido");

				return false;

			}

			else
			{

				error.SetError(produc, "");

				return true;

			}
		}
		private bool ValidarPrecio()
		{

			int pre;

			if (preci.Text == "" || !int.TryParse(preci.Text, out pre))

			{

				error.SetError(preci, "Debe ingresar un valor numérico");

				return false;

			}

			else
			{

				error.SetError(preci, "");

				return true;

			}
		}
		private bool Validarcant()
		{

			int canti;

			if (cant.Text == "" || !int.TryParse(cant.Text, out canti))

			{

				error.SetError(cant, "Debe ingresar un valor numérico");

				return false;

			}

			else
			{

				error.SetError(cant, "");

				return true;

			}
		}

		private void agregar_Click(object sender, EventArgs e)
		{
			StreamReader sr;
			StreamWriter swr;
			string registro, Nom, Ape, Mail, Produ;
			int cod, can, pre;
			double tot;
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
						if (ValidarNombre() == false) { return; }
						if (ValidarApe() == false) { return; }
						if (Validarmail() == false) { return; }
						if (Validarproduc() == false) { return; }
						if (ValidarPrecio() == false) { return; }
						if (Validarcant() == false) { return; }
						cod = Codigo;
						Nom = nom.Text;
						Ape = ape.Text;
						Mail = mail.Text;
						Produ = produc.Text;
						pre = int.Parse(preci.Text);
						can = int.Parse(cant.Text);
						tot = can * pre;
						swr.WriteLine(cod + "," + Nom + "," + Ape + "," + Mail + "," + Produ + "," + pre + "," + can + "," + tot);
						MessageBox.Show("Datos modificados", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
				this.Dispose();
			}
			catch (Exception)
			{

				MessageBox.Show("Archivo no existe");
			}
		}
	}
}
