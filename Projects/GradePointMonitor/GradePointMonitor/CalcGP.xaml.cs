using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PhoneCoreLib;
using PhoneBusinessLogic;

namespace GradePointMonitor
{
    public partial class SetGrade : PhoneApplicationPage
    {
        public SetGrade()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox1 = new ComboBox();
            comboBox1.Items.Add("Item 1");
            comboBox1.Items.Add("Item 2");
            comboBox1.Items.Add("Item 3");
            
            comboBox1.SelectionChanged += ComboBox_SelectionChanged;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            List<Course> courses = new List<Course>();
            for (int i = 0; i <= 10; i++)
            {
                courses.Add(new Course() { courseCode = "SSG205", courseGrade= Grade.A, courseUnit=3} );
            }
            float total, weight;
            float gp = new GPLogic().CalculateGP(courses,out weight, out total);

            //pass gp,weight, and total to the UI...

        }

       
       

    }     
}