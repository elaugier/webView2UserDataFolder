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
using Microsoft.Web.WebView2.Core;

namespace WebView2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Microsoft.Web.WebView2.Wpf.WebView2 NewWebView = new();
            string UserDataFolder;
            UserDataFolder = Environment.GetEnvironmentVariable("APPDATA") + "\\CAV";
            var env = CoreWebView2Environment.CreateAsync(null,
                UserDataFolder,
                new CoreWebView2EnvironmentOptions(null, null, null));
            webView.EnsureCoreWebView2Async(env.Result);
            webView.CoreWebView2InitializationCompleted += WebViewInitiliazed;
            webView.Source = new Uri("https://google.com");

        }

        private void WebViewInitiliazed(object? sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            string path = webView.CoreWebView2.Environment.UserDataFolder;
            string toto = "jklj";
        }

    }
}
