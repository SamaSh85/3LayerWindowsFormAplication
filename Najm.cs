using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DA;
using BL;

namespace BL
{
    public class Najm:DataAccessLayer
    {
        public string name1;
        public string family;
        public string tell;
        public string born;
        public int id;
     
   public void Add()
    {
        base.connect();
        string sql = "insert into Najm (Name1,Family,tell,born) Values(N'{0}',N'{1}','{2}','{3}')";
        sql=string.Format(sql,name1,family,tell,born);
        base.docommand(sql);
        base.disconnect();
    }
   public void delete()
   {
       base.connect();
       string sql = "delete from Najm where Id={0}";
       sql = string.Format(sql, id);
       base.docommand(sql);
       base.disconnect();

   }
   public void udate()
   {
       base.connect();
       string sql = "update Najm set Name1=N'{0}',Family=N'{1}',tell='{2}',born='{3}' where Id={4}";
       sql = string.Format(sql, name1, family, tell, born, id);
       base.docommand(sql);
       base.disconnect();
   }
   public DataTable select()
   {
       base.connect();
       string sql = "select * from Najm";
       DataTable dt = base.select(sql);
       base.disconnect();
       return dt;

   }
   public DataTable selectone()
   {
       base.connect();
       string sql = "select * from Najm where Id={0}";
       sql = string.Format(sql, id);
       DataTable dt = base.select(sql);
       base.disconnect();
       return dt;
   }

    }
}
