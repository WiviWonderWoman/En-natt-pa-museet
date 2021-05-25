using System.Collections.Generic;

namespace Museum
{
    public class Room
    {
        public bool currentLocation;
        public int roomId;
        public Door[] doors;
        public List<Art> arts;
        public string roomName;

        public Room(string nameToSet, int id)
        {
            roomName = nameToSet;
            currentLocation = false;
            roomId = id;
            doors = new Door[4];
            arts = new List<Art>();
        }
        //Adding four door to every room,giving them a direction
        public void AddDoors(int wId, int nId, int eId, int sId)
        {
            Door west = new Door(wId);
            doors[0]= west;
            west.direction = "Väster";

            Door north = new Door(nId);
            doors[1]= north;
            north.direction ="Norr";

            Door east = new Door(eId);
            doors[2]= east;
            east.direction = "Öster";

            Door south = new Door(sId);
            doors[3]= south;
            south.direction = "Söder";
        }

        //Following four methods are overloads, depending on amout of art the room should have
        //iterates through the museeums collection of art and adding the requested artwork to the room
        public void AddArtToRoom(List<Art> museumArts, int firstArt, int secondArt, int thirdArt, int forthArt)
        {
            for (int i = 0; i < museumArts.Count; i++)
            {
                Art foundArt = museumArts[i];

                if (i == firstArt || i == secondArt || i == thirdArt || i == forthArt)
                {
                    arts.Add(foundArt);
                } 
            }
        }

        public void AddArtToRoom(List<Art> museumArts, int firstArt, int secondArt, int thirdArt)
        {
            for (int i = 0; i < museumArts.Count; i++)
            {
                Art foundArt = museumArts[i];

                if (i == firstArt || i == secondArt || i == thirdArt)
                {
                    arts.Add(foundArt);
                } 
            }
        }
        public void AddArtToRoom(List<Art> museumArts, int firstArt, int secondArt)
        {
            for (int i = 0; i < museumArts.Count; i++)
            {
                Art foundArt = museumArts[i];

                if (i == firstArt || i == secondArt)
                {
                    arts.Add(foundArt);
                } 
            }

        }
        public void AddArtToRoom(List<Art> museumArts, int firstArt)
        {
           for (int i = 0; i < museumArts.Count; i++)
            {
                Art foundArt = museumArts[i];

                if (i == firstArt)
                {
                    arts.Add(foundArt);
                }
            } 
        }

        
            
    }
}
