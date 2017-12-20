using ICT13580069A2.Helpers;
using Xamarin.Forms;

namespace ICT13580069A2
{
    public partial class App : Application
    {
        public Static Dbhelper Dbhelper{ get, set;}
        public App ()
        {
        InitializeComponent();
        }
        public App(string dbpath)
        {
            InitializeComponent();

               Dbhelper = new Dbhelper(dbpath);
               MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
