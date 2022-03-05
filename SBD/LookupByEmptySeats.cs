using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBD
{
    public partial class LookupByEmptySeats : Form
    {
        public LookupByEmptySeats()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string CONNECTION_STRING = "Data Source = XE; User Id = RUMENPAVLOV; Password = 123456789;";

            OracleConnection con = new OracleConnection(CONNECTION_STRING);

            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "spravka_po_svobodnimesta";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("v_destinaciq_nachalo", OracleDbType.Varchar2).Value = textBox1.Text;
            cmd.Parameters.Add("v_destinaciq_krai", OracleDbType.Varchar2).Value = textBox2.Text;
            cmd.Parameters.Add("v_destinaciq_krai", OracleDbType.Date).Value = dateTimePicker1.Value.Date.ToString("dd MMM yy");
            cmd.Parameters.Add("v_destinaciq_krai", OracleDbType.Varchar2).Value = textBox3.Text;
            OracleParameter c = new OracleParameter();
            c.OracleDbType = OracleDbType.RefCursor;
            c.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(c);


            DataSet ds = new DataSet();

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
