using System.ComponentModel.DataAnnotations;
using Web.Models;

namespace Web.ViewModels
{
    public class PortfolioViewModel : PortfolioItem
    {
        public IFormFile File { get; set; }
    }
}
