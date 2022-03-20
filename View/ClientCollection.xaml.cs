using System.Windows;
using System;
using System.Windows.Controls;

namespace WpfPetarShatanovski.View
{
    /// <summary>
    /// Interaction logic for ClientCollection.xaml
    /// </summary>
    public partial class ClientCollection : UserControl
    {
        public ClientCollection()
        {
            InitializeComponent();
        }
        private void TextBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
        }
    }
}
