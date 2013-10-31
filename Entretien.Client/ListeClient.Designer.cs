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
            System.Windows.Forms.DataGridTextBoxColumn optimisticLockFieldDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn commandeDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn codeDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn dateInscriptionDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn preNomDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn nomDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn oidDataGridColumnStyleDataGridTextBoxColumn;
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.entretienlDataSet = new Entretien.Client.entretienlDataSet();
            this.clientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new Entretien.Client.entretienlDataSetTableAdapters.ClientTableAdapter();
            this.clientTableStyleDataGridTableStyle = new System.Windows.Forms.DataGridTableStyle();
            this.clientDataGrid = new System.Windows.Forms.DataGrid();
            this.newMenuItemMenuItem = new System.Windows.Forms.MenuItem();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            optimisticLockFieldDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            commandeDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            codeDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            dateInscriptionDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            preNomDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            nomDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            oidDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.entretienlDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbeDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.newMenuItemMenuItem);
            // 
            // entretienlDataSet
            // 
            this.entretienlDataSet.DataSetName = "entretienlDataSet";
            this.entretienlDataSet.Prefix = "";
            this.entretienlDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource1
            // 
            this.clientBindingSource1.DataMember = "Client";
            this.clientBindingSource1.DataSource = this.entretienlDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // clientTableStyleDataGridTableStyle
            // 
            this.clientTableStyleDataGridTableStyle.GridColumnStyles.Add(oidDataGridColumnStyleDataGridTextBoxColumn);
            this.clientTableStyleDataGridTableStyle.GridColumnStyles.Add(nomDataGridColumnStyleDataGridTextBoxColumn);
            this.clientTableStyleDataGridTableStyle.GridColumnStyles.Add(preNomDataGridColumnStyleDataGridTextBoxColumn);
            this.clientTableStyleDataGridTableStyle.GridColumnStyles.Add(dateInscriptionDataGridColumnStyleDataGridTextBoxColumn);
            this.clientTableStyleDataGridTableStyle.GridColumnStyles.Add(codeDataGridColumnStyleDataGridTextBoxColumn);
            this.clientTableStyleDataGridTableStyle.GridColumnStyles.Add(commandeDataGridColumnStyleDataGridTextBoxColumn);
            this.clientTableStyleDataGridTableStyle.GridColumnStyles.Add(optimisticLockFieldDataGridColumnStyleDataGridTextBoxColumn);
            this.clientTableStyleDataGridTableStyle.MappingName = "Client";
            // 
            // optimisticLockFieldDataGridColumnStyleDataGridTextBoxColumn
            // 
            optimisticLockFieldDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            optimisticLockFieldDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            optimisticLockFieldDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "OptimisticLockField";
            optimisticLockFieldDataGridColumnStyleDataGridTextBoxColumn.MappingName = "OptimisticLockField";
            // 
            // commandeDataGridColumnStyleDataGridTextBoxColumn
            // 
            commandeDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            commandeDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            commandeDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "Commande";
            commandeDataGridColumnStyleDataGridTextBoxColumn.MappingName = "Commande";
            // 
            // codeDataGridColumnStyleDataGridTextBoxColumn
            // 
            codeDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            codeDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            codeDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "Code";
            codeDataGridColumnStyleDataGridTextBoxColumn.MappingName = "Code";
            // 
            // dateInscriptionDataGridColumnStyleDataGridTextBoxColumn
            // 
            dateInscriptionDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            dateInscriptionDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            dateInscriptionDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "DateInscription";
            dateInscriptionDataGridColumnStyleDataGridTextBoxColumn.MappingName = "DateInscription";
            // 
            // preNomDataGridColumnStyleDataGridTextBoxColumn
            // 
            preNomDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            preNomDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            preNomDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "PreNom";
            preNomDataGridColumnStyleDataGridTextBoxColumn.MappingName = "PreNom";
            // 
            // nomDataGridColumnStyleDataGridTextBoxColumn
            // 
            nomDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            nomDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            nomDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "Nom";
            nomDataGridColumnStyleDataGridTextBoxColumn.MappingName = "Nom";
            // 
            // oidDataGridColumnStyleDataGridTextBoxColumn
            // 
            oidDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            oidDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            oidDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "Oid";
            oidDataGridColumnStyleDataGridTextBoxColumn.MappingName = "Oid";
            // 
            // clientDataGrid
            // 
            this.clientDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.clientDataGrid.DataSource = this.clientBindingSource1;
            this.clientDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientDataGrid.Location = new System.Drawing.Point(0, 0);
            this.clientDataGrid.Name = "clientDataGrid";
            this.clientDataGrid.Size = new System.Drawing.Size(240, 268);
            this.clientDataGrid.TabIndex = 4;
            this.clientDataGrid.TableStyles.Add(this.clientTableStyleDataGridTableStyle);
            //this.clientDataGrid.CurrentCellChanged += new System.EventHandler(this.clientDataGrid_CurrentCellChanged);
            this.clientDataGrid.Click += new System.EventHandler(this.clientDataGrid_Click);
            // 
            // newMenuItemMenuItem
            // 
            this.newMenuItemMenuItem.Text = "New";
            this.newMenuItemMenuItem.Click += new System.EventHandler(this.newMenuItemMenuItem_Click);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            // 
            // ListeClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.clientDataGrid);
            this.Menu = this.mainMenu1;
            this.Name = "ListeClient";
            this.Text = "DataGrid";
            this.Load += new System.EventHandler(this.ListeClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.entretienlDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbeDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource dbeDataSetBindingSource;
        //private dbeDataSet dbeDataSet;
        //private dbeDataSet1 dbeDataSet1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private Entretien.Client.entretienlDataSet entretienlDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource1;
        private Entretien.Client.entretienlDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.DataGridTableStyle clientTableStyleDataGridTableStyle;
        private System.Windows.Forms.DataGrid clientDataGrid;
        private System.Windows.Forms.MenuItem newMenuItemMenuItem;
        //private Entretien.dbeDataSet1TableAdapters.ClientTableAdapter clientTableAdapter;
    }
}