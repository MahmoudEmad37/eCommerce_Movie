using eTickets.Data.Base;
using eTickets.Data.ViewModels;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public class MoviesService : EntityBaseRepository<Movie>, IMoviesService
    {
        private readonly AppDbContext _context;
        public MoviesService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task AddNewMovieAsync(NewMovieVM data)
        {
            var newMovie = new Movie()
            {
                name = data.Name,
                desciption = data.Description,
                price = data.Price,
                imageUrl = data.ImageURL,
                cinemaId = data.CinemaId,
                startTime = data.StartDate,
                endTime = data.EndDate,
                movieCategory = data.MovieCategory,
                producerId = data.ProducerId
            };
            await _context.Movies.AddAsync(newMovie);
            await _context.SaveChangesAsync();

            //Add Movie Actors
            foreach (var actorId in data.ActorIds)
            {
                var newActorMovie = new Actor_Movie()
                {
                    movieId = newMovie.id,
                    actorId = actorId
                };
                await _context.Actors_Movies.AddAsync(newActorMovie);
            }
            await _context.SaveChangesAsync();
        }

        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            var movieDetails = await _context.Movies
                .Include(c => c.cinema)
                .Include(p => p.producer)
                .Include(am => am.actors_movies).ThenInclude(a => a.actor)
                .FirstOrDefaultAsync(n => n.id == id);

            return movieDetails;
        }

        public async Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues()
        {
            var response = new NewMovieDropdownsVM()
            {
                Actors = await _context.Actors.OrderBy(n => n.name).ToListAsync(),
                Cinemas = await _context.Cinemas.OrderBy(n => n.name).ToListAsync(),
                Producers = await _context.Producers.OrderBy(n => n.name).ToListAsync()
            };

            return response;
        }

        public async Task UpdateMovieAsync(NewMovieVM data)
        {
            var dbMovie = await _context.Movies.FirstOrDefaultAsync(n => n.id == data.Id);

            if(dbMovie != null)
            {
                dbMovie.name = data.Name;
                dbMovie.desciption = data.Description;
                dbMovie.price = data.Price;
                dbMovie.imageUrl = data.ImageURL;
                dbMovie.cinemaId = data.CinemaId;
                dbMovie.startTime = data.StartDate;
                dbMovie.endTime = data.EndDate;
                dbMovie.movieCategory = data.MovieCategory;
                dbMovie.producerId = data.ProducerId;
                await _context.SaveChangesAsync();
            }

            //Remove existing actors
            var existingActorsDb = _context.Actors_Movies.Where(n => n.movieId == data.Id).ToList();
            _context.Actors_Movies.RemoveRange(existingActorsDb);
            await _context.SaveChangesAsync();

            //Add Movie Actors
            foreach (var actorId in data.ActorIds)
            {
                var newActorMovie = new Actor_Movie()
                {
                    movieId = data.Id,
                    actorId = actorId
                };
                await _context.Actors_Movies.AddAsync(newActorMovie);
            }
            await _context.SaveChangesAsync();
        }
    }
}
