using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.fname = txt_fname.Text;
            s.lname = txt_lname.Text;
            s.gender = cb_gender.Text[0];
            s.dob = date_birth.Value.Date;
            s.phone = txt_phone.Text;
            s.save();
            MessageBox.Show(txt_fname + " has been registered");
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_fname.ResetText();
            txt_lname.ResetText();
            cb_gender.ResetText();
            date_birth.ResetText();
            txt_phone.ResetText();
        }
    }
}
