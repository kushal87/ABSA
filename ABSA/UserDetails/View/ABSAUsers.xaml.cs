using System;
using ABSA.UserDetails.Model;
using ABSA.UserDetails.ViewModel;
using Xamarin.Forms;


namespace ABSA.UserDetails.View
{
    public partial class ABSAUsers : ContentPage
    {
        public ABSAUsers()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            PeopleViewModel peopleViewModel = new PeopleViewModel();
            PeopleResponse peopleResponse = await peopleViewModel.callABSAWebService();
            listView.ItemsSource = peopleResponse.results;
        }
    }
}
