using SimpleApiReturnTenisPlaysStats.Models.Implementations;

namespace SimpleApiReturnTenisPlaysStats.Models.Contracts
{
    public interface ITenisPlayer
    {
        Country Country { get; set; }
        Data Data { get; set; }
        string FirstName { get; set; }
        int Id { get; set; }
        string LastName { get; set; }
        string Sex { get; set; }
        string ShortName { get; set; }
    }
}
