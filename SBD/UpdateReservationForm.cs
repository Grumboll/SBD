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
    public partial class UpdateReservationForm : Form
    {
        Form1 main;
        public UpdateReservationForm(Form1 main)
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
                objCmd.CommandText = "rezervacii_update";
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add("v_id_rezervaciq", OracleType.Number).Value = Int32.Parse(textBox1.Text);
                objCmd.Parameters.Add("v_data", OracleType.DateTime).Value = dateTimePicker1.Value.Date.ToString("dd MMM yy");
                objCmd.Parameters.Add("v_cena", OracleType.Double).Value = Double.Parse(textBox3.Text);
                objCmd.Parameters.Add("v_id_slujitel", OracleType.VarChar).Value = textBox4.Text;
                objCmd.Parameters.Add("v_id_klient", OracleType.VarChar).Value = textBox5.Text;
                objCmd.Parameters.Add("v_id_liniq", OracleType.Number).Value = Int32.Parse(textBox6.Text);
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
                this.Close();
            }
        }
    }
}
