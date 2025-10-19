using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pr11_Klimov
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Classes.Student> AllStudent = Classes.RepoStud.Allstudents();
        public int Count = 10;
        public int Step = 0;

        public MainWindow()
        {
            InitializeComponent();
            CreateStudent(Step, Count);
        }

        public void CreateStudent(int Step, int Count)
        {
            for (int iStudent = Step; iStudent < Step + Count; iStudent++)
            {
                if (AllStudent.Count > iStudent)
                {
                    parent.Children.Add(new Elements.Student(AllStudent[iStudent]));
                }
            }
            this.Step += Count;
        }

        private void ScrollViewer_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            ScrollViewer scroll = sender as ScrollViewer;
            double ParentHeight = parent.ActualHeight;
            double WindowHeight = scroll.ActualHeight - 20;
            double DeltaHeight = ParentHeight - WindowHeight;
            if (DeltaHeight - scroll.VerticalOffset < 140)
            {
                CreateStudent(Step, Count);
            }
        }

        private void SortText(object sender, RoutedEventArgs e)
        {
            SortName.Text = "";
            var stroke = AllStudent.Select(e => e.GetFIO(razdel.Text));
            var names = string.Join("", stroke);
            SortName.Text = names;
        }
    }
}