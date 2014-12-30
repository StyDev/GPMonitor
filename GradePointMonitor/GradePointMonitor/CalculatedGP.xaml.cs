using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;


namespace GradePointMonitor
{
    public partial class CalculatedGP : PhoneApplicationPage
    {
        CalcGP ne = new CalcGP();
        double basetab;
        double basetab1;
        int basetab2;
        public CalculatedGP()
        {
            InitializeComponent();
        }
        public void Answer()
        {
            

           
        }
        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void marksearned_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            basetab1 = Convert.ToDouble(ne.tt.Text);
            marksearned.Text = basetab1.ToString();
        }

        private void totalunits_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            basetab2 = Convert.ToInt32(ne.un.Text.ToString());
            totalunits.Text = basetab2.ToString();
        }

        

        private void gpa_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            basetab = basetab1 / basetab2;
            gpa.Text = basetab.ToString();
        }
 
    }
}