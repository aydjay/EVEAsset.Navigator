using System;

namespace Navigator.DAL.Navigator
{
    public class ScoutData
    {
        /// <summary>
        ///     SolarSystemID
        /// </summary>
        public int Id { get; set; }

        public string SolarSystemName { get; set; }

        public DateTime CachedTime { get; set; }

        public DateTime EarliestExpiryTime { get; set; }

        /// <summary>
        /// EvescoutDto that comes over the wire
        /// </summary>
        public string EveScoutData { get; set; }
    }
}
