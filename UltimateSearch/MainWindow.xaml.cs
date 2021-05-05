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
using System.Diagnostics;
using OpenUrl;

namespace UltimateSearch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SearchQueryTextbox.Text = Config.GetSearchBoxPlaceholder();
            Config.ConfigIns = Config.ConfigIns.LoadConfigFromFile();
            // setting up checkboxes
            GoogleCheckBox.IsChecked = Config.ConfigIns.SearchGoogle;
            WikiCheckBox.IsChecked = Config.ConfigIns.SearchWikipedia;
            StackCheckBox.IsChecked = Config.ConfigIns.SearchStackoverflow;
            YoutubeCheckBox.IsChecked = Config.ConfigIns.SearchYoutube;
            // setting user setting as unchanged (IsChecked apparently triggers checkbox event which sets SettingHasChanged to true)
            Config.SettingHasChanged = false;
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            string searchQuery = SearchQueryTextbox.Text;
            // dont search if  query string is empty or default 
            if(searchQuery != "" && searchQuery != Config.GetSearchBoxPlaceholder())
            {
                if (Config.ConfigIns.SearchGoogle)
                    Browser.StartNewBrowserProcess(Config.GetSearchUrl(Config.Websites.google) + searchQuery);
                if (Config.ConfigIns.SearchYoutube)
                    Browser.StartNewBrowserProcess(Config.GetSearchUrl(Config.Websites.youtube) + searchQuery);
                if (Config.ConfigIns.SearchWikipedia)
                    Browser.StartNewBrowserProcess(Config.GetSearchUrl(Config.Websites.wikipedia) + searchQuery);
                if (Config.ConfigIns.SearchStackoverflow)
                    Browser.StartNewBrowserProcess(Config.GetSearchUrl(Config.Websites.stackoverflow) + searchQuery);
            }
            // this is for user ability to write new query immediately again after sending current query
            SearchQueryTextbox.Focus();
        }

        private void GoogleCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            Config.ConfigIns.SearchGoogle = true;
            Config.SettingHasChanged = true;
        }


        private void StackCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            Config.ConfigIns.SearchStackoverflow = true;
            Config.SettingHasChanged = true;
        }

        private void YoutubeCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            Config.ConfigIns.SearchYoutube = true;
            Config.SettingHasChanged = true;
        }

        private void WikiCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            Config.ConfigIns.SearchWikipedia = true;
            Config.SettingHasChanged = true;
        }

        private void GoogleCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Config.ConfigIns.SearchGoogle = false;
            Config.SettingHasChanged = true;
        }

        private void StackCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Config.ConfigIns.SearchStackoverflow = false;
            Config.SettingHasChanged = true;
        }

        private void YoutubeCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Config.ConfigIns.SearchYoutube = false;
            Config.SettingHasChanged = true;
        }

        private void WikiCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Config.ConfigIns.SearchWikipedia = false;
            Config.SettingHasChanged = true;
        }

        private void SearchQuery_GotFocus(object sender, RoutedEventArgs e)
        {
            if(SearchQueryTextbox.Text == Config.GetSearchBoxPlaceholder())
                SearchQueryTextbox.Text = ""; 
        }

        private void MainWindowObject_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Config.SettingHasChanged)
                Config.ConfigIns.SaveConfigToFile();
        }

        /// <summary>
        /// when user presses enter fire search button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindowObject_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                // to prevent event firing twice
                e.Handled = true;
                SearchBtn_Click(this, e);
            }
        }
    }
}
