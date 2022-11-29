using CommunityToolkit.Maui.Core;
using MvvmHelpers.Commands;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopNoirApp.Models;

namespace ShopNoirApp.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private bool _IsPresented;
        private int count = 0;
        private DefaultItemCV _SelectedItem;

        public bool IsPresented
        {
            get => _IsPresented;
            set => SetProperty(ref _IsPresented, value);
        }

        public DefaultItemCV SelectedItem
        {
            get => _SelectedItem;
            set => SetProperty(ref _SelectedItem, value);
        }

        public AsyncCommand FlyoutCalled { get; set; }
        public AsyncCommand ItemSelected { get; set; }

        public MainPageViewModel()
        {
            FlyoutCalled = new AsyncCommand(_FlyoutCalled);
            ItemSelected = new AsyncCommand(_ItemSelected);
        }

        private async Task _ItemSelected()
        {
            if (SelectedItem != null)
            {
                SelectedItem = null;
                var toast = CommunityToolkit.Maui.Alerts.Toast.Make("Roupa Selecionada", ToastDuration.Short, 14);
                await toast.Show();
            }
        }

        private async Task _FlyoutCalled()
        {
            if (count == 0)
            {
                count++;
                Shell.Current.FlyoutBehavior = FlyoutBehavior.Locked;
                Shell.Current.FlyoutBehavior = FlyoutBehavior.Flyout;
            }
            Shell.Current.FlyoutIsPresented = true;
        }
    }
}
