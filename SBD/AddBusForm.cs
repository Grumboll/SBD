using System;
using System.Data;
using System.Data.OracleClient;
using System.Windows.Forms;

namespace SBD
{
    public partial class AddBusForm : Form
    {
        Form1 main;
        public AddBusForm(Form1 main)
        {
            this.main = main;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OracleConnection objConn = new OracleConnection("Data Source=XE; User ID=RUMENPAVLOV; Password=123456789"))
            {
                OracleCommand objCmd = new OracleCommand();
                objCmd.Connection = objConn;
                objCmd.CommandText = "avtobusi_ins";
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add("v_mesta", OracleType.Number).Value = Int32.Parse(textBox1.Text);
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
                main.loadBusGrid();
                this.Close();
            }
        }
    }
}
