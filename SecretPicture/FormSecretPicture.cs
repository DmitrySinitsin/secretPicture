using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecretPicture
{
    public partial class FormSecretPicture : Form
    {
        int secret_nr = 0;

        public FormSecretPicture()
        {
            InitializeComponent();
        }

        private void buttonShow1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources._041radiorubka;
            secret_nr = 0;
        }

        private void button_Shtab_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources._021shtab;
            secret_nr = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources._026shturman;
            secret_nr = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (secret_nr == 2)
                this.BackgroundImage = Properties.Resources.secret;
            else
                this.BackgroundImage = Properties.Resources._030kambuz;
            secret_nr = 0;
        }

        private void FormSecretPicture_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                //this.BackgroundImage = Properties.Resources.secret;
                secret_nr = 1;
            }
        }

        private void FormSecretPicture_MouseMove(object sender, MouseEventArgs e)
        {
            if (secret_nr == 1)

            if (e.X < buttonShow1.Location.X &&
                e.Y < buttonShow1.Location.Y)
            {
                    secret_nr = 2;
            }
        }
    }
}
