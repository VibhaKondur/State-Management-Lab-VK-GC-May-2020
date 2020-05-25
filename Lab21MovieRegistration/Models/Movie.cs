using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab21MovieRegistration.Models
{
    public class Movie
    {
        //1. Create a Movie model with the following properties:
        //ID
        //Title
        //Genre
        //Year
        //Actors
        //Directors
        //Add a 

        public int ID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }

        public int Runtime { get; set; }
        public int ReleaseYear { get; set; }
        public double RentalCost { get; set; }

        public Movie()
        {

        }

        public Movie(int id, string title, string genre, int runtime, int releaseYear,  double rentalCost)
        {
            ID = id;
            Title = title;
            Genre = genre;
            Runtime = runtime;
            ReleaseYear = releaseYear;
            RentalCost = rentalCost;
        }
    }
}
