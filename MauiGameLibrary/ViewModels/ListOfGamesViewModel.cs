using MauiGameLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiGameLibrary.Models;
using MauiGameLibrary.Services;
using System.Windows.Input;



namespace MauiGameLibrary.ViewModels
{
    [QueryProperty(nameof(SelectedGame), nameof(SelectedGame))]
    public class ListOfGamesViewModel : BaseViewModel
    {
        private GameDataService _gameDataService;

        private List<GameInformation> _games;


       


        // creating a command -- must be... public property  This Continues to -->
        public ICommand GameSelectedCommand { get; set; }


        private GameInformation _selectedGame;
        public GameInformation SelectedGame
        {

            get { return _selectedGame; }
            set
            {
                _selectedGame = value;
                OnPropertyChanged();
            }
        }

        public List<GameInformation> Games
        {

            get { return _games; }
            set { _games = value;
                OnPropertyChanged();
            }

        }

        //HERE
        public ListOfGamesViewModel(GameDataService service)
        {
            _gameDataService = service;

            GameSelectedCommand = new Command(GameSelected);

        }
        //AND HERE
        private async void GameSelected(object obj)
        {
            var param = new ShellNavigationQueryParameters()
            {
                { "SelectedGame", SelectedGame }
            
            };

            await AppShell.Current.GoToAsync("updategameroute");//the strong here is a root   !!! it needs to be registered/ in appshell
        }

        public void RefreshGames()
        {

            Games = _gameDataService.GetAllGameInformation();

        }


    }
}
