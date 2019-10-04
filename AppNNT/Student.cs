using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
namespace AppNNT
{
    class Student
    {
        private string Name;

        public string StudentName
        {
            get { return Name; }
            set { Name = value; }
        }
       public Student(string stName)
        {
            this.Name = stName;
        }
        public Student() { }
        public virtual void Talk()
        {
            if (StudentName.Equals("Nhat Minh"))
                MessageBox.Show("My name is " + this.StudentName + ", I am a College student");
            else if (StudentName.Equals("Nhu Thinh"))
                MessageBox.Show("My name is " + this.StudentName + ", I am a University student");
        }
    }

}
