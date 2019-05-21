using System.Collections.Generic;

namespace EVEAsset.Navigator.Models
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

        public List<int> NavigatedSystems{ get; } = new List<int>();
    }
}