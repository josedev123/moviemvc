using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CoreNotes;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using moviemvc.Data;
using moviemvc.Dtos;
using moviemvc.Models;

namespace moviemvc.Controllers
{
    [Route("api/[controller]")]
    public class ApiMoviesController: Controller
    {
        private ApplicationDbContext _context;
        public ApiMoviesController(ApplicationDbContext context)
        {
           _context = context;

        }

        //GET /api/apimovies
        [HttpGet]
        public ActionResult<MovieDto> GetMovies()
        {
            var movieDtos = _context.Movies.ToList().Select(Mapper.Map<Movie, MovieDto>);

            return Ok(movieDtos);
        }

        //GET /api/apimovies/1
        [HttpGet("{id}")]
        public ActionResult<MovieDto> GetMovie(int id)
        {
            var movieDto = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (movieDto == null)
                return NotFound();

            return Ok(Mapper.Map<Movie, MovieDto>(movieDto));
        }

                //POST /api/apicustomers/
        [HttpPost]
        public ActionResult<MovieDto> PostCustomer([FromBody] MovieDto movieDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var movie = Mapper.Map<MovieDto, Movie>(movieDto);
            _context.Movies.Add(movie);
            _context.SaveChanges();

            movieDto.Id = movie.Id;
            return Created(new Uri(Request.GetDisplayUrl() + movie.Id), movieDto);
        }

        [HttpPut("{id}")]
        public ActionResult PutMovie(int id, [FromBody] MovieDto movieDto)
        {
            if(!ModelState.IsValid)
                return BadRequest();

            var movieInDb = _context.Movies.SingleOrDefault(c => c.Id ==id);

            if(movieInDb == null)
            return NotFound();

            Mapper.Map(movieDto, movieInDb);


            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteMovie(int id)
        {

            var movieInDb = _context.Movies.SingleOrDefault(c => c.Id ==id);

            if(movieInDb == null)
            return NotFound();

            _context.Movies.Remove(movieInDb);
            _context.SaveChanges();

            return Ok();
        }


    }
}