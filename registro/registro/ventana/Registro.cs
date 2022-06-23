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

namespace registro.contenedor
{
	public partial class Registro : Form
	{
		public Registro()
		{
			InitializeComponent();
		}

		private void Registro_Load(object sender, EventArgs e)
		{

		}


		private void button1_Click(object sender, EventArgs e)
		{
			if (ValidarNombre() == false) { return; }
			if (ValidarApe() == false) { return; }
			if (Validarmail() == false) { return; }
			if (Validarproduc() == false) { return; }
			if (ValidarPrecio() == false) { return; }
			if (Validarcant() == false) { return; }

			StreamWriter swr;
			swr = File.AppendText(@"C:\Users\alvar\Documents\UPN\ciclo 5\Estructura de datos\Semana 14\inventario.txt");
			Random ale = new Random();
			string[] espacios = new string[8];
			string Nom,Ape,Mail,Produ;
			int cod, can, pre,num;
			double tot;
			num = ale.Next(1000, 10000);
			cod = num;
			Nom = nom.Text;
			Ape = ape.Text;
			Mail = mail.Text;
			Produ = produc.Text;
			pre = int.Parse(preci.Text);
			can = int.Parse(cant.Text);
			tot = can * pre;
			swr.WriteLine(cod + "," + Nom + "," + Ape + "," + Mail + "," + Produ + "," + pre + "," + can + "," + tot);
			swr.Close();
			MessageBox.Show("Agregado","AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			LimpiarControles(); nom.Focus();
		}
		private void LimpiarControles()
		{
			nom.Clear();
			ape.Clear();
			cant.Clear();
			mail.Clear();
			produc.Clear();
			cant.Clear();
			preci.Clear();
		}
		private void Registro_FormClosed(object sender, FormClosedEventArgs e)
		{

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


	}
}
