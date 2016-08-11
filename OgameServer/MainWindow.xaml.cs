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
using OgameServer.Utilities;

namespace OgameServer
{
    /// <summary>
    /// Main windows of the server.
    /// </summary>
    public partial class MainWindow : Window
    {
        Color textColor;
        Color errorColor;
        Color commandColor;
        Color timeColor;

        /// <summary>
        /// Constructor.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            textColor = Color.FromRgb(234, 206, 107);
            errorColor = Color.FromRgb(255, 87, 87);
            commandColor = Color.FromRgb(234, 143, 107);
            timeColor = Color.FromRgb(127, 161, 177);
        }

        /// <summary>
        /// Display a simple text.
        /// </summary>
        /// <param name="text">Text to display.</param>
        public void DisplayText(string text)
        {
            rtbConsole.AppendText(Tools.BuildTimeStamp(), timeColor);
            rtbConsole.AppendText(" ");
            rtbConsole.AppendText(text, textColor);
            rtbConsole.AppendText("\r");
        }

        /// <summary>
        /// Display an error.
        /// </summary>
        /// <param name="text">Text to display.</param>
        private void DisplayError(string text)
        {
            rtbConsole.AppendText(Tools.BuildTimeStamp(), timeColor);
            rtbConsole.AppendText(" ");
            rtbConsole.AppendText(text, errorColor);
            rtbConsole.AppendText("\r");
        }

        /// <summary>
        /// Display a command entered by the user.
        /// </summary>
        /// <param name="text">Text to display.</param>
        private void DisplayCommand(string text)
        {
            rtbConsole.AppendText(Tools.BuildTimeStamp(), timeColor);
            rtbConsole.AppendText(" ");
            rtbConsole.AppendText(text, commandColor);
            rtbConsole.AppendText("\r");
        }

        /// <summary>
        /// Click on "Start" button.
        /// </summary>
        private void StartClick(object sender, RoutedEventArgs e)
        {
            DisplayText("Server is running ...");
        }

        /// <summary>
        /// Click on "Stop" button.
        /// </summary>
        private void StopClick(object sender, RoutedEventArgs e)
        {
            DisplayText("Server stopped ...");
        }
    }
}
