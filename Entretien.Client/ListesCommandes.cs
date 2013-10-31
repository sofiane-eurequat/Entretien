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
    public partial class ListesCommandes : Form
    {
        public ListesCommandes()
        {
            InitializeComponent();
        }

        private void CreationComButton_Click(object sender, EventArgs e)
        {
            var commandesCreation = new CommandesCreation();
            commandesCreation.ShowDialog();
            this.Close();
        }

        private void VoirClientsButton_Click(object sender, EventArgs e)
        {
            var listeClient = new ListeClient();
            listeClient.ShowDialog();
            this.Close();
        }
    }
}