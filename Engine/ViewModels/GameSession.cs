using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;
using Engine.Factories;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public World CurrentWorld { get; set; }
       public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }

        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Theseus";
            CurrentPlayer.Gold = 1000;
            CurrentPlayer.Level = 1;
            CurrentPlayer.HitPoints = 20;
            CurrentPlayer.ExperiencePoints = 20;
            CurrentPlayer.CharacterClass = "Wizard";

            CurrentLocation = new Location();
            CurrentLocation.Name = "Home";
            CurrentLocation.XCoordinate = 0;
            CurrentLocation.YCoordinate = -1;
            CurrentLocation.Description = "This is your house in Athens";
            CurrentLocation.ImageName = "pack://application:,,,/Engine;component/Images/Locations/house.jpg";

            WorldFactory = new WorldFactory();
            CurrentWorld = factory.CreateWorld();
        }
        
    }
}
