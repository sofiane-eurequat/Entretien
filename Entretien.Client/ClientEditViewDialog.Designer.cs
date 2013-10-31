namespace Entretien.Client
{
    partial class ClientEditViewDialog
    {
        public static ClientEditViewDialog Instance(System.Windows.Forms.BindingSource bindingSource)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            if ((defaultInstance == null))
            {
                defaultInstance = new Entretien.Client.ClientEditViewDialog();
                defaultInstance.clientBindingSource.DataSource = bindingSource;
            }
            defaultInstance.oidTextBox.Focus();
            defaultInstance.AutoScrollPosition = new System.Drawing.Point(0, 0);
            defaultInstance.clientBindingSource.Position = bindingSource.Position;
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
            return defaultInstance;
        }
    
        private static ClientEditViewDialog defaultInstance;
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
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oidTextBox = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.preNomTextBox = new System.Windows.Forms.TextBox();
            this.dateInscriptionTextBox = new System.Windows.Forms.TextBox();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.commandeTextBox = new System.Windows.Forms.TextBox();
            this.optimisticLockFieldTextBox = new System.Windows.Forms.TextBox();
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
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = typeof(Entretien.Client.entretienlDataSet);
            // 
            // oidLabel
            // 
            oidLabel.Dock = System.Windows.Forms.DockStyle.Top;
            oidLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            oidLabel.Location = new System.Drawing.Point(4, 4);
            oidLabel.Name = "oidLabel";
            oidLabel.Size = new System.Drawing.Size(31, 21);
            oidLabel.Text = "Oid:";
            // 
            // oidTextBox
            // 
            this.oidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Oid", true));
            this.oidTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.oidTextBox.Location = new System.Drawing.Point(4, 18);
            this.oidTextBox.Name = "oidTextBox";
            this.oidTextBox.Size = new System.Drawing.Size(100, 21);
            this.oidTextBox.TabIndex = 1;
            // 
            // nomLabel
            // 
            nomLabel.Dock = System.Windows.Forms.DockStyle.Top;
            nomLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            nomLabel.Location = new System.Drawing.Point(4, 50);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(38, 21);
            nomLabel.Text = "Nom:";
            // 
            // nomTextBox
            // 
            this.nomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Nom", true));
            this.nomTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.nomTextBox.Location = new System.Drawing.Point(4, 64);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(100, 21);
            this.nomTextBox.TabIndex = 3;
            // 
            // preNomLabel
            // 
            preNomLabel.Dock = System.Windows.Forms.DockStyle.Top;
            preNomLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            preNomLabel.Location = new System.Drawing.Point(4, 96);
            preNomLabel.Name = "preNomLabel";
            preNomLabel.Size = new System.Drawing.Size(62, 21);
            preNomLabel.Text = "Pre Nom:";
            // 
            // preNomTextBox
            // 
            this.preNomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "PreNom", true));
            this.preNomTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.preNomTextBox.Location = new System.Drawing.Point(4, 110);
            this.preNomTextBox.Name = "preNomTextBox";
            this.preNomTextBox.Size = new System.Drawing.Size(100, 21);
            this.preNomTextBox.TabIndex = 5;
            // 
            // dateInscriptionLabel
            // 
            dateInscriptionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            dateInscriptionLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            dateInscriptionLabel.Location = new System.Drawing.Point(4, 142);
            dateInscriptionLabel.Name = "dateInscriptionLabel";
            dateInscriptionLabel.Size = new System.Drawing.Size(110, 21);
            dateInscriptionLabel.Text = "Date Inscription:";
            // 
            // dateInscriptionTextBox
            // 
            this.dateInscriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "DateInscription", true));
            this.dateInscriptionTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateInscriptionTextBox.Location = new System.Drawing.Point(4, 156);
            this.dateInscriptionTextBox.Name = "dateInscriptionTextBox";
            this.dateInscriptionTextBox.Size = new System.Drawing.Size(100, 21);
            this.dateInscriptionTextBox.TabIndex = 7;
            // 
            // codeLabel
            // 
            codeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            codeLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            codeLabel.Location = new System.Drawing.Point(4, 188);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(42, 21);
            codeLabel.Text = "Code:";
            // 
            // codeTextBox
            // 
            this.codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Code", true));
            this.codeTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.codeTextBox.Location = new System.Drawing.Point(4, 202);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(100, 21);
            this.codeTextBox.TabIndex = 9;
            // 
            // commandeLabel
            // 
            commandeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            commandeLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            commandeLabel.Location = new System.Drawing.Point(4, 234);
            commandeLabel.Name = "commandeLabel";
            commandeLabel.Size = new System.Drawing.Size(79, 21);
            commandeLabel.Text = "Commande:";
            // 
            // commandeTextBox
            // 
            this.commandeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Commande", true));
            this.commandeTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.commandeTextBox.Location = new System.Drawing.Point(4, 248);
            this.commandeTextBox.Name = "commandeTextBox";
            this.commandeTextBox.Size = new System.Drawing.Size(100, 21);
            this.commandeTextBox.TabIndex = 11;
            // 
            // optimisticLockFieldLabel
            // 
            optimisticLockFieldLabel.Dock = System.Windows.Forms.DockStyle.Top;
            optimisticLockFieldLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            optimisticLockFieldLabel.Location = new System.Drawing.Point(4, 280);
            optimisticLockFieldLabel.Name = "optimisticLockFieldLabel";
            optimisticLockFieldLabel.Size = new System.Drawing.Size(135, 21);
            optimisticLockFieldLabel.Text = "Optimistic Lock Field:";
            // 
            // optimisticLockFieldTextBox
            // 
            this.optimisticLockFieldTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "OptimisticLockField", true));
            this.optimisticLockFieldTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.optimisticLockFieldTextBox.Location = new System.Drawing.Point(4, 294);
            this.optimisticLockFieldTextBox.Name = "optimisticLockFieldTextBox";
            this.optimisticLockFieldTextBox.Size = new System.Drawing.Size(100, 21);
            this.optimisticLockFieldTextBox.TabIndex = 13;
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
            // ClientEditViewDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.optimisticLockFieldTextBox);
            this.Controls.Add(optimisticLockFieldLabel);
            this.Controls.Add(this.commandeTextBox);
            this.Controls.Add(commandeLabel);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(codeLabel);
            this.Controls.Add(this.dateInscriptionTextBox);
            this.Controls.Add(dateInscriptionLabel);
            this.Controls.Add(this.preNomTextBox);
            this.Controls.Add(preNomLabel);
            this.Controls.Add(this.nomTextBox);
            this.Controls.Add(nomLabel);
            this.Controls.Add(this.oidTextBox);
            this.Controls.Add(oidLabel);
            this.Controls.Add(this.topBorderPanel);
            this.Controls.Add(this.leftBorderPanel);
            this.Controls.Add(this.rightBorderPanel);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "ClientEditViewDialog";
            this.Text = "ClientEditViewDialog";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.ClientEditViewDialog_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.TextBox oidTextBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.TextBox preNomTextBox;
        private System.Windows.Forms.TextBox dateInscriptionTextBox;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.TextBox commandeTextBox;
        private System.Windows.Forms.TextBox optimisticLockFieldTextBox;
        private System.Windows.Forms.Panel topBorderPanel;
        private System.Windows.Forms.Panel leftBorderPanel;
        private System.Windows.Forms.Panel rightBorderPanel;
    }
}