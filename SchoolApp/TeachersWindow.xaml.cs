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
using System.Windows.Shapes;
using BAL;
using ENTITIES;

namespace SchoolApp
{
    
    public partial class TeachersWindow : Window
    {
        public TeachersWindow()
        {
            DataContext = this;
            functions bl = new functions();
            Teachers = bl.Readteachers();
            InitializeComponent();
        }
        public List<teacher> Teachers { get; set; }
    }
}
