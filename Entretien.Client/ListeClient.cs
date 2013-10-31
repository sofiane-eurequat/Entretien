using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Reflection;
using Entretien.Client;
using  System.Windows.Forms;
namespace Entretien
{
    public partial class ListeClient : Form
    {
        public ListeClient()
        {
            InitializeComponent();


            var liste = new DataTable();


            //GridClients.DataSource = GetSearchResults(queryStr);
        }


        DataTable GetSearchResults(string queryStr)
        {


            sync();
            //
            // Make a new DataTable.
        /*
            var path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            var tt=Path.Combine(path, "test.sdf");
            SqlCeConnection conn = new SqlCeConnection(@"Data Source=" +Path.Combine(path, "dbe.sdf"));
             
                conn.Open();
                   
                SqlCeDataAdapter adp = new SqlCeDataAdapter("select Nom,Prenom,Code from Client ",conn);
            */
               /* DataTable ds = new DataTable();
                adp.Fill(ds);
            */
           
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
                return null;
        }

        void sync(){
            Cursor.Current = Cursors.WaitCursor;
            Entretien.Client.WebReference.EntretienSyncService svcProxy = new Entretien.Client.WebReference.EntretienSyncService();
            Microsoft.Synchronization.Data.ServerSyncProviderProxy syncProxy =
                new Microsoft.Synchronization.Data.ServerSyncProviderProxy(svcProxy);





            // Call SyncAgent.Synchronize() to initiate the synchronization process.
            // Synchronization only updates the local database, not your project's data source.
            EntretienSyncAgent syncAgent = new EntretienSyncAgent();
            syncAgent.RemoteProvider = syncProxy;


            Microsoft.Synchronization.Data.SyncStatistics syncStats = syncAgent.Synchronize();

            // TODO: Reload your project data source from the local database (for example, call the TableAdapter.Fill method).



            clientTableAdapter.Fill(entretienlDataSet.Client);

            // Show synchronization statistics
            MessageBox.Show("Changes downloaded: " + syncStats.TotalChangesDownloaded.ToString()
                + "\r\nChanges Uploaded: " + syncStats.TotalChangesUploaded.ToString());

            Cursor.Current = Cursors.Default;
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
if (entretienlDataSetUtil.DesignerUtil.IsRunTime()) {
    // TODO: Delete this line of code to remove the default AutoFill for 'entretienlDataSet.Client'.
    this.clientTableAdapter.Fill(this.entretienlDataSet.Client);
}
            // TODO: This line of code loads data into the 'dbeDataSet1.Client' table. You can move, or remove it, as needed.
            //this.clientTableAdapter.Fill(this.dbeDataSet1.Client);

        }

        private void GridClients_CurrentCellChanged(object sender, EventArgs e)
        {

        }

        private void newMenuItemMenuItem_Click(object sender, EventArgs e)
        {
            clientBindingSource1.AddNew();
            Entretien.Client.ClientEditViewDialog clientEditViewDialog = Entretien.Client.ClientEditViewDialog.Instance(this.clientBindingSource1);
            clientEditViewDialog.ShowDialog();
        
        }

        private void clientDataGrid_Click(object sender, EventArgs e)
        {
            Entretien.Client.ClientSummaryViewDialog clientSummaryViewDialog = Entretien.Client.ClientSummaryViewDialog.Instance(this.clientBindingSource1);
            clientSummaryViewDialog.ShowDialog();



            Entretien.Client.ClientSummaryViewDialog customersSummaryViewDialog = Entretien.Client.ClientSummaryViewDialog.Instance(this.clientBindingSource);
            customersSummaryViewDialog.ShowDialog();
            // Update the database with changes made to the dataset
            clientTableAdapter.Update(entretienlDataSet.Client);
        }

        
    }
}