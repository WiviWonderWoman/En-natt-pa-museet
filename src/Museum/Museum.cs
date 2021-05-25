using System.Collections.Generic;

namespace Museum
{
    public class Museum
    {
        public List<Room> museumRooms;
        public List<Art> museumArts;

        public Museum()
        {
            museumRooms = new List<Room>();
        }
        //Adds a changeble collection of art to Museeum
        public void AddArtCollection()
        {
           museumArts = new List<Art>(Art.CollectionOfArt()); 
        }

        //Add customized rooms to Museeum
        public void AddRoomsToMuseum(Room room)
        {
            museumRooms.Add(room);
        }
        
        //Calculate possible relocations between rooms
        // DoorId - currentRoomId = nextRoomId
        //iterates through museumRooms to find nextRoom
        public Room PossibleTransfer(Museum museum,Room currentRoom, int doorId)
        {
            Room thisRoom = currentRoom;
            int nextRoomId = doorId - thisRoom.roomId; 
            Room foundRoom = null;

            foreach (Room room in museum.museumRooms)
            {
                if (nextRoomId == room.roomId)
                {
                    currentRoom.currentLocation = false;
                    foundRoom = room;
                    foundRoom.currentLocation = true;   
                }
            }  
            return foundRoom;  
        }
    }
}
