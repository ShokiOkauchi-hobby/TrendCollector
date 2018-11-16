﻿using System;
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
using System.Windows.Threading;

namespace get_trend_twitter
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CreateBrowser();
            GetPoint();
        }

        private void GetPoint()
        {
            SizeChanged += (sender, args) =>
            {
                wide.Content = "Width: " + ActualWidth.ToString();
            };
        }

        private void CreateBrowser()
        {
            var appDir = Environment.CurrentDirectory;
            var browser = new CefSharp.Wpf.ChromiumWebBrowser();
            browser.Address = "https://trends.google.co.jp/trends/?geo=JP";
            TrendBrowser.Children.Add(browser);
        }
    }
}
