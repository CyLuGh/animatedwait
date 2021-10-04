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
    /// Interaction logic for ProcessingIndeterminateProgress.xaml
    /// </summary>
    public partial class ProcessingIndeterminateProgress 
    {
        public ProcessingIndeterminateProgress()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty InputBorderBrushProperty = DependencyProperty.Register(
           "InputBorderBrush" , typeof( Brush ) , typeof( ProcessingIndeterminateProgress ) , new PropertyMetadata( Brushes.SteelBlue ) );

        public Brush InputBorderBrush
        {
            get => (Brush) GetValue( InputBorderBrushProperty );
            set => SetValue( InputBorderBrushProperty , value );
        }

        public static readonly DependencyProperty InputBackgroundProperty = DependencyProperty.Register(
            "InputBackground" , typeof( Brush ) , typeof( ProcessingIndeterminateProgress ) , new PropertyMetadata( Brushes.WhiteSmoke ) );

        public Brush InputBackground
        {
            get => (Brush) GetValue( InputBackgroundProperty );
            set => SetValue( InputBackgroundProperty , value );
        }

        public static readonly DependencyProperty AlertBrushProperty = DependencyProperty.Register(
            "AlertBrush" , typeof( Brush ) , typeof( ProcessingIndeterminateProgress ) , new PropertyMetadata( Brushes.Red ) );

        public Brush AlertBrush
        {
            get => (Brush) GetValue( AlertBrushProperty );
            set => SetValue( AlertBrushProperty , value );
        }

        public static readonly DependencyProperty SmokeBrushProperty = DependencyProperty.Register(
            "SmokeBrush" , typeof( Brush ) , typeof( ProcessingIndeterminateProgress ) , new PropertyMetadata( Brushes.Gray ) );

        public Brush SmokeBrush
        {
            get => (Brush) GetValue( SmokeBrushProperty );
            set => SetValue( SmokeBrushProperty , value );
        }

        public static readonly DependencyProperty ElectricArcBrushProperty = DependencyProperty.Register(
            "ElectricArcBrush" , typeof( Brush ) , typeof( ProcessingIndeterminateProgress ) , new PropertyMetadata( Brushes.Goldenrod ) );

        public Brush ElectricArcBrush
        {
            get => (Brush) GetValue( ElectricArcBrushProperty );
            set => SetValue( ElectricArcBrushProperty , value );
        }

        public static readonly DependencyProperty AbacusBorderBrushProperty = DependencyProperty.Register(
            "AbacusBorderBrush" , typeof( Brush ) , typeof( ProcessingIndeterminateProgress ) , new PropertyMetadata( Brushes.Peru ) );

        public Brush AbacusBorderBrush
        {
            get => (Brush) GetValue( AbacusBorderBrushProperty );
            set => SetValue( AbacusBorderBrushProperty , value );
        }

        public static readonly DependencyProperty AbacusForegroundProperty = DependencyProperty.Register(
            "AbacusForeground" , typeof( Brush ) , typeof( ProcessingIndeterminateProgress ) , new PropertyMetadata( Brushes.RoyalBlue ) );

        public Brush AbacusForeground
        {
            get => (Brush) GetValue( AbacusForegroundProperty );
            set => SetValue( AbacusForegroundProperty , value );
        }

        public static readonly DependencyProperty AbacusBackgroundProperty = DependencyProperty.Register(
            "AbacusBackground" , typeof( Brush ) , typeof( ProcessingIndeterminateProgress ) , new PropertyMetadata( Brushes.Transparent ) );

        public Brush AbacusBackground
        {
            get => (Brush) GetValue( AbacusBackgroundProperty );
            set => SetValue( AbacusBackgroundProperty , value );
        }

        public static readonly DependencyProperty NodeBrushProperty = DependencyProperty.Register(
            "NodeBrush" , typeof( Brush ) , typeof( ProcessingIndeterminateProgress ) , new PropertyMetadata( Brushes.CornflowerBlue ) );

        public Brush NodeBrush
        {
            get => (Brush) GetValue( NodeBrushProperty );
            set => SetValue( NodeBrushProperty , value );
        }

        public static readonly DependencyProperty BackgroundProperty = DependencyProperty.Register(
            "Background" , typeof( Brush ) , typeof( ProcessingIndeterminateProgress ) , new PropertyMetadata( Brushes.White ) );

        public Brush Background
        {
            get => (Brush) GetValue( BackgroundProperty );
            set => SetValue( BackgroundProperty , value );
        }

        public static readonly DependencyProperty ForegroundProperty = DependencyProperty.Register(
            "Foreground" , typeof( Brush ) , typeof( ProcessingIndeterminateProgress ) , new PropertyMetadata( Brushes.Black ) );

        public Brush Foreground
        {
            get => (Brush) GetValue( ForegroundProperty );
            set => SetValue( ForegroundProperty , value );
        }
    }
}
