using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.Data;

namespace Entretien
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            /*
            var path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            SqlCeConnection clientConn = new SqlCeConnection(@"Data Source=" + Path.Combine(path, "dbe.sdf"));


            SqlConnection serverConn = new SqlConnection(@"data source=REX-PC\Entretien;initial catalog=entretienl;Integrated Security=SSPI;");
            var scopeDesc = SqlSyncDescriptionBuilder.GetDescriptionForScope("ClientsScope", serverConn);
            // create CE provisioning object based on the ProductsScope
            SqlCeSyncScopeProvisioning clientProvision = new SqlCeSyncScopeProvisioning( scopeDesc);

            // starts the provisioning process
            clientProvision.Apply(clientConn);
            */

            

            Application.Run(new ListeClient());
        }
    }
}