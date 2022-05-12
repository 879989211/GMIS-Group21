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

        public void InsertStudent()
        {
            sql = "INSERT INTO Student(student_id,given_name,family_name,group_id,title,campus,phone,email,photo,category) Values (@student_id,@given_name,@family_name,@group_id,@title,@campus,@phone,@email,@photo,@category)";
            cammandQuery = new SqlCommand(sql, GlobaldbConnection());
           cammandQuery.Parameters.AddWithValue("@student_id", _student_id);
           cammandQuery.Parameters.AddWithValue("@given_name", _given_name);
           cammandQuery.Parameters.AddWithValue("@family_name", _family_name);
           cammandQuery.Parameters.AddWithValue("@group_id", _group_id);
           cammandQuery.Parameters.AddWithValue("@title", _title);
           cammandQuery.Parameters.AddWithValue("@campus", _campus);
           cammandQuery.Parameters.AddWithValue("@phone", _phone);
           cammandQuery.Parameters.AddWithValue("@email", _email);
          cammandQuery.Parameters.AddWithValue("@photo", _photo);
          cammandQuery.Parameters.AddWithValue("@category", _category);
            ConvertPic(_studentphoto, "@photo");
           cammandQuery.ExecuteNonQuery();
        }
 
      public void Updatestudent()
        {
            sql = "UPDATE student SET student_id=@student_id,given_name=@given_name,family_name=@family_name,group_id=@group_id,title=@title,campus=@campus,phone=@phone,email=@email,photo=@photo,category=@category Where student_id=@student_id";
           cammandQuery = new SqlCommand(sql, GlobaldbConnection());
             cammandQuery.Parameters.AddWithValue("@student_id", _student_id);
           cammandQuery.Parameters.AddWithValue("@given_name", _given_name);
           cammandQuery.Parameters.AddWithValue("@family_name", _family_name);
           cammandQuery.Parameters.AddWithValue("@group_id", _group_id);
           cammandQuery.Parameters.AddWithValue("@title", _title);
           cammandQuery.Parameters.AddWithValue("@campus", _campus);
           cammandQuery.Parameters.AddWithValue("@phone", _phone);
           cammandQuery.Parameters.AddWithValue("@email", _email);
          cammandQuery.Parameters.AddWithValue("@photo", _photo);
          cammandQuery.Parameters.AddWithValue("@category", _category);
            ConvertPic(_studentphoto, "@photo")
          
           cammandQuery.ExecuteNonQuery();
        }


     public bool DeleteStudent()
        {
            sql = "Delete From Regstudent Where Id='" + _student_id + "'";
            return ExecuteNonQuery(sql);
        }

          public void InsertClass()
        {
            sql = "INSERT INTO Class(class_id,group_id,day,start,end,room) Values (@class_id,@group_id,@day,@start,@end,@room)";
            cammandQuery = new SqlCommand(sql, GlobaldbConnection());
           cammandQuery.Parameters.AddWithValue("@class_id", _class_id);
           cammandQuery.Parameters.AddWithValue("@group_id", _group_id);
           cammandQuery.Parameters.AddWithValue("@day", _day);
           cammandQuery.Parameters.AddWithValue("@start", _start);
           cammandQuery.Parameters.AddWithValue("@end", _end);
           cammandQuery.Parameters.AddWithValue("@room", _room);
           cammandQuery.ExecuteNonQuery();
        }
    
      public void UpdateClass()
        {
            sql = "UPDATE Class SET class_id=@class_id,group_id=@group_id,day=@day,start=@start,end=@end,room=@room Where class_id=@class_id";
           cammandQuery = new SqlCommand(sql, GlobaldbConnection());
        
           cammandQuery.Parameters.AddWithValue("@class_id", _class_id);
           cammandQuery.Parameters.AddWithValue("@group_id", _group_id);
           cammandQuery.Parameters.AddWithValue("@day", _day);
           cammandQuery.Parameters.AddWithValue("@start", _start);
           cammandQuery.Parameters.AddWithValue("@end", _end);
           cammandQuery.Parameters.AddWithValue("@room", _room);
           cammandQuery.ExecuteNonQuery();
            
          
        }
     public bool DeleteClass()
        {
            sql = "Delete From Regclass Where Id='" + _class_id + "'";
            return ExecuteNonQuery(sql);
        }

}
