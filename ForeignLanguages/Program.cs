string country = Console.ReadLine().ToLower();
string language = string.Empty;

switch (country)
{
    case "england":
    case "usa":
        language = "English";
        break;
    case "spain":
    case "argentina":
    case "mexico":
        language = "Spanish";
        break;
    default:
        language = "unknown";
        break;
}

Console.WriteLine(language);
