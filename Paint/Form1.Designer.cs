namespace Paint
{
    partial class formPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFiguras = new System.Windows.Forms.Button();
            this.btnLinea = new System.Windows.Forms.Button();
            this.btnRelleno = new System.Windows.Forms.Button();
            this.btnCirculo = new System.Windows.Forms.Button();
            this.btnRectangulo = new System.Windows.Forms.Button();
            this.btnTriangulo = new System.Windows.Forms.Button();
            this.btnManoAlzada = new System.Windows.Forms.Button();
            this.btnPoligono = new System.Windows.Forms.Button();
            this.btnTexto = new System.Windows.Forms.Button();
            this.btnParametros = new System.Windows.Forms.Button();
            this.gbHerramientas = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbAcciones = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCoordenadas1 = new System.Windows.Forms.TextBox();
            this.tbCoordenadas = new System.Windows.Forms.TextBox();
            this.rtbTexto = new System.Windows.Forms.RichTextBox();
            this.btnAdelante = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnDibujar = new System.Windows.Forms.Button();
            this.btnPegar = new System.Windows.Forms.Button();
            this.btnCortar = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnColorDeFondo = new System.Windows.Forms.Button();
            this.btnColorDeBorde = new System.Windows.Forms.Button();
            this.gbParametros = new System.Windows.Forms.GroupBox();
            this.btnFuente = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDeBorde = new System.Windows.Forms.ColorDialog();
            this.colorDeFondo = new System.Windows.Forms.ColorDialog();
            this.gbHerramientas.SuspendLayout();
            this.gbAcciones.SuspendLayout();
            this.gbParametros.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(102, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 709);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // btnFiguras
            // 
            this.btnFiguras.Location = new System.Drawing.Point(0, 11);
            this.btnFiguras.Name = "btnFiguras";
            this.btnFiguras.Size = new System.Drawing.Size(102, 54);
            this.btnFiguras.TabIndex = 1;
            this.btnFiguras.Text = "Figuras";
            this.btnFiguras.UseVisualStyleBackColor = true;
            // 
            // btnLinea
            // 
            this.btnLinea.Location = new System.Drawing.Point(0, 62);
            this.btnLinea.Name = "btnLinea";
            this.btnLinea.Size = new System.Drawing.Size(102, 54);
            this.btnLinea.TabIndex = 2;
            this.btnLinea.Text = "Linea";
            this.btnLinea.UseVisualStyleBackColor = true;
            this.btnLinea.Click += new System.EventHandler(this.btnLinea_Click);
            // 
            // btnRelleno
            // 
            this.btnRelleno.Location = new System.Drawing.Point(0, 111);
            this.btnRelleno.Name = "btnRelleno";
            this.btnRelleno.Size = new System.Drawing.Size(102, 54);
            this.btnRelleno.TabIndex = 3;
            this.btnRelleno.Text = "Relleno";
            this.btnRelleno.UseVisualStyleBackColor = true;
            // 
            // btnCirculo
            // 
            this.btnCirculo.Location = new System.Drawing.Point(0, 162);
            this.btnCirculo.Name = "btnCirculo";
            this.btnCirculo.Size = new System.Drawing.Size(102, 54);
            this.btnCirculo.TabIndex = 4;
            this.btnCirculo.Text = "Circulo";
            this.btnCirculo.UseVisualStyleBackColor = true;
            // 
            // btnRectangulo
            // 
            this.btnRectangulo.Location = new System.Drawing.Point(0, 213);
            this.btnRectangulo.Name = "btnRectangulo";
            this.btnRectangulo.Size = new System.Drawing.Size(102, 54);
            this.btnRectangulo.TabIndex = 5;
            this.btnRectangulo.Text = "Rectangulo";
            this.btnRectangulo.UseVisualStyleBackColor = true;
            // 
            // btnTriangulo
            // 
            this.btnTriangulo.Location = new System.Drawing.Point(0, 264);
            this.btnTriangulo.Name = "btnTriangulo";
            this.btnTriangulo.Size = new System.Drawing.Size(102, 54);
            this.btnTriangulo.TabIndex = 6;
            this.btnTriangulo.Text = "Triangulo";
            this.btnTriangulo.UseVisualStyleBackColor = true;
            // 
            // btnManoAlzada
            // 
            this.btnManoAlzada.Location = new System.Drawing.Point(0, 315);
            this.btnManoAlzada.Name = "btnManoAlzada";
            this.btnManoAlzada.Size = new System.Drawing.Size(102, 54);
            this.btnManoAlzada.TabIndex = 7;
            this.btnManoAlzada.Text = "Mano Alzada";
            this.btnManoAlzada.UseVisualStyleBackColor = true;
            // 
            // btnPoligono
            // 
            this.btnPoligono.Location = new System.Drawing.Point(0, 366);
            this.btnPoligono.Name = "btnPoligono";
            this.btnPoligono.Size = new System.Drawing.Size(102, 54);
            this.btnPoligono.TabIndex = 8;
            this.btnPoligono.Text = "Polígono";
            this.btnPoligono.UseVisualStyleBackColor = true;
            // 
            // btnTexto
            // 
            this.btnTexto.Location = new System.Drawing.Point(0, 416);
            this.btnTexto.Name = "btnTexto";
            this.btnTexto.Size = new System.Drawing.Size(102, 54);
            this.btnTexto.TabIndex = 9;
            this.btnTexto.Text = "Texto";
            this.btnTexto.UseVisualStyleBackColor = true;
            this.btnTexto.Click += new System.EventHandler(this.btnTexto_Click);
            // 
            // btnParametros
            // 
            this.btnParametros.Location = new System.Drawing.Point(0, 466);
            this.btnParametros.Name = "btnParametros";
            this.btnParametros.Size = new System.Drawing.Size(102, 54);
            this.btnParametros.TabIndex = 10;
            this.btnParametros.Text = "Parametros";
            this.btnParametros.UseVisualStyleBackColor = true;
            // 
            // gbHerramientas
            // 
            this.gbHerramientas.Controls.Add(this.groupBox2);
            this.gbHerramientas.Controls.Add(this.btnParametros);
            this.gbHerramientas.Controls.Add(this.btnRectangulo);
            this.gbHerramientas.Controls.Add(this.btnLinea);
            this.gbHerramientas.Controls.Add(this.btnRelleno);
            this.gbHerramientas.Controls.Add(this.btnManoAlzada);
            this.gbHerramientas.Controls.Add(this.btnTexto);
            this.gbHerramientas.Controls.Add(this.btnPoligono);
            this.gbHerramientas.Controls.Add(this.btnTriangulo);
            this.gbHerramientas.Controls.Add(this.btnCirculo);
            this.gbHerramientas.Controls.Add(this.btnFiguras);
            this.gbHerramientas.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbHerramientas.Location = new System.Drawing.Point(0, 0);
            this.gbHerramientas.Name = "gbHerramientas";
            this.gbHerramientas.Size = new System.Drawing.Size(102, 709);
            this.gbHerramientas.TabIndex = 0;
            this.gbHerramientas.TabStop = false;
            this.gbHerramientas.Text = "Herramientas";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(0, 526);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(102, 184);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // gbAcciones
            // 
            this.gbAcciones.Controls.Add(this.label5);
            this.gbAcciones.Controls.Add(this.tbCoordenadas1);
            this.gbAcciones.Controls.Add(this.tbCoordenadas);
            this.gbAcciones.Controls.Add(this.rtbTexto);
            this.gbAcciones.Controls.Add(this.btnAdelante);
            this.gbAcciones.Controls.Add(this.btnAtras);
            this.gbAcciones.Controls.Add(this.btnSalir);
            this.gbAcciones.Controls.Add(this.btnBorrar);
            this.gbAcciones.Controls.Add(this.btnLimpiar);
            this.gbAcciones.Controls.Add(this.btnDibujar);
            this.gbAcciones.Controls.Add(this.btnPegar);
            this.gbAcciones.Controls.Add(this.btnCortar);
            this.gbAcciones.Controls.Add(this.btnAbrir);
            this.gbAcciones.Controls.Add(this.btnGuardar);
            this.gbAcciones.Controls.Add(this.btnColorDeFondo);
            this.gbAcciones.Controls.Add(this.btnColorDeBorde);
            this.gbAcciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbAcciones.Location = new System.Drawing.Point(102, 585);
            this.gbAcciones.Name = "gbAcciones";
            this.gbAcciones.Size = new System.Drawing.Size(1160, 124);
            this.gbAcciones.TabIndex = 1;
            this.gbAcciones.TabStop = false;
            this.gbAcciones.Text = "Acciones";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "label5";
            // 
            // tbCoordenadas1
            // 
            this.tbCoordenadas1.Location = new System.Drawing.Point(117, 89);
            this.tbCoordenadas1.Name = "tbCoordenadas1";
            this.tbCoordenadas1.Size = new System.Drawing.Size(237, 20);
            this.tbCoordenadas1.TabIndex = 14;
            // 
            // tbCoordenadas
            // 
            this.tbCoordenadas.Location = new System.Drawing.Point(117, 23);
            this.tbCoordenadas.Name = "tbCoordenadas";
            this.tbCoordenadas.Size = new System.Drawing.Size(237, 20);
            this.tbCoordenadas.TabIndex = 13;
            // 
            // rtbTexto
            // 
            this.rtbTexto.Location = new System.Drawing.Point(6, 21);
            this.rtbTexto.Name = "rtbTexto";
            this.rtbTexto.Size = new System.Drawing.Size(105, 91);
            this.rtbTexto.TabIndex = 12;
            this.rtbTexto.Text = "";
            // 
            // btnAdelante
            // 
            this.btnAdelante.Location = new System.Drawing.Point(928, 55);
            this.btnAdelante.Name = "btnAdelante";
            this.btnAdelante.Size = new System.Drawing.Size(55, 23);
            this.btnAdelante.TabIndex = 11;
            this.btnAdelante.Text = "Adelante";
            this.btnAdelante.UseVisualStyleBackColor = true;
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(867, 55);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(55, 23);
            this.btnAtras.TabIndex = 10;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1069, 90);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(1069, 20);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 8;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(948, 89);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnDibujar
            // 
            this.btnDibujar.Location = new System.Drawing.Point(948, 20);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(75, 23);
            this.btnDibujar.TabIndex = 6;
            this.btnDibujar.Text = "Dibujar";
            this.btnDibujar.UseVisualStyleBackColor = true;
            // 
            // btnPegar
            // 
            this.btnPegar.Location = new System.Drawing.Point(815, 89);
            this.btnPegar.Name = "btnPegar";
            this.btnPegar.Size = new System.Drawing.Size(75, 23);
            this.btnPegar.TabIndex = 5;
            this.btnPegar.Text = "Pegar";
            this.btnPegar.UseVisualStyleBackColor = true;
            // 
            // btnCortar
            // 
            this.btnCortar.Location = new System.Drawing.Point(815, 20);
            this.btnCortar.Name = "btnCortar";
            this.btnCortar.Size = new System.Drawing.Size(75, 23);
            this.btnCortar.TabIndex = 4;
            this.btnCortar.Text = "Cortar";
            this.btnCortar.UseVisualStyleBackColor = true;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(684, 89);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 3;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(684, 20);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnColorDeFondo
            // 
            this.btnColorDeFondo.Location = new System.Drawing.Point(526, 21);
            this.btnColorDeFondo.Name = "btnColorDeFondo";
            this.btnColorDeFondo.Size = new System.Drawing.Size(151, 92);
            this.btnColorDeFondo.TabIndex = 1;
            this.btnColorDeFondo.Text = "Color de fondo";
            this.btnColorDeFondo.UseVisualStyleBackColor = true;
            // 
            // btnColorDeBorde
            // 
            this.btnColorDeBorde.Location = new System.Drawing.Point(360, 21);
            this.btnColorDeBorde.Name = "btnColorDeBorde";
            this.btnColorDeBorde.Size = new System.Drawing.Size(151, 92);
            this.btnColorDeBorde.TabIndex = 0;
            this.btnColorDeBorde.Text = "Color de borde";
            this.btnColorDeBorde.UseVisualStyleBackColor = true;
            this.btnColorDeBorde.Click += new System.EventHandler(this.btnColorDeBorde_Click);
            // 
            // gbParametros
            // 
            this.gbParametros.Controls.Add(this.btnFuente);
            this.gbParametros.Controls.Add(this.label4);
            this.gbParametros.Controls.Add(this.label3);
            this.gbParametros.Controls.Add(this.label2);
            this.gbParametros.Controls.Add(this.label1);
            this.gbParametros.Controls.Add(this.textBox2);
            this.gbParametros.Controls.Add(this.textBox3);
            this.gbParametros.Controls.Add(this.textBox1);
            this.gbParametros.Location = new System.Drawing.Point(0, 526);
            this.gbParametros.Name = "gbParametros";
            this.gbParametros.Size = new System.Drawing.Size(96, 185);
            this.gbParametros.TabIndex = 2;
            this.gbParametros.TabStop = false;
            this.gbParametros.Text = "Misc";
            // 
            // btnFuente
            // 
            this.btnFuente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuente.Location = new System.Drawing.Point(57, 142);
            this.btnFuente.Name = "btnFuente";
            this.btnFuente.Size = new System.Drawing.Size(33, 23);
            this.btnFuente.TabIndex = 7;
            this.btnFuente.Text = "Fuente";
            this.btnFuente.UseVisualStyleBackColor = true;
            this.btnFuente.Click += new System.EventHandler(this.btnFuente_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fuente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tamaño";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Alto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ancho";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(57, 106);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(33, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(57, 66);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(33, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(33, 20);
            this.textBox1.TabIndex = 0;
            // 
            // fontDialog1
            // 
            this.fontDialog1.Apply += new System.EventHandler(this.btnFuente_Click);
            // 
            // colorDeBorde
            // 
            this.colorDeBorde.AnyColor = true;
            this.colorDeBorde.FullOpen = true;
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 709);
            this.Controls.Add(this.gbParametros);
            this.Controls.Add(this.gbAcciones);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbHerramientas);
            this.Name = "formPrincipal";
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.formPrincipal_Load);
            this.gbHerramientas.ResumeLayout(false);
            this.gbAcciones.ResumeLayout(false);
            this.gbAcciones.PerformLayout();
            this.gbParametros.ResumeLayout(false);
            this.gbParametros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFiguras;
        private System.Windows.Forms.Button btnLinea;
        private System.Windows.Forms.Button btnRelleno;
        private System.Windows.Forms.Button btnCirculo;
        private System.Windows.Forms.Button btnRectangulo;
        private System.Windows.Forms.Button btnTriangulo;
        private System.Windows.Forms.Button btnManoAlzada;
        private System.Windows.Forms.Button btnPoligono;
        private System.Windows.Forms.Button btnTexto;
        private System.Windows.Forms.Button btnParametros;
        private System.Windows.Forms.GroupBox gbHerramientas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbAcciones;
        private System.Windows.Forms.GroupBox gbParametros;
        private System.Windows.Forms.Button btnAdelante;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.Button btnPegar;
        private System.Windows.Forms.Button btnCortar;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnColorDeFondo;
        private System.Windows.Forms.Button btnColorDeBorde;
        private System.Windows.Forms.Button btnFuente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDeBorde;
        private System.Windows.Forms.ColorDialog colorDeFondo;
        private System.Windows.Forms.RichTextBox rtbTexto;
        private System.Windows.Forms.TextBox tbCoordenadas;
        private System.Windows.Forms.TextBox tbCoordenadas1;
        private System.Windows.Forms.Label label5;
    }
}

