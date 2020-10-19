/* El presente archivo fuente, tiene como finalidad el realizar los procesos 
 * de actualizacion de la tabla Articulos (incluir, modificar, reactivar y eliminar),
 * asi como tambien la capacidad de buscar registros.
 * Para la busqueda: se debe colocar el codigo del producto a buscar y dar click en el boton "Buscar".
 * Para la inclusion: se deben rellenar todos los campos, no se puede incluir un articulo con un campo nulo.
 * Para la modificacion: se debe primero realizar la busqueda del articulo, posteriormente se debe cambiar los
 * campos a modificar, dejando los demas iguales. Luego se da click en el boton "Modificar".
 * Para la reactivacion: se debe colocar el codigo del articulo a reactivar y luego dar click en el boton "Reactivar".
 * Para la eliminacion: se debe colocar el codigo del articulo a eliminar y luego dar click en el boton "Eliminar".
 * 
*/
using System;
using Gtk;
using MySql.Data.MySqlClient;

namespace ProyectoAeonFlux
{
	public partial class Articulos : Validaciones
	{
		public Articulos () 
		{
			this.Build ();
			this.IniciarReloj ();
		}

		// METODOS DE ACTUALIZACION CON MYSQL
		protected void Buscar()
		{
			//Metodo que retorna cada campo y rellena los entrys con dichos campos
			MySql.ConectorMysql bd = new MySql.ConectorMysql ();
			bd.Conectar();
			bd.cmd = new MySqlCommand ("Select * from tarticulos where artcod=?cod and artestatus='A'", bd.con);
			bd.cmd.Parameters.Add ("?cod", MySqlDbType.VarChar).Value = entcod.Text;
			bd.dr = bd.cmd.ExecuteReader ();
			if (bd.dr.Read ()) {
				entcodpto.Text = bd.dr [1].ToString ();
				entdesc.Text = bd.dr [2].ToString ();
				entcosto.Text = bd.dr [3].ToString ();
				entpredetal.Text = bd.dr [4].ToString ();
				entpremayor.Text = bd.dr [5].ToString ();
				entexistdetal.Text = bd.dr [6].ToString ();
				entexistmayor.Text = bd.dr [7].ToString ();
				bd.dr.Close ();
				bd.Desconectar ();
			} 
			else 
			{
				MessageDialog md1 = new MessageDialog (this, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "No se encontraron resultados");
				md1.Run ();
				md1.Destroy ();
				bd.dr.Close ();
				bd.Desconectar ();
			}
		}

		protected string BuscarString(string estatus)
		{
			//Metodo que retorna al igual que el metodo anterior, todos los campos
			//Pero esta vez en forma de string
			MySql.ConectorMysql bd = new MySql.ConectorMysql ();
			string resultado;
			bd.Conectar();
			bd.cmd = new MySqlCommand ("SELECT * FROM tarticulos WHERE artcod=?cod AND artestatus='" + estatus+"';", bd.con);
			bd.cmd.Parameters.Add ("?cod", MySqlDbType.VarChar).Value = entcod.Text;
			bd.dr = bd.cmd.ExecuteReader();
			if (bd.dr.Read()) {
				resultado = "Codigo: " + bd.dr[0] + "\nCodigo departamento: " + bd.dr[1] + "\nDescripcion: " + bd.dr[2] + "\nCosto:" + bd.dr[3] + "\nPrecio Detal: " + bd.dr[4] + "\nPrecio Mayor: " + bd.dr[5] + "\nCantidad Almacen 1: " + bd.dr[6] + "\nCantidad Almacen 2: " + bd.dr[7];
				bd.Desconectar();
				return resultado;
			} 
			else 
			{
				resultado = "No se obtuvieron resultados";
				bd.Desconectar();
				return resultado;
			}	

		}

		protected bool ExistenciaDepartamento(string dptocod)
		{
			//Metodo que retorna true si exise un departamento con el codigo ingresado
			MySql.ConectorMysql bd = new MySql.ConectorMysql ();
			bd.Conectar ();
			bd.cmd = new MySqlCommand ("SELECT dptocod FROM tdepartamentos WHERE dptoestatus='A' AND dptocod=" + dptocod, bd.con);
			bd.dr = bd.cmd.ExecuteReader ();
			if (bd.dr.Read ()) {
				bd.Desconectar ();
				return true;
			} 
			else 
			{
				bd.Desconectar ();
				return false;
			}
		}

