using Microsoft.AspNetCore.Mvc;

namespace modul9_103082400005.Controllers
{
    [ApiController]
    [Route("api/movies")]
    public class MovieController : ControllerBase
    {
        private static List<Movie> movieList = new List<Movie>
        {
            new Movie(
                "The Shawshank Redemption",
                "Frank Darabont",
                new List<string> { "Tim Robbins", "Morgan Freeman", "Bob Gunton" },
                "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency."
            ),

            new Movie(
                "The Godfather",
                "Francis Ford Coppola",
                new List<string> { "Marlon Brando", "Al Pacino", "James Caan" },
                "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son."
            ),

            new Movie(
                "The Dark Knight",
                "Christopher Nolan",
                new List<string> { "Christian Bale", "Heath Ledger", "Aaron Eckhart" },
                "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice."
            )
        };

        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return movieList;
        }

        [HttpGet("{id}")]
        public Movie Get(int id)
        {
            return movieList[id];
        }

        [HttpPost]
        public void Post([FromBody] Movie movieBaru)
        {
            movieList.Add(movieBaru);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            if (id >= 0 && id < movieList.Count)
            {
                movieList.RemoveAt(id);
            }
        }
    }
}
