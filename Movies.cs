using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesApp
{   
    class Movie
    {
        private string name;
        private string genre;
        private int length;
        private int yearOfPremiere;

        public Movie(string name,string genre,int length,int yearOfPremiere)
        {
            Name = name;
            Genre = genre;
            Length = length;
            YearOfPremiere = yearOfPremiere;

        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length == 0)
                    throw new Exception("Ime ne može biti prazno");

                name = value;
            }
        }

      
        public string Genre
        {
           get
            {
                return genre;
            }
            set
            {
                    genre = value;
            }
        }
        public int Length
        {
            set
            {
                if (value.Equals(0) || value < 1 || value > 450)
                    throw new Exception("Duzina filma bi trebala biti izmedju 1 i 450 min");
                
                length = value;
            }
            get
            {
                return length;
            }
        }
        public int YearOfPremiere
        {
            set
            {
                if (value.Equals(0) || value < 1900 || value > DateTime.Now.Year)
                    throw new Exception("Unesite godinu izmedju 1900 i trenutne godine");
                yearOfPremiere = value;
            }
            get
            { 
                 return yearOfPremiere;
            }
        }
        public override string ToString()
        {
            return Name + " " + "(" + YearOfPremiere + ")";
        }

        public string Serialize()
        {
            return Name + '|' + Genre + '|' + Length + '|' + YearOfPremiere;
        }

        public static Movie Deserialize(string serialized)
        {
            string[] parts = serialized.Split('|');

            string Name = parts[0];
            string Genre = parts[1];
            int Length = Int16.Parse(parts[2]);
            int YearOfPremiere = Int16.Parse(parts[3]);

            return new Movie(Name, Genre, Length, YearOfPremiere);
        }

    }
}
