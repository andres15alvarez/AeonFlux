/* La conexion a la base de datos esta desarrollada en este archivo fuente.
 * De esta forma 
*/
using System;
using Gtk;
using MySql.Data.MySqlClient;

namespace MySql
{
	public class ConectorMysql
	{
		public MySqlConnection con;
		public MySqlCommand cmd;
		public MySqlDataReader dr; 
		public Gtk.Window Vp{set; get;}
		public ConectorMysql ()
		{
			con = new MySqlConnection("server=localhost; database=aeonflux; uid=root; password=068856187030");
		}

		public bool Conectar()
		{
			try
			{
				con.Open();
				return true;
			}

			catch (MySqlException ex)
			{

				switch (ex.Number)
				{
				case 0:
					MessageDialog md = new MessageDialog
						(Vp, DialogFlags.DestroyWithParent, MessageType.Error, ButtonsType.Close, ex.Message);
					md.Run();
					md.Destroy();
					break;

				case 1045:
					MessageDialog md1 = new MessageDialog
						(Vp, DialogFlags.DestroyWithParent, MessageType.Error, ButtonsType.Close, ex.Message);
					md1.Run();
					md1.Destroy();
					break;
				}
				return false;
			}
		}

		public bool Desconectar()
		{
			try
			{
				con.Close();
				return true;
			}
			catch (MySqlException ex)
			{
				MessageDialog md = new MessageDialog
					(Vp, DialogFlags.DestroyWithParent, MessageType.Error, ButtonsType.Close, ex.Message);
				md.Run();
				md.Destroy();

				return false;
			}
		}
	}
}

