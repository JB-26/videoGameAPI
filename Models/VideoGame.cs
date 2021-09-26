using System;

namespace videoGameApi.Models
{
    public class VideoGame
    {
        public string name {get; set;}
        public string publisher {get; set;}
        public string developer {get; set;}
        public string platform {get; set;}
        public DateTime releaseDate {get; set;} 

        public double id {get; set;}
    }
}