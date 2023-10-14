namespace MyBrewBookApi.Models
{
    public class Receipts
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int AutorId { get; set; }
        public string? AutorName { get; set; }
        public string? Image { get; set; }
        public int ClassificationRecipes { get; set; }
        public int StyleId { get; set; }
        public Boolean AutoScaling { get; set; }
    }
}
