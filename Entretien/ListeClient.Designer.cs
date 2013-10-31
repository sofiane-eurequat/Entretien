namespace Entretien
{
    partial class ListeClient
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
            this.components = new System.ComponentModel.Container();
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GridClients = new System.Windows.Forms.DataGrid();
            this.label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            //this.dbeDataSet = new Entretien.dbeDataSet();
            this.dbeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.dbeDataSet1 = new Entretien.dbeDataSet1();
            //this.clientTableAdapter = new Entretien.dbeDataSet1TableAdapters.ClientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.dbeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbeDataSetBindingSource)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.dbeDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            //this.clientBindingSource.DataSource = this.dbeDataSet1;
            // 
            // GridClients
            // 
            this.GridClients.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.GridClients.DataSource = this.clientBindingSource;
            this.GridClients.Location = new System.Drawing.Point(0, 68);
            this.GridClients.Name = "GridClients";
            this.GridClients.Size = new System.Drawing.Size(237, 200);
            this.GridClients.TabIndex = 0;
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.Silver;
            this.label.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label.Location = new System.Drawing.Point(-3, 10);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(240, 20);
            this.label.Text = "Listes des clients";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 20);
            this.button1.TabIndex = 2;
            this.button1.Text = "Voir commandes";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(122, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 20);
            this.button2.TabIndex = 3;
            this.button2.Text = "Créer Clients";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dbeDataSet
            // 
            this.dbeDataSet.DataSetName = "dbeDataSet";
            this.dbeDataSet.Prefix = "";
            this.dbeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbeDataSetBindingSource
            // 
            this.dbeDataSetBindingSource.DataSource = this.dbeDataSet;
            this.dbeDataSetBindingSource.Position = 0;
            // 
            // dbeDataSet1
            // 
            this.dbeDataSet1.DataSetName = "dbeDataSet1";
            this.dbeDataSet1.Prefix = "";
            this.dbeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // ListeClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.GridClients);
            this.Menu = this.mainMenu1;
            this.Name = "ListeClient";
            this.Text = "DataGrid";
            this.Load += new System.EventHandler(this.ListeClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbeDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGrid GridClients;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource dbeDataSetBindingSource;
        //private dbeDataSet dbeDataSet;
        //private dbeDataSet1 dbeDataSet1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        //private Entretien.dbeDataSet1TableAdapters.ClientTableAdapter clientTableAdapter;
    }
}