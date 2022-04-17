using System;
using System.Collections.Generic;
using System.Linq;
using MovieStoreApp.MVC.Models;
namespace MovieStoreApp.MVC.Repository
{
    public class MovieRepository
    {

        List<MovieModel> movies;
        public MovieRepository()
        {
            movies = new List<MovieModel>
            {
                new MovieModel()
                {
                    Id = 1,
                    Title = "Demo1",
                    ReleaseDate = "11/25/1997",
                    PosterUrl = "https://m.media-amazon.com/images/M/MV5BMjI0NmFkYzEtNzU2YS00NTg5LWIwYmMtNmQ1MTU0OGJjOTMxXkEyXkFqcGdeQXVyMjMxOTE0ODA@._V1_.jpg",
                    Duration = 165,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. "

                },

                new MovieModel()
                {
                    Id = 2,
                    Title = "Fast & Furious",
                    ReleaseDate = "11/25/1997",
                    PosterUrl = "https://m.media-amazon.com/images/M/MV5BMjI0NmFkYzEtNzU2YS00NTg5LWIwYmMtNmQ1MTU0OGJjOTMxXkEyXkFqcGdeQXVyMjMxOTE0ODA@._V1_.jpg",
                    Duration = 165,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. "


                },


                new MovieModel()
                {
                    Id = 3,
                    Title = "Interstellar",
                    ReleaseDate = "11/25/1997",
                    PosterUrl = "https://m.media-amazon.com/images/M/MV5BMjI0NmFkYzEtNzU2YS00NTg5LWIwYmMtNmQ1MTU0OGJjOTMxXkEyXkFqcGdeQXVyMjMxOTE0ODA@._V1_.jpg",
                    Duration = 165,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. "


                },

                new MovieModel()
                {
                    Id = 4,
                    Title = "Harry Potter",
                    ReleaseDate = "11/25/1997",
                    PosterUrl = "https://m.media-amazon.com/images/M/MV5BMjI0NmFkYzEtNzU2YS00NTg5LWIwYmMtNmQ1MTU0OGJjOTMxXkEyXkFqcGdeQXVyMjMxOTE0ODA@._V1_.jpg",
                    Duration = 165,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. "


                },

                new MovieModel()
                {
                    Id = 5,
                    Title = "Enter The Dragon",
                    ReleaseDate = "11/25/1997",
                    PosterUrl = "https://m.media-amazon.com/images/M/MV5BMjI0NmFkYzEtNzU2YS00NTg5LWIwYmMtNmQ1MTU0OGJjOTMxXkEyXkFqcGdeQXVyMjMxOTE0ODA@._V1_.jpg",
                    Duration = 165,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. "


                }
            };
        }

        public IEnumerable<MovieModel> movieList()
        {
            return movies;
        }



        //next method for details

        public MovieModel find(int Id)
        {
            return movies.Where(x => x.Id == Id).FirstOrDefault();
        }


    }
      
    
}
