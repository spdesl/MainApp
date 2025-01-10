
using System.Reflection.Metadata;
using bussiness.Dtos;
using bussiness.models;

namespace bussiness.interfaces;

public interface IFileService
{
bool SaveContentToFile (string content);

string GetContentFromFile();
}
  
public interface IUserService
{
    bool Save(KontakRegistrationForm form);

    IEnumerable <User> GetAll();
} 