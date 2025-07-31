using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using BAL;
using ENTITIES;

namespace SchoolApp
{
    /// <summary>
    /// Interaction logic for StudentsWindow.xaml
    /// </summary>
    public partial class StudentsWindow : Window
    { 
        public List<student> Students { get; set; }
        public StudentsWindow()
        {
            DataContext = this;
            functions bl = new functions();
            Students = bl.ReadStudents();
            InitializeComponent();
        }
        
    }
}
