using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFDemo
{
    /// <summary>
    /// Interaction logic for StudentWindow.xaml
    /// </summary>
    public partial class StudentWindow : Window
    {
        private Student student;

        public Student Student
        {
            get { return student; }
            set { student = value; }
        }

        public StudentWindow() : this(new Student())
        {
        }

        public StudentWindow(Student st)
        {
            InitializeComponent();
            this.student = st;
           
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            //Instantiate a class object
            //Student student = new Student();

            //Set the values from our controls into the class
            student.FirstName = txbFirstName.Text;
            student.LastName = txbLastName.Text;
            student.StudentNumber = txbStudentNum.Text;
            student.Major = txbMajor.Text;

            List<Assignment> scores = new List<Assignment>();
            foreach (Assignment score in lbScores.Items)
            {
                scores.Add(score);    
            }
            student.Scores = scores;

            //Set the results from the class into a control on the form
            txbResults.Text = student.ToString();
            this.DialogResult = true;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Assignment assign = new Assignment();
            assign.Title = txbTitle.Text;
            assign.Score = int.Parse(txbScore.Text);
            lbScores.Items.Add(assign);
            txbTitle.Text = "";
            txbScore.Text = "";

        }

    }
}
