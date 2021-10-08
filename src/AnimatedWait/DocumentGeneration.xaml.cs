using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AnimatedWait
{
    public partial class DocumentGeneration : UserControl
    {
        public DocumentGeneration()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty FileBackgroundBrushProperty = DependencyProperty.Register(
            "FileBackgroundBrush" , typeof( Brush ) , typeof( DocumentGeneration ) , new PropertyMetadata( Brushes.GhostWhite ) );

        public Brush FileBackgroundBrush
        {
            get => (Brush) GetValue( FileBackgroundBrushProperty );
            set => SetValue( FileBackgroundBrushProperty , value );
        }

        public static readonly DependencyProperty FileBorderBrushProperty = DependencyProperty.Register(
            "FileBorderBrush" , typeof( Brush ) , typeof( DocumentGeneration ) , new PropertyMetadata( Brushes.DimGray ) );

        public Brush FileBorderBrush
        {
            get => (Brush) GetValue( FileBorderBrushProperty );
            set => SetValue( FileBorderBrushProperty , value );
        }

        public static readonly DependencyProperty FileContentBrushProperty = DependencyProperty.Register(
            "FileContentBrush" , typeof( Brush ) , typeof( DocumentGeneration ) , new PropertyMetadata( Brushes.DarkGray ) );

        public Brush FileContentBrush
        {
            get => (Brush) GetValue( FileContentBrushProperty );
            set => SetValue( FileContentBrushProperty , value );
        }

        public static readonly DependencyProperty RepeatBehaviorProperty = DependencyProperty.Register(
            "RepeatBehavior" , typeof( RepeatBehavior ) , typeof( DocumentGeneration ) , new PropertyMetadata( RepeatBehavior.Forever ) );

        public RepeatBehavior RepeatBehavior
        {
            get => (RepeatBehavior) GetValue( RepeatBehaviorProperty );
            set => SetValue( RepeatBehaviorProperty , value );
        }
    }
}
