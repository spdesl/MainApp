
using bussiness.factories;
using bussiness.interfaces;
using bussiness.services;

namespace presentaiton.consoleApp.Dialogs;

public class MenuDialogs
{
private readonly IUserService _userService = userService;

public void MainMenu()
{
 while(true)
 {
    Console.Clear();
    Console.WriteLine("*****Men Alternative*****");
    Console.WriteLine("1.Lägg till en ny kontakt");
    Console.WriteLine("2.Visa alla kontakter");
    Console.WriteLine("3.Välj ett alternative ");
    var option = Console.ReadLine()!;

   switch (option)
   {
    case "1":
        LäggTillKontakt();
        break;
    case "2":
        VisaKontakter();
        break;
    case "3":
         Console.WriteLine("Avsulta programmet!");
        break;
   
   } 
    
 }   
}

    public void LäggTillKontakt()
{
    var form = UserFactory.Create();

    Console.Clear();
    Console.WriteLine("===== Lägg till Ny Kontakt ======");
    Console.WriteLine("FörNamn: ");
    form.FörNamn = Console.ReadLine()!;
    Console.WriteLine("EfterNamn: ");
    form.EfterNamn = Console.ReadLine()!;
    Console.WriteLine("Epost: ");
    form.Epost = Console.ReadLine()!;
    Console.WriteLine("TelefonNummer: ");
    form.TelefoNnummer = Console.ReadLine()!;
    Console.WriteLine("GatuAdress: ");
    form.GatuAdress = Console.ReadLine()!;
    Console.WriteLine("PostNummer: ");
    form.PostNummer = Console.ReadLine()!;
    Console.WriteLine("Ort: ");
    form.Ort = Console.ReadLine()!;
    Console.WriteLine();

    var result = _userService.Save(form);
    if (result)
    Console.Write("Ny Kontakt tillagd!");
    else
    Console.WriteLine("Fel, försök igen! ");

    Console.ReadKey();
    
}
    public void VisaKontakter()
    {
      Console.Clear();
    Console.WriteLine("===== Visa alla kontakter ======"); 

    var users = _userService.GetAll();
    foreach (var user in users)
    {
        Console.WriteLine($"{user.FörNamn} {user.EfterNamn} {user.Epost} {user.TelefonNummer} {user.GatuAdress} {user.PostNummer} {user.Ort}> ");
    }
    Console.ReadKey();
    } 

   
}
