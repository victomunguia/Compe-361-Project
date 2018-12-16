using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Page1 : Page
    {
        MyArray passedVar;
        public Page1()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            passedVar = e.Parameter as MyArray;
        }
        private void HyperlinkButton_type(object sender, RoutedEventArgs m)
        {

            if ((bool)IntOption.IsChecked)
            {
                passedVar.chooseInt = true;
                this.Frame.Navigate(typeof(BlankPage2), passedVar);
            }
            else
            {
                passedVar.chooseFloat = true;
                this.Frame.Navigate(typeof(BlankPage2), passedVar);
            }
        }
    }
}
