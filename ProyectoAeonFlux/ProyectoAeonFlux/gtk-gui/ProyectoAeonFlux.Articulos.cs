
// This file has been generated by the GUI designer. Do not modify.
namespace ProyectoAeonFlux
{
	public partial class Articulos
	{
		private global::Gtk.VBox vbox5;
		
		private global::Gtk.VBox vbox6;
		
		private global::Gtk.HBox hbox6;
		
		private global::Gtk.HSeparator hseparator9;
		
		private global::Gtk.Label lblarticulos;
		
		private global::Gtk.HSeparator hseparator8;
		
		private global::Gtk.HBox hbox7;
		
		private global::Gtk.Label lblcod;
		
		private global::Gtk.Entry entcod;
		
		private global::Gtk.Label lblcodpto;
		
		private global::Gtk.Entry entcodpto;
		
		private global::Gtk.HBox hbox13;
		
		private global::Gtk.Label lbldesc;
		
		private global::Gtk.Entry entdesc;
		
		private global::Gtk.VBox vbox7;
		
		private global::Gtk.HBox hbox14;
		
		private global::Gtk.Label lblcosto;
		
		private global::Gtk.Entry entcosto;
		
		private global::Gtk.HBox hbox8;
		
		private global::Gtk.Label lblpredetal;
		
		private global::Gtk.Entry entpredetal;
		
		private global::Gtk.Label lblpremayor;
		
		private global::Gtk.Entry entpremayor;
		
		private global::Gtk.HBox hbox9;
		
		private global::Gtk.Label lblexistdetal;
		
		private global::Gtk.Entry entexistdetal;
		
		private global::Gtk.Label lblexistmayor;
		
		private global::Gtk.Entry entexistmayor;
		
		private global::Gtk.VBox vbox8;
		
		private global::Gtk.HBox hbox10;
		
		private global::Gtk.Button btnbuscar;
		
		private global::Gtk.Button btnincluir;
		
		private global::Gtk.Button btnmodificar;
		
		private global::Gtk.HSeparator hseparator7;
		
		private global::Gtk.HBox hbox11;
		
		private global::Gtk.Button btnreactivar;
		
		private global::Gtk.Button btneliminar;
		
		private global::Gtk.Button btncancelar;
		
		private global::Gtk.HBox hbox12;
		
		private global::Gtk.VBox vbox9;
		
		private global::Gtk.Label lblfecha;
		
		private global::Gtk.Label lblhora;
		
		private global::Gtk.VSeparator vseparator2;
		
		private global::Gtk.Button btnvolver;
		
