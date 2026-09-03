using CybersecurityAwarenessBot;
using System;
using System.IO;
using System.Media;

Console.Title = "Cybersecurity Awareness Bot";



try
{
    SoundPlayer player = new SoundPlayer("Resources/VoiceGreeting.wav");
    player.PlaySync();
}
catch
{
    Console.WriteLine("Voice greeting not found.");
}



try
{
    string logo = File.ReadAllText("Resources/ascii-logo.txt");
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine(logo);
    Console.ResetColor();
}
catch
{
    Console.WriteLine("Logo not found.");
}


Console.WriteLine("--------------------------------");
Console.WriteLine(" Cybersecurity Awareness Bot ");
Console.WriteLine("--------------------------------");


UserProfile user = new UserProfile();


Console.Write("Enter your name: ");
user.Name = Console.ReadLine();


Console.WriteLine(
    $"Welcome {user.Name}! I am here to help you stay safe online."
);


Chatbot chatbot = new Chatbot();

chatbot.Start(user); 
