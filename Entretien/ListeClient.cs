using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.IO;
using System.Reflection;
namespace Entretien
{
    public partial class ListeClient : Form
    {
        public ListeClient()
        {
            InitializeComponent();


            var liste = new DataTable();


            var queryStr = "";
            GridClients.DataSource = GetSearchResults(queryStr);
        }


        DataTable GetSearchResults(string queryStr)
        {
            //
            // Make a new DataTable.
        
            var path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            var tt=Path.Combine(path, "test.sdf");
            SqlCeConnection conn = new SqlCeConnection(@"Data Source=" +Path.Combine(path, "dbe.sdf"));
             
                conn.Open();
                   
                SqlCeDataAdapter adp = new SqlCeDataAdapter("select Nom,Prenom,Code from Client ",conn);

                DataTable ds = new DataTable();
                adp.Fill(ds);
            
           
                /*SqlCommand cmd = new SqlCommand("SELECT Nom, Prenom FROM Client", connd);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;*/
            
           
                //
            // You will want to declare a new DataAdapter,
            // and then call its fill method on the DataTable.
            //
                return ds;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            var ClientCreation = new ClientCreation();
            ClientCreation.ShowDialog();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var listesCommandes = new ListesCommandes();
            listesCommandes.ShowDialog();
            this.Close();
        }

        private void ListeClient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbeDataSet1.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.dbeDataSet1.Client);

        }
    }
}