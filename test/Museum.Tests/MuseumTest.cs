using System;
using Xunit;

namespace Museum.Tests
{
    public class MuseumTest
    {
        //Testing possible transfer between rooms
        [Fact]
        public void PossibleNavigation()
        {
            //arrange
            Museum TestMuseum = new Museum();

            Room entry = new Room("", 0);
            entry.AddDoors(0, 1, 0, 0);
            TestMuseum.AddRoomsToMuseum(entry);

            Room corridor = new Room("", 1);
            corridor.AddDoors(0, 3, 0, 1);
            TestMuseum.AddRoomsToMuseum(corridor);

            Room greenRoom = new Room("", 2);
            greenRoom.AddDoors(0, 9, 5, 3);
            TestMuseum.AddRoomsToMuseum(greenRoom);

            entry.currentLocation = true;

            //act
            TestMuseum.PossibleTransfer(TestMuseum, entry, 1);
            
            //assert
            Assert.True(corridor.currentLocation);
        }

        //Testing that it's not possible to "teleport" between rooms
        [Fact]
        public void ImpossibleNavigation()
        {
            //arrange
            Museum TestMuseum = new Museum();

            Room entry = new Room("", 0);
            entry.AddDoors(0, 1, 0, 0);
            TestMuseum.AddRoomsToMuseum(entry);

            Room corridor = new Room("", 1);
            corridor.AddDoors(0, 3, 0, 1);
            TestMuseum.AddRoomsToMuseum(corridor);

            Room greenRoom = new Room("", 2);
            greenRoom.AddDoors(0, 9, 5, 3);
            TestMuseum.AddRoomsToMuseum(greenRoom);

            entry.currentLocation = true;

            //act
            TestMuseum.PossibleTransfer(TestMuseum, entry, 3);
            
            //assert
            Assert.False(greenRoom.currentLocation);
            Assert.False(corridor.currentLocation);
        }

        //Testing if it's possible to add a collection of art to the museeum
        [Fact]
        public void AddCollectionOfArtToMuseum()
        {
            //arrange
            Museum TestMuseum = new Museum();
            var expected = 11;

            //act
            TestMuseum.AddArtCollection();
            var actual = TestMuseum.museumArts.Count;

            //assert
            Assert.Equal(expected, actual);
        }

        //Testing to add art to from the museumscollection to a room
        [Fact]
        public void AddArtToRoom()
        {
            //arrange
            Museum TestMuseum = new Museum();
            TestMuseum.AddArtCollection();

            Room redRoom = new Room("", 3);
            TestMuseum.AddRoomsToMuseum(redRoom);
            var expected = 3;

            //act
            redRoom.AddArtToRoom(TestMuseum.museumArts, 2, 3, 4);
            var actual = redRoom.arts.Count;

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
