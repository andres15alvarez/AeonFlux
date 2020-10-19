/* En este archivo fuente esta planteado el formulario para el proceso de actualizacion
 * de la tabla clientes, pero no esta del todo implementado. Solo estan validados los entrys
 * y botones.
*/
using System;
using Gtk;
using MySql.Data.MySqlClient;

namespace ProyectoAeonFlux
{
	public partial class Clientes : Validaciones
	{
		public Clientes ()
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

		protected void OnBtnreactivarClicked (object sender, EventArgs e)
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

		protected void OnBtncancelarClicked (object sender, EventArgs e)
		{
			entrif.Text = "";
			entnombre.Text = "";
			entdir.Text = "";
			enttlfno.Text = "";
			btncancelar.Sensitive = false;
		}

		protected void OnBtnvolverClicked (object sender, EventArgs e)
		{
			new MainWindow ();
			this.Destroy ();
		}

		protected void OnEntrifChanged (object sender, EventArgs e)
		{
			ValidarAlfaNum (entrif);
			ValidarBoton (btnbuscar, entrif);
			ValidarBoton (btnincluir, entrif);
			ValidarBoton (btneliminar, entrif);
			ValidarBoton (btnreactivar, entrif);
			ValidarBoton (btncancelar, entrif);
			EntryLimit (15, entrif);
		}

		protected void OnEntnombreChanged (object sender, EventArgs e)
		{
			ValidarAlfa (entnombre);
			ValidarBoton (btncancelar, entnombre);
			EntryLimit (40, entnombre);
		}

		protected void OnEntdirChanged (object sender, EventArgs e)
		{
			ValidarAlfaNumEspacio (entdir);
			ValidarBoton (btncancelar, entdir);
			EntryLimit (60, entdir);
		}

		protected void OnEnttlfnoChanged (object sender, EventArgs e)
		{
			ValidarNro (enttlfno);
			ValidarBoton (btncancelar, enttlfno);
			EntryLimit (15, enttlfno);
		}

		protected void OnBtnsalirClicked (object sender, EventArgs e)
		{
			Application.Quit ();
		}
	}
}

