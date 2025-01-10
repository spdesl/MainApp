using System.Text.Json;
using bussiness.Dtos;
using bussiness.factories;
using bussiness.interfaces;
using bussiness.models;

namespace bussiness.services;

public class UserService(IFileService fileService) : IUserService
{
private readonly IFileService _fileService = fileService;
private List<User> _users = [];

public IEnumerable<User> GetAll()
{
    var content = _fileService.GetContentFromFile();
    try{
        _users = JsonSerializer.Deserialize<List<User>>(content)!;
    }
    catch{
        _users = [];
    }
    return _users;
}

public bool Save(KontakRegistrationForm form)
{
    var user = UserFactory.Create(form);
    _users.Add(user);

    var json = JsonSerializer.Serialize(_users);
    var result = _fileService.SaveContentToFile(json);
    return result;
}
}

