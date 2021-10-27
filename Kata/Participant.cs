using System;
using System.Linq;

namespace Kata
{
    public class Participant
    {
        private string city;
        private string name;

        public string RegistrationNumber { get; set; }


        public string Country { get; set; }


        public string City
        {
            get => city;
            set
            {
                ValidateCity(value);
                city = value;
            }
        }

        public int ZipCode { get; set; }


        public int TelephoneNumber { get; set; }


        public string Name
        {
            get => name;
            set
            {
                ValidateName(value);
                name = FormatName(value);
            }
        }

        private void ValidateCity(string cityName)
        {
            var symbols = "#";
            if (cityName.Contains(symbols))
                throw new ArgumentException();
        }


        private static void ValidateName(string name)
        {
            var validCharacters = "abcdefghijklmnopqrstuvxyzæøå- ";
            if (string.IsNullOrEmpty(name)) throw new ArgumentException("Name must not be empty");

            foreach (var currentChar in name.ToLower())
                if (!validCharacters.Contains(currentChar))
                    throw new ArgumentException("Name must not contain digits or symbols");
        }

        private string FormatName(string value)
        {
            var firstLetterInName = true;
            var validCharacters = "- ";
            var valueCharArray = value.ToCharArray();

            for (var i = 0; i < valueCharArray.Length; i++)
                if (firstLetterInName)
                {
                    valueCharArray[i] = char.ToUpper(valueCharArray[i]);
                    firstLetterInName = false;
                }
                else if (validCharacters.Contains(valueCharArray[i]))
                {
                    firstLetterInName = true;
                }
                else
                {
                    valueCharArray[i] = char.ToLower(valueCharArray[i]);
                }

            return new string(valueCharArray);
        }
    }
}