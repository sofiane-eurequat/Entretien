namespace Entretien
{
    partial class ClientCreation
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
            this.buttonCreer = new System.Windows.Forms.Button();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelOrdre = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonCreer
            // 
            this.buttonCreer.Location = new System.Drawing.Point(86, 209);
            this.buttonCreer.Name = "buttonCreer";
            this.buttonCreer.Size = new System.Drawing.Size(128, 20);
            this.buttonCreer.TabIndex = 0;
            this.buttonCreer.Text = "Création";
            this.buttonCreer.Click += new System.EventHandler(this.buttonCreer_Click);
            // 
            // labelNom
            // 
            this.labelNom.Location = new System.Drawing.Point(16, 45);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(87, 20);
            this.labelNom.Text = "Nom";
            // 
            // labelPrenom
            // 
            this.labelPrenom.Location = new System.Drawing.Point(16, 73);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(87, 20);
            this.labelPrenom.Text = "Prenom";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(86, 44);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(128, 21);
            this.textBoxNom.TabIndex = 3;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(86, 72);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(128, 21);
            this.textBoxPrenom.TabIndex = 4;
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.Silver;
            this.label.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label.Location = new System.Drawing.Point(0, 11);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(240, 20);
            this.label.Text = "Veiullez créer un client";
            // 
            // labelDate
            // 
            this.labelDate.Location = new System.Drawing.Point(16, 97);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(100, 20);
            this.labelDate.Text = "Date";
            // 
            // labelOrdre
            // 
            this.labelOrdre.Location = new System.Drawing.Point(16, 128);
            this.labelOrdre.Name = "labelOrdre";
            this.labelOrdre.Size = new System.Drawing.Size(71, 20);
            this.labelOrdre.Text = "Commande";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(86, 99);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(128, 22);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(86, 128);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(128, 22);
            this.comboBox1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelOrdre);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.buttonCreer);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCreer;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelOrdre;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

