using System;
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
    [DesignTimeVisible(false)]
    public partial class OwnedPage : ContentPage
    {
        OwnedViewModel viewModel;

        public OwnedPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new OwnedViewModel();

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
