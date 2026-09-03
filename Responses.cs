namespace CybersecurityAwarenessBot
{
    public class Responses
    {


        public string GetResponse(string input)
        {

            if (input.Contains("password"))
            {
                return "Use strong passwords with uppercase letters, numbers and symbols. Never reuse passwords.";
            }


            if (input.Contains("phishing"))
            {
                return "Phishing is when criminals trick you into giving personal information. Always check suspicious emails.";
            }


            if (input.Contains("link"))
            {
                return "Do not click unknown links. Check the website address before entering information.";
            }


            if (input.Contains("safe browsing"))
            {
                return "Use trusted websites, avoid suspicious downloads and keep your browser updated.";
            }


            if (input.Contains("purpose"))
            {
                return "My purpose is to teach people about cybersecurity awareness.";
            }


            if (input.Contains("how are you"))
            {
                return "I am working perfectly and ready to protect you online.";
            }


            return "I didn't understand that. Try asking about passwords, phishing or safe browsing.";

        }


    }
} 