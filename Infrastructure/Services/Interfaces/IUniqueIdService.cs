namespace Infrastructure.Services.Interfaces;

public interface IUniqueIdService
{
    string Generator(int maxLength = 10);
}