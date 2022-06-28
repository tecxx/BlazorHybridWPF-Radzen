using Microsoft.Extensions.DependencyInjection;
using Radzen;
using System.Windows;

namespace BlazorHybridWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var serviceCollection = new ServiceCollection();
            serviceCollection.AddWpfBlazorWebView();
            serviceCollection.AddScoped<DialogService>();
            serviceCollection.AddScoped<NotificationService>();
            serviceCollection.AddScoped<TooltipService>();
            serviceCollection.AddScoped<ContextMenuService>();
            Resources.Add("services", serviceCollection.BuildServiceProvider());
        }
    }
}
