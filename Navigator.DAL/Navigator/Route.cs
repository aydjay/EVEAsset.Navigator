using System.Collections.Generic;

namespace Navigator.DAL.Navigator
{
    public class Route
    {
        public Route(int from, int to)
        {
            From = from;
            To = to;
        }

        public int From { get; set; }
        public int To { get; set; }
        
        public int RouteId { get; set; }

        public List<int> NavigatedSystems{ get; } = new List<int>();
    }
}