		private global::Gtk.Button btnsalir;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget ProyectoAeonFlux.Articulos
			this.Name = "ProyectoAeonFlux.Articulos";
			this.Title = global::Mono.Unix.Catalog.GetString ("Articulos");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child ProyectoAeonFlux.Articulos.Gtk.Container+ContainerChild
			this.vbox5 = new global::Gtk.VBox ();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.vbox6 = new global::Gtk.VBox ();
			this.vbox6.Name = "vbox6";
			this.vbox6.Spacing = 6;
			// Container child vbox6.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox ();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.hseparator9 = new global::Gtk.HSeparator ();
			this.hseparator9.Name = "hseparator9";
			this.hbox6.Add (this.hseparator9);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.hseparator9]));
			w1.Position = 0;
			// Container child hbox6.Gtk.Box+BoxChild
			this.lblarticulos = new global::Gtk.Label ();
			this.lblarticulos.Name = "lblarticulos";
			this.lblarticulos.LabelProp = global::Mono.Unix.Catalog.GetString ("<span color='blue'>Articulos</span>");
			this.lblarticulos.UseMarkup = true;
			this.hbox6.Add (this.lblarticulos);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.lblarticulos]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.hseparator8 = new global::Gtk.HSeparator ();
			this.hseparator8.Name = "hseparator8";
			this.hbox6.Add (this.hseparator8);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.hseparator8]));
			w3.Position = 2;
			this.vbox6.Add (this.hbox6);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.hbox6]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.hbox7 = new global::Gtk.HBox ();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.lblcod = new global::Gtk.Label ();
			this.lblcod.Name = "lblcod";
			this.lblcod.LabelProp = global::Mono.Unix.Catalog.GetString ("Codigo");
			this.hbox7.Add (this.lblcod);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.lblcod]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox7.Gtk.Box+BoxChild
			this.entcod = new global::Gtk.Entry ();
			this.entcod.CanFocus = true;
			this.entcod.Name = "entcod";
			this.entcod.IsEditable = true;
			this.entcod.InvisibleChar = '•';
			this.hbox7.Add (this.entcod);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.entcod]));
			w6.Position = 1;
			// Container child hbox7.Gtk.Box+BoxChild
			this.lblcodpto = new global::Gtk.Label ();
			this.lblcodpto.Name = "lblcodpto";
			this.lblcodpto.LabelProp = global::Mono.Unix.Catalog.GetString ("Codigo departamento");
			this.hbox7.Add (this.lblcodpto);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.lblcodpto]));
			w7.Position = 2;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox7.Gtk.Box+BoxChild
			this.entcodpto = new global::Gtk.Entry ();
			this.entcodpto.CanFocus = true;
			this.entcodpto.Name = "entcodpto";
			this.entcodpto.IsEditable = true;
			this.entcodpto.InvisibleChar = '•';
			this.hbox7.Add (this.entcodpto);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.entcodpto]));
			w8.Position = 3;
			this.vbox6.Add (this.hbox7);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.hbox7]));
			w9.Position = 1;
			w9.Expand = false;
			w9.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.hbox13 = new global::Gtk.HBox ();
			this.hbox13.Name = "hbox13";
			this.hbox13.Spacing = 6;
			// Container child hbox13.Gtk.Box+BoxChild
			this.lbldesc = new global::Gtk.Label ();
			this.lbldesc.Name = "lbldesc";
			this.lbldesc.LabelProp = global::Mono.Unix.Catalog.GetString ("Descripción");
			this.hbox13.Add (this.lbldesc);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox13 [this.lbldesc]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hbox13.Gtk.Box+BoxChild
			this.entdesc = new global::Gtk.Entry ();
			this.entdesc.CanFocus = true;
			this.entdesc.Name = "entdesc";
			this.entdesc.IsEditable = true;
			this.entdesc.InvisibleChar = '•';
			this.hbox13.Add (this.entdesc);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox13 [this.entdesc]));
			w11.Position = 1;
			this.vbox6.Add (this.hbox13);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.hbox13]));
			w12.Position = 2;
			w12.Expand = false;
			w12.Fill = false;
			this.vbox5.Add (this.vbox6);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.vbox6]));
			w13.Position = 0;
			w13.Expand = false;
			w13.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.vbox7 = new global::Gtk.VBox ();
			this.vbox7.Name = "vbox7";
			this.vbox7.Spacing = 6;
			// Container child vbox7.Gtk.Box+BoxChild
			this.hbox14 = new global::Gtk.HBox ();
			this.hbox14.Name = "hbox14";
			this.hbox14.Spacing = 6;
			// Container child hbox14.Gtk.Box+BoxChild
			this.lblcosto = new global::Gtk.Label ();
			this.lblcosto.Name = "lblcosto";
			this.lblcosto.LabelProp = global::Mono.Unix.Catalog.GetString ("Costo");
			this.hbox14.Add (this.lblcosto);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox14 [this.lblcosto]));
			w14.Position = 0;
			w14.Expand = false;
			w14.Fill = false;
			// Container child hbox14.Gtk.Box+BoxChild
			this.entcosto = new global::Gtk.Entry ();
			this.entcosto.CanFocus = true;
			this.entcosto.Name = "entcosto";
			this.entcosto.IsEditable = true;
			this.entcosto.InvisibleChar = '•';
			this.hbox14.Add (this.entcosto);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox14 [this.entcosto]));
			w15.Position = 1;
			w15.Expand = false;
			this.vbox7.Add (this.hbox14);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.hbox14]));
			w16.Position = 0;
			w16.Expand = false;
			w16.Fill = false;
			// Container child vbox7.Gtk.Box+BoxChild
			this.hbox8 = new global::Gtk.HBox ();
			this.hbox8.Name = "hbox8";
			this.hbox8.Spacing = 6;
			// Container child hbox8.Gtk.Box+BoxChild
			this.lblpredetal = new global::Gtk.Label ();
			this.lblpredetal.Name = "lblpredetal";
			this.lblpredetal.LabelProp = global::Mono.Unix.Catalog.GetString ("Precio al detal");
			this.hbox8.Add (this.lblpredetal);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.lblpredetal]));
			w17.Position = 0;
			w17.Expand = false;
			w17.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.entpredetal = new global::Gtk.Entry ();
			this.entpredetal.CanFocus = true;
			this.entpredetal.Name = "entpredetal";
			this.entpredetal.IsEditable = true;
			this.entpredetal.InvisibleChar = '•';
			this.hbox8.Add (this.entpredetal);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.entpredetal]));
			w18.Position = 1;
			// Container child hbox8.Gtk.Box+BoxChild
			this.lblpremayor = new global::Gtk.Label ();
			this.lblpremayor.Name = "lblpremayor";
			this.lblpremayor.LabelProp = global::Mono.Unix.Catalog.GetString ("Precio al mayor");
			this.hbox8.Add (this.lblpremayor);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.lblpremayor]));
			w19.Position = 2;
			w19.Expand = false;
			w19.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.entpremayor = new global::Gtk.Entry ();
			this.entpremayor.CanFocus = true;
			this.entpremayor.Name = "entpremayor";
			this.entpremayor.IsEditable = true;
			this.entpremayor.InvisibleChar = '•';
			this.hbox8.Add (this.entpremayor);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.entpremayor]));
			w20.Position = 3;
			this.vbox7.Add (this.hbox8);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.hbox8]));
			w21.Position = 1;
			w21.Expand = false;
			w21.Fill = false;
			// Container child vbox7.Gtk.Box+BoxChild
			this.hbox9 = new global::Gtk.HBox ();
			this.hbox9.Name = "hbox9";
			this.hbox9.Spacing = 6;
			// Container child hbox9.Gtk.Box+BoxChild
			this.lblexistdetal = new global::Gtk.Label ();
			this.lblexistdetal.Name = "lblexistdetal";
			this.lblexistdetal.LabelProp = global::Mono.Unix.Catalog.GetString ("Cantidad almacen 1");
			this.hbox9.Add (this.lblexistdetal);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox9 [this.lblexistdetal]));
			w22.Position = 0;
			w22.Expand = false;
			w22.Fill = false;
			// Container child hbox9.Gtk.Box+BoxChild
			this.entexistdetal = new global::Gtk.Entry ();
			this.entexistdetal.CanFocus = true;
			this.entexistdetal.Name = "entexistdetal";
			this.entexistdetal.IsEditable = true;
			this.entexistdetal.InvisibleChar = '•';
			this.hbox9.Add (this.entexistdetal);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox9 [this.entexistdetal]));
			w23.Position = 1;
			// Container child hbox9.Gtk.Box+BoxChild
			this.lblexistmayor = new global::Gtk.Label ();
			this.lblexistmayor.Name = "lblexistmayor";
			this.lblexistmayor.LabelProp = global::Mono.Unix.Catalog.GetString ("Cantidad almacen 2");
			this.hbox9.Add (this.lblexistmayor);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox9 [this.lblexistmayor]));
			w24.Position = 2;
			w24.Expand = false;
			w24.Fill = false;
			// Container child hbox9.Gtk.Box+BoxChild
			this.entexistmayor = new global::Gtk.Entry ();
			this.entexistmayor.CanFocus = true;
			this.entexistmayor.Name = "entexistmayor";
			this.entexistmayor.IsEditable = true;
			this.entexistmayor.InvisibleChar = '•';
			this.hbox9.Add (this.entexistmayor);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox9 [this.entexistmayor]));
			w25.Position = 3;
			this.vbox7.Add (this.hbox9);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.hbox9]));
			w26.Position = 2;
			w26.Expand = false;
			w26.Fill = false;
			this.vbox5.Add (this.vbox7);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.vbox7]));
			w27.Position = 1;
			w27.Expand = false;
			w27.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.vbox8 = new global::Gtk.VBox ();
			this.vbox8.Name = "vbox8";
			this.vbox8.Spacing = 6;
			// Container child vbox8.Gtk.Box+BoxChild
			this.hbox10 = new global::Gtk.HBox ();
			this.hbox10.Name = "hbox10";
			this.hbox10.Spacing = 6;
			// Container child hbox10.Gtk.Box+BoxChild
			this.btnbuscar = new global::Gtk.Button ();
			this.btnbuscar.Sensitive = false;
			this.btnbuscar.CanFocus = true;
			this.btnbuscar.Name = "btnbuscar";
			this.btnbuscar.UseUnderline = true;
			this.btnbuscar.Label = global::Mono.Unix.Catalog.GetString ("Buscar");
			this.hbox10.Add (this.btnbuscar);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox10 [this.btnbuscar]));
			w28.Position = 0;
			w28.Fill = false;
			// Container child hbox10.Gtk.Box+BoxChild
			this.btnincluir = new global::Gtk.Button ();
			this.btnincluir.Sensitive = false;
			this.btnincluir.CanFocus = true;
			this.btnincluir.Name = "btnincluir";
			this.btnincluir.UseUnderline = true;
			this.btnincluir.Label = global::Mono.Unix.Catalog.GetString ("Incluir");
			this.hbox10.Add (this.btnincluir);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox10 [this.btnincluir]));
			w29.Position = 1;
			w29.Fill = false;
			// Container child hbox10.Gtk.Box+BoxChild
			this.btnmodificar = new global::Gtk.Button ();
			this.btnmodificar.Sensitive = false;
			this.btnmodificar.CanFocus = true;
			this.btnmodificar.Name = "btnmodificar";
			this.btnmodificar.UseUnderline = true;
			this.btnmodificar.Label = global::Mono.Unix.Catalog.GetString ("Modificar");
			this.hbox10.Add (this.btnmodificar);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.hbox10 [this.btnmodificar]));
			w30.Position = 2;
			w30.Fill = false;
			this.vbox8.Add (this.hbox10);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.hbox10]));
			w31.Position = 0;
			w31.Expand = false;
			w31.Fill = false;
			// Container child vbox8.Gtk.Box+BoxChild
			this.hseparator7 = new global::Gtk.HSeparator ();
			this.hseparator7.Name = "hseparator7";
			this.vbox8.Add (this.hseparator7);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.hseparator7]));
			w32.Position = 1;
			w32.Expand = false;
			w32.Fill = false;
			// Container child vbox8.Gtk.Box+BoxChild
			this.hbox11 = new global::Gtk.HBox ();
			this.hbox11.Name = "hbox11";
			this.hbox11.Spacing = 6;
			// Container child hbox11.Gtk.Box+BoxChild
			this.btnreactivar = new global::Gtk.Button ();
			this.btnreactivar.Sensitive = false;
			this.btnreactivar.CanFocus = true;
			this.btnreactivar.Name = "btnreactivar";
			this.btnreactivar.UseUnderline = true;
			this.btnreactivar.Label = global::Mono.Unix.Catalog.GetString ("Reactivar");
			this.hbox11.Add (this.btnreactivar);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.hbox11 [this.btnreactivar]));
			w33.Position = 0;
			w33.Expand = false;
			w33.Fill = false;
			// Container child hbox11.Gtk.Box+BoxChild
			this.btneliminar = new global::Gtk.Button ();
			this.btneliminar.Sensitive = false;
			this.btneliminar.CanFocus = true;
			this.btneliminar.Name = "btneliminar";
			this.btneliminar.UseUnderline = true;
			this.btneliminar.Label = global::Mono.Unix.Catalog.GetString ("Eliminar");
			this.hbox11.Add (this.btneliminar);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.hbox11 [this.btneliminar]));
			w34.Position = 1;
			w34.Fill = false;
			// Container child hbox11.Gtk.Box+BoxChild
			this.btncancelar = new global::Gtk.Button ();
			this.btncancelar.Sensitive = false;
			this.btncancelar.CanFocus = true;
			this.btncancelar.Name = "btncancelar";
			this.btncancelar.UseUnderline = true;
			this.btncancelar.Label = global::Mono.Unix.Catalog.GetString ("Cancelar");
			this.hbox11.Add (this.btncancelar);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.hbox11 [this.btncancelar]));
			w35.Position = 2;
			w35.Expand = false;
			w35.Fill = false;
			this.vbox8.Add (this.hbox11);
			global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.hbox11]));
			w36.Position = 2;
			w36.Expand = false;
			w36.Fill = false;
			// Container child vbox8.Gtk.Box+BoxChild
			this.hbox12 = new global::Gtk.HBox ();
			this.hbox12.Name = "hbox12";
			this.hbox12.Spacing = 6;
			// Container child hbox12.Gtk.Box+BoxChild
			this.vbox9 = new global::Gtk.VBox ();
			this.vbox9.Name = "vbox9";
			this.vbox9.Spacing = 6;
			// Container child vbox9.Gtk.Box+BoxChild
			this.lblfecha = new global::Gtk.Label ();
			this.lblfecha.Name = "lblfecha";
			this.vbox9.Add (this.lblfecha);
			global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.lblfecha]));
			w37.Position = 0;
			w37.Expand = false;
			w37.Fill = false;
			// Container child vbox9.Gtk.Box+BoxChild
			this.lblhora = new global::Gtk.Label ();
			this.lblhora.Name = "lblhora";
			this.vbox9.Add (this.lblhora);
			global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.lblhora]));
			w38.Position = 1;
			w38.Expand = false;
			w38.Fill = false;
			this.hbox12.Add (this.vbox9);
			global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.hbox12 [this.vbox9]));
			w39.Position = 0;
			w39.Expand = false;
			w39.Fill = false;
			// Container child hbox12.Gtk.Box+BoxChild
			this.vseparator2 = new global::Gtk.VSeparator ();
			this.vseparator2.Name = "vseparator2";
			this.hbox12.Add (this.vseparator2);
			global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.hbox12 [this.vseparator2]));
			w40.Position = 1;
			w40.Fill = false;
			// Container child hbox12.Gtk.Box+BoxChild
			this.btnvolver = new global::Gtk.Button ();
			this.btnvolver.CanFocus = true;
			this.btnvolver.Name = "btnvolver";
			this.btnvolver.UseUnderline = true;
			this.btnvolver.Label = global::Mono.Unix.Catalog.GetString ("Volver");
			this.hbox12.Add (this.btnvolver);
			global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.hbox12 [this.btnvolver]));
			w41.Position = 2;
			w41.Expand = false;
			w41.Fill = false;
			// Container child hbox12.Gtk.Box+BoxChild
			this.btnsalir = new global::Gtk.Button ();
			this.btnsalir.CanFocus = true;
			this.btnsalir.Name = "btnsalir";
			this.btnsalir.UseUnderline = true;
			this.btnsalir.Label = global::Mono.Unix.Catalog.GetString ("Salir");
			this.hbox12.Add (this.btnsalir);
			global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.hbox12 [this.btnsalir]));
			w42.Position = 3;
			w42.Expand = false;
			w42.Fill = false;
			this.vbox8.Add (this.hbox12);
			global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.hbox12]));
			w43.Position = 3;
			w43.Expand = false;
			w43.Fill = false;
			this.vbox5.Add (this.vbox8);
			global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.vbox8]));
			w44.Position = 2;
			w44.Expand = false;
			w44.Fill = false;
			this.Add (this.vbox5);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 678;
			this.DefaultHeight = 319;
			this.Show ();
			this.entcod.Changed += new global::System.EventHandler (this.OnEntcodChanged);
			this.entcodpto.Changed += new global::System.EventHandler (this.OnEntcodptoChanged);
			this.entdesc.Changed += new global::System.EventHandler (this.OnEntdescChanged);
			this.entcosto.Changed += new global::System.EventHandler (this.OnEntcostoChanged);
			this.entpredetal.Changed += new global::System.EventHandler (this.OnEntpredetalChanged);
			this.entpremayor.Changed += new global::System.EventHandler (this.OnEntpremayorChanged);
			this.entexistdetal.Changed += new global::System.EventHandler (this.OnEntexistdetalChanged);
			this.entexistmayor.Changed += new global::System.EventHandler (this.OnEntexistmayorChanged);
			this.btnbuscar.Clicked += new global::System.EventHandler (this.OnBtnbuscarClicked);
			this.btnincluir.Clicked += new global::System.EventHandler (this.OnBtnincluirClicked);
			this.btnmodificar.Clicked += new global::System.EventHandler (this.OnBtnmodificarClicked);
			this.btnreactivar.Clicked += new global::System.EventHandler (this.OnBtnreactivarClicked);
			this.btneliminar.Clicked += new global::System.EventHandler (this.OnBtneliminarClicked);
			this.btncancelar.Clicked += new global::System.EventHandler (this.OnBtncancelarClicked);
			this.btnvolver.Clicked += new global::System.EventHandler (this.OnBtnvolverClicked);
			this.btnsalir.Clicked += new global::System.EventHandler (this.OnBtnsalirClicked);
		}
	}
}
