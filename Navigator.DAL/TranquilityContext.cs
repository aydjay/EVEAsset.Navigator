using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Navigator.DAL.SDE;

namespace Navigator.DAL
{
    //http://www.npgsql.org/efcore/index.html#using-an-existing-database-database-first
    public partial class TranquilityContext : DbContext
    {
        private string _connectionString;

        public TranquilityContext(DbContextOptions<TranquilityContext> options)
            : base(options)
        {

        }

        public virtual DbSet<AgtAgentTypes> AgtAgentTypes { get; set; }
        public virtual DbSet<AgtAgents> AgtAgents { get; set; }
        public virtual DbSet<AgtResearchAgents> AgtResearchAgents { get; set; }
        public virtual DbSet<CertCerts> CertCerts { get; set; }
        public virtual DbSet<ChrAncestries> ChrAncestries { get; set; }
        public virtual DbSet<ChrAttributes> ChrAttributes { get; set; }
        public virtual DbSet<ChrBloodlines> ChrBloodlines { get; set; }
        public virtual DbSet<ChrFactions> ChrFactions { get; set; }
        public virtual DbSet<ChrRaces> ChrRaces { get; set; }
        public virtual DbSet<CrpActivities> CrpActivities { get; set; }
        public virtual DbSet<CrpNpccorporationDivisions> CrpNpccorporationDivisions { get; set; }
        public virtual DbSet<CrpNpccorporationResearchFields> CrpNpccorporationResearchFields { get; set; }
        public virtual DbSet<CrpNpccorporationTrades> CrpNpccorporationTrades { get; set; }
        public virtual DbSet<CrpNpccorporations> CrpNpccorporations { get; set; }
        public virtual DbSet<CrpNpcdivisions> CrpNpcdivisions { get; set; }
        public virtual DbSet<DgmAttributeCategories> DgmAttributeCategories { get; set; }
        public virtual DbSet<DgmAttributeTypes> DgmAttributeTypes { get; set; }
        public virtual DbSet<DgmEffects> DgmEffects { get; set; }
        public virtual DbSet<DgmExpressions> DgmExpressions { get; set; }
        public virtual DbSet<DgmTypeAttributes> DgmTypeAttributes { get; set; }
        public virtual DbSet<DgmTypeEffects> DgmTypeEffects { get; set; }
        public virtual DbSet<EveGraphics> EveGraphics { get; set; }
        public virtual DbSet<EveIcons> EveIcons { get; set; }
        public virtual DbSet<EveUnits> EveUnits { get; set; }
        public virtual DbSet<IndustryActivity> IndustryActivity { get; set; }
        public virtual DbSet<IndustryBlueprints> IndustryBlueprints { get; set; }
        public virtual DbSet<InvCategories> InvCategories { get; set; }
        public virtual DbSet<InvContrabandTypes> InvContrabandTypes { get; set; }
        public virtual DbSet<InvControlTowerResourcePurposes> InvControlTowerResourcePurposes { get; set; }
        public virtual DbSet<InvControlTowerResources> InvControlTowerResources { get; set; }
        public virtual DbSet<InvFlags> InvFlags { get; set; }
        public virtual DbSet<InvGroups> InvGroups { get; set; }
        public virtual DbSet<InvItems> InvItems { get; set; }
        public virtual DbSet<InvMarketGroups> InvMarketGroups { get; set; }
        public virtual DbSet<InvMetaGroups> InvMetaGroups { get; set; }
        public virtual DbSet<InvMetaTypes> InvMetaTypes { get; set; }
        public virtual DbSet<InvNames> InvNames { get; set; }
        public virtual DbSet<InvPositions> InvPositions { get; set; }
        public virtual DbSet<InvTraits> InvTraits { get; set; }
        public virtual DbSet<InvTypeMaterials> InvTypeMaterials { get; set; }
        public virtual DbSet<InvTypeReactions> InvTypeReactions { get; set; }
        public virtual DbSet<InvTypes> InvTypes { get; set; }
        public virtual DbSet<InvUniqueNames> InvUniqueNames { get; set; }
        public virtual DbSet<InvVolumes> InvVolumes { get; set; }
        public virtual DbSet<MapCelestialStatistics> MapCelestialStatistics { get; set; }
        public virtual DbSet<MapConstellationJumps> MapConstellationJumps { get; set; }
        public virtual DbSet<MapConstellations> MapConstellations { get; set; }
        public virtual DbSet<MapDenormalize> MapDenormalize { get; set; }
        public virtual DbSet<MapJumps> MapJumps { get; set; }
        public virtual DbSet<MapLandmarks> MapLandmarks { get; set; }
        public virtual DbSet<MapLocationScenes> MapLocationScenes { get; set; }
        public virtual DbSet<MapLocationWormholeClasses> MapLocationWormholeClasses { get; set; }
        public virtual DbSet<MapRegionJumps> MapRegionJumps { get; set; }
        public virtual DbSet<MapRegions> MapRegions { get; set; }
        public virtual DbSet<MapSolarSystemJumps> MapSolarSystemJumps { get; set; }
        public virtual DbSet<MapSolarSystems> MapSolarSystems { get; set; }
        public virtual DbSet<MapUniverse> MapUniverse { get; set; }
        public virtual DbSet<PlanetSchematics> PlanetSchematics { get; set; }
        public virtual DbSet<PlanetSchematicsPinMap> PlanetSchematicsPinMap { get; set; }
        public virtual DbSet<PlanetSchematicsTypeMap> PlanetSchematicsTypeMap { get; set; }
        public virtual DbSet<RamActivities> RamActivities { get; set; }
        public virtual DbSet<RamAssemblyLineStations> RamAssemblyLineStations { get; set; }
        public virtual DbSet<RamAssemblyLineTypeDetailPerCategory> RamAssemblyLineTypeDetailPerCategory { get; set; }
        public virtual DbSet<RamAssemblyLineTypeDetailPerGroup> RamAssemblyLineTypeDetailPerGroup { get; set; }
        public virtual DbSet<RamAssemblyLineTypes> RamAssemblyLineTypes { get; set; }
        public virtual DbSet<RamInstallationTypeContents> RamInstallationTypeContents { get; set; }
        public virtual DbSet<SkinLicense> SkinLicense { get; set; }
        public virtual DbSet<SkinMaterials> SkinMaterials { get; set; }
        public virtual DbSet<Skins> Skins { get; set; }
        public virtual DbSet<StaOperationServices> StaOperationServices { get; set; }
        public virtual DbSet<StaOperations> StaOperations { get; set; }
        public virtual DbSet<StaServices> StaServices { get; set; }
        public virtual DbSet<StaStationTypes> StaStationTypes { get; set; }
        public virtual DbSet<StaStations> StaStations { get; set; }
        public virtual DbSet<TranslationTables> TranslationTables { get; set; }
        public virtual DbSet<TrnTranslationColumns> TrnTranslationColumns { get; set; }
        public virtual DbSet<TrnTranslationLanguages> TrnTranslationLanguages { get; set; }
        public virtual DbSet<TrnTranslations> TrnTranslations { get; set; }
        public virtual DbSet<WarCombatZoneSystems> WarCombatZoneSystems { get; set; }
        public virtual DbSet<WarCombatZones> WarCombatZones { get; set; }

