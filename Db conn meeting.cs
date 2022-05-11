using MySql.Data.MySqlClient;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMIS
{
    public class Database
    {
        private static bool reportingErrors = false;
       
        private const string db = "gmis";
        private const string user = "gmis";
        private const string pass = "gmis";
        private const string server = "alacritas.cis.utas.edu.au";
        protected static MySqlConnection mySqlConnection = null;
        
    }


    public static List<Meeting> LoadAll()
    {
        List<Meeting> m = new List<Meeting>();

        MySqlConnection conn = GetConnection();
        MySqlDataReader rdr = null;

        try
        {
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("select * from Meeting", conn);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                //Note that in your assignment you will need to inspect the *type* of the
                //employee/researcher before deciding which kind of concrete class to create.
                m.Add(new Meeting { meeting_id = rdr.GetInt32(0), group_id = rdr.GetString(1) + " " + rdr.GetString(2) });
            }
        }
        catch (MySqlException e)
        {
            ReportError("loading staff", e);
        }
        finally
        {
            if (rdr != null)
            {
                rdr.Close();
            }
            if (conn != null)
            {
                conn.Close();
            }
        }

        return staff;
    }

}
