using eTickets.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinemas
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            name = "Cinema 1",
                            logoUrl = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            description = "This is the desciption of the first cinema"
                        },
                        new Cinema()
                        {
                            name = "Cinema 2",
                            logoUrl = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            description = "This is the desciption of the first cinema"
                        },
                        new Cinema()
                        {
                            name = "Cinema 3",
                            logoUrl = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            description = "This is the desciption of the first cinema"
                        },
                        new Cinema()
                        {
                            name = "Cinema 4",
                            logoUrl = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            description = "This is the desciption of the first cinema"
                        },
                        new Cinema()
                        {
                            name = "Cinema 5",
                            logoUrl = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            description = "This is the desciption of the first cinema"
                        },
                    });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            name = "Actor 1",
                            bio = "This is the bio of the first actor",
                            profilePictureUrl = "http://dotnethow.net/images/actors/actor-1.jpeg"

                        },
                        new Actor()
                        {
                            name = "Actor 2",
                            bio = "This is the bio of the second actor",
                            profilePictureUrl = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new Actor()
                        {
                            name = "Actor 3",
                            bio = "This is the bio of the second actor",
                            profilePictureUrl = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new Actor()
                        {
                            name = "Actor 4",
                            bio = "This is the bio of the second actor",
                            profilePictureUrl = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new Actor()
                        {
                            name = "Actor 5",
                            bio = "This is the bio of the second actor",
                            profilePictureUrl = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            name = "Producer 1",
                            bio = "This is the bio of the first actor",
                            profilePictureUrl = "http://dotnethow.net/images/producers/producer-1.jpeg"

                        },
                        new Producer()
                        {
                            name = "Producer 2",
                            bio = "This is the bio of the second actor",
                            profilePictureUrl = "http://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                        new Producer()
                        {
                            name = "Producer 3",
                            bio = "This is the bio of the second actor",
                            profilePictureUrl = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                        new Producer()
                        {
                            name = "Producer 4",
                            bio = "This is the bio of the second actor",
                            profilePictureUrl = "http://dotnethow.net/images/producers/producer-4.jpeg"
                        },
                        new Producer()
                        {
                            name = "Producer 5",
                            bio = "This is the bio of the second actor",
                            profilePictureUrl = "http://dotnethow.net/images/producers/producer-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            name = "Life",
                            desciption = "This is the Life movie desciption",
                            price = 39.50,
                            imageUrl = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            startTime = DateTime.Now.AddDays(-10),
                            endTime = DateTime.Now.AddDays(10),
                            cinemaId = 3,
                            producerId = 3,
                            movieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            name = "The Shawshank Redemption",
                            desciption = "This is the Shawshank Redemption desciption",
                            price = 29.50,
                            imageUrl = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            startTime = DateTime.Now,
                            endTime = DateTime.Now.AddDays(3),
                            cinemaId = 1,
                            producerId = 1,
                            movieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            name = "Ghost",
                            desciption = "This is the Ghost movie desciption",
                            price = 39.50,
                            imageUrl = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            startTime = DateTime.Now,
                            endTime = DateTime.Now.AddDays(7),
                            cinemaId = 4,
                            producerId = 4,
                            movieCategory = MovieCategory.Horror
                        },
                        new Movie()
                        {
                            name = "Race",
                            desciption = "This is the Race movie desciption",
                            price = 39.50,
                            imageUrl = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            startTime = DateTime.Now.AddDays(-10),
                            endTime = DateTime.Now.AddDays(-5),
                            cinemaId = 1,
                            producerId = 2,
                            movieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            name = "Scoob",
                            desciption = "This is the Scoob movie desciption",
                            price = 39.50,
                            imageUrl = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            startTime = DateTime.Now.AddDays(-10),
                            endTime = DateTime.Now.AddDays(-2),
                            cinemaId = 1,
                            producerId = 3,
                            movieCategory = MovieCategory.Cartoon
                        },
                        new Movie()
                        {
                            name = "Cold Soles",
                            desciption = "This is the Cold Soles movie desciption",
                            price = 39.50,
                            imageUrl = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            startTime = DateTime.Now.AddDays(3),
                            endTime = DateTime.Now.AddDays(20),
                            cinemaId = 1,
                            producerId = 5,
                            movieCategory = MovieCategory.Drama
                        }
                    });
                    context.SaveChanges();
                }
                //Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            actorId = 1,
                            movieId = 1
                        },
                        new Actor_Movie()
                        {
                            actorId = 3,
                            movieId = 1
                        },

                         new Actor_Movie()
                        {
                            actorId = 1,
                            movieId = 2
                        },
                         new Actor_Movie()
                        {
                            actorId = 4,
                            movieId = 2
                        },

                        new Actor_Movie()
                        {
                            actorId = 1,
                            movieId = 3
                        },
                        new Actor_Movie()
                        {
                            actorId = 2,
                            movieId = 3
                        },
                        new Actor_Movie()
                        {
                            actorId = 5,
                            movieId = 3
                        },


                        new Actor_Movie()
                        {
                            actorId = 2,
                            movieId = 4
                        },
                        new Actor_Movie()
                        {
                            actorId = 3,
                            movieId = 4
                        },
                        new Actor_Movie()
                        {
                            actorId = 4,
                            movieId = 4
                        },


                        new Actor_Movie()
                        {
                            actorId = 2,
                            movieId = 5
                        },
                        new Actor_Movie()
                        {
                            actorId = 3,
                            movieId = 5
                        },
                        new Actor_Movie()
                        {
                            actorId = 4,
                            movieId = 5
                        },
                        new Actor_Movie()
                        {
                            actorId = 5,
                            movieId = 5
                        },


                        new Actor_Movie()
                        {
                            actorId = 3,
                            movieId = 6
                        },
                        new Actor_Movie()
                        {
                            actorId = 4,
                            movieId = 6
                        },
                        new Actor_Movie()
                        {
                            actorId = 5,
                            movieId = 6
                        },
                    });
                    context.SaveChanges();
                }
            }

        }

      /*  public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {

                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string adminUserEmail = "admin@etickets.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        name = "Admin User",
                        Username = "admin-user",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }


                string appUserEmail = "user@etickets.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        name = "Application User",
                        Username = "app-user",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }*/
    }
}