using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App1SignaR.ViewModel;


namespace App1SignaR.View
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        LobbyViewModel vm;
        LobbyViewModel VM
        {
            get => vm ?? (vm = (LobbyViewModel)BindingContext);
        }
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ToolbarProfile.Clicked += ToolbarProfile_Clicked;
        }

        private async void ToolbarProfile_clicked(object sender, EventArgs e) 
        {
            await Navigation.PushModalAsync(new XamChatNavigationPage(new ProfilePage()));
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            ToolbarProfile.Clicked -= ToolbarProfile_Clicked;
        }

        async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await VM.GoToGroupChat(Navigation, e.SelectedItem as string);
            ((ListView)sender).SelectedItem = null;
        }

    }
}
