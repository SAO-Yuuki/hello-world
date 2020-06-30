using LiveCharts;
using LiveCharts.Helpers;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
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

namespace WpfApp2
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //Labels = new[] { "2010", "2011", "2013", "2013", "2014", "2015" };
            InitializeComponent();

            Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May" };

            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Series 1",
                    Values = new ChartValues<double> { 4, 6, 5, 2 ,4 }
                },
                new LineSeries
                {
                    Title = "Series 2",
                    Values = new ChartValues<double> { 6, 7, 3, 4 ,6 },
                    PointGeometry = null
                },
                new LineSeries
                {
                    Title = "Series 3",
                    Values = new ChartValues<double> { 4,2,7,2,7 },
                    PointGeometry = DefaultGeometries.Square,
                    PointGeometrySize = 15
                }
            };

            var now = DateTime.UtcNow;
            InitialDateTime = new DateTime(now.Year, now.Month, now.Day);

            SeriesCollectionRow6 = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Series 1",
                    Values = new ChartValues<double> { 4, 6, 5, 2 ,7, 8, 2, 0, 3, 5, 2, 4, 6, 4, 7, 3, 10, 4, 1, 2, 5, 8, 4, 6, 2, 4, 8, 7, 5, 4, 3, 2, 5, 6, 5, 3, 6, 4, 6, 3, 4, 1, 4, 2, 3, 2, 3, 5, 8, 6, 8, 4, 2, 4, 1, 2, 5, 6, 4, 6, 5, 2 ,7, 8, 2, 0, 3, 5, 2, 4, 6, 4, 7, 3, 10, 4, 1, 2, 5, 8, 4, 6, 2, 4, 8, 7, 5, 4, 3, 2, 5, 6, 5, 3, 6, 4, 6, 3, 4, 1, 4, 2, 3, 2, 3, 5, 8, 6, 8, 4, 2, 4, 1, 2, 5, 6  },
                },
            };

            YFormatter = value => value.ToString("C");
            DataContext = this;
        }

        private PeriodUnits _period = PeriodUnits.Seconds;
        public PeriodUnits Period
        {
            get { return _period; }
            set
            {
                _period = value;
                OnPropertyChanged("Period");
            }
        }
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            if (PropertyChanged != null) PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private IAxisWindow _selectedWindow;
        public IAxisWindow SelectedWindow
        {
            get { return _selectedWindow; }
            set
            {
                _selectedWindow = value;
                OnPropertyChanged("SelectedWindow");
            }
        }

        public DateTime InitialDateTime
        {
            get { return _initialDateTime; }
            set
            {
                _initialDateTime = value;
                OnPropertyChanged("InitialDateTime");
            }
        }

        private DateTime _initialDateTime;


        #region 变量
        public string[] Labels { get; set; }
        public string[] LabelsRow1 { get; set; }
        public string[] LabelsRow2 { get; set; }
        public string[] LabelsRow3 { get; set; }
        public string[] LabelsRow4 { get; set; }
        public string[] LabelsRow5 { get; set; }
        public string[] LabelsRow6 { get; set; }
        public string[] LabelsRow7 { get; set; }

        public SeriesCollection SeriesCollection { get; set; }
        public SeriesCollection SeriesCollectionRow0 { get; set; }
        public SeriesCollection SeriesCollectionRow1 { get; set; }
        public SeriesCollection SeriesCollectionRow2 { get; set; }
        public SeriesCollection SeriesCollectionRow3 { get; set; }
        public SeriesCollection SeriesCollectionRow4 { get; set; }
        public SeriesCollection SeriesCollectionRow5 { get; set; }
        public SeriesCollection SeriesCollectionRow6 { get; set; }
        public SeriesCollection SeriesCollectionRow7 { get; set; }

        public Func<double, string> YFormatter { get; set; }
        public Func<double, string> YFormatterRow1 { get; set; }
        public Func<double, string> YFormatterRow2 { get; set; }
        public Func<double, string> YFormatterRow3 { get; set; }
        public Func<double, string> YFormatterRow4 { get; set; }
        public Func<double, string> YFormatterRow5 { get; set; }
        public Func<double, string> YFormatterRow6 { get; set; }
        public Func<double, string> YFormatterRow7 { get; set; }
        #endregion
    }
}
