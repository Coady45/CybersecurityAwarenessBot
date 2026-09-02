using System;

namespace CybersecurityAwarenessBot
{
    public class Chatbot
    {


        public void Start(UserProfile user)
        {

            Responses responses = new Responses();


            Console.WriteLine();
            Console.WriteLine("Type 'exit' to close the chatbot.");


            while (true)
            {

                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.Write(user.Name + ": ");

                string input = Console.ReadLine().ToLower();


                Console.ResetColor();



                if (string.IsNullOrWhiteSpace(input))
                {

                    Console.WriteLine(
                    "Bot: Please type a question."
                    );

                    continue;

                }



                if (input == "exit")
                {

                    Console.WriteLine(
                    "Bot: Goodbye! Stay safe online."
                    );

                    break;

                }



                string answer = responses.GetResponse(input);


                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine(
                "Bot: " + answer
                );

                Console.ResetColor();


            }


        }


    }
}
