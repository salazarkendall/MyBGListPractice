using Microsoft.AspNetCore.Mvc;

namespace MyBGListPractice.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BoardGamesController : ControllerBase
    {
        private readonly ILogger<BoardGamesController> _logger;

        public BoardGamesController(ILogger<BoardGamesController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetBoardGames")]
        public IEnumerable<BoardGame> Get()
        {
            return new[]{
                new BoardGame() {
                    Id = 1,
                    MaxPlayers = 5,
                    MinPlayers = 2,
                    Name = "Catan",
                    Year = 1999

                },
                new BoardGame() {
                    Id = 1,
                    MaxPlayers = 8,
                    MinPlayers = 2,
                    Name = "Monopoly",
                    Year = 1980

                },
                new BoardGame() {
                    Id = 1,
                    MaxPlayers = 6,
                    MinPlayers = 2,
                    Name = "Exploding Kittens",
                    Year = 2012

                }
            };
        }
    }
}
