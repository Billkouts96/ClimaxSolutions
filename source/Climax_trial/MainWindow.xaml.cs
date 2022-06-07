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
using  Climax_trial.MVVM.ViewModel;
using WPFUI.Common;
using WPFUI.Controls.Interfaces;
namespace Climax_trial
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


        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {

            this.DragMove();
        }

        private void RootDialog_OnButtonRightClick(object sender, RoutedEventArgs e)
        {

       
            WPFUI.Controls.Dialog RootDialog =new WPFUI.Controls.Dialog() ;

            RootDialog.Hide();
        }


        private void TrayMenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            if (sender is not MenuItem menuItem)
                return;

            System.Diagnostics.Debug.WriteLine($"DEBUG | WPF UI Tray clicked: {menuItem.Tag}", "WPFUI.Demo");
        }

        private void RootNavigation_OnNavigated(INavigation sender, RoutedNavigationEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"DEBUG | WPF UI Navigated to: {e.CurrentPage.PageTag}", "WPFUI.Demo");

            // This funky solution allows us to impose a negative
            // margin for Frame only for the Dashboard page, thanks
            // to which the banner will cover the entire page nicely.
            System.Windows.Controls.Frame RootFrame = new System.Windows.Controls.Frame();
            RootFrame.Margin = new Thickness(
                left: 0,
                top: e.CurrentPage.PageTag == "dashboard" ? -69 : 0,
                right: 0,
                bottom: 0);
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void NavigationButtonTheme_OnClick(object sender, RoutedEventArgs e)
        {
            // We check what theme is currently
            // active and choose its opposite.
            var newTheme = WPFUI.Appearance.Theme.GetAppTheme() == WPFUI.Appearance.ThemeType.Dark
                ? WPFUI.Appearance.ThemeType.Light
                : WPFUI.Appearance.ThemeType.Dark;

            // We apply the theme to the entire application.
            WPFUI.Appearance.Theme.Apply(
                themeType: newTheme,
                backgroundEffect: WPFUI.Appearance.BackgroundType.Mica,
                updateAccent: true,
                forceBackground: false);
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            this.MouseDown += delegate { DragMove(); };
        }

    }


}
