using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace registro
{
	public class funciones
	{
        

		public DataTable ConvertToDataTable(string filePath, int numberOfColumns)
		{
			DataTable tbl = new DataTable();

			tbl.Columns.Add(new DataColumn("Código"));
			tbl.Columns.Add(new DataColumn("Nombre"));
			tbl.Columns.Add(new DataColumn("Apellido"));
			tbl.Columns.Add(new DataColumn("E-mail"));
			tbl.Columns.Add(new DataColumn("Producto"));
			tbl.Columns.Add(new DataColumn("Precio"));
			tbl.Columns.Add(new DataColumn("Cantidad"));
			tbl.Columns.Add(new DataColumn("Total a pagar"));

			string[] lines = System.IO.File.ReadAllLines(filePath);

			foreach (string line in lines)
			{
				var cols = line.Split(',');

				DataRow dr = tbl.NewRow();
				for (int cIndex = 0; cIndex < 8; cIndex++)
				{
					dr[cIndex] = cols[cIndex];
				}

				tbl.Rows.Add(dr);
			}

			return tbl;
		}
	}
	public static class Global
	{
		public static string codi;
	}
}
