namespace Entretien
{
    partial class ListesCommandes
    {
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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.VoirClientsButton = new System.Windows.Forms.Button();
            this.CreationComButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(0, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 20);
            this.label1.Text = "label1";
            // 
            // dataGrid1
            // 
            this.dataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGrid1.Location = new System.Drawing.Point(0, 68);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(237, 200);
            this.dataGrid1.TabIndex = 1;
            // 
            // VoirClientsButton
            // 
            this.VoirClientsButton.Location = new System.Drawing.Point(0, 42);
            this.VoirClientsButton.Name = "VoirClientsButton";
            this.VoirClientsButton.Size = new System.Drawing.Size(86, 20);
            this.VoirClientsButton.TabIndex = 2;
            this.VoirClientsButton.Text = "Voir Clients";
            this.VoirClientsButton.Click += new System.EventHandler(this.VoirClientsButton_Click);
            // 
            // CreationComButton
            // 
            this.CreationComButton.Location = new System.Drawing.Point(92, 42);
            this.CreationComButton.Name = "CreationComButton";
            this.CreationComButton.Size = new System.Drawing.Size(148, 20);
            this.CreationComButton.TabIndex = 3;
            this.CreationComButton.Tag = "";
            this.CreationComButton.Text = "Création de commanes";
            this.CreationComButton.Click += new System.EventHandler(this.CreationComButton_Click);
            // 
            // ListesCommandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.CreationComButton);
            this.Controls.Add(this.VoirClientsButton);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.label1);
            this.Menu = this.mainMenu1;
            this.Name = "ListesCommandes";
            this.Text = "ListesCommandes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.Button VoirClientsButton;
        private System.Windows.Forms.Button CreationComButton;
    }
}