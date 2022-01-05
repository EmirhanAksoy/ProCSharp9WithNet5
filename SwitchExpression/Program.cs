using System;

string name = "Loki";

switch (name)
{
    case "Loki":
        {
            Console.WriteLine($"My name is {name}");
            break;
        }
    case "Borc":
        {
            Console.WriteLine($"My name is Loki, just {name}");
            break;
        }

    default: break;
}

/// <summary>
/// Switch expression with string
/// </summary>
static string GetCatMessage(string catName)
{
    return catName switch
    {
        "Loki" => "I am Loki",
        "Borc" => "I am Borc",
        _ => "I am not a cat !"
    };
}

string message = GetCatMessage("Borc");

Console.WriteLine(message);

/// <summary>
/// Switch expression with Tuple
/// </summary>
static string GetRockPaperScissorsResult(string first,string second)
{
    return (first, second) switch
    {
        ("rock","paper") => "Paper wins",
        ("rock", "scissors") => "Rock wins",
        ("paper", "rock") => "Paper wins",
        ("paper", "scissors") => "Scissors wins",
        ("scissors", "rock") => "Rock wins",
        ("scissors", "paper") => "Scissors wins",
        _=> "No winner !",

    };
}


string gameResult = GetRockPaperScissorsResult("rock", "paper");

Console.WriteLine(gameResult);






