using videoGameApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace videoGameApi.Services
{
    //this is an in-memeory service
    public static class VideoGameService
    {
        static List<VideoGame> Games {get;}

        static int nextId = 3;

        static VideoGameService()
        {
            Games = new List<VideoGame>
            {
                new VideoGame{ name = "Super Mario 64", publisher = "Nintendo", developer = "Nintendo", platform = "Nintendo 64", releaseDate = new System.DateTime(1996, 06, 23), id = 1},
                new VideoGame{ name = "X-Men Vs Street Fighter", publisher = "Capcom", developer = "Capcom", platform = "Sega Saturn", releaseDate = new System.DateTime(1997, 11, 27), id = 2}
            };
        }

        public static List<VideoGame> GetAll() => Games;

        public static VideoGame Get(int id) => Games.FirstOrDefault(p => p.id == id);

        public static void Add(VideoGame game)
        {
            game.id = nextId++;
            Games.Add(game);
        }

        public static void Delete(int id)
        {
            var game = Get(id);
            if (game is null)
                return;
            Games.Remove(game);
        }

        public static void Update(VideoGame game)
        {
            var index = Games.FindIndex(p => p.id == game.id);
            if (index == -1)
                return;
            Games[index] = game;
        }
    }
}