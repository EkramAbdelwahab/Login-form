using System;
using System.Data.OleDb;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using System.Data.SqlClient;

namespace log_in
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = @"Provider=microsoft.Ace.oledB.12.0;data source=E:\mmm.accdb;";
            OleDbConnection conn = new OleDbConnection(constr);
            OleDbCommand cmd = conn.CreateCommand();
            string user = textBox1.Text;
            string pass = textBox2.Text;
            cmd.CommandText = "select password from Table1 where username='"+user+"'";
            
            conn.Open();
            string res=cmd.ExecuteScalar().ToString();
            if (pass == res)
            {
                MessageBox.Show("log in done");
            }
            else
            {
                MessageBox.Show("login Failed");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string constr = @"Provider=microsoft.Ace.oledB.12.0;data source=E:\mmm.accdb;";
            OleDbConnection con = new OleDbConnection(constr);
            OleDbCommand cmd = con.CreateCommand();
            string username="", password="";
            username = textBox1.Text;
            password = textBox2.Text;
            //ده السبب ف الانجكشن  لانه بيدخل من غير مايعمل  اى check
            cmd.CommandText = "insert into Table1 values('"+username+"','"+password+"')";
           // cmd.CommandText = "select coount(*)from users where  username='" + username + "' and password='" + password + "'";
            //'or'1'='1
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("insertion has been done successful");
           


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string constr = @"Provider=microsoft.Ace.oledB.12.0;data source=E:\mmm.accdb;";
            OleDbConnection con = new OleDbConnection(constr);
            OleDbCommand cmd = con.CreateCommand();
            string username = "", password = "";
            username = textBox1.Text;
            password = textBox2.Text;
            //ده السبب ف الانجكشن  لانه بيدخل من غير مايعمل  اى check
            //cmd.CommandText = "insert into users values('"+username+"','"+password+"')";
            cmd.CommandText = "select count(*)from Table1 where  username='" + username + "' and password='" + password + "'";
            //'or'1'='1
            con.Open();
            int result=(int)cmd.ExecuteScalar();
            if (result > 0)
            {
                MessageBox.Show("success");
            }
            else
            {
                MessageBox.Show("failed");
            }
            con.Close();
           
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string constr=@'data source
        }
    }
}
