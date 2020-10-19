/* En este archivo fuente esta planteado el formulario para el proceso de actualizacion
 * de la tabla departamentos, pero no esta del todo implementado. Solo estan validados los entrys
 * y botones.
*/
using System;
using Gtk;
using MySql.Data.MySqlClient;

namespace ProyectoAeonFlux
{
	public partial class Departamentos : Validaciones
	{
		public Departamentos () 
		{
			this.Build ();
			this.IniciarReloj ();
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


		protected void OnEntcodChanged (object sender, EventArgs e)
		{
			ValidarAlfaNum (entcod);
			ValidarBoton (btnbuscar, entcod);
			ValidarBoton (btnIncluir, entcod);
			ValidarBoton (btneliminar, entcod);
			ValidarBoton (btnreactivar, entcod);
			ValidarBoton (btncancelar, entcod);
			EntryLimit (2, entcod);
		}
		protected void OnEntdescChanged (object sender, EventArgs e)
		{
			ValidarAlfaNumEspacio (entdesc);
			ValidarBoton (btncancelar, entdesc);
			EntryLimit (30, entdesc);
		}
		protected void OnBtnbuscarClicked (object sender, EventArgs e)
		{
			btnmodificar.Sensitive = true;
			MessageDialog md1 = new MessageDialog (this, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "No implementado");
			md1.Run ();
			md1.Destroy ();
		}

		protected void OnBtnincluirClicked (object sender, EventArgs e)
		{
			MessageDialog md1 = new MessageDialog (this, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "No implementado");
			md1.Run ();
			md1.Destroy ();
		}

		protected void OnBtnmodificarClicked (object sender, EventArgs e)
		{
			MessageDialog md1 = new MessageDialog (this, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "No implementado");
			md1.Run ();
			md1.Destroy ();
		}

		protected void OnBtneliminarClicked (object sender, EventArgs e)
		{
			MessageDialog md1 = new MessageDialog (this, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "No implementado");
			md1.Run ();
			md1.Destroy ();
		}

		protected void OnBtnreactivarClicked (object sender, EventArgs e)
		{
			MessageDialog md1 = new MessageDialog (this, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "No implementado");
			md1.Run ();
			md1.Destroy ();
		}

		protected void OnBtncancelarClicked (object sender, EventArgs e)
		{
			entcod.Text = "";
			entdesc.Text = "";
			btncancelar.Sensitive = false;
		}

		protected void OnBtnvolverClicked (object sender, EventArgs e)
		{
			new MainWindow ();
			this.Destroy ();
		}

		protected void OnBtnsalirClicked (object sender, EventArgs e)
		{
			Application.Quit ();
		}
	}
}
