using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpresionesRegulares
{
    public partial class FrmValidaciones : Form
    {

        private bool Intro;
        private bool Foco;
        private bool Validar;
        private string Cadena;

        public FrmValidaciones()
        {
            InitializeComponent();
            Intro = false;
            Foco = false;
            Validar = false;
            Cadena = "";
        }

        private void ChkEnter_CheckedChanged_1(object sender, EventArgs e)
        {
            if (ChkEnter.Checked == true)
            {
                Intro = true;

                Foco = false;
                ChkFoco.Checked = false;

                Validar = false;
                ChkValidar.Checked = false;
            }
            else
                Intro = false;
        }

        private void ChkFoco_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkFoco.Checked == true)
            {
                Foco = true;

                Intro = false;
                ChkEnter.Checked = false;

                Validar = false;
                ChkValidar.Checked = false;
            }
            else
                Foco = false;
        }

        private void ChkValidar_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkValidar.Checked == true)
            {
                Validar = true;

                Intro = false;
                ChkEnter.Checked = false;

                Foco = false;
                ChkFoco.Checked = false;
            }
            else
                Validar = false;
        }

        private void BtnValidar_Click(object sender, EventArgs e)
        {
            if (Validar)
            {
                validacionTelefono();
                validacionCP();
                validacionEmail();
                validacionNIF();
                validacionCCC();
                validacionTarjeta();
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TextBox[] cajasDeTexto = { TxtTelefono, TxtCP, TxtEmail, TxtNIF, TxtCCC, TxtTarjeta };
            Label[] etiquetas = { LblValidacionTelefono, LblValidacionCP, LblValidacionEmail, LblValidacionNIF, LblValidacionCCC, LblValidacionTarjeta };

            for(int i = 0; i < cajasDeTexto.Length; i++)
            {
                cajasDeTexto[i].Clear();
                etiquetas[i].Visible = false;
            }

            ChkEnter.Checked = false;
            ChkFoco.Checked = false;
            ChkValidar.Checked = false;
            Intro = false;
            Foco = false;
            Validar = false;
        }

        private void Txt_Leave(object sender, EventArgs e)
        {
            TextBox cajaTexto = (TextBox)sender;

            switch (cajaTexto.Name)
            {
                case "TxtTelefono":
                    if (Foco)
                    {
                        validacionTelefono();
                    }
                    break;

                case "TxtCP":
                    if (Foco)
                    {
                        validacionCP();
                    }
                    break;

                case "TxtEmail":
                    if (Foco)
                    {
                        validacionEmail();
                    }
                    break;

                case "TxtNIF":
                    if (Foco)
                    {
                        validacionNIF();
                    }
                    break;

                case "TxtCCC":
                    if (Foco)
                    {
                        validacionCCC();
                    }
                    break;

                case "TxtTarjeta":
                    if (Foco)
                    {
                        validacionTarjeta();
                    }
                    break;
            }
        }

        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Intro)
            {
                TextBox cajaTexto = (TextBox)sender;

                switch (cajaTexto.Name)
                {
                    case "TxtTelefono":
                        if (e.KeyChar == Convert.ToChar(Keys.Enter))
                        {
                            validacionTelefono();
                        }
                        break;

                    case "TxtCP":
                        if (e.KeyChar == Convert.ToChar(Keys.Enter))
                        {
                            validacionCP();
                        }
                        break;

                    case "TxtEmail":
                        if (e.KeyChar == Convert.ToChar(Keys.Enter))
                        {
                            validacionEmail();
                        }
                        break;

                    case "TxtNIF":
                        if (e.KeyChar == Convert.ToChar(Keys.Enter))
                        {
                            validacionNIF();
                        }
                        break;

                    case "TxtCCC":
                        if (e.KeyChar == Convert.ToChar(Keys.Enter))
                        {
                            validacionCCC();
                        }
                        break;

                    case "TxtTarjeta":
                        if (e.KeyChar == Convert.ToChar(Keys.Enter))
                        {
                            validacionTarjeta();
                        }
                        break;
                }
            }
        }

        private void validacionTelefono()
        {
            if (TxtTelefono.Text != "")
            {
                bool validacionTelefono = Validaciones.ValidarTelefono(TxtTelefono.Text.ToUpper(), ref Cadena);

                if (validacionTelefono)
                    LblValidacionTelefono.ForeColor = Color.DarkCyan;
                else
                    LblValidacionTelefono.ForeColor = Color.OrangeRed;

                LblValidacionTelefono.Text = Cadena;
                LblValidacionTelefono.Visible = true;
            }
        }

        private void validacionCP()
        {
            if (TxtCP.Text != "")
            {
                bool validacionCP = Validaciones.ValidarCP(TxtCP.Text.ToUpper(), ref Cadena);

                if (validacionCP)
                    LblValidacionCP.ForeColor = Color.DarkCyan;
                else
                    LblValidacionCP.ForeColor = Color.OrangeRed;

                LblValidacionCP.Text = Cadena;
                LblValidacionCP.Visible = true;
            }
        }

        private void validacionEmail()
        {
            if (TxtEmail.Text != "")
            {
                bool validacionEmail = Validaciones.ValidarEmail(TxtEmail.Text.ToUpper(), ref Cadena);

                if (validacionEmail)
                    LblValidacionEmail.ForeColor = Color.DarkCyan;
                else
                    LblValidacionEmail.ForeColor = Color.OrangeRed;

                LblValidacionEmail.Text = Cadena;
                LblValidacionEmail.Visible = true;
            }
        }

        private void validacionNIF()
        {
            if (TxtNIF.Text != "")
            {
                bool validacionNif = Validaciones.ValidarNIF(TxtNIF.Text.ToUpper(), ref Cadena);

                if (validacionNif)
                    LblValidacionNIF.ForeColor = Color.DarkCyan;
                else
                    LblValidacionNIF.ForeColor = Color.OrangeRed;

                LblValidacionNIF.Text = Cadena;
                LblValidacionNIF.Visible = true;
            }
        }

        private void validacionCCC()
        {
            if (TxtCCC.Text != "")
            {
                bool validacionCCC = Validaciones.ValidarCCC(TxtCCC.Text.ToUpper(), ref Cadena);

                if (validacionCCC)
                    LblValidacionCCC.ForeColor = Color.DarkCyan;
                else
                    LblValidacionCCC.ForeColor = Color.OrangeRed;

                LblValidacionCCC.Text = Cadena;
                LblValidacionCCC.Visible = true;
            }
        }

        private void validacionTarjeta()
        {
            if (TxtTarjeta.Text != "")
            {
                bool validacionTarjeta = Validaciones.ValidarTarjeta(TxtTarjeta.Text.ToUpper(), ref Cadena);

                if (validacionTarjeta)
                    LblValidacionTarjeta.ForeColor = Color.DarkCyan;
                else
                    LblValidacionTarjeta.ForeColor = Color.OrangeRed;

                LblValidacionTarjeta.Text = Cadena;
                LblValidacionTarjeta.Visible = true;
            }
        }
    }
}
