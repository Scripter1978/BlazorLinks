using Infrastructure.Services.Interfaces;

namespace Infrastructure.Services;

public class UniqueIdService : IUniqueIdService
{
    // Create a url id short generator
    public string Generator(int maxLength = 10)
    {
        string allowedCharsURL = "abcdefghijklmnopqrstuvwxyz1234567890";
        //$-_.+!*'(),
        //unwise in URI      = "{" | "}" | "|" | "\" | "^" | "[" | "]" | "`"
        //reserved in URI    = ";" | "/" | "?" | ":" | "@" | "&" | "=" | "+" | "$" | ","
        string res = "";
        Random rnd = new Random();
        while (0 < maxLength--)
            res += allowedCharsURL[rnd.Next(allowedCharsURL.Length)];
        return res;
    }
}