		protected void Incluir()
		{
			//Metodo que incluye un registro en la tabla tarticulos
			MySql.ConectorMysql bd = new MySql.ConectorMysql ();
			bd.Conectar ();
			bd.cmd = new MySqlCommand ("INSERT INTO tarticulos VALUES(?artcod, ?artcodpto, ?artdesc, ?artcosto, ?artpredetal, ?artpremayor, ?artexistdetal, ?artexistmayor, ?artestatus)", bd.con);
			bd.cmd.Parameters.Add ("?artcod", MySqlDbType.VarChar).Value = entcod.Text;
			bd.cmd.Parameters.Add ("?artcodpto", MySqlDbType.VarChar).Value = entcodpto.Text;
			bd.cmd.Parameters.Add ("?artdesc", MySqlDbType.VarChar).Value = entdesc.Text;
			bd.cmd.Parameters.Add ("?artcosto", MySqlDbType.Double).Value = double.Parse (entcosto.Text);
			bd.cmd.Parameters.Add ("?artpredetal", MySqlDbType.Double).Value = double.Parse (entpredetal.Text);
			bd.cmd.Parameters.Add ("?artpremayor", MySqlDbType.Double).Value = double.Parse (entpremayor.Text);
			bd.cmd.Parameters.Add ("?artexistdetal", MySqlDbType.Int16).Value = Int16.Parse (entexistdetal.Text);
			bd.cmd.Parameters.Add ("?artexistmayor", MySqlDbType.Int16).Value = Int16.Parse (entexistmayor.Text);
			bd.cmd.Parameters.Add ("?artestatus", MySqlDbType.VarChar).Value = "A";

			if (bd.cmd.ExecuteNonQuery () > 0) {
				bd.Desconectar ();
				MessageDialog msg = new MessageDialog (this, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "El registro fue incluido exitosamente.");
				msg.Run ();
				msg.Destroy ();
			} 
			else 
			{
				bd.Desconectar ();
				MessageDialog msg = new MessageDialog (this, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "El registro no fue incluido.");
				msg.Run ();
				msg.Destroy ();
			}
		}

		protected void Eliminar()
		{
			//Metodo que elimina un registro de la tabla tarticulos
			MySql.ConectorMysql bd = new MySql.ConectorMysql ();
			bd.Conectar ();
			bd.cmd = new MySqlCommand ("UPDATE tarticulos SET artestatus='E' WHERE artcod=?artcod AND artestatus='A'", bd.con);
			bd.cmd.Parameters.Add ("?artcod", MySqlDbType.VarChar).Value = entcod.Text;
			if (bd.cmd.ExecuteNonQuery () > 0) {
				MessageDialog msg = new MessageDialog (this, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "El registro fue eliminado exitosamente.");
				msg.Run ();
				msg.Destroy ();
				bd.Desconectar ();
			} 
			else 
			{
				MessageDialog msg = new MessageDialog (this, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "El registro no fue eliminado.");
				msg.Run ();
				msg.Destroy ();
				bd.Desconectar ();
			}	
		}

		protected void Reactivar()
		{
			//Metodo que reactiva un registro eliminado logicamente de la tabla tarticulos
			MySql.ConectorMysql bd = new MySql.ConectorMysql ();
			bd.Conectar ();
			bd.cmd = new MySqlCommand ("UPDATE tarticulos SET artestatus='A' WHERE artcod=?artcod AND artestatus='E'", bd.con);
			bd.cmd.Parameters.Add ("?artcod", MySqlDbType.VarChar).Value = entcod.Text;
			if (bd.cmd.ExecuteNonQuery () > 0) 
			{
				MessageDialog msg = new MessageDialog (this, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "El registro fue reactivado exitosamente.");
				msg.Run ();
				msg.Destroy ();
				bd.Desconectar ();
			} 
			else 
			{
				MessageDialog msg = new MessageDialog (this, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "El registro no fue reactivado.");
				msg.Run ();
				msg.Destroy ();
				bd.Desconectar ();
			}
		}

