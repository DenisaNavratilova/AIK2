using Microsoft.EntityFrameworkCore;
using Navratilova;
using Navratilova.Model;

namespace Navratilova
{
    public class LogicCredits
    {
        private readonly CreditsContext _dbContext;

        public LogicCredits(CreditsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddCredit(int value, bool success)
        {
            var credit = new Credits
            {
                Created = DateTime.Now,
                Value = value,
                Success = success
            };

            _dbContext.Credits.Add(credit);
            _dbContext.SaveChanges();
        }
    }
}