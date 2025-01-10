
namespace Test.Factories;

public class UserFactory_Tests
{
[Fact]
public void Create_ShouldReturnKontakRegistrationForm()
    {
        // Act
        var result = UserFactory.Create();

        //Assert
        Assert.NotNull(result);
        Assert.IsType<KontaktRegistrationForm>(result);
    }

public void Create_ShouldReturnUser_WhenKontakRegistrationFormIsProvided()
    {

        // Arrange
        var KontaktRegistrationForm = new KontaktRegistrationForm()
        {
            FörNamn = "David" ,
            EfterNamn = "Andersson" ,
            Epost = "david.andersson@gmail.com" ,
            TelefonNummer = "0704748407" ,
            GatuAdress = "Sverkersvägen 4" , 
            PostNummer = "17754" , 
            Ort = "Järfälla" , 
        };

        // Act
        var result = UserFactory.Create(KontaktRegistrationForm);

        //Assert
        Assert.NotNull(result);
        Assert.IsType<KUser>(result);
        Assert.Equal(KontaktRegistrationForm.FörNamn, result.FörNamn);
        Assert.Equal(KontaktRegistrationForm.EfterNamn, result.EfterNamn);
        Assert.Equal(KontaktRegistrationForm.Epost, result.Epost);
        Assert.Equal(KontaktRegistrationForm.TelefonNummer, result.TelefonNummer);
        Assert.Equal(KontaktRegistrationForm.GatuAdress, result.GatuAdress);
        Assert.Equal(KontaktRegistrationForm.PostNummer, result.PostNummer);
        Assert.Equal(KontaktRegistrationForm.Ort, result.Ort);
        

    }

}
