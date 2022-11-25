using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_Lab_Gernale
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnOkay_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmFileName frmFileName = new FrmFileName();
            frmFileName.ShowDialog();

            string getStudentNo = txtStudentNo.Text;
            string getFirstName = txtLastName.Text;
            string getLastName = txtFirstName.Text;
            string getMiddleInitial = txtMiddleInitial.Text;
            string getProgram = cbProgram.Text;
            string getAge = txtAge.Text;
            string getGender = cbGender.Text;
            string getContactNo = txtContactNo.Text;
            string getBirthday = txtBirthday.Text;

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, FrmFileName.SetFileName)))
            {
                outputFile.WriteLine("Student No: " + getStudentNo);
                outputFile.WriteLine("Full Name: " + getLastName + "," + getFirstName + " " + getMiddleInitial + ".");
                outputFile.WriteLine("Gender: " + getGender);
                outputFile.WriteLine("Program: " + getProgram);
                outputFile.WriteLine("Age: " + getAge);
                outputFile.WriteLine("Birthday: " + getBirthday);
                outputFile.WriteLine("ContactNo: " + getContactNo);
            }
        }
    }
}
