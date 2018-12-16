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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage2 : Page
    {
        MyArray passedVar2;
        public BlankPage2()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            passedVar2 = e.Parameter as MyArray;
        }
        private void HyperlinkButton_proceed(object sender, RoutedEventArgs e)
        {
            if((bool)Ascending.IsChecked)
            {
                passedVar2.Asceding = true;
                this.Frame.Navigate(typeof(Output), passedVar2);
            }
            else if((bool)Descending.IsChecked)
            {
                passedVar2.Descending = true;
                this.Frame.Navigate(typeof(Output), passedVar2);
            }
            else
            {
                passedVar2.Random = true;
                this.Frame.Navigate(typeof(Output), passedVar2);
            }
        }
    }
}
