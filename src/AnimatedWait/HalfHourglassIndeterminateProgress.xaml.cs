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

namespace AnimatedWait
{
    public partial class HalfHourglassIndeterminateProgress
    {
        public HalfHourglassIndeterminateProgress()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty StrokeProperty = DependencyProperty.Register(
            "Stroke" , typeof( Brush ) , typeof( HalfHourglassIndeterminateProgress ) , new FrameworkPropertyMetadata( Brushes.Gray ) );

        public Brush Stroke
        {
            get => (Brush) GetValue( StrokeProperty );
            set => SetValue( StrokeProperty , value );
        }
    }
}