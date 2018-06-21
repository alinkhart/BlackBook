using System;
using BlackBook.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace BlackBook.Setup {
    public partial class BlackBookApp : Application {
        
        public BlackBookApp() {
            InitializeComponent();

            MainPage = new LoginView();
        }

        protected override void OnStart() {
            // Handle when your app starts
        }

        protected override void OnSleep() {
            // Handle when your app sleeps
        }

        protected override void OnResume() {
            // Handle when your app resumes
        }
    }
}