		protected void Modificar()
		{
			//Metodo que actualiza un registro existente en la tabla tarticulos
			MySql.ConectorMysql bd = new MySql.ConectorMysql ();
			bd.Conectar ();
			bd.cmd = new MySqlCommand ("UPDATE tarticulos SET artdesc=?artdesc, artcosto=?artcosto, artpreciodetal=?artpredetal, artpreciomayor=?artpremayor, artexistdetal=?artexistdetal, artexistmayor=?artexistmayor WHERE artcod=?artcod AND artestatus='A'", bd.con);
			bd.cmd.Parameters.Add ("?artdesc", MySqlDbType.VarChar).Value = entdesc.Text;
			bd.cmd.Parameters.Add ("?artcosto", MySqlDbType.Double).Value = double.Parse (entcosto.Text);
			bd.cmd.Parameters.Add ("?artpredetal", MySqlDbType.Double).Value = double.Parse (entpredetal.Text);
			bd.cmd.Parameters.Add ("?artpremayor", MySqlDbType.Double).Value = double.Parse (entpremayor.Text);
			bd.cmd.Parameters.Add ("?artexistdetal", MySqlDbType.Int16).Value = Int16.Parse (entexistdetal.Text);
			bd.cmd.Parameters.Add ("?artexistmayor", MySqlDbType.Int16).Value = Int16.Parse (entexistmayor.Text);
			bd.cmd.Parameters.Add ("?artcod", MySqlDbType.VarChar).Value = entcod.Text;
			if (bd.cmd.ExecuteNonQuery () > 0) {
				MessageDialog msg = new MessageDialog (this, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "El registro fue modificado exitosamente.");
				msg.Run ();
				msg.Destroy ();
				bd.Desconectar ();
			} 
			else 
			{
				MessageDialog msg = new MessageDialog (this, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "El registro no fue modificado.");
				msg.Run ();
				msg.Destroy ();
				bd.Desconectar ();
			}
		}

		//OTROS METODOS
		protected bool FechaHora()
		{
			lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
			lblhora.Text = DateTime.Now.ToString ("hh:mm tt");
			return true;
		}

		protected void IniciarReloj() 
		{
			GLib.Timeout.Add (1000, new GLib.TimeoutHandler (FechaHora));
		}

		protected string LeerDatosEntrys()
		{
			//Metodo que retorna los datos ingresados en los entrys, a fin de servir para confirmar una inclusion
			string resultado;
			resultado = "Codigo:" + entcod.Text + "\nDescripcion:" + entdesc.Text + "\nCosto:" + entcosto.Text + "\nPrecio al detal:" + entpredetal.Text + "\nPrecio al mayor:" + entpremayor.Text + "\nCantidad almacen 1:" + entexistdetal.Text + "\nCantidad almacen 2:" + entexistmayor.Text;
			return resultado;
		}

		protected void OnEntcodChanged (object sender, EventArgs e)
		{
			ValidarBoton (btnbuscar, entcod);
			ValidarBoton (btnincluir, entcod);
			ValidarBoton (btnreactivar, entcod);
			ValidarBoton (btneliminar, entcod);
			ValidarBoton (btncancelar, entcod);
			ValidarAlfaNum (entcod);
			EntryLimit (4, entcod);
		}

		protected void OnEntcodptoChanged (object sender, EventArgs e)
		{
			ValidarAlfaNum (entcodpto);
			EntryLimit (2, entcodpto);
			ValidarBoton (btncancelar, entcodpto);
		}

		protected void OnEntdescChanged (object sender, EventArgs e)
		{
			ValidarAlfaNumEspacio(entdesc);
			EntryLimit (40, entdesc);
			ValidarBoton (btncancelar, entdesc);
		}

		protected void OnEntcostoChanged (object sender, EventArgs e)
		{
			ValidarNroDecimal (entcosto);
			EntryLimit (15, entcosto);
			ValidarBoton (btncancelar, entcosto);
		}

