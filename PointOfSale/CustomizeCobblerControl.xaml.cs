using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ExamTwoCodeQuestions.Data;

namespace ExamTwoQuestions.PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCobblerControl.xaml
    /// </summary>
    public partial class CustomizeCobblerControl : UserControl
    {
        public CustomizeCobblerControl()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// Private event for creating the text for the Summary Text Box.
        /// Shows that changes have been made to the cobbler.
        /// </summary>
        /// <param name="sender">The control that was changed</param>
        /// <param name="e">Routed Event Args</param>
        private void ChangeSelectionTextBox(object sender, RoutedEventArgs e)
        {
            var cobbler = DataContext as Cobbler;
            StringBuilder summary = new StringBuilder();
            switch (cobbler.Fruit)
            {
                case FruitFilling.Peach:
                    summary.Append("Peach Cobbler ");
                    break;
                case FruitFilling.Cherry:
                    summary.Append("Cherry Cobbler ");
                    break;
                case FruitFilling.Blueberry:
                    summary.Append("Blueberry Cobbler ");
                    break;
                default:
                    summary.Append("Error ");
                    break;
            }
            
            if (cobbler.WithIceCream)
            {
                summary.Append("With Ice Cream");
            }
            else summary.Append("Without Ice Cream");

            tbSelection.Text = summary.ToString();
        }

       
    }
}
