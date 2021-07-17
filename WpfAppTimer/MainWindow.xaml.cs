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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfAppTimer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class TokenRetrieveModel
        {
            public string Ticker { get; set; }
            public string Address { get; set; }
            public string Name { get; set; }
            public string Decimals { get; set; }

            public string Balance { get; set; }
        }
        ObservableCollection<TokenRetrieveModel> tokenlist = new ObservableCollection<TokenRetrieveModel>();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            var objmodel = new TokenRetrieveModel
            {
                Ticker = DateTime.Now.ToString(),
                Address = "CUwkBGkXrQpMnZeWW2SpAv1Vu9zPvjWNFS",
                Name = "Mediconnect",
                Balance = "32332",
                Decimals = "8"
            };
            this.tokenlist.Add(objmodel);
            this.DataGrid1.ItemsSource = tokenlist;

            //listBox1.Items.Add(DateTime.Now.Hour.ToString() + ":" +
            //    DateTime.Now.Second.ToString());

            //CommandManager.InvalidateRequerySuggested();
            //listBox1.Items.MoveCurrentToLast();
            //listBox1.SelectedItem = listBox1.Items.CurrentItem;
            //listBox1.ScrollIntoView(listBox1.Items.CurrentItem);
        }
    }
}
