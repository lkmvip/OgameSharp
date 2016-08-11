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
using OgameServer.Network;

namespace OgameServer
{
    /// <summary>
    /// Main windows of the server.
    /// </summary>
    public partial class MainWindow : Window
    {
        MainServer server;
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

            server = new MainServer(27000, 27100, 1, 1);
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
            // Start the main server
            server.Start();

            // Display the notices about the servers
            DisplayText("Main server is running ...");
            DisplayText("Login server is running ...");
            DisplayText("Game server is running ...");

            // Enable and disable the buttons
            buttonStart.IsEnabled = false;
            buttonStop.IsEnabled = true;
            buttonExecute.IsEnabled = true;
        }

        /// <summary>
        /// Click on "Stop" button.
        /// </summary>
        private void StopClick(object sender, RoutedEventArgs e)
        {
            // Stop the main server
            server.Stop();

            // Display the notices about the servers
            DisplayText("Servers stopped ...");

            // Enable and disable the buttons
            buttonStart.IsEnabled = true;
            buttonStop.IsEnabled = false;
            buttonExecute.IsEnabled = false;
        }

        /// <summary>
        /// Click on "Execute" button.
        /// </summary>
        private void ExecuteClick(object sender, RoutedEventArgs e)
        {
            // Save the command
            string command = textBoxCommandLine.Text;

            // Handle the command 
            HandleCommand(command);

            // Display the command in the console
            DisplayCommand(command);

            // Clear the command line
            textBoxCommandLine.Clear();
        }

        /// <summary>
        /// Handle a command written by the user.
        /// </summary>
        /// <param name="command">Command in string format.</param>
        private void HandleCommand(string command)
        {

        }
    }
}
