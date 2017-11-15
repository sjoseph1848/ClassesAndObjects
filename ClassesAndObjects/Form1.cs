using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesAndObjects
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }


    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Seniority { get; set; }

        //what actions do we want employee to take
        public string Promote()
        {
            return "Employee has been promoted..";
        }

        public string AnnualRevie()
        {
            return "Annual review completed...";
        }
    }


}
