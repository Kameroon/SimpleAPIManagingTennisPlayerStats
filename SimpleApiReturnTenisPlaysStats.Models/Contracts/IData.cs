namespace SimpleApiReturnTenisPlaysStats.Models.Contracts
{
    public interface IData
    {
        int Rank { get; set; }
        int Points { get; set; }
        int Weight { get; set; }
        int Height { get; set; }
        int Age { get; set; }
        int[] Last { get; set; }
    }
}
