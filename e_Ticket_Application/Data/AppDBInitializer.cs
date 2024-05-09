using e_Ticket_Application.Data.Enum;
using e_Ticket_Application.Models;
using Microsoft.EntityFrameworkCore;

namespace e_Ticket_Application.Data
{
    public class AppDBInitializer
    {
        public static void Seeding(IApplicationBuilder applicationBuilder)
        {
            using (var ServiceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = ServiceScope.ServiceProvider.GetService<AppDBContext>();
                context.Database.EnsureCreated();

                //cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>
                    {
                        new Cinema
                        {
                            Name = "PVR: INOX",
                            Logo = "",
                            Description = "Megaplex Mall of Asia Bangalore"
                        },
                        new Cinema
                        {
                            Name = "PVR: Gopalan Grand Mall",
                            Logo = "",
                            Description = "Old Madras Road"
                        },
                        new Cinema
                        {
                            Name = "PVR: Global Mall",
                            Logo = "",
                            Description = "Mysore Road, Bengaluru"
                        },
                        new Cinema
                        {
                            Name = "PVR: Orion Mall",
                            Logo = "",
                            Description = ",Dr Rajkumar Road"
                        },
                        new Cinema
                        {
                            Name = "PVR: Vega City",
                            Logo = "",
                            Description = "Bannerghatta Road"
                        },


                    });
                    context.SaveChanges();
                }

                //actor
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>
                    {
                        new Actor
                        {
                            ProfilePictureUrl = "https://in.bookmyshow.com/person/ryan-gosling/25971",
                            FullName = "Harriet Slater",
                            Bio = ""
                        },
                        new Actor
                        {
                            ProfilePictureUrl = "",
                            FullName = "Adain Bradley",
                            Bio = ""
                        },
                        new Actor
                        {
                            ProfilePictureUrl = "",
                            FullName = "Jacob Batalon",
                            Bio = ""
                        },
                        new Actor
                        {
                            ProfilePictureUrl = "https://in.bookmyshow.com/person/ryan-gosling/25971",
                            FullName = "Ryan Gosling",
                            Bio = ""
                        },
                        new Actor
                        {
                            ProfilePictureUrl = "https://in.bookmyshow.com/bengaluru/movies/the-fall-guy/ET00375399#",
                            FullName = "Stephanie Hsu",
                            Bio = ""
                        },
                    });
                    context.SaveChanges();
                }

                //producer
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>
                    {
                        new Producer
                        {
                            ProfilePictureUrl = "",
                            FullName = "Rebecca Huntley",
                            Bio = ""
                        },
                        new Producer
                        {
                            ProfilePictureUrl = "",
                            FullName = "Manjot Singh",
                            Bio = ""
                        },
                        new Producer
                        {
                            ProfilePictureUrl = "",
                            FullName = "Raman Singh",
                            Bio = ""
                        },
                        new Producer
                        {
                            ProfilePictureUrl = "",
                            FullName = "Kulinder Kaur",
                            Bio = ""
                        },
                        new Producer
                        {
                            ProfilePictureUrl = "",
                            FullName = "Jasleen Kaur",
                            Bio = ""
                        },
                    });
                    context.SaveChanges();
                }


                //movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>
                    {
                        new Movie
                        {
                            Name = "Kingdom of the Planet of the Apes",
                            Price = 500.0,
                            Description = "Set several generations in the future following Caesar`s reign, where apes are the dominant species living harmoniously and humans have been reduced to living in the shadows.",
                            ImageUrl = "",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-1),
                            CinemaId = 3,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Drama,
                        },
                        new Movie
                        {
                            Name = "Kung Fu Panda 4",
                            Price = 500.0,
                            Description = "Po faces his greatest challenge yet when he ventures to the big city and meets a new villain called the Chameleon.",
                            ImageUrl = "",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-1),
                            CinemaId = 5,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Drama,
                        },
                        new Movie
                        {
                            Name = "Kung Fu Panda 3",
                            Price = 500.0,
                            Description = "Po faces his greatest challenge yet when he ventures to the big city and meets a new villain called the Chameleon.",
                            ImageUrl = "",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-1),
                            CinemaId = 5,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Drama,
                        },
                        new Movie
                        {
                            Name = "Kung Fu Panda 4",
                            Price = 500.0,
                            Description = "Po faces his greatest challenge yet when he ventures to the big city and meets a new villain called the Chameleon.",
                            ImageUrl = "",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-1),
                            CinemaId = 5,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Drama,
                        },


                    });
                    context.SaveChanges();
                }


                //actors & movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>
                    {
                        new Actor_Movie
                        {
                            ActorId = 1,
                            MovieId = 2,
                        },
                        new Actor_Movie
                        {
                            ActorId = 3,
                            MovieId = 3,
                        },
                        new Actor_Movie
                        {
                            ActorId = 4,
                            MovieId = 1,
                        },
                        new Actor_Movie
                        {
                            ActorId = 5,
                            MovieId = 4,
                        },
                        new Actor_Movie
                        {
                            ActorId = 2,
                            MovieId = 3,
                        },
                    });
                    context.SaveChanges();
                }



            }
        }
    }
}
