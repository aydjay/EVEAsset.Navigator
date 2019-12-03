SELECT array_to_json(array_agg(row_to_json(r)))
FROM (
	SELECT evesde."mapSolarSystems"."solarSystemID"
		,evesde."mapSolarSystems"."solarSystemName"
		,evesde."mapSolarSystems"."regionID"
		,evesde."mapRegions"."regionName"
	FROM evesde."mapSolarSystems"
	LEFT JOIN evesde."mapRegions" ON evesde."mapRegions"."regionID" = evesde."mapSolarSystems"."regionID"
	WHERE "solarSystemName" IN (
			'Podion'
			,'Odebeinn'
			,'Egbinger'
			,'Misaba'
			,'Konora'
			,'Daras'
			,'Irmalin'
			,'Saminer'
			,'Villasen'
			,'Hakonen'
			,'Otitoh'
			,'Faspera'
			,'Gehi'
			,'Hophib'
			,'Toustain'
			,'Agaullores'
			,'Iitanmadan'
			,'Anin'
			,'Chardalane'
			,'Obe'
			,'Skarkon'
			,'Sieh'
			)
	) r;
