
namespace ExpresionesRegulares
{
    partial class FrmValidaciones
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.GrpOpciones = new System.Windows.Forms.GroupBox();
            this.ChkValidar = new System.Windows.Forms.CheckBox();
            this.ChkFoco = new System.Windows.Forms.CheckBox();
            this.ChkEnter = new System.Windows.Forms.CheckBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnValidar = new System.Windows.Forms.Button();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtCP = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtTarjeta = new System.Windows.Forms.TextBox();
            this.TxtCCC = new System.Windows.Forms.TextBox();
            this.TxtNIF = new System.Windows.Forms.TextBox();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.LblCP = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblNIF = new System.Windows.Forms.Label();
            this.LblCCC = new System.Windows.Forms.Label();
            this.LblTarjeta = new System.Windows.Forms.Label();
            this.LblValidacionTelefono = new System.Windows.Forms.Label();
            this.LblValidacionCP = new System.Windows.Forms.Label();
            this.LblValidacionEmail = new System.Windows.Forms.Label();
            this.LblValidacionNIF = new System.Windows.Forms.Label();
            this.LblValidacionCCC = new System.Windows.Forms.Label();
            this.LblValidacionTarjeta = new System.Windows.Forms.Label();
            this.GrpOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpOpciones
            // 
            this.GrpOpciones.Controls.Add(this.ChkValidar);
            this.GrpOpciones.Controls.Add(this.ChkFoco);
            this.GrpOpciones.Controls.Add(this.ChkEnter);
            this.GrpOpciones.Location = new System.Drawing.Point(12, 12);
            this.GrpOpciones.Name = "GrpOpciones";
            this.GrpOpciones.Size = new System.Drawing.Size(450, 47);
            this.GrpOpciones.TabIndex = 0;
            this.GrpOpciones.TabStop = false;
            this.GrpOpciones.Text = "Opciones de validación";
            // 
            // ChkValidar
            // 
            this.ChkValidar.AutoSize = true;
            this.ChkValidar.Location = new System.Drawing.Point(236, 19);
            this.ChkValidar.Name = "ChkValidar";
            this.ChkValidar.Size = new System.Drawing.Size(161, 17);
            this.ChkValidar.TabIndex = 2;
            this.ChkValidar.Text = "Al presionar el botón \'Validar\'";
            this.ChkValidar.UseVisualStyleBackColor = true;
            this.ChkValidar.CheckedChanged += new System.EventHandler(this.ChkValidar_CheckedChanged);
            // 
            // ChkFoco
            // 
            this.ChkFoco.AutoSize = true;
            this.ChkFoco.Location = new System.Drawing.Point(121, 19);
            this.ChkFoco.Name = "ChkFoco";
            this.ChkFoco.Size = new System.Drawing.Size(103, 17);
            this.ChkFoco.TabIndex = 1;
            this.ChkFoco.Text = "Al perder el foco";
            this.ChkFoco.UseVisualStyleBackColor = true;
            this.ChkFoco.CheckedChanged += new System.EventHandler(this.ChkFoco_CheckedChanged);
            // 
            // ChkEnter
            // 
            this.ChkEnter.AutoSize = true;
            this.ChkEnter.Location = new System.Drawing.Point(6, 19);
            this.ChkEnter.Name = "ChkEnter";
            this.ChkEnter.Size = new System.Drawing.Size(109, 17);
            this.ChkEnter.TabIndex = 0;
            this.ChkEnter.Text = "Al presionar Enter";
            this.ChkEnter.UseVisualStyleBackColor = true;
            this.ChkEnter.CheckedChanged += new System.EventHandler(this.ChkEnter_CheckedChanged_1);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnLimpiar.Location = new System.Drawing.Point(552, 12);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(104, 47);
            this.BtnLimpiar.TabIndex = 1;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnValidar
            // 
            this.BtnValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnValidar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnValidar.Location = new System.Drawing.Point(671, 12);
            this.BtnValidar.Name = "BtnValidar";
            this.BtnValidar.Size = new System.Drawing.Size(104, 47);
            this.BtnValidar.TabIndex = 2;
            this.BtnValidar.Text = "Validar";
            this.BtnValidar.UseVisualStyleBackColor = true;
            this.BtnValidar.Click += new System.EventHandler(this.BtnValidar_Click);
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(186, 103);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(139, 20);
            this.TxtTelefono.TabIndex = 3;
            this.TxtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            this.TxtTelefono.Leave += new System.EventHandler(this.Txt_Leave);
            // 
            // TxtCP
            // 
            this.TxtCP.Location = new System.Drawing.Point(186, 127);
            this.TxtCP.Name = "TxtCP";
            this.TxtCP.Size = new System.Drawing.Size(139, 20);
            this.TxtCP.TabIndex = 4;
            this.TxtCP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            this.TxtCP.Leave += new System.EventHandler(this.Txt_Leave);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(186, 155);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(276, 20);
            this.TxtEmail.TabIndex = 5;
            this.TxtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            this.TxtEmail.Leave += new System.EventHandler(this.Txt_Leave);
            // 
            // TxtTarjeta
            // 
            this.TxtTarjeta.Location = new System.Drawing.Point(186, 231);
            this.TxtTarjeta.Name = "TxtTarjeta";
            this.TxtTarjeta.Size = new System.Drawing.Size(276, 20);
            this.TxtTarjeta.TabIndex = 6;
            this.TxtTarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            this.TxtTarjeta.Leave += new System.EventHandler(this.Txt_Leave);
            // 
            // TxtCCC
            // 
            this.TxtCCC.Location = new System.Drawing.Point(186, 207);
            this.TxtCCC.Name = "TxtCCC";
            this.TxtCCC.Size = new System.Drawing.Size(276, 20);
            this.TxtCCC.TabIndex = 7;
            this.TxtCCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            this.TxtCCC.Leave += new System.EventHandler(this.Txt_Leave);
            // 
            // TxtNIF
            // 
            this.TxtNIF.Location = new System.Drawing.Point(186, 179);
            this.TxtNIF.Name = "TxtNIF";
            this.TxtNIF.Size = new System.Drawing.Size(139, 20);
            this.TxtNIF.TabIndex = 8;
            this.TxtNIF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            this.TxtNIF.Leave += new System.EventHandler(this.Txt_Leave);
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.LblTelefono.Location = new System.Drawing.Point(8, 101);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(78, 20);
            this.LblTelefono.TabIndex = 9;
            this.LblTelefono.Text = "Teléfono:";
            // 
            // LblCP
            // 
            this.LblCP.AutoSize = true;
            this.LblCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.LblCP.Location = new System.Drawing.Point(8, 127);
            this.LblCP.Name = "LblCP";
            this.LblCP.Size = new System.Drawing.Size(118, 20);
            this.LblCP.TabIndex = 10;
            this.LblCP.Text = "Código Postal:";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.LblEmail.Location = new System.Drawing.Point(8, 153);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(62, 20);
            this.LblEmail.TabIndex = 11;
            this.LblEmail.Text = "E-mail:";
            // 
            // LblNIF
            // 
            this.LblNIF.AutoSize = true;
            this.LblNIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.LblNIF.Location = new System.Drawing.Point(8, 179);
            this.LblNIF.Name = "LblNIF";
            this.LblNIF.Size = new System.Drawing.Size(82, 20);
            this.LblNIF.TabIndex = 11;
            this.LblNIF.Text = "NIF / NIE:";
            // 
            // LblCCC
            // 
            this.LblCCC.AutoSize = true;
            this.LblCCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.LblCCC.Location = new System.Drawing.Point(8, 205);
            this.LblCCC.Name = "LblCCC";
            this.LblCCC.Size = new System.Drawing.Size(50, 20);
            this.LblCCC.TabIndex = 12;
            this.LblCCC.Text = "CCC:";
            // 
            // LblTarjeta
            // 
            this.LblTarjeta.AutoSize = true;
            this.LblTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.LblTarjeta.Location = new System.Drawing.Point(8, 231);
            this.LblTarjeta.Name = "LblTarjeta";
            this.LblTarjeta.Size = new System.Drawing.Size(125, 20);
            this.LblTarjeta.TabIndex = 13;
            this.LblTarjeta.Text = "Tarjeta Crédito:";
            // 
            // LblValidacionTelefono
            // 
            this.LblValidacionTelefono.AutoSize = true;
            this.LblValidacionTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.LblValidacionTelefono.Location = new System.Drawing.Point(548, 101);
            this.LblValidacionTelefono.Name = "LblValidacionTelefono";
            this.LblValidacionTelefono.Size = new System.Drawing.Size(215, 20);
            this.LblValidacionTelefono.TabIndex = 14;
            this.LblValidacionTelefono.Text = "Mensaje validación teléfono";
            this.LblValidacionTelefono.Visible = false;
            // 
            // LblValidacionCP
            // 
            this.LblValidacionCP.AutoSize = true;
            this.LblValidacionCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.LblValidacionCP.Location = new System.Drawing.Point(548, 125);
            this.LblValidacionCP.Name = "LblValidacionCP";
            this.LblValidacionCP.Size = new System.Drawing.Size(255, 20);
            this.LblValidacionCP.TabIndex = 15;
            this.LblValidacionCP.Text = "Mensaje validación código postal";
            this.LblValidacionCP.Visible = false;
            // 
            // LblValidacionEmail
            // 
            this.LblValidacionEmail.AutoSize = true;
            this.LblValidacionEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.LblValidacionEmail.Location = new System.Drawing.Point(548, 153);
            this.LblValidacionEmail.Name = "LblValidacionEmail";
            this.LblValidacionEmail.Size = new System.Drawing.Size(202, 20);
            this.LblValidacionEmail.TabIndex = 16;
            this.LblValidacionEmail.Text = "Mensaje validación e-mail";
            this.LblValidacionEmail.Visible = false;
            // 
            // LblValidacionNIF
            // 
            this.LblValidacionNIF.AutoSize = true;
            this.LblValidacionNIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.LblValidacionNIF.Location = new System.Drawing.Point(548, 179);
            this.LblValidacionNIF.Name = "LblValidacionNIF";
            this.LblValidacionNIF.Size = new System.Drawing.Size(214, 20);
            this.LblValidacionNIF.TabIndex = 17;
            this.LblValidacionNIF.Text = "Mensaje validación NIF/NIE";
            this.LblValidacionNIF.Visible = false;
            // 
            // LblValidacionCCC
            // 
            this.LblValidacionCCC.AutoSize = true;
            this.LblValidacionCCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.LblValidacionCCC.Location = new System.Drawing.Point(548, 207);
            this.LblValidacionCCC.Name = "LblValidacionCCC";
            this.LblValidacionCCC.Size = new System.Drawing.Size(192, 20);
            this.LblValidacionCCC.TabIndex = 18;
            this.LblValidacionCCC.Text = "Mensaje validación CCC";
            this.LblValidacionCCC.Visible = false;
            // 
            // LblValidacionTarjeta
            // 
            this.LblValidacionTarjeta.AutoSize = true;
            this.LblValidacionTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.LblValidacionTarjeta.Location = new System.Drawing.Point(548, 231);
            this.LblValidacionTarjeta.Name = "LblValidacionTarjeta";
            this.LblValidacionTarjeta.Size = new System.Drawing.Size(282, 20);
            this.LblValidacionTarjeta.TabIndex = 19;
            this.LblValidacionTarjeta.Text = "Mensaje validación tarjeta de crédito";
            this.LblValidacionTarjeta.Visible = false;
            // 
            // FrmValidaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::ExpresionesRegulares.Properties.Resources.índice;
            this.ClientSize = new System.Drawing.Size(840, 282);
            this.Controls.Add(this.LblValidacionTarjeta);
            this.Controls.Add(this.LblValidacionCCC);
            this.Controls.Add(this.LblValidacionNIF);
            this.Controls.Add(this.LblValidacionEmail);
            this.Controls.Add(this.LblValidacionCP);
            this.Controls.Add(this.LblValidacionTelefono);
            this.Controls.Add(this.LblTarjeta);
            this.Controls.Add(this.LblCCC);
            this.Controls.Add(this.LblNIF);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblCP);
            this.Controls.Add(this.LblTelefono);
            this.Controls.Add(this.TxtNIF);
            this.Controls.Add(this.TxtCCC);
            this.Controls.Add(this.TxtTarjeta);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtCP);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.BtnValidar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.GrpOpciones);
            this.Name = "FrmValidaciones";
            this.Text = "Validaciones";
            this.GrpOpciones.ResumeLayout(false);
            this.GrpOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpOpciones;
        private System.Windows.Forms.CheckBox ChkValidar;
        private System.Windows.Forms.CheckBox ChkFoco;
        private System.Windows.Forms.CheckBox ChkEnter;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnValidar;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtCP;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtTarjeta;
        private System.Windows.Forms.TextBox TxtCCC;
        private System.Windows.Forms.TextBox TxtNIF;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.Label LblCP;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblNIF;
        private System.Windows.Forms.Label LblCCC;
        private System.Windows.Forms.Label LblTarjeta;
        private System.Windows.Forms.Label LblValidacionTelefono;
        private System.Windows.Forms.Label LblValidacionCP;
        private System.Windows.Forms.Label LblValidacionEmail;
        private System.Windows.Forms.Label LblValidacionNIF;
        private System.Windows.Forms.Label LblValidacionCCC;
        private System.Windows.Forms.Label LblValidacionTarjeta;
    }
}

