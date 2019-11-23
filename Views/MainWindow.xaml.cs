using $safeprojectname$.ViewModels;
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

namespace $safeprojectname$.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ActionTabViewModal vmd;

        public MainWindow()
        {
            InitializeComponent();

            vmd = new ActionTabViewModal();
            actionTabs.ItemsSource = vmd.Tabs;
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }


        private void RibbonButton_Click_1(object sender, RoutedEventArgs e)
        {
            vmd.Tabs.Add(new ActionTabItem { Header = "UserControl 1", Content = new Button1UserControl() });
            actionTabs.SelectedIndex = vmd.Tabs.Count - 1;
        }

        private void Close_Tab(object sender, MouseButtonEventArgs e)
        {
            vmd.Tabs.RemoveAt(actionTabs.SelectedIndex);
        }

        private void RibbonButton_Click_2(object sender, RoutedEventArgs e)
        {
            vmd.Tabs.Add(new ActionTabItem { Header = "UserControl 2", Content = new Button1UserControl() });
            actionTabs.SelectedIndex = vmd.Tabs.Count - 1;

        }
    }
}