		protected void OnEntpredetalChanged (object sender, EventArgs e)
		{
			ValidarNroDecimal (entpredetal);
			EntryLimit (15, entpredetal);
			ValidarBoton (btncancelar, entpredetal);
		}

		protected void OnEntpremayorChanged (object sender, EventArgs e)
		{
			ValidarNroDecimal (entpremayor);
			EntryLimit (15, entpremayor);
			ValidarBoton (btncancelar, entpremayor);
		}

		protected void OnEntexistdetalChanged (object sender, EventArgs e)
		{
			ValidarNro (entexistdetal);
			EntryLimit (4, entexistdetal);
			ValidarBoton (btncancelar, entexistdetal);
		}

		protected void OnEntexistmayorChanged (object sender, EventArgs e)
		{
			ValidarNro (entexistmayor);
			EntryLimit (4, entexistmayor);
			ValidarBoton (btncancelar, entexistmayor);
		}

		protected void OnBtnbuscarClicked (object sender, EventArgs e)
		{
			Buscar ();
			btnmodificar.Sensitive = true;
		}

		protected void OnBtnincluirClicked (object sender, EventArgs e)
		{
			//Se verifica que todos los entrys estan llenos
			if (entcod.Text == "" || entcodpto.Text == "" || entdesc.Text == "" || entcosto.Text == "" || entpredetal.Text == "" || entpremayor.Text == "" || entexistdetal.Text == "" || entexistmayor.Text == "") {
				MessageDialog msg = new MessageDialog (this, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "Debe llenar todos los campos.");
				msg.Run ();
				msg.Destroy ();
			} 
			//Se revisa si existe un registro con el codigo ingreso
			else if (BuscarString("A")!="No se obtuvieron resultados") {
				MessageDialog msg = new MessageDialog (this, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "El registro ya existe");
				msg.Run ();
				msg.Destroy ();
				entcod.Text = "";
				entcodpto.Text = "";
				entdesc.Text = "";
				entcosto.Text = "";
				entpredetal.Text = "";
				entpremayor.Text = "";
				entexistdetal.Text = "";
				entexistmayor.Text = "";
			} 
			//En este paso se verifica si el codigo del departamento corresponde a un departamento en la tabla
			//tdepartamentos
			else if (ExistenciaDepartamento(entcodpto.Text) == false) 
			{
				MessageDialog msg = new MessageDialog (this, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "El departamento no existe");
				msg.Run ();
				msg.Destroy ();
				entcodpto.Text = "";
			}
			else 
			{
				//Se procede ahora a cofirmar la inclusion del registro
				if (DialogYESNO ("Inclusion", "Si", "No", "¿Desea incluir el siguiente registro?\n" + "Codigo: " + 
					entcod.Text + "\nCodigo departamento: " + entcodpto.Text + "\nDescripcion: " + entdesc.Text + "\nCosto:" + entcosto.Text + "\nPrecio Detal: " + entpredetal.Text + "\nPrecio Mayor: " + entpremayor.Text + "\nCantidad Almacen 1: " + entexistdetal.Text + "\nCantidad Almacen 2: " + entexistmayor.Text) == ResponseType.Yes) {
					Incluir ();
					entcod.Text = "";
					entcodpto.Text = "";
					entdesc.Text = "";
					entcosto.Text = "";
					entpredetal.Text = "";
					entpremayor.Text = "";
					entexistdetal.Text = "";
					entexistmayor.Text = "";
				} 
				else 
				{
					entcod.Text = "";
					entcodpto.Text = "";
					entdesc.Text = "";
					entcosto.Text = "";
					entpredetal.Text = "";
					entpremayor.Text = "";
					entexistdetal.Text = "";
					entexistmayor.Text = "";
				}
			}
		}

