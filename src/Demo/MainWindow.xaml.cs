using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
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
using ReactiveUI;

namespace Demo
{
    public partial class MainWindow : Window, IViewFor<DemoViewModel>
    {
        public MainWindow()
        {
            InitializeComponent();

            this.WhenActivated( disposables =>
            {
                this.WhenAnyValue( x => x.ViewModel )
                    .WhereNotNull()
                    .Do( vm => PopulateFromViewModel( this , vm , disposables ) )
                    .Subscribe()
                    .DisposeWith( disposables );
            } );

            ViewModel = new DemoViewModel();
        }

        private void PopulateFromViewModel( MainWindow view , DemoViewModel viewModel , CompositeDisposable disposables )
        {
            view.Bind( viewModel ,
                    vm => vm.ShowHourglass ,
                    v => v.CheckBoxHourglass.IsChecked )
                .DisposeWith( disposables );

            view.OneWayBind( viewModel ,
                    vm => vm.ShowHourglass ,
                    v => v.Hourglass.Visibility ,
                    b => b ? Visibility.Visible : Visibility.Collapsed )
                .DisposeWith( disposables );
        }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (DemoViewModel) value;
        }

        public DemoViewModel ViewModel { get; set; }
    }
}
