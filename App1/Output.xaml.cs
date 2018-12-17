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
    public partial class Output : Page
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

            else if ((bool)passedVar3.ShellSort)
            {
                if ((bool)passedVar3.chooseInt)
                {
                    passedVar3.Shell_Sort_int();
                    if ((bool)passedVar3.Asceding)
                        outputToBlock(passedVar3.intArray);
                    else
                       outputToBlock_descend(passedVar3.intArray);
                }
                else
                {
                    passedVar3.Shell_Sort_float();
                    if ((bool)passedVar3.Asceding)
                        outputToBlock(passedVar3.floatArray);
                    else
                        outputToBlock_descend(passedVar3.floatArray);
                }
            }
            else if ((bool)passedVar3.SelectionSort)
            {
                if ((bool)passedVar3.chooseInt)
                {
                    passedVar3.Selection_Sort_int();
                    if ((bool)passedVar3.Asceding)
                        outputToBlock(passedVar3.intArray);
                    else
                        outputToBlock_descend(passedVar3.intArray);
                }
                else
                {
                    passedVar3.Selection_Sort_float();
                    if ((bool)passedVar3.Asceding)
                        outputToBlock(passedVar3.floatArray);
                    else
                        outputToBlock_descend(passedVar3.floatArray);
                }
            }
            else if ((bool)passedVar3.InsertionSort)
            {
                if ((bool)passedVar3.chooseInt)
                {
                    passedVar3.Insertion_Sort_int();
                    if ((bool)passedVar3.Asceding)
                        outputToBlock(passedVar3.intArray);
                    else
                        outputToBlock_descend(passedVar3.intArray);
                }
                else
                {
                    passedVar3.Insertion_Sort_float();
                    if ((bool)passedVar3.Asceding)
                        outputToBlock(passedVar3.floatArray);
                    else
                        outputToBlock_descend(passedVar3.floatArray);
                }
            }
            else if ((bool)passedVar3.MergeSort)
            {
                if ((bool)passedVar3.chooseInt)
                {
                    passedVar3.SortMerge_int(passedVar3.intArray, 0, (passedVar3.intArray.Length - 1));
                    if ((bool)passedVar3.Asceding)
                        outputToBlock(passedVar3.intArray);
                    else
                        outputToBlock_descend(passedVar3.intArray);
                }
                else
                {
                    passedVar3.SortMerge_double(passedVar3.floatArray, 0, (passedVar3.floatArray.Length - 1));
                    if ((bool)passedVar3.Asceding)
                        outputToBlock(passedVar3.floatArray);
                    else
                        outputToBlock_descend(passedVar3.floatArray);
                }
            }
            else if((bool)passedVar3.Quicksort)
            {
                if ((bool)passedVar3.chooseInt)
                {
                    passedVar3.QuickSort_int(passedVar3.intArray, 0, (passedVar3.intArray.Length - 1));
                    if ((bool)passedVar3.Asceding)
                        outputToBlock(passedVar3.intArray);
                    else
                        outputToBlock_descend(passedVar3.intArray);
                }
                else
                {
                    passedVar3.QuickSort_double(passedVar3.floatArray, 0, (passedVar3.floatArray.Length - 1));//function for double Quicksort_double
                    if ((bool)passedVar3.Asceding)
                        outputToBlock(passedVar3.floatArray);
                    else
                        outputToBlock_descend(passedVar3.floatArray);
                }
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
        private void outputToBlock_descend(int[] data)
        {
            for (int index = 19; index >= 0; index--)
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
        private void outputToBlock_descend(double[] data)
        {
            for (int index = 19; index >= 0; index--)
            {
                double x = data[index];
                output.Text += x.ToString("0.00") + "  ,";

            }
            output.Text += '\n';
        }
    }
}
