namespace Models
{
    public class Team
    {
        public int ID { get; set; }

        public string TeamName { get; set; }

        public string TeamCity { get; set; }

        public int Wins { get; set; }

        public int Losses { get; set; }

        public int Draws { get; set; }
    }
}