namespace Entretien.Client
{
    partial class ClientSummaryViewDialog
    {
        public void AttachVisibilityBindings(ControlCollection controls)
        {
            for (int i = 0; (i < controls.Count); i = (i + 1))
            {
                if ((controls[i].DataBindings["Visible"] != null))
                {
                    // Attach event handlers to auto-hide controls.
                    controls[i].DataBindings["Visible"].Format += new System.Windows.Forms.ConvertEventHandler(this.Visibility_Format);
                    controls[i].DataBindings["Visible"].DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
                }
            }

        }
    
        public void Visibility_Format(object sender, System.Windows.Forms.ConvertEventArgs e)
        {
            if ((e.Value == System.DBNull.Value))
            {
                e.Value = false;
            }
            else
            {
                e.Value = true;
            }

        }
    
        public static ClientSummaryViewDialog Instance(System.Windows.Forms.BindingSource bindingSource)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            if ((defaultInstance == null))
            {
                defaultInstance = new Entretien.Client.ClientSummaryViewDialog();
                defaultInstance.clientBindingSource.DataSource = bindingSource;
            }
            defaultInstance.AutoScrollPosition = new System.Drawing.Point(0, 0);
            defaultInstance.clientBindingSource.Position = bindingSource.Position;
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
            return defaultInstance;
        }
    
