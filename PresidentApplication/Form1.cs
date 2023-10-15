using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresidentApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckEligibiity_Click(object sender, EventArgs e)
        {
            bool approved = true;
            if (!NaturalBornCitizenCheckBox.Checked)
            {
                approved = false;
            }
            if (BirthYearDateTimePicker.Value  > DateTime.Now.AddYears(-35))
            {
                approved = false;
            }
            if (ResidentYearsNumeric.Value < 14)
            {
                approved = false;
            }
            if (PriorTermsNumeric.Value > 1)
            {
                approved = false;
            }
            if (RebelledCheckBox.Checked)
            {
                approved = false;
            }
            if (approved)
            {
                MessageBox.Show("Congratulations you are eligible To run for President.");
            }
            else
            {
                MessageBox.Show("You are not eligible To run for President.");
            }
        }
    }
}
