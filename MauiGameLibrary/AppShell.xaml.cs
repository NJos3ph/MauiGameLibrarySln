namespace MauiGameLibrary
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }


        private void RegisterRoutes()
        {

            Routing.RegisterRoute("updategameroute", typeof(Views.UpdateGameView));
        
        }

    }
}
