using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaloniaBindingProblem
{
    public class AnotherProblem : Window
    {
        public AnotherProblem()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif

            Item = new();
            this.DataContext = this;
        }
        
        public ViewModel Item { get; }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}