using System;

namespace Museum
{
    public abstract class Display
    {
        public static void ShowIntro(Museum museum)
        {
            Console.Clear();
            Console.WriteLine($"Välkommen till {museum}!\n"); 
            Console.WriteLine($"Just nu har vi en utställning av allkonstären {museum.museumArts[0].artist}s mest kända verk.\n");
            Console.WriteLine($"Ni kommer att guidas runt i ett rum i taget, i er egen takt.\n");
            Console.WriteLine($"Ni får välja åt vilket håll / genom vilken dörr du vill fortsätta er upplevelse.\n");
            Console.WriteLine($"När Ni känner er redo för att start rundvandringen så trycker Ni på valfri tangent."); 
            Console.ReadKey();
        }
        public static void ShowRoom(Museum museum)
        {
            //iterates through all rooms in Museum to find current possition
            for (int i = 0; i < museum.museumRooms.Count; i++)
            {
                Room room = museum.museumRooms[i];

                if (room.currentLocation == true)
                {
                    Console.Clear();
                    Room currentRoom = room; 

                    //if current room doesn't have any art 
                    if (currentRoom.arts.Count == 0)
                    {
                        Console.WriteLine($"I {currentRoom.roomName} finns för tillfället inga konstverk.\n"); 
                        Console.WriteLine("Det finns dörrar i följande vädersträck att välja på:\n");
                    }

                    //if current room have art,iterates through list of art and describe them
                    else 
                    {
                        Console.WriteLine($"I {currentRoom.roomName} finns {currentRoom.arts.Count} konstverk att beundra:\n");
                        foreach (var art in currentRoom.arts)
                        {
                            Console.WriteLine("Titel: " + art.title); 
                            Console.WriteLine(art.description);   
                            Console.WriteLine(art.artist); 
                            Console.WriteLine("\n");     
                        }
                        Console.WriteLine("När du känner dig färdig med att betraktat skapelserna finns det dörrar i följande vädersträck att välja på:\n");
                    }
                    
                    //iterates through array of doors and present direction and Door number
                    foreach (var door in currentRoom.doors)
                    {
                        if (door.doorId != 0)
                        {
                            Console.WriteLine($"{door.direction} med dörrnummer {door.doorId}\n");
                            
                        }
                    }
                    //Gives user a chans to escape the Museum
                    if (currentRoom.roomName == "Enrte")
                    {
                        Console.WriteLine("Om du önskar lämna museet, tryck [0]\n");
                    }

                    //Based on user input move to next room (or exit)
                    Console.Write("Ange önskat dörrnummer:\t");
                    int chosenDoor = ReadInt();

                    if (chosenDoor == 0)
                    {
                        Console.Write($"Tack för att Ni ville besöka {museum}!");
                        Console.Write($"Välkommen åter!");
                        return;
                    }

                    //Compute navigation and find next room to describe
                    Room nextRoom = museum.PossibleTransfer(museum, currentRoom, chosenDoor);
                    ShowRoom(museum); 
                }
            } 
        }
        //Catches incorrect input
        private static int ReadInt()
        {
            int door;
            while (int.TryParse(Console.ReadLine(), out door) == false)
            {
                Console.WriteLine("Du skrev inte in ett tal. Försök igen.");
            }
            return door;
        }
    }
}
