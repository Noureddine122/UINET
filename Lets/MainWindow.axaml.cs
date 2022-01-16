using System;
using System.Diagnostics;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace Lets
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        public void button_click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var txt = (TextBox)this.FindNameScope().Find("Txt");
            var tt = txt.Text.Trim();
            var ttt = this.FindControl<RadioButton>("Chek").Width;
            button.Content = ttt;
        }
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}