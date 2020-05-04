using Android.App;
using Android.Content;
using Android.OS;

namespace AppProCiencia.Droid
{
    [Activity(Theme = "@style/MyTheme.Splash", MainLauncher = false, NoHistory = true)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }

        //async void Simulansdor()
        //{
        //    //await Task.Delay(5000); // Simulando a demora de inicialização.
        //    StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        //}
    }
}