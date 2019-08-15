﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using TheBacklog.Models;
using TheBacklog.Views;
using TheBacklog.ViewModels;

namespace TheBacklog.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WishListPage : ContentPage
    {
        WishListViewModel viewModel;

        public WishListPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new WishListViewModel();

        }

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewItemPage()));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Items.Count == 0)
            {
                viewModel.LoadItemsCommand.Execute(null);
            }
        }
    }
}
