using Core.Enums;

namespace Core.Generators;

public static class UniqueIdService
{
    public static string Generator(int maxLength = 10)
    {
        var allowedCharsURL = @"abcdefghijklmnopqrstuvwxyz1234567890/\=+*)(*&^%$#@!~`?><,.;:][{}|";
        //string allowedCharsURL = "abcdefghijklmnopqrstuvwxyz1234567890";
        //$-_.+!*'(),
        //unwise in URI      = "{" | "}" | "|" | "\" | "^" | "[" | "]" | "`"
        //reserved in URI    = ";" | "/" | "?" | ":" | "@" | "&" | "=" | "+" | "$" | ","
        var res = "";
        var rnd = new Random();
        while (0 < maxLength--)
            res += allowedCharsURL[rnd.Next(allowedCharsURL.Length)];
        return res;
    }
    public static string Generator(UniqueIdType type, int maxLength = 10)
    {
        var allowedCharsURL = @"abcdefghijklmnopqrstuvwxyz1234567890";
        //string allowedCharsURL = "abcdefghijklmnopqrstuvwxyz1234567890";
        //$-_.+!*'(),
        //unwise in URI      = "{" | "}" | "|" | "\" | "^" | "[" | "]" | "`"
        //reserved in URI    = ";" | "/" | "?" | ":" | "@" | "&" | "=" | "+" | "$" | ","
        var res = "";
        var rnd = new Random();
        while (0 < maxLength--)
            res += allowedCharsURL[rnd.Next(allowedCharsURL.Length)];
        return $"{type}_{res}";
    }
}