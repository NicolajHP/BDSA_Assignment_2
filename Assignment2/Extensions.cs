namespace Assignment2;
using System.Text.RegularExpressions;

public static class Extensions
{
    public static bool isSecure(this Uri uri) => uri.Scheme == "https";
    

    public static int WordCount(this string text) => Regex.Replace(text, @"[^a-zA-Z ]", "").Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Length;
    } 
