﻿using BetterGenshinImpact.ViewModel.Pages;
using System.Windows.Controls;

namespace BetterGenshinImpact.View.Pages
{
    /// <summary>
    /// NotificationSettingsPage.xaml 的交互逻辑
    /// </summary>
    public partial class NotificationSettingsPage : Page
    {
        private NotificationSettingsPageViewModel ViewModel { get; }

        public NotificationSettingsPage(NotificationSettingsPageViewModel viewModel)
        {
            DataContext = ViewModel = viewModel;
            InitializeComponent();
        }
    }
}
