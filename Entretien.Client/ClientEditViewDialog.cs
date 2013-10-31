using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Entretien.Client
{
    public partial class ClientEditViewDialog : Form
    {
        public ClientEditViewDialog()
        {
            InitializeComponent();
        }

        private void ClientEditViewDialog_Closing(object sender, CancelEventArgs e)
        {
            this.clientBindingSource.EndEdit();

        }
    }
}