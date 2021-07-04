using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCTimer
{
    class DBConnector
    {
        //public SqlCeConnection conn = new SqlCeConnection(@"DataSource=Z:\\VisualStudioProjects\\IT518\\Aidinlou - Sales and Inventory System\\Aidinlou - Sales and Inventory System\\AidinlouDB.sdf");
        public SqlCeConnection conn = new SqlCeConnection(@"DataSource=pctimerdb.sdf");
        public SqlCeCommand cmd;
        public DataSet ds;
        public DataTable dt;
        public SqlCeDataAdapter da;

        public DBConnector(String query)
        {
            this.cmd = new SqlCeCommand();
            this.da = new SqlCeDataAdapter(query, conn);
            this.dt = new DataTable();
            da.Fill(this.dt);
        }

        public DBConnector(String query, String tableName)
        {
            this.cmd = new SqlCeCommand();
            this.ds = new DataSet();
            this.da = new SqlCeDataAdapter(query, conn);
            da.Fill(ds, tableName);
        }

        public DBConnector(String query, SqlCeCommand cmd)
        {
            this.cmd = cmd;
            this.cmd.CommandText = query;
            this.cmd.Connection = conn;
            conn.Open();
            this.cmd.ExecuteNonQuery();
        }
    }
}
