namespace NZWalks.API.Model.Domain
{
    public class Walks
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public double Length { get; set; }
        public Guid RegionId { get; set; }
        public Guid WalkDifficultyId { get; set; }

        //Navigration Property
        public Region Region { get; set; }
        public WalkDifficulty WalkDifficulty { get; set; }
    }
}
