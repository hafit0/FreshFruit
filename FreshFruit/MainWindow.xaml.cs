using FreshFruit.Controller;
using FreshFruit.Model;
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

namespace FreshFruit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, BucketEvenListener
    {
        Seller Hafit;
        public MainWindow()
        {
            InitializeComponent();

            Bucket KeranjangBuah = new Bucket(4);
            BucketController bucketController = new BucketController(KeranjangBuah, this);

            Hafit = new Seller("Hafit", bucketController);
            ListBoxBucket.ItemsSource = KeranjangBuah.findAll();
        }

        public void onFailed(string message)
        {
            MessageBox.Show(message, "Warning");
        }

        public void onSucceed(string message)
        {
            ListBoxBucket.Items.Refresh();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Fruit anggur = new Fruit("Anggur");
            Hafit.addFruit(anggur);
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Fruit apel = new Fruit("Apel");
            Hafit.addFruit(apel);
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            Fruit pisang = new Fruit("Pisang");
            Hafit.addFruit(pisang);
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            Fruit jeruk = new Fruit("Jeruk");
            Hafit.addFruit(jeruk);
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            Fruit anggur = new Fruit("Anggur");
            Fruit apel = new Fruit("Apel");
            Fruit pisang = new Fruit("Pisang");
            Fruit jeruk = new Fruit("Jeruk");
            Hafit.removeFruit(anggur);
            Hafit.removeFruit(apel);
            Hafit.removeFruit(pisang);
            Hafit.removeFruit(jeruk);
        }

    }
}