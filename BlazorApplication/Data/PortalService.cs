using System;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApplication.Data
{
    public class PortalService
    {
        private static readonly string[] Summaries = new[]
        {
            "AnujaP", "ChintanP", "NiteshK", "ZinithP", "TanviM", "DiyaraP", "KaminiT", "AasthaD", "KhushbooD", "SurajK"
        };

        public Task<PortalUsers[]> GetPortalUsersAsync(int portalId)
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, portalId > 0 ? 5 : 10).Select(index => new PortalUsers
            {
                CreatedDate = DateTime.Now.AddYears(-2).AddDays(index),
                UserId = index,
                Username = Summaries[index - 1]
            }).ToArray());
        }
    }
}
