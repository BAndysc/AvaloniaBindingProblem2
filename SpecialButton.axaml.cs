using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.VisualTree;

namespace AvaloniaBindingProblem
{
    public class SpecialButton : UserControl
    {
        public SpecialButton()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void Button_OnClick(object? sender, RoutedEventArgs e)
        {
            Canvas.SetLeft(FindParent()!, 120);
        }

        private Control? FindParent()
        {
            Control? element = this;
            while (element != null && !element.Classes.Contains("xyz"))
                element = (Control)((IVisual)element).VisualParent!;
            return element;
        }
    }
}