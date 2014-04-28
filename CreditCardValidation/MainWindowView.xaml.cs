using MahApps.Metro.Controls;
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

namespace CreditCardValidation
{
    /// <summary>
    /// Interaction logic for MainWindowView.xaml
    /// </summary>
    public partial class MainWindowView : MetroWindow
    {
        #region Constructor

        private MainWindowViewModel viewModel;

        public MainWindowView()
        {
            InitializeComponent();
            viewModel = new MainWindowViewModel();
            this.DataContext = viewModel;
        }

        #endregion

        #region Events

        private void AboutButton_Click(object sender, RoutedEventArgs e)
        {
            viewModel.AboutButtonClicked();
        }

        private void ValidateButton_Click(object sender, RoutedEventArgs e)
        {
            viewModel.ValidateButtonClicked();
        }

        private void ValidationField_Changed(object sender, RoutedEventArgs e)
        {
            viewModel.ValidationFieldModified();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            viewModel.CalculateButtonClicked();
        }

        private void CalculateField_Changed(object sender, RoutedEventArgs e)
        {
            viewModel.CalculateFieldModified();
        }

        #endregion
    }
}
