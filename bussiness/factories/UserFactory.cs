
using bussiness.Dtos;
using bussiness.models;

namespace bussiness.factories;

public static class UserFactory
{
public static KontakRegistrationForm Create() => new();

public static User Create(KontakRegistrationForm form) => new()
{
    FörNamn = form.FörNamn,
    EfterNamn = form.EfterNamn,
    Epost = form.Epost,
    TelefonNummer = form.TelefoNnummer,
    GatuAdress = form.GatuAdress,
    PostNummer = form.PostNummer,
    Ort = form.Ort,
    Id = form.Id,
    
};
}
