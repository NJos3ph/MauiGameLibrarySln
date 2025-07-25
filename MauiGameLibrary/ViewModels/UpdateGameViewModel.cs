using MauiGameLibrary.Models;
using MauiGameLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiGameLibrary.ViewModels
{
    public class UpdateGameViewModel : BaseViewModel
    {
        //This lets this class know about Games Data service/ update and use
        private GameDataService _gameDataService;


        private List<GameType> _gameTypes;

        public List<GameType> GameTypes
        {

            get {return _gameTypes; }
            set { _gameTypes = value;
                OnPropertyChanged();
            }
        
        }


        public UpdateGameViewModel(GameDataService gameDataService)
        {
            _gameDataService = gameDataService;
        }

       

    }
}
