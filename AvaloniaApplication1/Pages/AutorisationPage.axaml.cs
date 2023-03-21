using System;
using System.Linq;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using AvaloniaApplication1.Data;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static AvaloniaApplication1.Utils;

namespace AvaloniaApplication1.Pages;

public partial class AutorisationPage : UserControl
{
    public AutorisationPage()
    {
        InitializeComponent();
    }

    private void LoginBtn_OnClick(object? sender, RoutedEventArgs e)
    {
        try
        {
            User user = Utils.db.Users.FirstOrDefault(u => u.Login == LoginTb.Text);
            if (user == null)
            {
                Utils.Error("Пользователь не найден");
                return;
            }

            if (user.Password != PasswordTb.Text)
            {
                Utils.Error("Неверный пароль");
                return;
            }

            CurrentPage.Content = new MainPage();
        }
        catch (Exception exception)
        {
            Utils.Error(exception.Message);
        }
    }
}