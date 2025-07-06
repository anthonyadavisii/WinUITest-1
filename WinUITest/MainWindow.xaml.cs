using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Microsoft.Windows.AI;
using Microsoft.Windows.AI.Search.Experimental;
using Microsoft.Windows.AI.Text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUITest
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            InitAI();
        }

        private async void InitAI()
        {
            OutputText.Text = "Loading..";
            using LanguageModel languageModel =
                await LanguageModel.CreateAsync();
            if (LanguageModel.GetReadyState() == AIFeatureReadyState.NotReady)
            {
                var readyResult = await LanguageModel.EnsureReadyAsync();
                // Compare to the string or enum value that actually exists
                if (LanguageModel.GetReadyState() != AIFeatureReadyState.Ready)
                {
                    throw new Exception("AI feature is still not ready after installation.");
                }
            }

            string prompt = "Provide me a sentence that uses all letters in the English alphabet.";
            var responseResult = await languageModel.GenerateResponseAsync(prompt);
            string text = responseResult.Text;
            OutputText.Text = text;
        }
    }
}
