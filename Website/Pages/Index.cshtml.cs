using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CowboyCafe.Data;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Items being searched
        /// </summary>
        public IEnumerable<IOrderItem> Items
        {
            get;
            protected set;
        }

        /// <summary>
        /// Terms being searched for
        /// </summary>
        [BindProperty]
        public string SearchTerms
        {
            get;
            set;
        } = "";

        /// <summary>
        /// Item types being searched for
        /// </summary>
        [BindProperty]
        public string[] ItemTypes
        {
            get;
            set;
        }

        /// <summary>
        /// Minimum calories being searched
        /// </summary>
        [BindProperty]
        public string CalMin
        {
            get;
            set;
        }

        /// <summary>
        /// Max calories being searched
        /// </summary>
        [BindProperty]
        public string CalMax
        {
            get;
            set;
        }

        /// <summary>
        /// Min price being searched
        /// </summary>
        [BindProperty]
        public string PriceMin
        {
            get;
            set;
        }

        /// <summary>
        /// Max price being searched
        /// </summary>
        [BindProperty]
        public string PriceMax
        {
            get;
            set;
        }

        /// <summary>
        /// After every page refresh
        /// </summary>
        public void OnGet()
        {
            SearchTerms = Request.Query["SearchTerms"];
            ItemTypes = Request.Query["ItemTypes"];
            CalMin = Request.Query["CalMin"];
            CalMax = Request.Query["CalMax"];
            PriceMin = Request.Query["PriceMin"];
            PriceMax = Request.Query["PriceMax"];
            Items = CowboyCafe.Data.Menu.Search(SearchTerms);
            Items = CowboyCafe.Data.Menu.FilterByCatagory(Items, ItemTypes);
            Items = CowboyCafe.Data.Menu.FilterByCalories(Items, CalMin, CalMax);
        }
    }
}
