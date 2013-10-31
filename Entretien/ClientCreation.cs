using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Entretien
{
    public partial class ClientCreation : Form
    {
        public ClientCreation()
        {
            InitializeComponent();
        }

        private void buttonCreer_Click(object sender, EventArgs e)
        {
            var listeClient = new ListeClient();
            listeClient.ShowDialog();
            this.Close();
        }
    }
}