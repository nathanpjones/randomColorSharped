using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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
using RandomColorGenerator;

namespace RandomColorSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private ColorScheme _scheme = ColorScheme.Random;
        private Luminosity _luminosity = Luminosity.Bright;
        private int _numberToGenerate = 84;

        public MainWindow()
        {
            InitializeComponent();
            GenerateColors();
        }

        public ColorScheme Scheme
        {
            get { return _scheme; }
            set
            {
                if (_scheme == value) return;
                _scheme = value;
                OnPropertyChanged("Scheme");
            }
        }
        public Luminosity Luminosity
        {
            get { return _luminosity; }
            set
            {
                if (_luminosity == value) return;
                _luminosity = value;
                OnPropertyChanged("Luminosity");
            }
        }
        public int NumberToGenerate
        {
            get { return _numberToGenerate; }
            set
            {
                if (_numberToGenerate == value) return;
                _numberToGenerate = value;
                OnPropertyChanged("NumberToGenerate");
            }
        }

        private void OnTextBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                GenerateColors();
            }
        }

        private void OnButtonClick(object sender, RoutedEventArgs e)
        {
            GenerateColors();
        }

        private void GenerateColors()
        {
            var colors = RandomColor.GetColors(Scheme, Luminosity, NumberToGenerate);

            GeneratedColorsListBox.BeginInit();
            GeneratedColorsListBox.Items.Clear();
            foreach (var c in colors)
            {
                GeneratedColorsListBox.Items.Add(new SolidColorBrush(c));
            }
            GeneratedColorsListBox.EndInit();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
