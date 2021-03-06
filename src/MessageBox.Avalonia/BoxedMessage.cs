
using MessageBoxSlim.Avalonia.DTO;
using MessageBoxSlim.Avalonia.Interfaces;
using MessageBoxSlim.Avalonia.ViewModels;
using MessageBoxSlim.Avalonia.Views;


namespace MessageBoxSlim.Avalonia
{
    public static class BoxedMessage
    {
        public static IMessageBox<UserResult> Create(MessageBoxParams @params)
        {
            MessageBoxWindow window = new MessageBoxWindow(@params.Style);
            window.DataContext = new MessageBoxViewModel(@params, window);
            return window;
        }
    }
}
