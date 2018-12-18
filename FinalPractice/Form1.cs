using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalPractice
{
    public partial class Form1 : Form
    {
        List<Sale> Info = new List<Sale>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAccessSale db = new DataAccessSale();
            Info = db.PullData(TextBox.Text);
            UpdateInfo();
        }

        private void UpdateInfo()
        {
            ListBox.DataSource = Info;
            ListBox.DisplayMember = "Getinfo";
        }
    }
}
