using SabalanTracking.Models;

namespace SabalanTracking.Helper
{
    public static class SnGenerator
    {
        public static string GenerateSN(Proces proces)
        {
            string SN = "";
            Char RndChar = GenerateRandomChar();
            SN = string.Concat("AB", proces.Id, proces.DeviceId, proces.ProcessNameId, proces.DateTime.Replace("/",""), proces.MaterialId, RndChar);
            return SN;
        }

        static char GenerateRandomChar()
        {
            Random random = new Random();
            // Generate a random number between ASCII values for 'A' (65) and 'Z' (90).
            int randomAsciiValue = random.Next(65, 91);
            // Convert the ASCII value to a character.
            char randomChar = (char)randomAsciiValue;
            return randomChar;
        }
    }
}
