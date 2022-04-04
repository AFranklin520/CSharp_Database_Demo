//Anthony Franklin afranklin18@cnm.edu
//WPFDialogDemo
//03/17/2022

using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;


/*
 TODO: 
6.2.	Set up the lists in the other tabs so they can be used to update and change the lists in School.
6.3.	Set up the student form so that is uses the Major, Campus and Courses lists to initialize the options on the form. Possibly by changing controls on the student form to drop down lists.
6.4.	Add delete functionality to the lists.
6.5.	Add a menu bar with a File menu that allows you to save all the data to a file or files.

 */
namespace WPFDemo
{
    /// <summary>
    /// Interaction logic for SchoolWindow.xaml
    /// </summary>
    public partial class SchoolWindow : Window
    {
        School school = new School();
        public SchoolWindow()
        {
            InitializeComponent();
            lbCampuses.ItemsSource = school.Campuses;
            lbCourses.ItemsSource = school.Courses;
            lbMajors.ItemsSource = school.Majors;
            lbStudents.ItemsSource = school.Students;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Student newStudent = new Student();
            StudentWindow studentWindow = new StudentWindow(newStudent);
            studentWindow.ShowDialog();
            if (studentWindow.DialogResult == true)
            {
                MessageBox.Show("Student " + newStudent.StudentNumber + " Added!");
                school.Students.Add(newStudent);
                lbStudents.Items.Refresh();

            }
            else
            {
                MessageBox.Show("Dialog Cancelled!");
            }

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            if (saveFile.ShowDialog() == true)
            {
                using (StreamWriter file = new StreamWriter(saveFile.OpenFile()))
                {
                    foreach (var student in school.Students)
                    {
                        file.WriteLine(student.ToString());
                    }
                }
            }

        }


        private void onItemClick(object sender, MouseButtonEventArgs e)
        {
            Student student = (Student)lbStudents.SelectedItem;
            StudentWindow studentWindow = new StudentWindow(student);
            
            studentWindow.txbFirstName.Text = student.FirstName;
            studentWindow.txbLastName.Text = student.LastName;
            studentWindow.txbStudentNum.Text = student.StudentNumber;
            studentWindow.txbMajor.Text = student.Major;
            studentWindow.lbScores.ItemsSource = student.Scores;
            studentWindow.ShowDialog();
        }
    }
}
