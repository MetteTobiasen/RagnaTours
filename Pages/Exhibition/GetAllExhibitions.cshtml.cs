﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RagnaTours.Interfaces;
using RagnaTours.Models;

namespace RagnaTours.Pages
{
    public class GetAllExhibitionsModel : PageModel
    {
        private IExhibitionRepository catalog;
        public GetAllExhibitionsModel(IExhibitionRepository repository)
        {
            catalog = repository;
        }
        public Dictionary<int, Exhibition> Exhibitions { get; private set; }

        [BindProperty(SupportsGet = true)]
        public string FilterCriteria { get; set; }

        public IActionResult OnGet()
        {
            Exhibitions = catalog.AllExhibitions();
            if (!string.IsNullOrEmpty(FilterCriteria))
            {
                Exhibitions = catalog.FilterPizza(FilterCriteria);
            }

            return Page();
        }
    }
}