using Oracle.DataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace SBD
{
    public partial class LookupByDestinationForm : Form
    {
        public LookupByDestinationForm()
        {
            InitializeComponent();
        }

        private void LookupByDestinationForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet3.DESTINACIQ' table. You can move, or remove it, as needed.
            this.dESTINACIQTableAdapter1.Fill(this.dataSet3.DESTINACIQ);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string CONNECTION_STRING = "Data Source = XE; User Id = RUMENPAVLOV; Password = 123456789;";

            OracleConnection con = new OracleConnection(CONNECTION_STRING);
            
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "search_po_destinaciq";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("v_destinaciq_nachalo", OracleDbType.Varchar2).Value = textBox1.Text;
            cmd.Parameters.Add("v_destinaciq_krai", OracleDbType.Varchar2).Value = textBox2.Text;
            OracleParameter c = new OracleParameter();
            c.OracleDbType = OracleDbType.RefCursor;
            c.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(c);
            

            DataSet ds = new DataSet();

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }
    }
}