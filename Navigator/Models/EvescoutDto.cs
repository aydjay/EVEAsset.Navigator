using System;

namespace Navigator.Models
{
    //https://docs.microsoft.com/en-us/aspnet/core/fundamentals/http-requests?view=aspnetcore-3.1
    public class EveScoutDto
    {
        public int Id { get; set; }
        public string SignatureId { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string WormholeMass { get; set; }
        public string WormholeEol { get; set; }
        public DateTime WormholeEstimatedEol { get; set; }
        public string WormholeDestinationSignatureId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? StatusUpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedById { get; set; }
        public DateTime? DeletedBy { get; set; }
        public DateTime? DeletedById { get; set; }
        public int WormholeSourceWormholeTypeId { get; set; }
        public int WormholeDestinationWormholeTypeId { get; set; }
        public int SolarSystemId { get; set; }
        public int WormholeDestinationSolarSystemId { get; set; }
        public SourceWormholeType SourceWormholeType { get; set; }
        public DestinationWormholeType DestinationWormholeType { get; set; }
        public SourceSolarSystem SourceSolarSystem { get; set; }
        public DestinationSolarSystem DestinationSolarSystem { get; set; }
        public int Jumps { get; set; }
        public double Lightyears { get; set; }
    }

    public class SourceWormholeType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Src { get; set; }
        public string Dest { get; set; }
        public int Lifetime { get; set; }
        public int JumpMass { get; set; }
        public int MaxMass { get; set; }
    }

    public class DestinationWormholeType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Src { get; set; }
        public string Dest { get; set; }
        public int Lifetime { get; set; }
        public int JumpMass { get; set; }
        public int MaxMass { get; set; }
    }

    public class Region
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class SourceSolarSystem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ConstellationId { get; set; }
        public double Security { get; set; }
        public int RegionId { get; set; }
        public Region Region { get; set; }
    }

    public class DestinationSolarSystem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ConstellationId { get; set; }
        public double Security { get; set; }
        public int RegionId { get; set; }
        public Region Region { get; set; }
    }
}
