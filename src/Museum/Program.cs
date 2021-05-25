namespace Museum
{
    class Program
    {
        static void Main(string[] args)
        {
            //arrange this specifik Museum, Room, Doors and Art
            Museum Wivis_Virtuella_Museum = new Museum();
            Wivis_Virtuella_Museum.AddArtCollection();      

            Room entry = new Room("Enrte", 0);
            entry.AddDoors(0, 1, 0, 0);
            Wivis_Virtuella_Museum.AddRoomsToMuseum(entry);

            Room corridor = new Room("Korridor", 1);
            corridor.AddDoors(0, 3, 0, 1);
            Wivis_Virtuella_Museum.AddRoomsToMuseum(corridor);

            Room greenRoom = new Room("Gröna Rummet", 2);
            greenRoom.AddDoors(0, 9, 5, 3);
            greenRoom.AddArtToRoom(Wivis_Virtuella_Museum.museumArts, 0, 1);
            Wivis_Virtuella_Museum.AddRoomsToMuseum(greenRoom);

            Room redRoom = new Room("Röda Rummet", 3);
            redRoom.AddDoors(5, 7, 0, 0);
            redRoom.AddArtToRoom(Wivis_Virtuella_Museum.museumArts, 2, 3, 4);
            Wivis_Virtuella_Museum.AddRoomsToMuseum(redRoom);

            Room purpleRoom = new Room("Lila Rummet", 4);
            purpleRoom.AddDoors(11, 0, 0, 7);
            purpleRoom.AddArtToRoom(Wivis_Virtuella_Museum.museumArts,5, 6, 7, 8);
            Wivis_Virtuella_Museum.AddRoomsToMuseum(purpleRoom);

            Room blackRoom = new Room("Svarta Rummet", 5);
            blackRoom.AddDoors(0, 0, 0, 12);
            Wivis_Virtuella_Museum.AddRoomsToMuseum(blackRoom);

            Room whiteRoom = new Room("Vita Rummet", 6);
            whiteRoom.AddDoors(0, 0, 13, 0);
            whiteRoom.AddArtToRoom(Wivis_Virtuella_Museum.museumArts, 9);
            Wivis_Virtuella_Museum.AddRoomsToMuseum(whiteRoom);

            Room blueRoom = new Room("Blåa Rummet", 7);
            blueRoom.AddDoors(13, 12, 11, 9);
            blueRoom.AddArtToRoom(Wivis_Virtuella_Museum.museumArts, 10);
            Wivis_Virtuella_Museum.AddRoomsToMuseum(blueRoom);

            //Mark start position
            entry.currentLocation = true;

            //Introduction
            Display.ShowIntro(Wivis_Virtuella_Museum);

            //Discribe room to user
            Display.ShowRoom(Wivis_Virtuella_Museum);
        }
    }
}
