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
    public partial class CommandesCreation : Form
    {
        public CommandesCreation()
        {
            InitializeComponent();
        }

        private void CreationComandebutton1_Click(object sender, EventArgs e)
        {
            var listesCommandes = new ListesCommandes();
            listesCommandes.ShowDialog();
            this.Close();
        }
    }
}