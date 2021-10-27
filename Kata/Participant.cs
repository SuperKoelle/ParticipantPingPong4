﻿using System;
using System.Linq;

namespace Kata
{
    public class Participant
    {
        private string name;
        private int telephoneNumber;
        private int zipCode;
        private string city;
        private string country;
        private string registreringsNumber;

        public string RegistrationNumber
        {
            get { return registreringsNumber; }
            set { registreringsNumber = value; }
        }


        public string Country
        {
            get { return country; }
            set { country = value; }
        }


        public string City
        {
            get { return city; }
            set 
            {
                ValidateCity(value);
                city = value; 
            }
        }

        private void ValidateCity(string cityName)
        {
            var symbols = "#";
            if (cityName.Contains(symbols))
            throw new ArgumentException();
        }

        public int ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }


        public int TelephoneNumber
        {
            get { return telephoneNumber; }
            set { telephoneNumber = value; }
        }


        public string Name
        {
            get { return name; }
            set
            {
                ValidateName(value);
                name = value;
            }
        }

        private static void ValidateName(string name)
        {
            string validCharacters = "abcdefghijklmnopqrstuvxyzæøå";
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name must not be empty");
            }

            foreach (char currentChar in name.ToLower())
            {
               
                if (!validCharacters.Contains(currentChar))
                    throw new ArgumentException("Name must not contain digits or symbols");
            }
        }
    }
}
