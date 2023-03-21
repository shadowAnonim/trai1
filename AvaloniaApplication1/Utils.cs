using AvaloniaApplication1.Data;
using Avalonia.Controls;
using MessageBox.Avalonia;
using MessageBox.Avalonia.Enums;

namespace AvaloniaApplication1;

public static class Utils
{
    public static  Train1dbContext db = new Train1dbContext();
    public static MainWindow AppMainWindow = null;
    public static ContentControl CurrentPage = null;
    
    public static void Error(string message)
    {
        MessageBoxManager.GetMessageBoxStandardWindow("Ошибка", message, ButtonEnum.Ok, Icon.Error).ShowDialog(AppMainWindow);
    }
}