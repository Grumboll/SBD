using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBD
{
    public partial class AddTicketForm : Form
    {
        Form1 main;
        public AddTicketForm(Form1 main)
        {
            this.main = main;
            InitializeComponent();
        }

        private void AddTicketForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet3.REZERVACII' table. You can move, or remove it, as needed.
            this.rEZERVACIITableAdapter.Fill(this.dataSet3.REZERVACII);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OracleConnection objConn = new OracleConnection("Data Source=XE; User ID=RUMENPAVLOV; Password=123456789"))
            {
                OracleCommand objCmd = new OracleCommand();
                objCmd.Connection = objConn;
                objCmd.CommandText = "bileti_ins";
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add("v_id_type", OracleType.Number).Value = Int32.Parse(textBox1.Text);
                objCmd.Parameters.Add("v_mqsto", OracleType.Number).Value = Int32.Parse(textBox2.Text);
                objCmd.Parameters.Add("v_id_rezervaciq", OracleType.Number).Value = Int32.Parse(textBox3.Text);
                try
                {
                    objConn.Open();
                    objCmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine("Exception: {0}", ex.ToString());
                }
                objConn.Close();
                main.loadTicketGrid();
                this.Close();
            }
        }
    }
}
