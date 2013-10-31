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
    public partial class ClientSummaryViewDialog : Form
    {
        public ClientSummaryViewDialog()
        {
            InitializeComponent();
            // Attach event handlers to auto-hide controls.
            this.AttachVisibilityBindings(this.Controls);
        }

        private void editMenuItemMenuItem_Click(object sender, EventArgs e)
        {
            Entretien.Client.ClientEditViewDialog clientEditViewDialog = Entretien.Client.ClientEditViewDialog.Instance(this.clientBindingSource);
            clientEditViewDialog.ShowDialog();
            this.Close();

        }

        private void ClientSummaryViewDialog_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == System.Windows.Forms.Keys.Up))
            {
                this.AutoScrollPosition = new System.Drawing.Point(0, ((0 - this.AutoScrollPosition.Y)
                                - 16));
                e.Handled = true;
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Down))
            {
                this.AutoScrollPosition = new System.Drawing.Point(0, ((0 - this.AutoScrollPosition.Y)
                                + 16));
                e.Handled = true;
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Up))
            {
                // Up
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Down))
            {
                // Down
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Left))
            {
                // Left
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Right))
            {
                // Right
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Enter))
            {
                // Enter
            }

        }
    }
}