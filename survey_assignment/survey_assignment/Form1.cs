using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace survey_assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Comments.Visible = CheckBox_Comments.Checked;
        }

        private void Submit_Survey_Click(object sender, EventArgs e)
        {
            string rating = "";
            if (Cource_Rate_Excellent.Checked) rating = "Excellent";
            else if (Cource_Rate_Good.Checked) rating = "Good";
            else if (Cource_Rate_Average.Checked) rating = "Average";
            else
            {
                MessageBox.Show("Please select a rating.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string comments = CheckBox_Comments.Checked ? Comments.Text : "No additional comments";

            MessageBox.Show($"Rating: {rating}\nComments: {comments}", "Survey Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
