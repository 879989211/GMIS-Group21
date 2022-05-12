using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;


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
    
    public static List<Student> LoadAll()
    {
        List<Student> m = new List<Student>();

        MySqlConnection conn = GetConnection();
        MySqlDataReader rdr = null;

        try
        {
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("select * from Student", conn);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                //Note that in your assignment you will need to inspect the *type* of the
                //employee/researcher before deciding which kind of concrete class to create.
                m.Add(new Student { student_id = rdr.GetInt32(0), group_id = rdr.GetString(1) + " " + rdr.GetString(2) });
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

    
    public static List<Class> LoadAll()
    {
        List<Class> m = new List<Class>();

        MySqlConnection conn = GetConnection();
        MySqlDataReader rdr = null;

        try
        {
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("select * from Class", conn);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                //Note that in your assignment you will need to inspect the *type* of the
                //employee/researcher before deciding which kind of concrete class to create.
                m.Add(new Class { class_id = rdr.GetInt32(0), group_id = rdr.GetString(1) + " " + rdr.GetString(2) });
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




      


   
