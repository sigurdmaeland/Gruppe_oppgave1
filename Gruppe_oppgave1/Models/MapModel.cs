namespace Gruppe_oppgave1.Models
{
    
    // Mapmodel klassen som definerer dataene for en kartposisjon
    public class MapModel
    {
        // Breddegradsposisjon på kartet
        public string Latitude { get; set; }
        
        // Lengdegradsposisjon på kartet
        public string Longitude { get; set; }
        
        // Beskrivelse 
        public string Description { get; set; }
    }
}
