/* Andres Alvarez C.I.:27198200
 * Este archivo fuente, es el menu principal del sistema para actualizar.
 * De aqui se accede a los demas formularios para realizar los procesos de acualizacion
 * en las debidas tablas (articulos, departamentos, clientes). 
*/
using System;
using Gtk;

namespace ProyectoAeonFlux
{
	public partial class MainWindow: Gtk.Window
	{
		public MainWindow () : base (Gtk.WindowType.Toplevel)
		{
			Build ();
			this.IniciarReloj ();
		}

		protected void OnDeleteEvent (object sender, DeleteEventArgs a)
		{
			Application.Quit ();
			a.RetVal = true;
		}

		protected void OnBtnsalirClicked (object sender, EventArgs e)
		{
			Application.Quit();
		}

		protected void OnBtnclientesClicked (object sender, EventArgs e)
		{
			new Clientes ();
			this.Destroy ();
		}

		protected void OnBtndepartamentosClicked (object sender, EventArgs e)
		{
			new Departamentos ();
			this.Destroy ();
		}

		protected void OnBtnarticulosClicked (object sender, EventArgs e)
		{
			new Articulos ();
			this.Destroy ();
		}

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
	}
}