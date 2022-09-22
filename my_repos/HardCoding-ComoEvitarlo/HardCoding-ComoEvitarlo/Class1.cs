using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HardCoding_ComoEvitarlo
{
    internal class Class1
    {
        SqlConnection con;
        public void Metodo()
        {



            // Avoid:  Avoid hard cording connection related strings in the code files (C# or VB).
            con = new SqlConnection("Data Source=ServerName;Initial Catalog=Northwind;" +
                "User ID = userName; Password = password; providerName = "System.Data.SqlClient");
                );



            // Do:  Application connection strings must read from the configuration files.
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthwindConnectionString"].ConnectionString);

            < configuration >
                < connectionStrings >
                  < add name = "NorthwindConnectionString"
                   providerName = "System.Data.SqlClient"
                   connectionString = "Data Source=ServerName;Initial Catalog=Northwind;User ID=userName;Password=password" />
                </ connectionStrings >
            </ configuration >

            /* Connection strings are going to be vary for each environment, so it 
             * would be a best practice to always read the application connection 
             * strings from Configuration files.It gives us the flexibility to modify 
             * the strings directly without building / re - deploying the whole application.
            */




        }
    }
}