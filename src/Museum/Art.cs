namespace Museum
{
    public class Art
    {
        public int artId;
        public string title;
        public string description;
        public string artist;

        public Art(int artIdToSet, string titleToSet, string descriptionToSet)
        {
            artId = artIdToSet;
            title = titleToSet;
            description = descriptionToSet;
            artist = "Wivianne Grapenholt";
        }  
        //specify a unique collection of art and returning them in an array
        public static Art[] CollectionOfArt()
        {
            Art art1 = new Art(1, "Ångest", "Svart staty i järn föreställande en mans gestalt.");
            Art art2 = new Art(2, "Depression", "Svart oljemålning på duk.");
            Art art3 = new Art(3, "Glädje", "Vepa i klara färger.");
            Art art4 = new Art(4, "Sorg", "Landskap i gråskala, oljemålning på duk.");
            Art art5 = new Art(5, "Ilska", "Röd keramik skulptur med skarpa kanter.");
            Art art6 = new Art(6, "Rädsla", "Akvarellmålning av ett litet barn i fosterställning");
            Art art7 = new Art(7, "Skam", "Byst i gips föreställande en kvinna som gömmer ansiktet i sina händer.");
            Art art8 = new Art(8, "Skuld", "Oljemålning på duk föreställande en man bakom fängelsegaller.");
            Art art9 = new Art(9, "Ömhet", "Litografi som avbildar ett omfamnande par");
            Art art10 = new Art(10, "Ensamhet", "Blank duk med en liten prick i mitten.");
            Art art11 = new Art(11, "Gemenskap", "Akvarellmålning föreställande en livlig och varm sammankomst av människor.");

            Art[] artCollection= {art1, art2, art3, art4, art5, art6, art7, art8, art9, art10, art11};
            return artCollection;
        }
    }
}