        private static ClientSummaryViewDialog defaultInstance;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label oidLabel;
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label preNomLabel;
            System.Windows.Forms.Label dateInscriptionLabel;
            System.Windows.Forms.Label codeLabel;
            System.Windows.Forms.Label commandeLabel;
            System.Windows.Forms.Label optimisticLockFieldLabel;
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.editMenuItemMenuItem = new System.Windows.Forms.MenuItem();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oidLabel1 = new System.Windows.Forms.Label();
            this.nomLabel1 = new System.Windows.Forms.Label();
            this.preNomLabel1 = new System.Windows.Forms.Label();
            this.dateInscriptionLabel1 = new System.Windows.Forms.Label();
            this.codeLabel1 = new System.Windows.Forms.Label();
            this.commandeLabel1 = new System.Windows.Forms.Label();
            this.optimisticLockFieldLabel1 = new System.Windows.Forms.Label();
            this.topBorderPanel = new System.Windows.Forms.Panel();
            this.leftBorderPanel = new System.Windows.Forms.Panel();
            this.rightBorderPanel = new System.Windows.Forms.Panel();
            oidLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            preNomLabel = new System.Windows.Forms.Label();
            dateInscriptionLabel = new System.Windows.Forms.Label();
            codeLabel = new System.Windows.Forms.Label();
            commandeLabel = new System.Windows.Forms.Label();
            optimisticLockFieldLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.editMenuItemMenuItem);
            // 
            // editMenuItemMenuItem
            // 
            this.editMenuItemMenuItem.Text = "Edit";
            this.editMenuItemMenuItem.Click += new System.EventHandler(this.editMenuItemMenuItem_Click);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = typeof(Entretien.Client.entretienlDataSet);
            // 
            // oidLabel
            // 
            oidLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.clientBindingSource, "Oid", true));
            oidLabel.Dock = System.Windows.Forms.DockStyle.Top;
            oidLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            oidLabel.Location = new System.Drawing.Point(4, 4);
            oidLabel.Name = "oidLabel";
            oidLabel.Size = new System.Drawing.Size(31, 21);
            oidLabel.Text = "Oid:";
            // 
            // oidLabel1
            // 
            this.oidLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Oid", true));
            this.oidLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.clientBindingSource, "Oid", true));
            this.oidLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.oidLabel1.Location = new System.Drawing.Point(4, 18);
            this.oidLabel1.Name = "oidLabel1";
            this.oidLabel1.Size = new System.Drawing.Size(100, 20);
            // 
            // nomLabel
            // 
            nomLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.clientBindingSource, "Nom", true));
            nomLabel.Dock = System.Windows.Forms.DockStyle.Top;
            nomLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            nomLabel.Location = new System.Drawing.Point(4, 49);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(38, 21);
            nomLabel.Text = "Nom:";
            // 
            // nomLabel1
            // 
            this.nomLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Nom", true));
            this.nomLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.clientBindingSource, "Nom", true));
            this.nomLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.nomLabel1.Location = new System.Drawing.Point(4, 63);
            this.nomLabel1.Name = "nomLabel1";
            this.nomLabel1.Size = new System.Drawing.Size(100, 20);
            // 
            // preNomLabel
            // 
            preNomLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.clientBindingSource, "PreNom", true));
            preNomLabel.Dock = System.Windows.Forms.DockStyle.Top;
            preNomLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            preNomLabel.Location = new System.Drawing.Point(4, 94);
            preNomLabel.Name = "preNomLabel";
            preNomLabel.Size = new System.Drawing.Size(62, 21);
            preNomLabel.Text = "Pre Nom:";
            // 
            // preNomLabel1
            // 
            this.preNomLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "PreNom", true));
            this.preNomLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.clientBindingSource, "PreNom", true));
            this.preNomLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.preNomLabel1.Location = new System.Drawing.Point(4, 108);
            this.preNomLabel1.Name = "preNomLabel1";
            this.preNomLabel1.Size = new System.Drawing.Size(100, 20);
            // 
            // dateInscriptionLabel
            // 
            dateInscriptionLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.clientBindingSource, "DateInscription", true));
            dateInscriptionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            dateInscriptionLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            dateInscriptionLabel.Location = new System.Drawing.Point(4, 139);
            dateInscriptionLabel.Name = "dateInscriptionLabel";
            dateInscriptionLabel.Size = new System.Drawing.Size(110, 21);
            dateInscriptionLabel.Text = "Date Inscription:";
            // 
            // dateInscriptionLabel1
            // 
            this.dateInscriptionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "DateInscription", true));
            this.dateInscriptionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.clientBindingSource, "DateInscription", true));
            this.dateInscriptionLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateInscriptionLabel1.Location = new System.Drawing.Point(4, 153);
            this.dateInscriptionLabel1.Name = "dateInscriptionLabel1";
            this.dateInscriptionLabel1.Size = new System.Drawing.Size(100, 20);
            // 
            // codeLabel
            // 
            codeLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.clientBindingSource, "Code", true));
            codeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            codeLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            codeLabel.Location = new System.Drawing.Point(4, 184);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(42, 21);
            codeLabel.Text = "Code:";
            // 
            // codeLabel1
            // 
            this.codeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Code", true));
            this.codeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.clientBindingSource, "Code", true));
            this.codeLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.codeLabel1.Location = new System.Drawing.Point(4, 198);
            this.codeLabel1.Name = "codeLabel1";
            this.codeLabel1.Size = new System.Drawing.Size(100, 20);
            // 
            // commandeLabel
            // 
            commandeLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.clientBindingSource, "Commande", true));
            commandeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            commandeLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            commandeLabel.Location = new System.Drawing.Point(4, 229);
            commandeLabel.Name = "commandeLabel";
            commandeLabel.Size = new System.Drawing.Size(79, 21);
            commandeLabel.Text = "Commande:";
            // 
            // commandeLabel1
            // 
            this.commandeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Commande", true));
            this.commandeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.clientBindingSource, "Commande", true));
            this.commandeLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.commandeLabel1.Location = new System.Drawing.Point(4, 243);
            this.commandeLabel1.Name = "commandeLabel1";
            this.commandeLabel1.Size = new System.Drawing.Size(100, 20);
            // 
            // optimisticLockFieldLabel
            // 
            optimisticLockFieldLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.clientBindingSource, "OptimisticLockField", true));
            optimisticLockFieldLabel.Dock = System.Windows.Forms.DockStyle.Top;
            optimisticLockFieldLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            optimisticLockFieldLabel.Location = new System.Drawing.Point(4, 274);
            optimisticLockFieldLabel.Name = "optimisticLockFieldLabel";
            optimisticLockFieldLabel.Size = new System.Drawing.Size(135, 21);
            optimisticLockFieldLabel.Text = "Optimistic Lock Field:";
            // 
            // optimisticLockFieldLabel1
            // 
            this.optimisticLockFieldLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "OptimisticLockField", true));
            this.optimisticLockFieldLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.clientBindingSource, "OptimisticLockField", true));
            this.optimisticLockFieldLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.optimisticLockFieldLabel1.Location = new System.Drawing.Point(4, 288);
            this.optimisticLockFieldLabel1.Name = "optimisticLockFieldLabel1";
            this.optimisticLockFieldLabel1.Size = new System.Drawing.Size(100, 20);
            // 
            // topBorderPanel
            // 
            this.topBorderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBorderPanel.Location = new System.Drawing.Point(0, 0);
            this.topBorderPanel.Name = "topBorderPanel";
            this.topBorderPanel.Size = new System.Drawing.Size(100, 2);
            // 
            // leftBorderPanel
            // 
            this.leftBorderPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftBorderPanel.Location = new System.Drawing.Point(0, 0);
            this.leftBorderPanel.Name = "leftBorderPanel";
            this.leftBorderPanel.Size = new System.Drawing.Size(4, 100);
            // 
            // rightBorderPanel
            // 
            this.rightBorderPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightBorderPanel.Location = new System.Drawing.Point(0, 0);
            this.rightBorderPanel.Name = "rightBorderPanel";
            this.rightBorderPanel.Size = new System.Drawing.Size(4, 100);
            // 
            // ClientSummaryViewDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.optimisticLockFieldLabel1);
            this.Controls.Add(optimisticLockFieldLabel);
            this.Controls.Add(this.commandeLabel1);
            this.Controls.Add(commandeLabel);
            this.Controls.Add(this.codeLabel1);
            this.Controls.Add(codeLabel);
            this.Controls.Add(this.dateInscriptionLabel1);
            this.Controls.Add(dateInscriptionLabel);
            this.Controls.Add(this.preNomLabel1);
            this.Controls.Add(preNomLabel);
            this.Controls.Add(this.nomLabel1);
            this.Controls.Add(nomLabel);
            this.Controls.Add(this.oidLabel1);
            this.Controls.Add(oidLabel);
            this.Controls.Add(this.topBorderPanel);
            this.Controls.Add(this.leftBorderPanel);
            this.Controls.Add(this.rightBorderPanel);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "ClientSummaryViewDialog";
            this.Text = "ClientSummaryViewDialog";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClientSummaryViewDialog_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem editMenuItemMenuItem;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.Label oidLabel1;
        private System.Windows.Forms.Label nomLabel1;
        private System.Windows.Forms.Label preNomLabel1;
        private System.Windows.Forms.Label dateInscriptionLabel1;
        private System.Windows.Forms.Label codeLabel1;
        private System.Windows.Forms.Label commandeLabel1;
        private System.Windows.Forms.Label optimisticLockFieldLabel1;
        private System.Windows.Forms.Panel topBorderPanel;
        private System.Windows.Forms.Panel leftBorderPanel;
        private System.Windows.Forms.Panel rightBorderPanel;
    }
}