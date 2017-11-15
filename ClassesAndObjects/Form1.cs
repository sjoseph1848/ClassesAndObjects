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
            Employee e1 = new Employee();
            e1.FirstName = "Mark";
            e1.LastName = "Long";
            e1.Seniority = 5;

            //call one of the methods
            string p = e1.Promote();
            MessageBox.Show(p);
            
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

        public string AnnualReview()
        {
            return "Annual review completed...";
        }
    }


}
