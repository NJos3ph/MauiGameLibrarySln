using MauiGameLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static Android.Resource;


namespace MauiGameLibrary.Services
{
    public class GameDataService
    {


       private List<GameInformation> _gameInformation = new List<GameInformation>();
       private List<GameType> _gameTypes = new List<GameType>();


        public GameDataService()
        {

            CreateFakeGameInformation();
            PrePopulateData();
        }

        public void PrePopulateData()
        {

            PrePopulateGameTypes();

        }

        public void PrePopulateGameTypes()
        {

            GameType gameType = new GameType() { Name = "Nintendo 64", Description = "Nintendo's 64 bit Console" };
            _gameTypes.Add(gameType);

             gameType = new GameType() { Name = "Nintendo Wii", Description = "Nintendo's family motion Console" };
            _gameTypes.Add(gameType);

            gameType = new GameType() { Name = "Nintendo Switch", Description = "Nintendo's handheld Console" };
            _gameTypes.Add(gameType);

            gameType = new GameType() { Name = "Playstation 5", Description = "Sony's Latest Console" };
            _gameTypes.Add(gameType);



        }

        public List<GameInformation> GetAllGameInformation()
        {

            return _gameInformation;

        }


        public void CreateFakeGameInformation()
        {
            _gameInformation.Add(new GameInformation
            {
                Id = Guid.NewGuid().ToString(),
                Title = "The Legend of Zelda: Breath of the Wild",
                GameType = "Nintendo Wii",
                CompanyName = "Nintendo",
                Genre = "Adventure",
                AgeRestriction = "E10+",
                Multiplayer = false,
                Description = "An open-world action-adventure game set in the kingdom of Hyrule.",
                Image = "zelda.png",
                YearPublished = new DateTime(2017, 3, 3)
            });
            _gameInformation.Add(new GameInformation
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Super Mario Odyssey",
                GameType = "Nintendo Switch",
                CompanyName = "Nintendo",
                Genre = "Platformer",
                AgeRestriction = "E",
                Multiplayer = false,
                Description = "A 3D platformer where Mario travels across various kingdoms to rescue Princess Peach.",
                Image = "mario.png",
                YearPublished = new DateTime(2017, 10, 27)
            });
        }




        public void UpdateGameInformation(GameInformation gameInformation)
        {

            if (!string.IsNullOrEmpty(gameInformation.Id))
            {   // UPDATE
                var uniqueGame = GetGameInformationById(gameInformation.Id);
                int position = _gameInformation.IndexOf(uniqueGame);
                _gameInformation[position] = gameInformation;
            }
            else
            {
                //  INSERT    
                string id = Guid.NewGuid().ToString();
                gameInformation.Id = id;
                _gameInformation.Add(gameInformation);

            }
        }


        public GameInformation GetGameInformationById(string id)
        {

            var uniqueGame = _gameInformation.Where(gameInfo => gameInfo.Id == id).FirstOrDefault();
            return uniqueGame;

        }

        public List<GameInformation> GetGameInformationByTiTle(string title)
        {
            return _gameInformation.Where(gameInfo => gameInfo.Title == title).ToList();

        }

        public List<GameType> GetGamesType() 
        {
            return _gameTypes;

           

        }

    }
}
