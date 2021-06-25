using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstApp.ForeachLoop
{
    public partial class frmForEach : Form
    {
        public frmForEach()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var student = new Student();
            student.StudentId = Convert.ToInt32(txtStudentId.Text);
            student.Name = txtName.Text;
            student.Surname = txtSurname.Text;
            student.Age = Convert.ToInt32(txtAge.Text);

            var StudentList = new ArrayList(); //Recomended
            //Boxing-polymorphism
            StudentList.Add(student);

            foreach (Student _student in StudentList)
            {
                //Unboxing-polymorphism
                //MessageBox.Show(((Student)_student).Name + "" + ((Student)_student).Surname);
                MessageBox.Show(_student.Name + "" + _student.Surname);
            }
        }
    }
}