        //NB: These tables look a) empty and b) no pk's set at all.
        // Unable to generate entity type for table 'evesde.industryActivitySkills'. Please see the warning messages.
        // Unable to generate entity type for table 'evesde.industryActivityProducts'. Please see the warning messages.
        // Unable to generate entity type for table 'evesde.industryActivityRaces'. Please see the warning messages.
        // Unable to generate entity type for table 'evesde.industryActivityProbabilities'. Please see the warning messages.
        // Unable to generate entity type for table 'evesde.skinShip'. Please see the warning messages.
        // Unable to generate entity type for table 'evesde.certSkills'. Please see the warning messages.
        // Unable to generate entity type for table 'evesde.industryActivityMaterials'. Please see the warning messages.
        // Unable to generate entity type for table 'evesde.certMasteries'. Please see the warning messages.
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(_connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<AgtAgentTypes>(entity =>
            {
                entity.HasKey(e => e.AgentTypeId)
                    .HasName("agtAgentTypes_pkey");

                entity.ToTable("agtAgentTypes", "evesde");

                entity.Property(e => e.AgentTypeId)
                    .HasColumnName("agentTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AgentType)
                    .HasColumnName("agentType")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AgtAgents>(entity =>
            {
                entity.HasKey(e => e.AgentId)
                    .HasName("agtAgents_pkey");

                entity.ToTable("agtAgents", "evesde");

                entity.HasIndex(e => e.CorporationId)
                    .HasName("ix_evesde_agtAgents_corporationID");

                entity.HasIndex(e => e.LocationId)
                    .HasName("ix_evesde_agtAgents_locationID");

                entity.Property(e => e.AgentId)
                    .HasColumnName("agentID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AgentTypeId).HasColumnName("agentTypeID");

                entity.Property(e => e.CorporationId).HasColumnName("corporationID");

                entity.Property(e => e.DivisionId).HasColumnName("divisionID");

                entity.Property(e => e.IsLocator).HasColumnName("isLocator");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.LocationId).HasColumnName("locationID");

                entity.Property(e => e.Quality).HasColumnName("quality");
            });

            modelBuilder.Entity<AgtResearchAgents>(entity =>
            {
                entity.HasKey(e => new { e.AgentId, e.TypeId })
                    .HasName("agtResearchAgents_pkey");

                entity.ToTable("agtResearchAgents", "evesde");

                entity.HasIndex(e => e.TypeId)
                    .HasName("ix_evesde_agtResearchAgents_typeID");

                entity.Property(e => e.AgentId).HasColumnName("agentID");

                entity.Property(e => e.TypeId).HasColumnName("typeID");
            });

            modelBuilder.Entity<CertCerts>(entity =>
            {
                entity.HasKey(e => e.CertId)
                    .HasName("certCerts_pkey");

                entity.ToTable("certCerts", "evesde");

                entity.Property(e => e.CertId)
                    .HasColumnName("certID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.GroupId).HasColumnName("groupID");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ChrAncestries>(entity =>
            {
                entity.HasKey(e => e.AncestryId)
                    .HasName("chrAncestries_pkey");

                entity.ToTable("chrAncestries", "evesde");

                entity.Property(e => e.AncestryId)
                    .HasColumnName("ancestryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AncestryName)
                    .HasColumnName("ancestryName")
                    .HasMaxLength(100);

                entity.Property(e => e.BloodlineId).HasColumnName("bloodlineID");

                entity.Property(e => e.Charisma).HasColumnName("charisma");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(1000);

                entity.Property(e => e.IconId).HasColumnName("iconID");

                entity.Property(e => e.Intelligence).HasColumnName("intelligence");

                entity.Property(e => e.Memory).HasColumnName("memory");

                entity.Property(e => e.Perception).HasColumnName("perception");

                entity.Property(e => e.ShortDescription)
                    .HasColumnName("shortDescription")
                    .HasMaxLength(500);

                entity.Property(e => e.Willpower).HasColumnName("willpower");
            });

            modelBuilder.Entity<ChrAttributes>(entity =>
            {
                entity.HasKey(e => e.AttributeId)
                    .HasName("chrAttributes_pkey");

                entity.ToTable("chrAttributes", "evesde");

                entity.Property(e => e.AttributeId)
                    .HasColumnName("attributeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AttributeName)
                    .HasColumnName("attributeName")
                    .HasMaxLength(100);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(1000);

                entity.Property(e => e.IconId).HasColumnName("iconID");

                entity.Property(e => e.Notes)
                    .HasColumnName("notes")
                    .HasMaxLength(500);

                entity.Property(e => e.ShortDescription)
                    .HasColumnName("shortDescription")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<ChrBloodlines>(entity =>
            {
                entity.HasKey(e => e.BloodlineId)
                    .HasName("chrBloodlines_pkey");

                entity.ToTable("chrBloodlines", "evesde");

                entity.Property(e => e.BloodlineId)
                    .HasColumnName("bloodlineID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BloodlineName)
                    .HasColumnName("bloodlineName")
                    .HasMaxLength(100);

                entity.Property(e => e.Charisma).HasColumnName("charisma");

                entity.Property(e => e.CorporationId).HasColumnName("corporationID");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(1000);

                entity.Property(e => e.FemaleDescription)
                    .HasColumnName("femaleDescription")
                    .HasMaxLength(1000);

                entity.Property(e => e.IconId).HasColumnName("iconID");

                entity.Property(e => e.Intelligence).HasColumnName("intelligence");

                entity.Property(e => e.MaleDescription)
                    .HasColumnName("maleDescription")
                    .HasMaxLength(1000);

                entity.Property(e => e.Memory).HasColumnName("memory");

                entity.Property(e => e.Perception).HasColumnName("perception");

                entity.Property(e => e.RaceId).HasColumnName("raceID");

                entity.Property(e => e.ShipTypeId).HasColumnName("shipTypeID");

                entity.Property(e => e.ShortDescription)
                    .HasColumnName("shortDescription")
                    .HasMaxLength(500);

                entity.Property(e => e.ShortFemaleDescription)
                    .HasColumnName("shortFemaleDescription")
                    .HasMaxLength(500);

                entity.Property(e => e.ShortMaleDescription)
                    .HasColumnName("shortMaleDescription")
                    .HasMaxLength(500);

                entity.Property(e => e.Willpower).HasColumnName("willpower");
            });

            modelBuilder.Entity<ChrFactions>(entity =>
            {
                entity.HasKey(e => e.FactionId)
                    .HasName("chrFactions_pkey");

                entity.ToTable("chrFactions", "evesde");

                entity.Property(e => e.FactionId)
                    .HasColumnName("factionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CorporationId).HasColumnName("corporationID");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(1000);

                entity.Property(e => e.FactionName)
                    .HasColumnName("factionName")
                    .HasMaxLength(100);

                entity.Property(e => e.IconId).HasColumnName("iconID");

                entity.Property(e => e.MilitiaCorporationId).HasColumnName("militiaCorporationID");

                entity.Property(e => e.RaceIds).HasColumnName("raceIDs");

                entity.Property(e => e.SizeFactor).HasColumnName("sizeFactor");

                entity.Property(e => e.SolarSystemId).HasColumnName("solarSystemID");

                entity.Property(e => e.StationCount).HasColumnName("stationCount");

                entity.Property(e => e.StationSystemCount).HasColumnName("stationSystemCount");
            });

            modelBuilder.Entity<ChrRaces>(entity =>
            {
                entity.HasKey(e => e.RaceId)
                    .HasName("chrRaces_pkey");

                entity.ToTable("chrRaces", "evesde");

                entity.Property(e => e.RaceId)
                    .HasColumnName("raceID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(1000);

                entity.Property(e => e.IconId).HasColumnName("iconID");

                entity.Property(e => e.RaceName)
                    .HasColumnName("raceName")
                    .HasMaxLength(100);

                entity.Property(e => e.ShortDescription)
                    .HasColumnName("shortDescription")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<CrpActivities>(entity =>
            {
                entity.HasKey(e => e.ActivityId)
                    .HasName("crpActivities_pkey");

                entity.ToTable("crpActivities", "evesde");

                entity.Property(e => e.ActivityId)
                    .HasColumnName("activityID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActivityName)
                    .HasColumnName("activityName")
                    .HasMaxLength(100);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<CrpNpccorporationDivisions>(entity =>
            {
                entity.HasKey(e => new { e.CorporationId, e.DivisionId })
                    .HasName("crpNPCCorporationDivisions_pkey");

                entity.ToTable("crpNPCCorporationDivisions", "evesde");

                entity.Property(e => e.CorporationId).HasColumnName("corporationID");

                entity.Property(e => e.DivisionId).HasColumnName("divisionID");

                entity.Property(e => e.Size).HasColumnName("size");
            });

            modelBuilder.Entity<CrpNpccorporationResearchFields>(entity =>
            {
                entity.HasKey(e => new { e.SkillId, e.CorporationId })
                    .HasName("crpNPCCorporationResearchFields_pkey");

                entity.ToTable("crpNPCCorporationResearchFields", "evesde");

                entity.Property(e => e.SkillId).HasColumnName("skillID");

                entity.Property(e => e.CorporationId).HasColumnName("corporationID");
            });

            modelBuilder.Entity<CrpNpccorporationTrades>(entity =>
            {
                entity.HasKey(e => new { e.CorporationId, e.TypeId })
                    .HasName("crpNPCCorporationTrades_pkey");

                entity.ToTable("crpNPCCorporationTrades", "evesde");

                entity.Property(e => e.CorporationId).HasColumnName("corporationID");

                entity.Property(e => e.TypeId).HasColumnName("typeID");
            });

            modelBuilder.Entity<CrpNpccorporations>(entity =>
            {
                entity.HasKey(e => e.CorporationId)
                    .HasName("crpNPCCorporations_pkey");

                entity.ToTable("crpNPCCorporations", "evesde");

                entity.Property(e => e.CorporationId)
                    .HasColumnName("corporationID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Border).HasColumnName("border");

                entity.Property(e => e.Corridor).HasColumnName("corridor");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(4000);

                entity.Property(e => e.EnemyId).HasColumnName("enemyID");

                entity.Property(e => e.Extent).HasColumnName("extent");

                entity.Property(e => e.FactionId).HasColumnName("factionID");

                entity.Property(e => e.FriendId).HasColumnName("friendID");

                entity.Property(e => e.Fringe).HasColumnName("fringe");

                entity.Property(e => e.Hub).HasColumnName("hub");

                entity.Property(e => e.IconId).HasColumnName("iconID");

                entity.Property(e => e.InitialPrice).HasColumnName("initialPrice");

                entity.Property(e => e.InvestorId1).HasColumnName("investorID1");

                entity.Property(e => e.InvestorId2).HasColumnName("investorID2");

                entity.Property(e => e.InvestorId3).HasColumnName("investorID3");

                entity.Property(e => e.InvestorId4).HasColumnName("investorID4");

                entity.Property(e => e.InvestorShares1).HasColumnName("investorShares1");

                entity.Property(e => e.InvestorShares2).HasColumnName("investorShares2");

                entity.Property(e => e.InvestorShares3).HasColumnName("investorShares3");

                entity.Property(e => e.InvestorShares4).HasColumnName("investorShares4");

                entity.Property(e => e.MinSecurity).HasColumnName("minSecurity");

                entity.Property(e => e.PublicShares).HasColumnName("publicShares");

                entity.Property(e => e.Scattered).HasColumnName("scattered");

                entity.Property(e => e.Size).HasColumnName("size");

                entity.Property(e => e.SizeFactor).HasColumnName("sizeFactor");

                entity.Property(e => e.SolarSystemId).HasColumnName("solarSystemID");

                entity.Property(e => e.StationCount).HasColumnName("stationCount");

                entity.Property(e => e.StationSystemCount).HasColumnName("stationSystemCount");
            });

            modelBuilder.Entity<CrpNpcdivisions>(entity =>
            {
                entity.HasKey(e => e.DivisionId)
                    .HasName("crpNPCDivisions_pkey");

                entity.ToTable("crpNPCDivisions", "evesde");

                entity.Property(e => e.DivisionId)
                    .HasColumnName("divisionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(1000);

                entity.Property(e => e.DivisionName)
                    .HasColumnName("divisionName")
                    .HasMaxLength(100);

                entity.Property(e => e.LeaderType)
                    .HasColumnName("leaderType")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<DgmAttributeCategories>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("dgmAttributeCategories_pkey");

                entity.ToTable("dgmAttributeCategories", "evesde");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("categoryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CategoryDescription)
                    .HasColumnName("categoryDescription")
                    .HasMaxLength(200);

                entity.Property(e => e.CategoryName)
                    .HasColumnName("categoryName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DgmAttributeTypes>(entity =>
            {
                entity.HasKey(e => e.AttributeId)
                    .HasName("dgmAttributeTypes_pkey");

                entity.ToTable("dgmAttributeTypes", "evesde");

                entity.Property(e => e.AttributeId)
                    .HasColumnName("attributeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AttributeName)
                    .HasColumnName("attributeName")
                    .HasMaxLength(100);

                entity.Property(e => e.CategoryId).HasColumnName("categoryID");

                entity.Property(e => e.DefaultValue).HasColumnName("defaultValue");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(1000);

                entity.Property(e => e.DisplayName)
                    .HasColumnName("displayName")
                    .HasMaxLength(150);

                entity.Property(e => e.HighIsGood).HasColumnName("highIsGood");

                entity.Property(e => e.IconId).HasColumnName("iconID");

                entity.Property(e => e.Published).HasColumnName("published");

                entity.Property(e => e.Stackable).HasColumnName("stackable");

                entity.Property(e => e.UnitId).HasColumnName("unitID");
            });

            modelBuilder.Entity<DgmEffects>(entity =>
            {
                entity.HasKey(e => e.EffectId)
                    .HasName("dgmEffects_pkey");

                entity.ToTable("dgmEffects", "evesde");

                entity.Property(e => e.EffectId)
                    .HasColumnName("effectID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(1000);

                entity.Property(e => e.DisallowAutoRepeat).HasColumnName("disallowAutoRepeat");

                entity.Property(e => e.DischargeAttributeId).HasColumnName("dischargeAttributeID");

                entity.Property(e => e.DisplayName)
                    .HasColumnName("displayName")
                    .HasMaxLength(100);

                entity.Property(e => e.Distribution).HasColumnName("distribution");

                entity.Property(e => e.DurationAttributeId).HasColumnName("durationAttributeID");

                entity.Property(e => e.EffectCategory).HasColumnName("effectCategory");

                entity.Property(e => e.EffectName)
                    .HasColumnName("effectName")
                    .HasMaxLength(400);

                entity.Property(e => e.ElectronicChance).HasColumnName("electronicChance");

                entity.Property(e => e.FalloffAttributeId).HasColumnName("falloffAttributeID");

                entity.Property(e => e.FittingUsageChanceAttributeId).HasColumnName("fittingUsageChanceAttributeID");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasMaxLength(60);

                entity.Property(e => e.IconId).HasColumnName("iconID");

                entity.Property(e => e.IsAssistance).HasColumnName("isAssistance");

                entity.Property(e => e.IsOffensive).HasColumnName("isOffensive");

                entity.Property(e => e.IsWarpSafe).HasColumnName("isWarpSafe");

                entity.Property(e => e.ModifierInfo).HasColumnName("modifierInfo");

                entity.Property(e => e.NpcActivationChanceAttributeId).HasColumnName("npcActivationChanceAttributeID");

                entity.Property(e => e.NpcUsageChanceAttributeId).HasColumnName("npcUsageChanceAttributeID");

                entity.Property(e => e.PostExpression).HasColumnName("postExpression");

                entity.Property(e => e.PreExpression).HasColumnName("preExpression");

                entity.Property(e => e.PropulsionChance).HasColumnName("propulsionChance");

                entity.Property(e => e.Published).HasColumnName("published");

                entity.Property(e => e.RangeAttributeId).HasColumnName("rangeAttributeID");

                entity.Property(e => e.RangeChance).HasColumnName("rangeChance");

                entity.Property(e => e.SfxName)
                    .HasColumnName("sfxName")
                    .HasMaxLength(20);

                entity.Property(e => e.TrackingSpeedAttributeId).HasColumnName("trackingSpeedAttributeID");
            });

            modelBuilder.Entity<DgmExpressions>(entity =>
            {
                entity.HasKey(e => e.ExpressionId)
                    .HasName("dgmExpressions_pkey");

                entity.ToTable("dgmExpressions", "evesde");

                entity.Property(e => e.ExpressionId)
                    .HasColumnName("expressionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Arg1).HasColumnName("arg1");

                entity.Property(e => e.Arg2).HasColumnName("arg2");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(1000);

                entity.Property(e => e.ExpressionAttributeId).HasColumnName("expressionAttributeID");

                entity.Property(e => e.ExpressionGroupId).HasColumnName("expressionGroupID");

                entity.Property(e => e.ExpressionName)
                    .HasColumnName("expressionName")
                    .HasMaxLength(500);

                entity.Property(e => e.ExpressionTypeId).HasColumnName("expressionTypeID");

                entity.Property(e => e.ExpressionValue)
                    .HasColumnName("expressionValue")
                    .HasMaxLength(100);

                entity.Property(e => e.OperandId).HasColumnName("operandID");
            });

            modelBuilder.Entity<DgmTypeAttributes>(entity =>
            {
                entity.HasKey(e => new { e.TypeId, e.AttributeId })
                    .HasName("dgmTypeAttributes_pkey");

                entity.ToTable("dgmTypeAttributes", "evesde");

                entity.HasIndex(e => e.AttributeId)
                    .HasName("ix_evesde_dgmTypeAttributes_attributeID");

                entity.Property(e => e.TypeId).HasColumnName("typeID");

                entity.Property(e => e.AttributeId).HasColumnName("attributeID");

                entity.Property(e => e.ValueFloat).HasColumnName("valueFloat");

                entity.Property(e => e.ValueInt).HasColumnName("valueInt");
            });

            modelBuilder.Entity<DgmTypeEffects>(entity =>
            {
                entity.HasKey(e => new { e.TypeId, e.EffectId })
                    .HasName("dgmTypeEffects_pkey");

                entity.ToTable("dgmTypeEffects", "evesde");

                entity.Property(e => e.TypeId).HasColumnName("typeID");

                entity.Property(e => e.EffectId).HasColumnName("effectID");

                entity.Property(e => e.IsDefault).HasColumnName("isDefault");
            });

            modelBuilder.Entity<EveGraphics>(entity =>
            {
                entity.HasKey(e => e.GraphicId)
                    .HasName("eveGraphics_pkey");

                entity.ToTable("eveGraphics", "evesde");

                entity.Property(e => e.GraphicId)
                    .HasColumnName("graphicID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.GraphicFile)
                    .HasColumnName("graphicFile")
                    .HasMaxLength(100);

                entity.Property(e => e.SofFactionName)
                    .HasColumnName("sofFactionName")
                    .HasMaxLength(100);

                entity.Property(e => e.SofHullName)
                    .HasColumnName("sofHullName")
                    .HasMaxLength(100);

                entity.Property(e => e.SofRaceName)
                    .HasColumnName("sofRaceName")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<EveIcons>(entity =>
            {
                entity.HasKey(e => e.IconId)
                    .HasName("eveIcons_pkey");

                entity.ToTable("eveIcons", "evesde");

                entity.Property(e => e.IconId)
                    .HasColumnName("iconID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.IconFile)
                    .HasColumnName("iconFile")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<EveUnits>(entity =>
            {
                entity.HasKey(e => e.UnitId)
                    .HasName("eveUnits_pkey");

                entity.ToTable("eveUnits", "evesde");

                entity.Property(e => e.UnitId)
                    .HasColumnName("unitID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(1000);

                entity.Property(e => e.DisplayName)
                    .HasColumnName("displayName")
                    .HasMaxLength(50);

                entity.Property(e => e.UnitName)
                    .HasColumnName("unitName")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<IndustryActivity>(entity =>
            {
                entity.HasKey(e => new { e.TypeId, e.ActivityId })
                    .HasName("industryActivity_pkey");

                entity.ToTable("industryActivity", "evesde");

                entity.HasIndex(e => e.ActivityId)
                    .HasName("ix_evesde_industryActivity_activityID");

                entity.Property(e => e.TypeId).HasColumnName("typeID");

                entity.Property(e => e.ActivityId).HasColumnName("activityID");

                entity.Property(e => e.Time).HasColumnName("time");
            });

            modelBuilder.Entity<IndustryBlueprints>(entity =>
            {
                entity.HasKey(e => e.TypeId)
                    .HasName("industryBlueprints_pkey");

                entity.ToTable("industryBlueprints", "evesde");

                entity.Property(e => e.TypeId)
                    .HasColumnName("typeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.MaxProductionLimit).HasColumnName("maxProductionLimit");
            });

            modelBuilder.Entity<InvCategories>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("invCategories_pkey");

                entity.ToTable("invCategories", "evesde");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("categoryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CategoryName)
                    .HasColumnName("categoryName")
                    .HasMaxLength(100);

                entity.Property(e => e.IconId).HasColumnName("iconID");

                entity.Property(e => e.Published).HasColumnName("published");
            });

            modelBuilder.Entity<InvContrabandTypes>(entity =>
            {
                entity.HasKey(e => new { e.FactionId, e.TypeId })
                    .HasName("invContrabandTypes_pkey");

                entity.ToTable("invContrabandTypes", "evesde");

                entity.HasIndex(e => e.TypeId)
                    .HasName("ix_evesde_invContrabandTypes_typeID");

                entity.Property(e => e.FactionId).HasColumnName("factionID");

                entity.Property(e => e.TypeId).HasColumnName("typeID");

                entity.Property(e => e.AttackMinSec).HasColumnName("attackMinSec");

                entity.Property(e => e.ConfiscateMinSec).HasColumnName("confiscateMinSec");

                entity.Property(e => e.FineByValue).HasColumnName("fineByValue");

                entity.Property(e => e.StandingLoss).HasColumnName("standingLoss");
            });

            modelBuilder.Entity<InvControlTowerResourcePurposes>(entity =>
            {
                entity.HasKey(e => e.Purpose)
                    .HasName("invControlTowerResourcePurposes_pkey");

                entity.ToTable("invControlTowerResourcePurposes", "evesde");

                entity.Property(e => e.Purpose)
                    .HasColumnName("purpose")
                    .ValueGeneratedNever();

                entity.Property(e => e.PurposeText)
                    .HasColumnName("purposeText")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<InvControlTowerResources>(entity =>
            {
                entity.HasKey(e => new { e.ControlTowerTypeId, e.ResourceTypeId })
                    .HasName("invControlTowerResources_pkey");

                entity.ToTable("invControlTowerResources", "evesde");

                entity.Property(e => e.ControlTowerTypeId).HasColumnName("controlTowerTypeID");

                entity.Property(e => e.ResourceTypeId).HasColumnName("resourceTypeID");

                entity.Property(e => e.FactionId).HasColumnName("factionID");

                entity.Property(e => e.MinSecurityLevel).HasColumnName("minSecurityLevel");

                entity.Property(e => e.Purpose).HasColumnName("purpose");

                entity.Property(e => e.Quantity).HasColumnName("quantity");
            });

            modelBuilder.Entity<InvFlags>(entity =>
            {
                entity.HasKey(e => e.FlagId)
                    .HasName("invFlags_pkey");

                entity.ToTable("invFlags", "evesde");

                entity.Property(e => e.FlagId)
                    .HasColumnName("flagID")
                    .ValueGeneratedNever();

                entity.Property(e => e.FlagName)
                    .HasColumnName("flagName")
                    .HasMaxLength(200);

                entity.Property(e => e.FlagText)
                    .HasColumnName("flagText")
                    .HasMaxLength(100);

                entity.Property(e => e.OrderId).HasColumnName("orderID");
            });

            modelBuilder.Entity<InvGroups>(entity =>
            {
                entity.HasKey(e => e.GroupId)
                    .HasName("invGroups_pkey");

                entity.ToTable("invGroups", "evesde");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("ix_evesde_invGroups_categoryID");

                entity.Property(e => e.GroupId)
                    .HasColumnName("groupID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Anchorable).HasColumnName("anchorable");

                entity.Property(e => e.Anchored).HasColumnName("anchored");

                entity.Property(e => e.CategoryId).HasColumnName("categoryID");

                entity.Property(e => e.FittableNonSingleton).HasColumnName("fittableNonSingleton");

                entity.Property(e => e.GroupName)
                    .HasColumnName("groupName")
                    .HasMaxLength(100);

                entity.Property(e => e.IconId).HasColumnName("iconID");

                entity.Property(e => e.Published).HasColumnName("published");

                entity.Property(e => e.UseBasePrice).HasColumnName("useBasePrice");
            });

            modelBuilder.Entity<InvItems>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("invItems_pkey");

                entity.ToTable("invItems", "evesde");

                entity.HasIndex(e => e.LocationId)
                    .HasName("ix_evesde_invItems_locationID");

                entity.HasIndex(e => new { e.OwnerId, e.LocationId })
                    .HasName("items_IX_OwnerLocation");

                entity.Property(e => e.ItemId)
                    .HasColumnName("itemID")
                    .ValueGeneratedNever();

                entity.Property(e => e.FlagId).HasColumnName("flagID");

                entity.Property(e => e.LocationId).HasColumnName("locationID");

                entity.Property(e => e.OwnerId).HasColumnName("ownerID");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.TypeId).HasColumnName("typeID");
            });

            modelBuilder.Entity<InvMarketGroups>(entity =>
            {
                entity.HasKey(e => e.MarketGroupId)
                    .HasName("invMarketGroups_pkey");

                entity.ToTable("invMarketGroups", "evesde");

                entity.Property(e => e.MarketGroupId)
                    .HasColumnName("marketGroupID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(3000);

                entity.Property(e => e.HasTypes).HasColumnName("hasTypes");

                entity.Property(e => e.IconId).HasColumnName("iconID");

                entity.Property(e => e.MarketGroupName)
                    .HasColumnName("marketGroupName")
                    .HasMaxLength(100);

                entity.Property(e => e.ParentGroupId).HasColumnName("parentGroupID");
            });

            modelBuilder.Entity<InvMetaGroups>(entity =>
            {
                entity.HasKey(e => e.MetaGroupId)
                    .HasName("invMetaGroups_pkey");

                entity.ToTable("invMetaGroups", "evesde");

                entity.Property(e => e.MetaGroupId)
                    .HasColumnName("metaGroupID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(1000);

                entity.Property(e => e.IconId).HasColumnName("iconID");

                entity.Property(e => e.MetaGroupName)
                    .HasColumnName("metaGroupName")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<InvMetaTypes>(entity =>
            {
                entity.HasKey(e => e.TypeId)
                    .HasName("invMetaTypes_pkey");

                entity.ToTable("invMetaTypes", "evesde");

                entity.Property(e => e.TypeId)
                    .HasColumnName("typeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.MetaGroupId).HasColumnName("metaGroupID");

                entity.Property(e => e.ParentTypeId).HasColumnName("parentTypeID");
            });

            modelBuilder.Entity<InvNames>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("invNames_pkey");

                entity.ToTable("invNames", "evesde");

                entity.Property(e => e.ItemId)
                    .HasColumnName("itemID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasColumnName("itemName")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<InvPositions>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("invPositions_pkey");

                entity.ToTable("invPositions", "evesde");

                entity.Property(e => e.ItemId)
                    .HasColumnName("itemID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Pitch).HasColumnName("pitch");

                entity.Property(e => e.Roll).HasColumnName("roll");

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.Y).HasColumnName("y");

                entity.Property(e => e.Yaw).HasColumnName("yaw");

                entity.Property(e => e.Z).HasColumnName("z");
            });

            modelBuilder.Entity<InvTraits>(entity =>
            {
                entity.HasKey(e => e.TraitId)
                    .HasName("invTraits_pkey");

                entity.ToTable("invTraits", "evesde");

                entity.Property(e => e.TraitId)
                    .HasColumnName("traitID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bonus).HasColumnName("bonus");

                entity.Property(e => e.BonusText).HasColumnName("bonusText");

                entity.Property(e => e.SkillId).HasColumnName("skillID");

                entity.Property(e => e.TypeId).HasColumnName("typeID");

                entity.Property(e => e.UnitId).HasColumnName("unitID");
            });

            modelBuilder.Entity<InvTypeMaterials>(entity =>
            {
                entity.HasKey(e => new { e.TypeId, e.MaterialTypeId })
                    .HasName("invTypeMaterials_pkey");

                entity.ToTable("invTypeMaterials", "evesde");

                entity.Property(e => e.TypeId).HasColumnName("typeID");

                entity.Property(e => e.MaterialTypeId).HasColumnName("materialTypeID");

                entity.Property(e => e.Quantity).HasColumnName("quantity");
            });

            modelBuilder.Entity<InvTypeReactions>(entity =>
            {
                entity.HasKey(e => new { e.ReactionTypeId, e.Input, e.TypeId })
                    .HasName("invTypeReactions_pkey");

                entity.ToTable("invTypeReactions", "evesde");

                entity.Property(e => e.ReactionTypeId).HasColumnName("reactionTypeID");

                entity.Property(e => e.Input).HasColumnName("input");

                entity.Property(e => e.TypeId).HasColumnName("typeID");

                entity.Property(e => e.Quantity).HasColumnName("quantity");
            });

            modelBuilder.Entity<InvTypes>(entity =>
            {
                entity.HasKey(e => e.TypeId)
                    .HasName("invTypes_pkey");

                entity.ToTable("invTypes", "evesde");

                entity.HasIndex(e => e.GroupId)
                    .HasName("ix_evesde_invTypes_groupID");

                entity.Property(e => e.TypeId)
                    .HasColumnName("typeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BasePrice)
                    .HasColumnName("basePrice")
                    .HasColumnType("numeric(19,4)");

                entity.Property(e => e.Capacity).HasColumnName("capacity");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.GraphicId).HasColumnName("graphicID");

                entity.Property(e => e.GroupId).HasColumnName("groupID");

                entity.Property(e => e.IconId).HasColumnName("iconID");

                entity.Property(e => e.MarketGroupId).HasColumnName("marketGroupID");

                entity.Property(e => e.Mass).HasColumnName("mass");

                entity.Property(e => e.PortionSize).HasColumnName("portionSize");

                entity.Property(e => e.Published).HasColumnName("published");

                entity.Property(e => e.RaceId).HasColumnName("raceID");

                entity.Property(e => e.SoundId).HasColumnName("soundID");

                entity.Property(e => e.TypeName)
                    .HasColumnName("typeName")
                    .HasMaxLength(100);

                entity.Property(e => e.Volume).HasColumnName("volume");
            });

            modelBuilder.Entity<InvUniqueNames>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("invUniqueNames_pkey");

                entity.ToTable("invUniqueNames", "evesde");

                entity.HasIndex(e => e.ItemName)
                    .HasName("ix_evesde_invUniqueNames_itemName")
                    .IsUnique();

                entity.HasIndex(e => new { e.GroupId, e.ItemName })
                    .HasName("invUniqueNames_IX_GroupName");

                entity.Property(e => e.ItemId)
                    .HasColumnName("itemID")
                    .ValueGeneratedNever();

                entity.Property(e => e.GroupId).HasColumnName("groupID");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasColumnName("itemName")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<InvVolumes>(entity =>
            {
                entity.HasKey(e => e.TypeId)
                    .HasName("invVolumes_pkey");

                entity.ToTable("invVolumes", "evesde");

                entity.Property(e => e.TypeId)
                    .HasColumnName("typeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Volume).HasColumnName("volume");
            });

            modelBuilder.Entity<MapCelestialStatistics>(entity =>
            {
                entity.HasKey(e => e.CelestialId)
                    .HasName("mapCelestialStatistics_pkey");

                entity.ToTable("mapCelestialStatistics", "evesde");

                entity.Property(e => e.CelestialId)
                    .HasColumnName("celestialID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Density).HasColumnName("density");

                entity.Property(e => e.Eccentricity).HasColumnName("eccentricity");

                entity.Property(e => e.EscapeVelocity).HasColumnName("escapeVelocity");

                entity.Property(e => e.Fragmented).HasColumnName("fragmented");

                entity.Property(e => e.Life).HasColumnName("life");

                entity.Property(e => e.Locked).HasColumnName("locked");

                entity.Property(e => e.Luminosity).HasColumnName("luminosity");

                entity.Property(e => e.Mass).HasColumnName("mass");

                entity.Property(e => e.MassDust).HasColumnName("massDust");

                entity.Property(e => e.MassGas).HasColumnName("massGas");

                entity.Property(e => e.OrbitPeriod).HasColumnName("orbitPeriod");

                entity.Property(e => e.OrbitRadius).HasColumnName("orbitRadius");

                entity.Property(e => e.Pressure).HasColumnName("pressure");

                entity.Property(e => e.Radius).HasColumnName("radius");

                entity.Property(e => e.RotationRate).HasColumnName("rotationRate");

                entity.Property(e => e.SpectralClass)
                    .HasColumnName("spectralClass")
                    .HasMaxLength(10);

                entity.Property(e => e.SurfaceGravity).HasColumnName("surfaceGravity");

                entity.Property(e => e.Temperature).HasColumnName("temperature");
            });

            modelBuilder.Entity<MapConstellationJumps>(entity =>
            {
                entity.HasKey(e => new { e.FromConstellationId, e.ToConstellationId })
                    .HasName("mapConstellationJumps_pkey");

                entity.ToTable("mapConstellationJumps", "evesde");

                entity.Property(e => e.FromConstellationId).HasColumnName("fromConstellationID");

                entity.Property(e => e.ToConstellationId).HasColumnName("toConstellationID");

                entity.Property(e => e.FromRegionId).HasColumnName("fromRegionID");

                entity.Property(e => e.ToRegionId).HasColumnName("toRegionID");
            });

            modelBuilder.Entity<MapConstellations>(entity =>
            {
                entity.HasKey(e => e.ConstellationId)
                    .HasName("mapConstellations_pkey");

                entity.ToTable("mapConstellations", "evesde");

                entity.Property(e => e.ConstellationId)
                    .HasColumnName("constellationID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConstellationName)
                    .HasColumnName("constellationName")
                    .HasMaxLength(100);

                entity.Property(e => e.FactionId).HasColumnName("factionID");

                entity.Property(e => e.Radius).HasColumnName("radius");

                entity.Property(e => e.RegionId).HasColumnName("regionID");

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.XMax).HasColumnName("xMax");

                entity.Property(e => e.XMin).HasColumnName("xMin");

                entity.Property(e => e.Y).HasColumnName("y");

                entity.Property(e => e.YMax).HasColumnName("yMax");

                entity.Property(e => e.YMin).HasColumnName("yMin");

                entity.Property(e => e.Z).HasColumnName("z");

                entity.Property(e => e.ZMax).HasColumnName("zMax");

                entity.Property(e => e.ZMin).HasColumnName("zMin");
            });

            modelBuilder.Entity<MapDenormalize>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("mapDenormalize_pkey");

                entity.ToTable("mapDenormalize", "evesde");

                entity.HasIndex(e => e.ConstellationId)
                    .HasName("ix_evesde_mapDenormalize_constellationID");

                entity.HasIndex(e => e.OrbitId)
                    .HasName("ix_evesde_mapDenormalize_orbitID");

                entity.HasIndex(e => e.RegionId)
                    .HasName("ix_evesde_mapDenormalize_regionID");

                entity.HasIndex(e => e.SolarSystemId)
                    .HasName("ix_evesde_mapDenormalize_solarSystemID");

                entity.HasIndex(e => e.TypeId)
                    .HasName("ix_evesde_mapDenormalize_typeID");

                entity.HasIndex(e => new { e.GroupId, e.ConstellationId })
                    .HasName("mapDenormalize_IX_groupConstellation");

                entity.HasIndex(e => new { e.GroupId, e.RegionId })
                    .HasName("mapDenormalize_IX_groupRegion");

                entity.HasIndex(e => new { e.GroupId, e.SolarSystemId })
                    .HasName("mapDenormalize_IX_groupSystem");

                entity.Property(e => e.ItemId)
                    .HasColumnName("itemID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CelestialIndex).HasColumnName("celestialIndex");

                entity.Property(e => e.ConstellationId).HasColumnName("constellationID");

                entity.Property(e => e.GroupId).HasColumnName("groupID");

                entity.Property(e => e.ItemName)
                    .HasColumnName("itemName")
                    .HasMaxLength(100);

                entity.Property(e => e.OrbitId).HasColumnName("orbitID");

                entity.Property(e => e.OrbitIndex).HasColumnName("orbitIndex");

                entity.Property(e => e.Radius).HasColumnName("radius");

                entity.Property(e => e.RegionId).HasColumnName("regionID");

                entity.Property(e => e.Security).HasColumnName("security");

                entity.Property(e => e.SolarSystemId).HasColumnName("solarSystemID");

                entity.Property(e => e.TypeId).HasColumnName("typeID");

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.Y).HasColumnName("y");

                entity.Property(e => e.Z).HasColumnName("z");
            });

            modelBuilder.Entity<MapJumps>(entity =>
            {
                entity.HasKey(e => e.StargateId)
                    .HasName("mapJumps_pkey");

                entity.ToTable("mapJumps", "evesde");

                entity.Property(e => e.StargateId)
                    .HasColumnName("stargateID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DestinationId).HasColumnName("destinationID");
            });

            modelBuilder.Entity<MapLandmarks>(entity =>
            {
                entity.HasKey(e => e.LandmarkId)
                    .HasName("mapLandmarks_pkey");

                entity.ToTable("mapLandmarks", "evesde");

                entity.Property(e => e.LandmarkId)
                    .HasColumnName("landmarkID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.IconId).HasColumnName("iconID");

                entity.Property(e => e.LandmarkName)
                    .HasColumnName("landmarkName")
                    .HasMaxLength(100);

                entity.Property(e => e.LocationId).HasColumnName("locationID");

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.Y).HasColumnName("y");

                entity.Property(e => e.Z).HasColumnName("z");
            });

            modelBuilder.Entity<MapLocationScenes>(entity =>
            {
                entity.HasKey(e => e.LocationId)
                    .HasName("mapLocationScenes_pkey");

                entity.ToTable("mapLocationScenes", "evesde");

                entity.Property(e => e.LocationId)
                    .HasColumnName("locationID")
                    .ValueGeneratedNever();

                entity.Property(e => e.GraphicId).HasColumnName("graphicID");
            });

            modelBuilder.Entity<MapLocationWormholeClasses>(entity =>
            {
                entity.HasKey(e => e.LocationId)
                    .HasName("mapLocationWormholeClasses_pkey");

                entity.ToTable("mapLocationWormholeClasses", "evesde");

                entity.Property(e => e.LocationId)
                    .HasColumnName("locationID")
                    .ValueGeneratedNever();

                entity.Property(e => e.WormholeClassId).HasColumnName("wormholeClassID");
            });

            modelBuilder.Entity<MapRegionJumps>(entity =>
            {
                entity.HasKey(e => new { e.FromRegionId, e.ToRegionId })
                    .HasName("mapRegionJumps_pkey");

                entity.ToTable("mapRegionJumps", "evesde");

                entity.Property(e => e.FromRegionId).HasColumnName("fromRegionID");

                entity.Property(e => e.ToRegionId).HasColumnName("toRegionID");
            });

            modelBuilder.Entity<MapRegions>(entity =>
            {
                entity.HasKey(e => e.RegionId)
                    .HasName("mapRegions_pkey");

                entity.ToTable("mapRegions", "evesde");

                entity.Property(e => e.RegionId)
                    .HasColumnName("regionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.FactionId).HasColumnName("factionID");

                entity.Property(e => e.Radius).HasColumnName("radius");

                entity.Property(e => e.RegionName)
                    .HasColumnName("regionName")
                    .HasMaxLength(100);

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.XMax).HasColumnName("xMax");

                entity.Property(e => e.XMin).HasColumnName("xMin");

                entity.Property(e => e.Y).HasColumnName("y");

                entity.Property(e => e.YMax).HasColumnName("yMax");

                entity.Property(e => e.YMin).HasColumnName("yMin");

                entity.Property(e => e.Z).HasColumnName("z");

                entity.Property(e => e.ZMax).HasColumnName("zMax");

                entity.Property(e => e.ZMin).HasColumnName("zMin");
            });

            modelBuilder.Entity<MapSolarSystemJumps>(entity =>
            {
                entity.HasKey(e => new { e.FromSolarSystemId, e.ToSolarSystemId })
                    .HasName("mapSolarSystemJumps_pkey");

                entity.ToTable("mapSolarSystemJumps", "evesde");

                entity.Property(e => e.FromSolarSystemId).HasColumnName("fromSolarSystemID");

                entity.Property(e => e.ToSolarSystemId).HasColumnName("toSolarSystemID");

                entity.Property(e => e.FromConstellationId).HasColumnName("fromConstellationID");

                entity.Property(e => e.FromRegionId).HasColumnName("fromRegionID");

                entity.Property(e => e.ToConstellationId).HasColumnName("toConstellationID");

                entity.Property(e => e.ToRegionId).HasColumnName("toRegionID");
            });

            modelBuilder.Entity<MapSolarSystems>(entity =>
            {
                entity.HasKey(e => e.SolarSystemId)
                    .HasName("mapSolarSystems_pkey");

                entity.ToTable("mapSolarSystems", "evesde");

                entity.HasIndex(e => e.ConstellationId)
                    .HasName("ix_evesde_mapSolarSystems_constellationID");

                entity.HasIndex(e => e.RegionId)
                    .HasName("ix_evesde_mapSolarSystems_regionID");

                entity.HasIndex(e => e.Security)
                    .HasName("ix_evesde_mapSolarSystems_security");

                entity.Property(e => e.SolarSystemId)
                    .HasColumnName("solarSystemID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Border).HasColumnName("border");

                entity.Property(e => e.Constellation).HasColumnName("constellation");

                entity.Property(e => e.ConstellationId).HasColumnName("constellationID");

                entity.Property(e => e.Corridor).HasColumnName("corridor");

                entity.Property(e => e.FactionId).HasColumnName("factionID");

                entity.Property(e => e.Fringe).HasColumnName("fringe");

                entity.Property(e => e.Hub).HasColumnName("hub");

                entity.Property(e => e.International).HasColumnName("international");

                entity.Property(e => e.Luminosity).HasColumnName("luminosity");

                entity.Property(e => e.Radius).HasColumnName("radius");

                entity.Property(e => e.RegionId).HasColumnName("regionID");

                entity.Property(e => e.Regional).HasColumnName("regional");

                entity.Property(e => e.Security).HasColumnName("security");

                entity.Property(e => e.SecurityClass)
                    .HasColumnName("securityClass")
                    .HasMaxLength(2);

                entity.Property(e => e.SolarSystemName)
                    .HasColumnName("solarSystemName")
                    .HasMaxLength(100);

                entity.Property(e => e.SunTypeId).HasColumnName("sunTypeID");

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.XMax).HasColumnName("xMax");

                entity.Property(e => e.XMin).HasColumnName("xMin");

                entity.Property(e => e.Y).HasColumnName("y");

                entity.Property(e => e.YMax).HasColumnName("yMax");

                entity.Property(e => e.YMin).HasColumnName("yMin");

                entity.Property(e => e.Z).HasColumnName("z");

                entity.Property(e => e.ZMax).HasColumnName("zMax");

                entity.Property(e => e.ZMin).HasColumnName("zMin");
            });

            modelBuilder.Entity<MapUniverse>(entity =>
            {
                entity.HasKey(e => e.UniverseId)
                    .HasName("mapUniverse_pkey");

                entity.ToTable("mapUniverse", "evesde");

                entity.Property(e => e.UniverseId)
                    .HasColumnName("universeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Radius).HasColumnName("radius");

                entity.Property(e => e.UniverseName)
                    .HasColumnName("universeName")
                    .HasMaxLength(100);

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.XMax).HasColumnName("xMax");

                entity.Property(e => e.XMin).HasColumnName("xMin");

                entity.Property(e => e.Y).HasColumnName("y");

                entity.Property(e => e.YMax).HasColumnName("yMax");

                entity.Property(e => e.YMin).HasColumnName("yMin");

                entity.Property(e => e.Z).HasColumnName("z");

                entity.Property(e => e.ZMax).HasColumnName("zMax");

                entity.Property(e => e.ZMin).HasColumnName("zMin");
            });

            modelBuilder.Entity<PlanetSchematics>(entity =>
            {
                entity.HasKey(e => e.SchematicId)
                    .HasName("planetSchematics_pkey");

                entity.ToTable("planetSchematics", "evesde");

                entity.Property(e => e.SchematicId)
                    .HasColumnName("schematicID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CycleTime).HasColumnName("cycleTime");

                entity.Property(e => e.SchematicName)
                    .HasColumnName("schematicName")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<PlanetSchematicsPinMap>(entity =>
            {
                entity.HasKey(e => new { e.SchematicId, e.PinTypeId })
                    .HasName("planetSchematicsPinMap_pkey");

                entity.ToTable("planetSchematicsPinMap", "evesde");

                entity.Property(e => e.SchematicId).HasColumnName("schematicID");

                entity.Property(e => e.PinTypeId).HasColumnName("pinTypeID");
            });

            modelBuilder.Entity<PlanetSchematicsTypeMap>(entity =>
            {
                entity.HasKey(e => new { e.SchematicId, e.TypeId })
                    .HasName("planetSchematicsTypeMap_pkey");

                entity.ToTable("planetSchematicsTypeMap", "evesde");

                entity.Property(e => e.SchematicId).HasColumnName("schematicID");

                entity.Property(e => e.TypeId).HasColumnName("typeID");

                entity.Property(e => e.IsInput).HasColumnName("isInput");

                entity.Property(e => e.Quantity).HasColumnName("quantity");
            });

            modelBuilder.Entity<RamActivities>(entity =>
            {
                entity.HasKey(e => e.ActivityId)
                    .HasName("ramActivities_pkey");

                entity.ToTable("ramActivities", "evesde");

                entity.Property(e => e.ActivityId)
                    .HasColumnName("activityID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActivityName)
                    .HasColumnName("activityName")
                    .HasMaxLength(100);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(1000);

                entity.Property(e => e.IconNo)
                    .HasColumnName("iconNo")
                    .HasMaxLength(5);

                entity.Property(e => e.Published).HasColumnName("published");
            });

            modelBuilder.Entity<RamAssemblyLineStations>(entity =>
            {
                entity.HasKey(e => new { e.StationId, e.AssemblyLineTypeId })
                    .HasName("ramAssemblyLineStations_pkey");

                entity.ToTable("ramAssemblyLineStations", "evesde");

                entity.HasIndex(e => e.OwnerId)
                    .HasName("ix_evesde_ramAssemblyLineStations_ownerID");

                entity.HasIndex(e => e.RegionId)
                    .HasName("ix_evesde_ramAssemblyLineStations_regionID");

                entity.HasIndex(e => e.SolarSystemId)
                    .HasName("ix_evesde_ramAssemblyLineStations_solarSystemID");

                entity.Property(e => e.StationId).HasColumnName("stationID");

                entity.Property(e => e.AssemblyLineTypeId).HasColumnName("assemblyLineTypeID");

                entity.Property(e => e.OwnerId).HasColumnName("ownerID");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.RegionId).HasColumnName("regionID");

                entity.Property(e => e.SolarSystemId).HasColumnName("solarSystemID");

                entity.Property(e => e.StationTypeId).HasColumnName("stationTypeID");
            });

            modelBuilder.Entity<RamAssemblyLineTypeDetailPerCategory>(entity =>
            {
                entity.HasKey(e => new { e.AssemblyLineTypeId, e.CategoryId })
                    .HasName("ramAssemblyLineTypeDetailPerCategory_pkey");

                entity.ToTable("ramAssemblyLineTypeDetailPerCategory", "evesde");

                entity.Property(e => e.AssemblyLineTypeId).HasColumnName("assemblyLineTypeID");

                entity.Property(e => e.CategoryId).HasColumnName("categoryID");

                entity.Property(e => e.CostMultiplier).HasColumnName("costMultiplier");

                entity.Property(e => e.MaterialMultiplier).HasColumnName("materialMultiplier");

                entity.Property(e => e.TimeMultiplier).HasColumnName("timeMultiplier");
            });

            modelBuilder.Entity<RamAssemblyLineTypeDetailPerGroup>(entity =>
            {
                entity.HasKey(e => new { e.AssemblyLineTypeId, e.GroupId })
                    .HasName("ramAssemblyLineTypeDetailPerGroup_pkey");

                entity.ToTable("ramAssemblyLineTypeDetailPerGroup", "evesde");

                entity.Property(e => e.AssemblyLineTypeId).HasColumnName("assemblyLineTypeID");

                entity.Property(e => e.GroupId).HasColumnName("groupID");

                entity.Property(e => e.CostMultiplier).HasColumnName("costMultiplier");

                entity.Property(e => e.MaterialMultiplier).HasColumnName("materialMultiplier");

                entity.Property(e => e.TimeMultiplier).HasColumnName("timeMultiplier");
            });

            modelBuilder.Entity<RamAssemblyLineTypes>(entity =>
            {
                entity.HasKey(e => e.AssemblyLineTypeId)
                    .HasName("ramAssemblyLineTypes_pkey");

                entity.ToTable("ramAssemblyLineTypes", "evesde");

                entity.Property(e => e.AssemblyLineTypeId)
                    .HasColumnName("assemblyLineTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActivityId).HasColumnName("activityID");

                entity.Property(e => e.AssemblyLineTypeName)
                    .HasColumnName("assemblyLineTypeName")
                    .HasMaxLength(100);

                entity.Property(e => e.BaseCostMultiplier).HasColumnName("baseCostMultiplier");

                entity.Property(e => e.BaseMaterialMultiplier).HasColumnName("baseMaterialMultiplier");

                entity.Property(e => e.BaseTimeMultiplier).HasColumnName("baseTimeMultiplier");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(1000);

                entity.Property(e => e.MinCostPerHour).HasColumnName("minCostPerHour");

                entity.Property(e => e.Volume).HasColumnName("volume");
            });

            modelBuilder.Entity<RamInstallationTypeContents>(entity =>
            {
                entity.HasKey(e => new { e.InstallationTypeId, e.AssemblyLineTypeId })
                    .HasName("ramInstallationTypeContents_pkey");

                entity.ToTable("ramInstallationTypeContents", "evesde");

                entity.Property(e => e.InstallationTypeId).HasColumnName("installationTypeID");

                entity.Property(e => e.AssemblyLineTypeId).HasColumnName("assemblyLineTypeID");

                entity.Property(e => e.Quantity).HasColumnName("quantity");
            });

            modelBuilder.Entity<SkinLicense>(entity =>
            {
                entity.HasKey(e => e.LicenseTypeId)
                    .HasName("skinLicense_pkey");

                entity.ToTable("skinLicense", "evesde");

                entity.Property(e => e.LicenseTypeId)
                    .HasColumnName("licenseTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.SkinId).HasColumnName("skinID");
            });

            modelBuilder.Entity<SkinMaterials>(entity =>
            {
                entity.HasKey(e => e.SkinMaterialId)
                    .HasName("skinMaterials_pkey");

                entity.ToTable("skinMaterials", "evesde");

                entity.Property(e => e.SkinMaterialId)
                    .HasColumnName("skinMaterialID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DisplayNameId).HasColumnName("displayNameID");

                entity.Property(e => e.MaterialSetId).HasColumnName("materialSetID");
            });

            modelBuilder.Entity<Skins>(entity =>
            {
                entity.HasKey(e => e.SkinId)
                    .HasName("skins_pkey");

                entity.ToTable("skins", "evesde");

                entity.Property(e => e.SkinId)
                    .HasColumnName("skinID")
                    .ValueGeneratedNever();

                entity.Property(e => e.InternalName)
                    .HasColumnName("internalName")
                    .HasMaxLength(70);

                entity.Property(e => e.SkinMaterialId).HasColumnName("skinMaterialID");
            });

            modelBuilder.Entity<StaOperationServices>(entity =>
            {
                entity.HasKey(e => new { e.OperationId, e.ServiceId })
                    .HasName("staOperationServices_pkey");

                entity.ToTable("staOperationServices", "evesde");

                entity.Property(e => e.OperationId).HasColumnName("operationID");

                entity.Property(e => e.ServiceId).HasColumnName("serviceID");
            });

            modelBuilder.Entity<StaOperations>(entity =>
            {
                entity.HasKey(e => e.OperationId)
                    .HasName("staOperations_pkey");

                entity.ToTable("staOperations", "evesde");

                entity.Property(e => e.OperationId)
                    .HasColumnName("operationID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActivityId).HasColumnName("activityID");

                entity.Property(e => e.AmarrStationTypeId).HasColumnName("amarrStationTypeID");

                entity.Property(e => e.Border).HasColumnName("border");

                entity.Property(e => e.CaldariStationTypeId).HasColumnName("caldariStationTypeID");

                entity.Property(e => e.Corridor).HasColumnName("corridor");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(1000);

                entity.Property(e => e.Fringe).HasColumnName("fringe");

                entity.Property(e => e.GallenteStationTypeId).HasColumnName("gallenteStationTypeID");

                entity.Property(e => e.Hub).HasColumnName("hub");

                entity.Property(e => e.JoveStationTypeId).HasColumnName("joveStationTypeID");

                entity.Property(e => e.MinmatarStationTypeId).HasColumnName("minmatarStationTypeID");

                entity.Property(e => e.OperationName)
                    .HasColumnName("operationName")
                    .HasMaxLength(100);

                entity.Property(e => e.Ratio).HasColumnName("ratio");
            });

            modelBuilder.Entity<StaServices>(entity =>
            {
                entity.HasKey(e => e.ServiceId)
                    .HasName("staServices_pkey");

                entity.ToTable("staServices", "evesde");

                entity.Property(e => e.ServiceId)
                    .HasColumnName("serviceID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(1000);

                entity.Property(e => e.ServiceName)
                    .HasColumnName("serviceName")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<StaStationTypes>(entity =>
            {
                entity.HasKey(e => e.StationTypeId)
                    .HasName("staStationTypes_pkey");

                entity.ToTable("staStationTypes", "evesde");

                entity.Property(e => e.StationTypeId)
                    .HasColumnName("stationTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Conquerable).HasColumnName("conquerable");

                entity.Property(e => e.DockEntryX).HasColumnName("dockEntryX");

                entity.Property(e => e.DockEntryY).HasColumnName("dockEntryY");

                entity.Property(e => e.DockEntryZ).HasColumnName("dockEntryZ");

                entity.Property(e => e.DockOrientationX).HasColumnName("dockOrientationX");

                entity.Property(e => e.DockOrientationY).HasColumnName("dockOrientationY");

                entity.Property(e => e.DockOrientationZ).HasColumnName("dockOrientationZ");

                entity.Property(e => e.OfficeSlots).HasColumnName("officeSlots");

                entity.Property(e => e.OperationId).HasColumnName("operationID");

                entity.Property(e => e.ReprocessingEfficiency).HasColumnName("reprocessingEfficiency");
            });

            modelBuilder.Entity<StaStations>(entity =>
            {
                entity.HasKey(e => e.StationId)
                    .HasName("staStations_pkey");

                entity.ToTable("staStations", "evesde");

                entity.HasIndex(e => e.ConstellationId)
                    .HasName("ix_evesde_staStations_constellationID");

                entity.HasIndex(e => e.CorporationId)
                    .HasName("ix_evesde_staStations_corporationID");

                entity.HasIndex(e => e.OperationId)
                    .HasName("ix_evesde_staStations_operationID");

                entity.HasIndex(e => e.RegionId)
                    .HasName("ix_evesde_staStations_regionID");

                entity.HasIndex(e => e.SolarSystemId)
                    .HasName("ix_evesde_staStations_solarSystemID");

                entity.HasIndex(e => e.StationTypeId)
                    .HasName("ix_evesde_staStations_stationTypeID");

                entity.Property(e => e.StationId)
                    .HasColumnName("stationID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConstellationId).HasColumnName("constellationID");

                entity.Property(e => e.CorporationId).HasColumnName("corporationID");

                entity.Property(e => e.DockingCostPerVolume).HasColumnName("dockingCostPerVolume");

                entity.Property(e => e.MaxShipVolumeDockable).HasColumnName("maxShipVolumeDockable");

                entity.Property(e => e.OfficeRentalCost).HasColumnName("officeRentalCost");

                entity.Property(e => e.OperationId).HasColumnName("operationID");

                entity.Property(e => e.RegionId).HasColumnName("regionID");

                entity.Property(e => e.ReprocessingEfficiency).HasColumnName("reprocessingEfficiency");

                entity.Property(e => e.ReprocessingHangarFlag).HasColumnName("reprocessingHangarFlag");

                entity.Property(e => e.ReprocessingStationsTake).HasColumnName("reprocessingStationsTake");

                entity.Property(e => e.Security).HasColumnName("security");

                entity.Property(e => e.SolarSystemId).HasColumnName("solarSystemID");

                entity.Property(e => e.StationName)
                    .HasColumnName("stationName")
                    .HasMaxLength(100);

                entity.Property(e => e.StationTypeId).HasColumnName("stationTypeID");

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.Y).HasColumnName("y");

                entity.Property(e => e.Z).HasColumnName("z");
            });

            modelBuilder.Entity<TranslationTables>(entity =>
            {
                entity.HasKey(e => new { e.SourceTable, e.TranslatedKey })
                    .HasName("translationTables_pkey");

                entity.ToTable("translationTables", "evesde");

                entity.Property(e => e.SourceTable)
                    .HasColumnName("sourceTable")
                    .HasMaxLength(200);

                entity.Property(e => e.TranslatedKey)
                    .HasColumnName("translatedKey")
                    .HasMaxLength(200);

                entity.Property(e => e.DestinationTable)
                    .HasColumnName("destinationTable")
                    .HasMaxLength(200);

                entity.Property(e => e.TcGroupId).HasColumnName("tcGroupID");

                entity.Property(e => e.TcId).HasColumnName("tcID");
            });

            modelBuilder.Entity<TrnTranslationColumns>(entity =>
            {
                entity.HasKey(e => e.TcId)
                    .HasName("trnTranslationColumns_pkey");

                entity.ToTable("trnTranslationColumns", "evesde");

                entity.Property(e => e.TcId)
                    .HasColumnName("tcID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ColumnName)
                    .IsRequired()
                    .HasColumnName("columnName")
                    .HasMaxLength(128);

                entity.Property(e => e.MasterId)
                    .HasColumnName("masterID")
                    .HasMaxLength(128);

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasColumnName("tableName")
                    .HasMaxLength(256);

                entity.Property(e => e.TcGroupId).HasColumnName("tcGroupID");
            });

            modelBuilder.Entity<TrnTranslationLanguages>(entity =>
            {
                entity.HasKey(e => e.NumericLanguageId)
                    .HasName("trnTranslationLanguages_pkey");

                entity.ToTable("trnTranslationLanguages", "evesde");

                entity.Property(e => e.NumericLanguageId)
                    .HasColumnName("numericLanguageID")
                    .ValueGeneratedNever();

                entity.Property(e => e.LanguageId)
                    .HasColumnName("languageID")
                    .HasMaxLength(50);

                entity.Property(e => e.LanguageName)
                    .HasColumnName("languageName")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<TrnTranslations>(entity =>
            {
                entity.HasKey(e => new { e.TcId, e.KeyId, e.LanguageId })
                    .HasName("trnTranslations_pkey");

                entity.ToTable("trnTranslations", "evesde");

                entity.Property(e => e.TcId).HasColumnName("tcID");

                entity.Property(e => e.KeyId).HasColumnName("keyID");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("languageID")
                    .HasMaxLength(50);

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text");
            });

            modelBuilder.Entity<WarCombatZoneSystems>(entity =>
            {
                entity.HasKey(e => e.SolarSystemId)
                    .HasName("warCombatZoneSystems_pkey");

                entity.ToTable("warCombatZoneSystems", "evesde");

                entity.Property(e => e.SolarSystemId)
                    .HasColumnName("solarSystemID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CombatZoneId).HasColumnName("combatZoneID");
            });

            modelBuilder.Entity<WarCombatZones>(entity =>
            {
                entity.HasKey(e => e.CombatZoneId)
                    .HasName("warCombatZones_pkey");

                entity.ToTable("warCombatZones", "evesde");

                entity.Property(e => e.CombatZoneId)
                    .HasColumnName("combatZoneID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CenterSystemId).HasColumnName("centerSystemID");

                entity.Property(e => e.CombatZoneName)
                    .HasColumnName("combatZoneName")
                    .HasMaxLength(100);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(500);

                entity.Property(e => e.FactionId).HasColumnName("factionID");
            });
        }

        public IServiceProvider ConfigureServices(IServiceCollection services, string connection)
        {
            _connectionString = connection;

            return services.AddEntityFrameworkNpgsql()
                .AddDbContext<TranquilityContext>()
                .BuildServiceProvider();
        }
    }
}

