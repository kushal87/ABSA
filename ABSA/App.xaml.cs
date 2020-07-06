using System;
using ABSA.UserDetails.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ABSA
{
    public partial class App : Application {

        static RestService restService;

        public App() {
            InitializeComponent();
            MainPage = new NavigationPage(new UserValidation())
            {
                BarBackgroundColor = Color.DarkSlateGray,
                BarTextColor = Color.White
            };
        }

        protected override void OnStart() {

        }

        protected override void OnSleep() {

        }

        protected override void OnResume() {

        }

        public static RestService RestService
        {
            get
            {
                if(restService == null)
                {
                    restService = new RestService();
                }
                return restService;
            }
        }


    }
}
