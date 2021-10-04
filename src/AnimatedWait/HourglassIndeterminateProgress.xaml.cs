using System;
using System.Collections.Generic;
using System.Text;
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
    /// <summary>
    /// Interaction logic for HourglassIndeterminateProgress.xaml
    /// </summary>
    public partial class HourglassIndeterminateProgress
    {
        public HourglassIndeterminateProgress()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty StrokeUpperProperty = DependencyProperty.Register(
            "StrokeUpper" , typeof( Brush ) , typeof( HourglassIndeterminateProgress ) , new PropertyMetadata( default( Brush ) ) );

        public Brush StrokeUpper
        {
            get => (Brush) GetValue( StrokeUpperProperty );
            set => SetValue( StrokeUpperProperty , value );
        }

        public static readonly DependencyProperty StrokeLowerProperty = DependencyProperty.Register(
            "StrokeLower" , typeof( Brush ) , typeof( HourglassIndeterminateProgress ) , new PropertyMetadata( default( Brush ) ) );

        public Brush StrokeLower
        {
            get => (Brush) GetValue( StrokeLowerProperty );
            set => SetValue( StrokeLowerProperty , value );
        }
    }
}
