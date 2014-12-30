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
using System.Windows.Input;
using System.Windows.Media.Imaging;


namespace GradePointMonitor
{

    public partial class CalcGP : PhoneApplicationPage
    {
        public TextBox cc;
        public ListPicker gr;
        public TextBox un;
        public TextBox tt;
        public Image cancel;

        int rows = 0;
        public CalcGP()
        {
            InitializeComponent();
        }

        public void doCalculations()
        {
            int basetab1;
            double _total, basetab2;

            var g = (Microsoft.Phone.Controls.ListPicker)gr;
            basetab1 = Convert.ToInt32(un.Text);
            basetab2 = Convert.ToDouble(g.SelectedIndex);
            _total = basetab1 * basetab2;
            tt.Text = _total.ToString();

            if (basetab1 < 1)
            {
                un.Text = "Error";
            }
        }
        


        private void calculator_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CalculatedGP.xaml", UriKind.Relative));
        }

        public void AddNewTextBox()
        {
            ++rows;
            cc = new TextBox();
            gr = new ListPicker();
            un = new TextBox();
            tt = new TextBox();
            cancel = new Image();
           
            CalcGrid.RowDefinitions.Add( new RowDefinition(){ Height= new System.Windows.GridLength(60)});


            cc.Height = 63;
            cc.Width = 140;
            cc.Name = "cc" + rows.ToString();
            cc.FontSize = 20;
            Grid.SetRow(cc, rows);
            Grid.SetColumn(cc, 0);

            List<string> grade = new List<string>();

            grade.Add("F");
            grade.Add("E");
            grade.Add("D");
            grade.Add("C");
            grade.Add("B");
            grade.Add("A");
            
            gr.ItemsSource = grade;
            gr.Name = "gr" + rows.ToString();
            gr.Height = 30;
            gr.Width = 50;
            gr.FontSize = 20;
            gr.FullModeHeader = "Select Grade";
            Grid.SetRow(gr, rows);
            Grid.SetColumn(gr, 1);
            

            InputScope scope = new InputScope();
            InputScopeName name = new InputScopeName();
            name.NameValue = InputScopeNameValue.Number;
            scope.Names.Add(name);
           
            un.Height = 63;
            un.Width = 100;
            un.Name = "un" + rows.ToString();
            un.FontSize = 20;
    
            Grid.SetRow(un, rows);
            Grid.SetColumn(un, 2);
            un.InputScope = scope;

            tt.Height = 63;
            tt.Width = 100;
            tt.FontSize = 20;
            tt.Name = "tt" + rows.ToString();
            tt.IsReadOnly = true;
            tt.Tap += tt_Tap;
            tt.FontWeight = FontWeights.Bold;
            Grid.SetRow(tt, rows);
            Grid.SetColumn(tt, 3);

            cancel.Height = 63;
            cancel.Width = 40;
            cancel.Name = "im" + rows.ToString();
            cancel.Tap += cancel_Tap;
            cancel.Source=new BitmapImage(new Uri("/Images/appbar.cancel.rest.png", UriKind.RelativeOrAbsolute));
            
            Grid.SetRow(cancel, rows);
            Grid.SetColumn(cancel, 4);
            
            CalcGrid.Children.Add(cc);
            CalcGrid.Children.Add(gr);
            CalcGrid.Children.Add(un);
            CalcGrid.Children.Add(tt);
            CalcGrid.Children.Add(cancel);
   
        }

        public void RemoveTextBox()
        {

            CalcGrid.Children.Remove(cc);
            CalcGrid.Children.Remove(gr);
            CalcGrid.Children.Remove(un);
            CalcGrid.Children.Remove(tt);
            CalcGrid.Children.Remove(cancel);
            CalcGrid.RowDefinitions.RemoveAt(0);
            CalcGrid.RowDefinitions.Remove(new RowDefinition() { Height = new System.Windows.GridLength(60) });
 
        }
   

        void tt_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            try
            {
                doCalculations();
            }
            catch (Exception exc)
            {
                tt.Text = "Error!";
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AddNewTextBox();
        }

        void cancel_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            RemoveTextBox();
        }
        private void SetGrade_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/SetGrade.xaml", UriKind.Relative));
        }

       
    }
}
