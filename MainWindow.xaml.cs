using System;
using System.Windows;
using WpfPetarShatanovski.Infrastructure;
using WpfPetarShatanovski.ViewModel;

namespace WpfPetarShatanovski
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            
            DataContext = new MainWindowViewModel();
            
            (this.DataContext as MainWindowViewModel).ShowMessageBox += delegate (object sender, EventArgs args)
            {
                MessageBox.Show(((MessageEventArgs)args).Message);
            };
        }
    }
}
