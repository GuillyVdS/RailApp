namespace Server.Entities
{
    public class DepartureDetails
    {
        public string DepartureTime { get; set; }

        public string Destination { get; set; }

        public string Platform { get; set; }    

        public string ExpectedTime { get; set; }

        public DepartureDetails(string departuretime, string destination, string platform, string expectedtime) =>
            (DepartureTime, Destination, Platform, ExpectedTime)  
        =   (departuretime, destination, platform, expectedtime);
    }
}