using Jaguars.Test.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Jaguars.Test.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			IEnumerable<PlayerModel> players = PlayerModelFactory.GetAllPlayers();

			List<PlayerModel> goodPlayers = new List<PlayerModel>();
			short bottomGrade = 0;
			short topGrade = 0;

			foreach (PlayerModel player in players)
			{
				if (goodPlayers.Count < 50)
				{
					if (player.LatestGrade > topGrade)
					{
						topGrade = player.LatestGrade;
						goodPlayers.Add(player);
					}
					else
                    {
						bottomGrade = player.LatestGrade;
						goodPlayers.Add(player);
                    }
				}
                else
                {
					if(player.LatestGrade > bottomGrade)
                    {
						goodPlayers.Remove(goodPlayers.MinBy(x => x.LatestGrade));
						goodPlayers.Add(player);
						bottomGrade = goodPlayers.MinBy(x => x.LatestGrade).LatestGrade;
                    }

                }
			}

			return View(goodPlayers.OrderByDescending(r => r.LatestGrade));
		}

		public IActionResult PlayerDetail(int id)
		{
			PlayerModel player = PlayerModelFactory.GetPlayerById(id);
			return View(player);
		}

		public IActionResult ComparePlayer(string searchString)
        {
			IEnumerable<PlayerModel> players = PlayerModelFactory.GetAllPlayers();
			List<PlayerModel> searchResults = new List<PlayerModel>();

			if (!String.IsNullOrEmpty(searchString))
			{
				return View(searchResults.Where(x => x.FullNameFormal.Contains(searchString)));
            }
            else
            {
				return View();
            }
        }

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}