namespace Entretien
{
    partial class CommandesCreation
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
            this.Numlabel = new System.Windows.Forms.Label();
            this.Nomlabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.CreationComandebutton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(4, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 20);
            this.label1.Text = "Création commande";
            // 
            // Numlabel
            // 
            this.Numlabel.Location = new System.Drawing.Point(3, 80);
            this.Numlabel.Name = "Numlabel";
            this.Numlabel.Size = new System.Drawing.Size(100, 20);
            this.Numlabel.Text = "Num Commande";
            // 
            // Nomlabel
            // 
            this.Nomlabel.Location = new System.Drawing.Point(4, 132);
            this.Nomlabel.Name = "Nomlabel";
            this.Nomlabel.Size = new System.Drawing.Size(100, 20);
            this.Nomlabel.Text = "Nom Commande";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 21);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(111, 131);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(126, 21);
            this.textBox2.TabIndex = 4;
            // 
            // CreationComandebutton1
            // 
            this.CreationComandebutton1.Location = new System.Drawing.Point(137, 190);
            this.CreationComandebutton1.Name = "CreationComandebutton1";
            this.CreationComandebutton1.Size = new System.Drawing.Size(100, 20);
            this.CreationComandebutton1.TabIndex = 5;
            this.CreationComandebutton1.Text = "Création";
            this.CreationComandebutton1.Click += new System.EventHandler(this.CreationComandebutton1_Click);
            // 
            // CommandesCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.CreationComandebutton1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Nomlabel);
            this.Controls.Add(this.Numlabel);
            this.Controls.Add(this.label1);
            this.Menu = this.mainMenu1;
            this.Name = "CommandesCreation";
            this.Text = "CommandesCreation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Numlabel;
        private System.Windows.Forms.Label Nomlabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button CreationComandebutton1;
    }
}