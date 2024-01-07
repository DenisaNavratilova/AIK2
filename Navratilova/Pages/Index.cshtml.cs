using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Navratilova.Model;
using Navratilova;

namespace Navratilova.Pages
{
    public class IndexModel : PageModel
    {
        private readonly LogicCredits _logicCredits;

        public IndexModel(LogicCredits logicCredits)
        {
            _logicCredits = logicCredits;
        }

        public void OnPost(int score, bool success)
        {
            _logicCredits.AddCredit(score, success);
        }
    }
}