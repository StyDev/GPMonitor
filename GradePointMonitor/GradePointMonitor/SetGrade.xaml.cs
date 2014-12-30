using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PhoneCoreLib;
using System.IO.IsolatedStorage;

namespace GradePointMonitor
{
    public partial class SetGrade : PhoneApplicationPage
    {
        public SetGrade()
        {
            InitializeComponent();
            List<string> grade = new List<string>();
            grade.Add("F");
            grade.Add("E");
            grade.Add("D");
            grade.Add("C");
            grade.Add("B");
            grade.Add("A");

            Dropdown.ItemsSource = grade;
            Dropdown.FullModeHeader = "Select Grade";
            Dropdown_Copy.ItemsSource = grade;
            Dropdown_Copy.FullModeHeader = "Select Grade";
            Dropdown_Copy1.ItemsSource = grade;
            Dropdown_Copy1.FullModeHeader= "Select Grade";
            Dropdown_Copy2.ItemsSource = grade;
            Dropdown_Copy2.FullModeHeader = "Select Grade";
            Dropdown_Copy3.ItemsSource = grade;
            Dropdown_Copy3.FullModeHeader = "Select Grade";
            Dropdown_Copy4.ItemsSource = grade;
            Dropdown_Copy4.FullModeHeader = "Select Grade";
        }

        public void SetTheGrade()
        {
            

            
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
          
            IsolatedStorageSettings settings = IsolatedStorageSettings.ApplicationSettings;

                settings[Dropdown.SelectedIndex.ToString()] = A.Text;
                settings[Dropdown_Copy.SelectedIndex.ToString()] = B.Text;
                settings[Dropdown_Copy1.SelectedIndex.ToString()] = C.Text;
                settings[Dropdown_Copy2.SelectedIndex.ToString()] = D.Text;
                settings[Dropdown_Copy3.SelectedIndex.ToString()] = E.Text;
                settings[Dropdown_Copy4.SelectedIndex.ToString()] = F.Text;
            
            settings.Save(); 
            
        }

        private void Dropdown_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {

        }
     }
  }