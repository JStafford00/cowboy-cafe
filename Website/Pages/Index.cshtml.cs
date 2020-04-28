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

        public IEnumerable<IOrderItem> Items
        {
            get;
            protected set;
        }

        [BindProperty]
        public string SearchTerms
        {
            get;
            set;
        } = "";

        [BindProperty]
        public string[] ItemTypes
        {
            get;
            set;
        }

        [BindProperty]
        public string CalMin
        {
            get;
            set;
        }

        [BindProperty]
        public string CalMax
        {
            get;
            set;
        }

        [BindProperty]
        public string PriceMin
        {
            get;
            set;
        }

        [BindProperty]
        public string PriceMax
        {
            get;
            set;
        }

        public void OnGet()
        {
            SearchTerms = Request.Query["SearchTerms"];
            ItemTypes = Request.Query["ItemTypes"];
            CalMin = Request.Query["CalMin"];
            CalMax = Request.Query["CalMax"];
            PriceMin = Request.Query["PriceMin"];
            PriceMax = Request.Query["PriceMax"];
            Items = CowboyCafe.Data.Menu.Search(SearchTerms);
            Items = CowboyCafe.Data.Menu.FilterByItemType(Items, ItemTypes);
            Items = CowboyCafe.Data.Menu.FilterByCalories(Items, CalMin, CalMax);
        }
    }
}
