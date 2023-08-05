namespace Server.Entities
{
    public class SimpleDepartureBoard
    {
        public string Location { get; set; }
        public List<DepartureDetails> Departures { get; set; } = new List<DepartureDetails>();


        public SimpleDepartureBoard(string location, List<DepartureDetails> departures) => 
            (Location, Departures) = (location, departures);

    }
}