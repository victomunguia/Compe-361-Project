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
using App1;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Output : Page
    {
        MyArray passedVar3;
        public Output()
        {
            this.InitializeComponent();
   
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            passedVar3 = e.Parameter as MyArray;
        }
        private void outputClick(object sender, RoutedEventArgs e)
        {
            if (((bool)passedVar3.Random) && ((bool)passedVar3.chooseInt))
            {
                outputToBlock(passedVar3.intArray);
            }
            else if (((bool)passedVar3.Random) && ((bool)passedVar3.chooseFloat))
            {
                outputToBlock(passedVar3.floatArray);
            }
            else if (((bool)passedVar3.ShellSort) && ((bool)passedVar3.chooseInt) && ((bool)passedVar3.Asceding))
            {
                passedVar3.Shell_Sort_int();
                outputToBlock(passedVar3.intArray);
            }
            else if (((bool)passedVar3.SelectionSort) && ((bool)passedVar3.chooseInt) && ((bool)passedVar3.Asceding))
            {
                passedVar3.Selection_Sort_int();
                outputToBlock(passedVar3.intArray);
            }
            else if (((bool)passedVar3.InsertionSort) && ((bool)passedVar3.chooseInt) && ((bool)passedVar3.Asceding))
            {
                passedVar3.Insertion_Sort_int();
                outputToBlock(passedVar3.intArray);
            }
        }
        private void outputToBlock(int []data)
        {
            for (int index = 0; index < 20; index++)
            {
                int x = passedVar3.intArray[index];
                output.Text += x.ToString() + ',';
            }
            output.Text += '\n';
        }
        private void outputToBlock(double[] data)
        {
            for (int index = 0; index < 20; index++)
            {
                double x = data[index];
                output.Text += x.ToString("0.00") +"  ,";
             
            }
            output.Text += '\n';
        }
    }
}
