/* En este archivo fuente se encuentran todas las validaciones necesarias
 * para que el sistema corra como lo esperado. Asi no se tendran ingresos 
 * no debidos en los entrys.
*/
using System;
using Gtk;

namespace ProyectoAeonFlux
{
	public partial class Validaciones : Gtk.Window
	{
		public Validaciones () : base (Gtk.WindowType.Toplevel)
		{
			//this.Build ();
		}

		public static void ValidarNro(Entry ent)
		{
			string cadena = ent.Text;
			int i;
			for (i = 0; i < cadena.Length; i++) 
			{
				if (char.IsDigit (cadena[i])) 
				{
				} 
				else 
				{
					ent.Text = cadena.Substring (0, cadena.Length - 1);
				}
			}
		}

		public static void ValidarNroDecimal(Entry ent)
		{
			string cadena = ent.Text;
			int i;
			int cont = 0;
			for (i = 0; i < cadena.Length; i++) 
			{
				if (char.IsDigit (cadena[i]) || cadena [i] == '.' || cadena [i] == ',') {

					if (cadena [i] == ',' || cadena [i] == '.') {

						if (cont >= 1) { 

							ent.Text = cadena.Substring (0, cadena.Length - 1); 

						} else if (cadena [i] == ',') { 

							cont++; 

						} else if (cadena [i] == '.') { 

							ent.Text = cadena.Substring (0, cadena.Length - 1) + ','; 
							cont++;
						}
					}
				} 
				else 
				{
					ent.Text = cadena.Substring (0, cadena.Length - 1);
				}
			}
		}

		public static void ValidarAlfa(Entry ent)
		{
			string cadena = ent.Text;
			int i;
			for (i = 0; i < cadena.Length; i++) 
			{
				if (char.IsLetter (cadena[i]) || cadena[i]==' ') {
				} 
				else 
				{
					ent.Text = cadena.Substring (0, cadena.Length - 1);
				}
			}
		}

		public static void ValidarAlfaNum(Entry ent)
		{
			string cadena = ent.Text;
			int i;
			for (i = 0; i < cadena.Length; i++) 
			{
				if (char.IsLetter (cadena[i]) || char.IsDigit(cadena[i])) 
				{
				} 
				else 
				{
					ent.Text = cadena.Substring (0, cadena.Length - 1);
				}
			}
		}

		public static void ValidarAlfaNumEspacio(Entry ent)
		{
			string cadena = ent.Text;
			int i;
			for (i = 0; i < cadena.Length; i++) 
			{
				if (char.IsLetter (cadena[i]) || char.IsDigit(cadena[i]) || cadena[i]==' ') 
				{
				} 
				else 
				{
					ent.Text = cadena.Substring (0, cadena.Length - 1);
				}
			}
		}

		public static void ValidarBoton(Button bton, params Entry[] texts)
		{
			for (int i = 0; i < texts.Length; i++)
			{
				if (string.IsNullOrEmpty(texts[i].Text))
				{
					bton.Sensitive = false;
				}
			}
			bton.Sensitive = true;
		}

		public static void EntryLimit(int max, Entry ent)
		{
			if (ent.Text.Length > max)
			{
				ent.Text = ent.Text.Substring(0, max);
			}
		}

		public ResponseType DialogYESNO(string aviso, string opc1, string opc2, string msj)
		{
			Dialog dialog = null;
			ResponseType response = ResponseType.None;
			try
			{
				dialog = new Dialog(
					aviso,
					dialog,
					DialogFlags.DestroyWithParent | DialogFlags.Modal,
					opc1, ResponseType.Yes,
					opc2, ResponseType.No
				);
				dialog.VBox.Add(new Image(Stock.DialogInfo, IconSize.Dialog));

				dialog.VBox.Add(new Label(msj));
				dialog.ShowAll();

				response = (ResponseType)dialog.Run();
			}
			finally
			{
				if (dialog != null)
					dialog.Destroy();
			}
			return response;
		}
	}
}


