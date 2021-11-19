using RetroLogger5000.Data.Models;
using RetroLogger5000.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RetroLogger5000.Web.Api
{
    public class GamesController : ApiController
    {
		private readonly IGameData db;

		public GamesController(IGameData db) => this.db = db;

		public IEnumerable<Game> Get()
		{
			var model = db.GetAll();
			return model;
		}
    }
}
