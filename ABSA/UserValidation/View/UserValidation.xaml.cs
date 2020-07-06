using System;
using System.Collections.Generic;
using ABSA.UserDetails.View;
using Xamarin.Forms;

namespace ABSA
{
    public partial class UserValidation : ContentPage
    {
        public UserValidation()
        {
            InitializeComponent();
        }

        void SubmitButton_Clicked(System.Object sender, System.EventArgs e)
        {
            
            if (SAIdEntry.Text?.Length > 0)
            {
                var UserValidationViewModel = new UserValidationViewModel(SAIdEntry.Text);
                string message = UserValidationViewModel.isValidNumber() ? "Number is valid" : "Number is not valid";
                DisplayAlert("Result", message, "OK");
            } 
        }

        async void ShowUsersButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ABSAUsers());
        }
    }
}
