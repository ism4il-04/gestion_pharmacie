using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPharmacie
{
    public partial class Landing : Form
    {
        public Landing()
        {
            InitializeComponent();

            // Add gradient background rendering here (SAFE)
            this.Paint += Landing_Paint;
        }

        private void Landing_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                       this.ClientRectangle,
                       ColorTranslator.FromHtml("#1FA2FF"),
                       ColorTranslator.FromHtml("#A6FFCB"),
                       45f))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void bienvenue2_Click(object sender, EventArgs e)
        {

        }

        private void bienvenue_Click(object sender, EventArgs e)
        {

        }
    }
}
