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

namespace Lab_ListView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            string tempPrice;

            VideoGame vg = new VideoGame();

            vg.GameName = GameNameTextBox.Text;
            vg.Rating = RatingTextBox.Text;
            tempPrice = PriceTextBox.Text;
            if (!double.TryParse(tempPrice, out double i)) { }
            vg.Price = i;

            VideoGameListView.Items.Add(vg);

            GameNameTextBox.Text = " ";
            RatingTextBox.Text = " ";
            PriceTextBox.Text = " ";

            GameNameTextBox.Focus();
        }

    }
}
