﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MovieLibrary.Pages
{
    public class TeamModel : PageModel
    {
        private readonly ILogger<TeamModel> _logger;

        public TeamModel(ILogger<TeamModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}