using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryBuilding
{
    internal class BannedGame : IClassModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Series { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string Details { get; set; } = string.Empty;

        public BannedGame() { }

        public BannedGame(string title, string series, string country, string details)
        {
            Title = title;
            Series = series;
            Country = country;
            Details = details;

        }

        public override string ToString()
        {
            string msg = "";
            msg += $"Name: {Title}";
            msg += $"Franchise: {Series}";
            msg += $"Country: {Country}";
            msg += $"Reason for ban: {Details}";
            return msg;

        }
    }
}