		protected void OnBtneliminarClicked (object sender, EventArgs e)
		{
			//Se verifica si el registro a eliminar existe
			if (BuscarString ("A") == "No se obtuvieron resultados") 
			{
				if (BuscarString ("E") != "No se obtuvieron resultados") {
					MessageDialog msg = new MessageDialog (this, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "El codigo corresponde a un registro eliminado. \nVerifique el codigo");
					msg.Run ();
					msg.Destroy ();
				} 
				else 
				{
					MessageDialog msg = new MessageDialog (this, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "No se encontraron resultados para eliminar. \nVerifique el codigo");
					msg.Run ();
					msg.Destroy ();
				}
			}
			//Se procede a confirmar la eliminacion del registro
			else if (DialogYESNO ("Eliminacion", "Si", "No", "¿Desea eliminar el siguiente registro?\n" + BuscarString ("A")) == ResponseType.Yes) {
				Eliminar ();
				entcod.Text = "";
			} 
			else 
			{
				entcod.Text = "";
			}	
		}

		protected void OnBtncancelarClicked (object sender, EventArgs e)
		{
			entcod.Text = "";
			entcodpto.Text = "";
			entdesc.Text="";
			entcosto.Text = "";
			entpredetal.Text = "";
			entpremayor.Text = "";
			entexistdetal.Text = "";
			entexistmayor.Text = "";
			btncancelar.Sensitive = false;
		}
		protected void OnBtnmodificarClicked (object sender, EventArgs e)
		{
			//Se verifica que todos los entrys estan llenos
			if (entcod.Text == "" || entdesc.Text == "" || entcosto.Text == "" || entpredetal.Text == "" || entpremayor.Text == "" || entexistdetal.Text == "" || entexistmayor.Text == "") {
				MessageDialog msg = new MessageDialog (this, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "Debe llenar todos los campos, excepto el codigo departamento. \nLos campos que no vayan a ser modificados, los debe dejar iguales");
				msg.Run ();
				msg.Destroy ();
			} 
			//Ahora se verifica si el registro existe
			else if (BuscarString ("A") == "No se obtuvieron resultados") {
				MessageDialog msg = new MessageDialog (this, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "No se encontraron resultados para modificar. \nVerifique el codigo");
				msg.Run ();
				msg.Destroy ();
			} 
			//Se confirma la modificacion del registro presentando todos los campos que va a modificar
			else if (DialogYESNO ("Modificacion", "Si", "No", "¿Estas son las modificaciones para el siguiente registro?\n" + LeerDatosEntrys()) == ResponseType.Yes) {
				Modificar ();
				entcod.Text = "";
				entcodpto.Text = "";
				entdesc.Text = "";
				entcosto.Text = "";
				entpredetal.Text = "";
				entpremayor.Text = "";
				entexistdetal.Text = "";
				entexistmayor.Text = "";
			} 
			else 
			{
				entcod.Text = "";
				entcodpto.Text = "";
				entdesc.Text="";
				entcosto.Text = "";
				entpredetal.Text = "";
				entpremayor.Text = "";
				entexistdetal.Text = "";
				entexistmayor.Text = "";
			}
		}
		protected void OnBtnvolverClicked (object sender, EventArgs e)
		{
			new MainWindow ();
			this.Destroy ();
		}

		protected void OnBtnreactivarClicked (object sender, EventArgs e)
		{
			//Se verifica si el registro esta eliminado
			if (BuscarString ("E") == "No se obtuvieron resultados") 
			{
				if (BuscarString ("A") != "No se obtuvieron resultados") {
					MessageDialog msg = new MessageDialog (this, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "El codigo corresponde a un registro activo. \nVerifique el codigo");
					msg.Run ();
					msg.Destroy ();
				} 
				else 
				{
					MessageDialog msg = new MessageDialog (this, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "No se encontraron resultados para reactivar. \nVerifique el codigo");
					msg.Run ();
					msg.Destroy ();
				}
			}
			//Se confirma la reactivacion del registro
			else if (DialogYESNO ("Reactivacion", "Si", "No", "¿Desea reactivar el siguiente registro?\n" + BuscarString ("E")) == ResponseType.Yes) {
				Reactivar ();
				entcod.Text = "";
			} 
			else 
			{
				entcod.Text = "";
			}		
		}

		protected void OnBtnsalirClicked (object sender, EventArgs e)
		{
			Application.Quit ();
		}
	}
}

