using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace huynh_tien_thang_c2109i2_25_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataAdapter apdater = new SqlDataAdapter();
        DataSet ds = new DataSet();

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var ef = new SinhVienEntities1())
            {
                studentGridView1.DataSource = ef.TblStudents.ToList();
            }
        }
        private void loadStudent() {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["huynh_tien_thang_c2109i2_25_1.Properties.Settings.SinhVienConnectionString"].ConnectionString;
          command.Connection = con;
            command.CommandText = "Select * from TblStudent;";
            command.CommandType = CommandType.Text;
            apdater.SelectCommand = command;
            ds.Tables.Clear();
            apdater.Fill(ds);
            studentSource1.DataSource = ds.Tables[0];
            studentGridView1.DataSource = studentSource1;
        }

        private void studentGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel= true;
        }
    }
}
