using System.Windows;
using System.Windows.Media;

namespace AnimatedWait
{
    public partial class CircularWorkIndicator
    {
        public CircularWorkIndicator()
        {
            InitializeComponent();
        }

        public Brush FirstBrush
        {
            get { return (Brush) GetValue( FirstBrushProperty ); }
            set { SetValue( FirstBrushProperty , value ); }
        }

        public static readonly DependencyProperty FirstBrushProperty =
            DependencyProperty.Register( "FirstBrush" , typeof( Brush ) , typeof( CircularWorkIndicator ) , new PropertyMetadata( default( Brush ) ) );



        public Brush SecondBrush
        {
            get { return (Brush) GetValue( SecondBrushProperty ); }
            set { SetValue( SecondBrushProperty , value ); }
        }

        public static readonly DependencyProperty SecondBrushProperty =
            DependencyProperty.Register( "SecondBrush" , typeof( Brush ) , typeof( CircularWorkIndicator ) , new PropertyMetadata( default( Brush ) ) );

        public Brush ThirdBrush
        {
            get { return (Brush) GetValue( ThirdBrushProperty ); }
            set { SetValue( ThirdBrushProperty , value ); }
        }

        public static readonly DependencyProperty ThirdBrushProperty =
            DependencyProperty.Register( "ThirdBrush" , typeof( Brush ) , typeof( CircularWorkIndicator ) , new PropertyMetadata( default( Brush ) ) );


        public Brush FourthBrush
        {
            get { return (Brush) GetValue( FourthBrushProperty ); }
            set { SetValue( FourthBrushProperty , value ); }
        }

        public static readonly DependencyProperty FourthBrushProperty =
            DependencyProperty.Register( "FourthBrush" , typeof( Brush ) , typeof( CircularWorkIndicator ) , new PropertyMetadata( default( Brush ) ) );

    }
}
