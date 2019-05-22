using System.Text.RegularExpressions;

namespace Navigator.Repositories
{
    public class SolarSystemRepository
    {
        private readonly Regex _regex;

        public SolarSystemRepository()
        {
            _regex = new Regex(@"J\d{6}|Thera");
        }

        public bool IsWormhole(string systemName)
        {
            //There must be a property in the SDE to denote if a system is a wormhole, but for now, just going to regex
            //to get appropriate systems.
            var match = _regex.Match(systemName);
            return match.Success;
        }
    }
}