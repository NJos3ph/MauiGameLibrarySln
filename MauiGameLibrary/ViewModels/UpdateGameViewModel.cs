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

        public UpdateGameViewModel(GameDataService gameDataService)
        {
            _gameDataService = gameDataService;
        }

    }
}
