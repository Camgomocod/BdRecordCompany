namespace BdRecordCompany
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbcGestion = new TabControl();
            tpRegistroEmpresa = new TabPage();
            pnlRegistroEmpresa = new Panel();
            btnGuardar = new Button();
            rbEmpresaCasaMatriz = new RadioButton();
            rbEmpresaSubsidiaria = new RadioButton();
            txtEmpresaNombre = new TextBox();
            txtEmpresaId = new TextBox();
            lbEmpresaTipo = new Label();
            lbEmpresaNombre = new Label();
            lbEmpresaId = new Label();
            tpRegistroArtista = new TabPage();
            pnlRegistroArtista = new Panel();
            cbProductorClasificacion = new ComboBox();
            cbProductorAniosExp = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            txtProductorNombre = new TextBox();
            txtProductorTarjeta = new TextBox();
            lbProductorAñosExp = new Label();
            lbProductorNombre = new Label();
            lbProductorTarjeta = new Label();
            tpRegistroEmpresaProductor = new TabPage();
            panel1 = new Panel();
            lbVinculacionFechaFin = new Label();
            label5 = new Label();
            button2 = new Button();
            txtVinculacionTarjetaProfesional = new TextBox();
            txtVinculacionIdentificacion = new TextBox();
            lbVinculacionFechaIni = new Label();
            label3 = new Label();
            label4 = new Label();
            tpBuscarVinculacion = new TabPage();
            tpConsultaContrato = new TabPage();
            pnlConsultaContrato = new Panel();
            dtpVinculacionFechaIni = new DateTimePicker();
            dtpVinculacionFechaFin = new DateTimePicker();
            label8 = new Label();
            label7 = new Label();
            button3 = new Button();
            dateTimePicker2 = new DateTimePicker();
            panel2 = new Panel();
            tbcGestion.SuspendLayout();
            tpRegistroEmpresa.SuspendLayout();
            pnlRegistroEmpresa.SuspendLayout();
            tpRegistroArtista.SuspendLayout();
            pnlRegistroArtista.SuspendLayout();
            tpRegistroEmpresaProductor.SuspendLayout();
            panel1.SuspendLayout();
            tpBuscarVinculacion.SuspendLayout();
            tpConsultaContrato.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tbcGestion
            // 
            tbcGestion.Controls.Add(tpRegistroEmpresa);
            tbcGestion.Controls.Add(tpRegistroArtista);
            tbcGestion.Controls.Add(tpRegistroEmpresaProductor);
            tbcGestion.Controls.Add(tpBuscarVinculacion);
            tbcGestion.Controls.Add(tpConsultaContrato);
            tbcGestion.Location = new Point(12, 12);
            tbcGestion.Name = "tbcGestion";
            tbcGestion.RightToLeft = RightToLeft.Yes;
            tbcGestion.SelectedIndex = 0;
            tbcGestion.Size = new Size(768, 426);
            tbcGestion.TabIndex = 0;
            // 
            // tpRegistroEmpresa
            // 
            tpRegistroEmpresa.Controls.Add(pnlRegistroEmpresa);
            tpRegistroEmpresa.Location = new Point(4, 24);
            tpRegistroEmpresa.Name = "tpRegistroEmpresa";
            tpRegistroEmpresa.Padding = new Padding(3);
            tpRegistroEmpresa.Size = new Size(760, 398);
            tpRegistroEmpresa.TabIndex = 0;
            tpRegistroEmpresa.Text = "Registro Empresa";
            tpRegistroEmpresa.UseVisualStyleBackColor = true;
            // 
            // pnlRegistroEmpresa
            // 
            pnlRegistroEmpresa.Controls.Add(btnGuardar);
            pnlRegistroEmpresa.Controls.Add(rbEmpresaCasaMatriz);
            pnlRegistroEmpresa.Controls.Add(rbEmpresaSubsidiaria);
            pnlRegistroEmpresa.Controls.Add(txtEmpresaNombre);
            pnlRegistroEmpresa.Controls.Add(txtEmpresaId);
            pnlRegistroEmpresa.Controls.Add(lbEmpresaTipo);
            pnlRegistroEmpresa.Controls.Add(lbEmpresaNombre);
            pnlRegistroEmpresa.Controls.Add(lbEmpresaId);
            pnlRegistroEmpresa.Location = new Point(54, 27);
            pnlRegistroEmpresa.Name = "pnlRegistroEmpresa";
            pnlRegistroEmpresa.Size = new Size(513, 345);
            pnlRegistroEmpresa.TabIndex = 1;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(205, 221);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // rbEmpresaCasaMatriz
            // 
            rbEmpresaCasaMatriz.AutoSize = true;
            rbEmpresaCasaMatriz.Location = new Point(284, 144);
            rbEmpresaCasaMatriz.Name = "rbEmpresaCasaMatriz";
            rbEmpresaCasaMatriz.Size = new Size(86, 19);
            rbEmpresaCasaMatriz.TabIndex = 6;
            rbEmpresaCasaMatriz.TabStop = true;
            rbEmpresaCasaMatriz.Text = "Casa Matriz";
            rbEmpresaCasaMatriz.UseVisualStyleBackColor = true;
            // 
            // rbEmpresaSubsidiaria
            // 
            rbEmpresaSubsidiaria.AutoSize = true;
            rbEmpresaSubsidiaria.Location = new Point(172, 144);
            rbEmpresaSubsidiaria.Name = "rbEmpresaSubsidiaria";
            rbEmpresaSubsidiaria.Size = new Size(82, 19);
            rbEmpresaSubsidiaria.TabIndex = 5;
            rbEmpresaSubsidiaria.TabStop = true;
            rbEmpresaSubsidiaria.Text = "Subsidiaria";
            rbEmpresaSubsidiaria.UseVisualStyleBackColor = true;
            // 
            // txtEmpresaNombre
            // 
            txtEmpresaNombre.Location = new Point(172, 101);
            txtEmpresaNombre.Name = "txtEmpresaNombre";
            txtEmpresaNombre.Size = new Size(206, 23);
            txtEmpresaNombre.TabIndex = 4;
            // 
            // txtEmpresaId
            // 
            txtEmpresaId.Location = new Point(172, 72);
            txtEmpresaId.Name = "txtEmpresaId";
            txtEmpresaId.Size = new Size(206, 23);
            txtEmpresaId.TabIndex = 3;
            // 
            // lbEmpresaTipo
            // 
            lbEmpresaTipo.AutoSize = true;
            lbEmpresaTipo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbEmpresaTipo.Location = new Point(35, 146);
            lbEmpresaTipo.Name = "lbEmpresaTipo";
            lbEmpresaTipo.Size = new Size(33, 17);
            lbEmpresaTipo.TabIndex = 2;
            lbEmpresaTipo.Text = "Tipo";
            lbEmpresaTipo.TextAlign = ContentAlignment.TopRight;
            // 
            // lbEmpresaNombre
            // 
            lbEmpresaNombre.AutoSize = true;
            lbEmpresaNombre.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbEmpresaNombre.Location = new Point(35, 110);
            lbEmpresaNombre.Name = "lbEmpresaNombre";
            lbEmpresaNombre.Size = new Size(55, 17);
            lbEmpresaNombre.TabIndex = 1;
            lbEmpresaNombre.Text = "Nombre";
            lbEmpresaNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbEmpresaId
            // 
            lbEmpresaId.AutoSize = true;
            lbEmpresaId.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbEmpresaId.Location = new Point(35, 78);
            lbEmpresaId.Name = "lbEmpresaId";
            lbEmpresaId.Size = new Size(89, 17);
            lbEmpresaId.TabIndex = 0;
            lbEmpresaId.Text = "Identificación";
            lbEmpresaId.TextAlign = ContentAlignment.TopRight;
            // 
            // tpRegistroArtista
            // 
            tpRegistroArtista.Controls.Add(pnlRegistroArtista);
            tpRegistroArtista.Location = new Point(4, 24);
            tpRegistroArtista.Name = "tpRegistroArtista";
            tpRegistroArtista.Padding = new Padding(3);
            tpRegistroArtista.Size = new Size(760, 398);
            tpRegistroArtista.TabIndex = 1;
            tpRegistroArtista.Text = "Registro Productor";
            tpRegistroArtista.UseVisualStyleBackColor = true;
            // 
            // pnlRegistroArtista
            // 
            pnlRegistroArtista.Controls.Add(cbProductorClasificacion);
            pnlRegistroArtista.Controls.Add(cbProductorAniosExp);
            pnlRegistroArtista.Controls.Add(label1);
            pnlRegistroArtista.Controls.Add(button1);
            pnlRegistroArtista.Controls.Add(txtProductorNombre);
            pnlRegistroArtista.Controls.Add(txtProductorTarjeta);
            pnlRegistroArtista.Controls.Add(lbProductorAñosExp);
            pnlRegistroArtista.Controls.Add(lbProductorNombre);
            pnlRegistroArtista.Controls.Add(lbProductorTarjeta);
            pnlRegistroArtista.Location = new Point(57, 28);
            pnlRegistroArtista.Name = "pnlRegistroArtista";
            pnlRegistroArtista.Size = new Size(513, 345);
            pnlRegistroArtista.TabIndex = 2;
            // 
            // cbProductorClasificacion
            // 
            cbProductorClasificacion.FormattingEnabled = true;
            cbProductorClasificacion.Location = new Point(172, 172);
            cbProductorClasificacion.Name = "cbProductorClasificacion";
            cbProductorClasificacion.Size = new Size(206, 23);
            cbProductorClasificacion.TabIndex = 10;
            // 
            // cbProductorAniosExp
            // 
            cbProductorAniosExp.FormattingEnabled = true;
            cbProductorAniosExp.Location = new Point(172, 136);
            cbProductorAniosExp.Name = "cbProductorAniosExp";
            cbProductorAniosExp.Size = new Size(206, 23);
            cbProductorAniosExp.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 178);
            label1.Name = "label1";
            label1.Size = new Size(89, 17);
            label1.TabIndex = 8;
            label1.Text = " :Clasificación";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // button1
            // 
            button1.Location = new Point(195, 293);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtProductorNombre
            // 
            txtProductorNombre.Location = new Point(172, 101);
            txtProductorNombre.Name = "txtProductorNombre";
            txtProductorNombre.Size = new Size(206, 23);
            txtProductorNombre.TabIndex = 4;
            // 
            // txtProductorTarjeta
            // 
            txtProductorTarjeta.Location = new Point(172, 72);
            txtProductorTarjeta.Name = "txtProductorTarjeta";
            txtProductorTarjeta.Size = new Size(206, 23);
            txtProductorTarjeta.TabIndex = 3;
            // 
            // lbProductorAñosExp
            // 
            lbProductorAñosExp.AutoSize = true;
            lbProductorAñosExp.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbProductorAñosExp.Location = new Point(35, 142);
            lbProductorAñosExp.Name = "lbProductorAñosExp";
            lbProductorAñosExp.Size = new Size(117, 17);
            lbProductorAñosExp.TabIndex = 2;
            lbProductorAñosExp.Text = " :Años Experiencia";
            lbProductorAñosExp.TextAlign = ContentAlignment.TopRight;
            // 
            // lbProductorNombre
            // 
            lbProductorNombre.AutoSize = true;
            lbProductorNombre.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbProductorNombre.Location = new Point(35, 110);
            lbProductorNombre.Name = "lbProductorNombre";
            lbProductorNombre.Size = new Size(116, 17);
            lbProductorNombre.TabIndex = 1;
            lbProductorNombre.Text = " :Nombre Artistico";
            lbProductorNombre.TextAlign = ContentAlignment.TopRight;
            // 
            // lbProductorTarjeta
            // 
            lbProductorTarjeta.AutoSize = true;
            lbProductorTarjeta.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbProductorTarjeta.Location = new Point(35, 78);
            lbProductorTarjeta.Name = "lbProductorTarjeta";
            lbProductorTarjeta.Size = new Size(126, 17);
            lbProductorTarjeta.TabIndex = 0;
            lbProductorTarjeta.Text = " :Tarjeta Profesional";
            lbProductorTarjeta.TextAlign = ContentAlignment.TopRight;
            // 
            // tpRegistroEmpresaProductor
            // 
            tpRegistroEmpresaProductor.Controls.Add(panel1);
            tpRegistroEmpresaProductor.Location = new Point(4, 24);
            tpRegistroEmpresaProductor.Name = "tpRegistroEmpresaProductor";
            tpRegistroEmpresaProductor.Size = new Size(760, 398);
            tpRegistroEmpresaProductor.TabIndex = 2;
            tpRegistroEmpresaProductor.Text = "Vinculacion Empresa-Productor";
            tpRegistroEmpresaProductor.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(dtpVinculacionFechaFin);
            panel1.Controls.Add(dtpVinculacionFechaIni);
            panel1.Controls.Add(lbVinculacionFechaFin);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(txtVinculacionTarjetaProfesional);
            panel1.Controls.Add(txtVinculacionIdentificacion);
            panel1.Controls.Add(lbVinculacionFechaIni);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(50, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(513, 345);
            panel1.TabIndex = 2;
            // 
            // lbVinculacionFechaFin
            // 
            lbVinculacionFechaFin.AutoSize = true;
            lbVinculacionFechaFin.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbVinculacionFechaFin.Location = new Point(35, 174);
            lbVinculacionFechaFin.Name = "lbVinculacionFechaFin";
            lbVinculacionFechaFin.Size = new Size(66, 17);
            lbVinculacionFechaFin.TabIndex = 9;
            lbVinculacionFechaFin.Text = "Fecha Fin";
            lbVinculacionFechaFin.TextAlign = ContentAlignment.TopRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(35, 110);
            label5.Name = "label5";
            label5.Size = new Size(126, 17);
            label5.TabIndex = 8;
            label5.Text = " :Tarjeta Profesional";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // button2
            // 
            button2.Location = new Point(205, 221);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = true;
            // 
            // txtVinculacionTarjetaProfesional
            // 
            txtVinculacionTarjetaProfesional.Location = new Point(172, 104);
            txtVinculacionTarjetaProfesional.Name = "txtVinculacionTarjetaProfesional";
            txtVinculacionTarjetaProfesional.Size = new Size(206, 23);
            txtVinculacionTarjetaProfesional.TabIndex = 4;
            // 
            // txtVinculacionIdentificacion
            // 
            txtVinculacionIdentificacion.Location = new Point(172, 72);
            txtVinculacionIdentificacion.Name = "txtVinculacionIdentificacion";
            txtVinculacionIdentificacion.Size = new Size(206, 23);
            txtVinculacionIdentificacion.TabIndex = 3;
            // 
            // lbVinculacionFechaIni
            // 
            lbVinculacionFechaIni.AutoSize = true;
            lbVinculacionFechaIni.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbVinculacionFechaIni.Location = new Point(35, 142);
            lbVinculacionFechaIni.Name = "lbVinculacionFechaIni";
            lbVinculacionFechaIni.Size = new Size(80, 17);
            lbVinculacionFechaIni.TabIndex = 2;
            lbVinculacionFechaIni.Text = "Fecha Inicio";
            lbVinculacionFechaIni.TextAlign = ContentAlignment.TopRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(35, 110);
            label3.Name = "label3";
            label3.Size = new Size(0, 17);
            label3.TabIndex = 1;
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(35, 78);
            label4.Name = "label4";
            label4.Size = new Size(89, 17);
            label4.TabIndex = 0;
            label4.Text = "Identificación";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // tpBuscarVinculacion
            // 
            tpBuscarVinculacion.Controls.Add(panel2);
            tpBuscarVinculacion.Location = new Point(4, 24);
            tpBuscarVinculacion.Name = "tpBuscarVinculacion";
            tpBuscarVinculacion.Size = new Size(760, 398);
            tpBuscarVinculacion.TabIndex = 3;
            tpBuscarVinculacion.Text = "Buscar Vinculación";
            tpBuscarVinculacion.UseVisualStyleBackColor = true;
            // 
            // tpConsultaContrato
            // 
            tpConsultaContrato.Controls.Add(pnlConsultaContrato);
            tpConsultaContrato.Location = new Point(4, 24);
            tpConsultaContrato.Name = "tpConsultaContrato";
            tpConsultaContrato.Size = new Size(760, 398);
            tpConsultaContrato.TabIndex = 4;
            tpConsultaContrato.Text = "Consulta Contrato Vigente";
            tpConsultaContrato.UseVisualStyleBackColor = true;
            // 
            // pnlConsultaContrato
            // 
            pnlConsultaContrato.Location = new Point(31, 27);
            pnlConsultaContrato.Name = "pnlConsultaContrato";
            pnlConsultaContrato.Size = new Size(698, 345);
            pnlConsultaContrato.TabIndex = 1;
            // 
            // dtpVinculacionFechaIni
            // 
            dtpVinculacionFechaIni.Location = new Point(172, 136);
            dtpVinculacionFechaIni.Name = "dtpVinculacionFechaIni";
            dtpVinculacionFechaIni.Size = new Size(200, 23);
            dtpVinculacionFechaIni.TabIndex = 10;
            // 
            // dtpVinculacionFechaFin
            // 
            dtpVinculacionFechaFin.Location = new Point(172, 168);
            dtpVinculacionFechaFin.Name = "dtpVinculacionFechaFin";
            dtpVinculacionFechaFin.Size = new Size(200, 23);
            dtpVinculacionFechaFin.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(35, 110);
            label8.Name = "label8";
            label8.Size = new Size(0, 17);
            label8.TabIndex = 1;
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(31, 96);
            label7.Name = "label7";
            label7.Size = new Size(80, 17);
            label7.TabIndex = 2;
            label7.Text = "Fecha Inicio";
            label7.TextAlign = ContentAlignment.TopRight;
            // 
            // button3
            // 
            button3.Location = new Point(203, 267);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 7;
            button3.Text = "Guardar";
            button3.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(168, 90);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Controls.Add(dateTimePicker2);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(48, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(513, 345);
            panel2.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 450);
            Controls.Add(tbcGestion);
            Name = "Form1";
            Text = "Record Company";
            tbcGestion.ResumeLayout(false);
            tpRegistroEmpresa.ResumeLayout(false);
            pnlRegistroEmpresa.ResumeLayout(false);
            pnlRegistroEmpresa.PerformLayout();
            tpRegistroArtista.ResumeLayout(false);
            pnlRegistroArtista.ResumeLayout(false);
            pnlRegistroArtista.PerformLayout();
            tpRegistroEmpresaProductor.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tpBuscarVinculacion.ResumeLayout(false);
            tpConsultaContrato.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbcGestion;
        private TabPage tpRegistroEmpresa;
        private TabPage tpRegistroArtista;
        private TabPage tpRegistroEmpresaProductor;
        private TabPage tpBuscarVinculacion;
        private TabPage tpConsultaContrato;
        private Panel pnlRegistroEmpresa;
        private Panel pnlConsultaContrato;
        private Label lbEmpresaId;
        private Label lbEmpresaNombre;
        private Label lbEmpresaTipo;
        private TextBox txtEmpresaNombre;
        private TextBox txtEmpresaId;
        private RadioButton rbEmpresaCasaMatriz;
        private Button btnGuardar;
        private RadioButton rbEmpresaSubsidiaria;
        private Panel pnlRegistroArtista;
        private Button button1;
        private TextBox txtProductorNombre;
        private TextBox txtProductorTarjeta;
        private Label lbProductorAñosExp;
        private Label lbProductorNombre;
        private Label lbProductorTarjeta;
        private Label label1;
        private ComboBox cbProductorAniosExp;
        private ComboBox cbProductorClasificacion;
        private Panel panel1;
        private Label lbVinculacionFechaFin;
        private Label label5;
        private Button button2;
        private TextBox txtVinculacionTarjetaProfesional;
        private TextBox txtVinculacionIdentificacion;
        private Label lbVinculacionFechaIni;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpVinculacionFechaFin;
        private DateTimePicker dtpVinculacionFechaIni;
        private Panel panel2;
        private DateTimePicker dateTimePicker2;
        private Button button3;
        private Label label7;
        private Label label8;
    }
}
