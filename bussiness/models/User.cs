
using bussiness.Helpers;

namespace bussiness.models;

public class User
{
    public string FörNamn { get; set; } = null!;

    public string EfterNamn { get; set; } = null!;

    public string Epost { get; set; } = null!;

    public string TelefonNummer { get; set; } = null!;

    public string GatuAdress { get; set; } = null!;

    public string PostNummer { get; set; } = null!;

    public string Ort { get; set; } = null!;

    public string Id { get; set; } = IdGenerator.Generate()!;

    
    
}
