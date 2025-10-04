using sharks.Models;

namespace sharks.Data
{
    public static class SharkSeedData
    {
        public static List<Shark> GetSharks()
        {
            return new List<Shark>
            {
                new Shark
                {
                    Id = 1,
                    Name = "Jaws",
                    TagId = "TAG-100",
                    Gender = "Female",
                    Length = 3.2,
                    Weight = 580.0,
                    TaggedDate = new DateTime(2024, 5, 12),
                    TaggedLocation = "Australia, Port Lincoln",
                    Notes = "Tiburón tigre juvenil con comportamiento activo",
                    SharkSpeciesId = 2 // Tiburón Tigre
                },
                new Shark
                {
                    Id = 2,
                    Name = "Lemon Drop",
                    TagId = "TAG-200",
                    Gender = "Male",
                    Length = 2.1,
                    Weight = 75.0,
                    TaggedDate = new DateTime(2024, 3, 8),
                    TaggedLocation = "Bahamas, Bimini",
                    Notes = "Tiburón limón joven en excelentes condiciones",
                    SharkSpeciesId = 3 // Tiburón Limón
                },
                new Shark
                {
                    Id = 3,
                    Name = "Bruce",
                    TagId = "TAG-001",
                    Gender = "Male",
                    Length = 4.8,
                    Weight = 1150.0,
                    TaggedDate = new DateTime(2013, 8, 15),
                    TaggedLocation = "Sudáfrica, False Bay",
                    Notes = "Tiburón blanco adulto con cicatrices distintivas en la aleta dorsal",
                    SharkSpeciesId = 1 // Tiburón Blanco
                }
            };
        }

        public static List<SharkTracking> GetSharkTrackingData()
        {
            return new List<SharkTracking>
            {
                new SharkTracking { Id = 1, SharkId = 3, Latitude = -34.60661m, Longitude = 21.15244m, TrackingDateTime = new DateTime(2014, 7, 6, 4, 57, 28) },
                new SharkTracking { Id = 2, SharkId = 3, Latitude = -34.78752m, Longitude = 19.42479m, TrackingDateTime = new DateTime(2014, 6, 23, 2, 40, 9) },
                new SharkTracking { Id = 3, SharkId = 3, Latitude = -34.42487m, Longitude = 21.09754m, TrackingDateTime = new DateTime(2014, 6, 15, 13, 15, 44) },
                new SharkTracking { Id = 4, SharkId = 3, Latitude = -34.70432272m, Longitude = 20.21013441m, TrackingDateTime = new DateTime(2014, 6, 3, 2, 23, 57) },
                new SharkTracking { Id = 5, SharkId = 3, Latitude = -34.65556m, Longitude = 19.37459m, TrackingDateTime = new DateTime(2014, 5, 28, 19, 53, 57) },
                new SharkTracking { Id = 6, SharkId = 3, Latitude = -34.63245m, Longitude = 19.42612m, TrackingDateTime = new DateTime(2014, 4, 11, 0, 56, 6) },
                new SharkTracking { Id = 7, SharkId = 3, Latitude = -34.62952m, Longitude = 19.42943m, TrackingDateTime = new DateTime(2014, 4, 10, 3, 4, 58) },
                new SharkTracking { Id = 8, SharkId = 3, Latitude = -34.62948m, Longitude = 19.42926m, TrackingDateTime = new DateTime(2014, 4, 10, 1, 11, 30) },
                new SharkTracking { Id = 9, SharkId = 3, Latitude = -34.64901797m, Longitude = 20.29276432m, TrackingDateTime = new DateTime(2014, 1, 16, 4, 30, 50) },
                new SharkTracking { Id = 10, SharkId = 3, Latitude = -34.66521297m, Longitude = 20.26497576m, TrackingDateTime = new DateTime(2014, 1, 10, 13, 20, 14) },
                new SharkTracking { Id = 11, SharkId = 3, Latitude = -34.81799m, Longitude = 20.23152m, TrackingDateTime = new DateTime(2014, 1, 8, 1, 23, 54) },
                new SharkTracking { Id = 12, SharkId = 3, Latitude = -34.71725348m, Longitude = 20.13079566m, TrackingDateTime = new DateTime(2013, 12, 28, 0, 4, 59) },
                new SharkTracking { Id = 13, SharkId = 3, Latitude = -34.71818947m, Longitude = 20.12474436m, TrackingDateTime = new DateTime(2013, 12, 27, 14, 15, 25) },
                new SharkTracking { Id = 14, SharkId = 3, Latitude = -34.72023786m, Longitude = 20.11244288m, TrackingDateTime = new DateTime(2013, 12, 26, 8, 43, 24) },
                new SharkTracking { Id = 15, SharkId = 3, Latitude = -34.72199931m, Longitude = 20.11298288m, TrackingDateTime = new DateTime(2013, 12, 26, 7, 55, 39) },
                new SharkTracking { Id = 16, SharkId = 3, Latitude = -34.73791136m, Longitude = 20.0834699m, TrackingDateTime = new DateTime(2013, 12, 25, 17, 1, 0) },
                new SharkTracking { Id = 17, SharkId = 3, Latitude = -34.72689m, Longitude = 20.09885m, TrackingDateTime = new DateTime(2013, 12, 24, 22, 40, 11) },
                new SharkTracking { Id = 18, SharkId = 3, Latitude = -34.73446m, Longitude = 20.08771m, TrackingDateTime = new DateTime(2013, 12, 24, 16, 29, 27) },
                new SharkTracking { Id = 19, SharkId = 3, Latitude = -34.74514747m, Longitude = 20.07850746m, TrackingDateTime = new DateTime(2013, 12, 24, 12, 58, 21) },
                new SharkTracking { Id = 20, SharkId = 3, Latitude = -34.72674m, Longitude = 20.10565m, TrackingDateTime = new DateTime(2013, 12, 23, 15, 4, 22) },
                new SharkTracking { Id = 21, SharkId = 3, Latitude = -34.71498566m, Longitude = 20.13827425m, TrackingDateTime = new DateTime(2013, 12, 23, 15, 0, 52) },
                new SharkTracking { Id = 22, SharkId = 3, Latitude = -34.72938875m, Longitude = 20.10850444m, TrackingDateTime = new DateTime(2013, 12, 23, 14, 31, 11) },
                new SharkTracking { Id = 23, SharkId = 3, Latitude = -34.74924733m, Longitude = 20.07331304m, TrackingDateTime = new DateTime(2013, 12, 23, 11, 31, 43) },
                new SharkTracking { Id = 24, SharkId = 3, Latitude = -34.76028641m, Longitude = 20.06214768m, TrackingDateTime = new DateTime(2013, 12, 22, 11, 34, 24) },
                new SharkTracking { Id = 25, SharkId = 3, Latitude = -34.7766m, Longitude = 20.05964m, TrackingDateTime = new DateTime(2013, 12, 22, 0, 56, 10) },
                new SharkTracking { Id = 26, SharkId = 3, Latitude = -34.88268m, Longitude = 20.28008m, TrackingDateTime = new DateTime(2013, 12, 21, 11, 44, 7) },
                new SharkTracking { Id = 27, SharkId = 3, Latitude = -34.72235m, Longitude = 20.35575m, TrackingDateTime = new DateTime(2013, 12, 7, 21, 19, 33) },
                new SharkTracking { Id = 28, SharkId = 3, Latitude = -34.65221m, Longitude = 20.4527m, TrackingDateTime = new DateTime(2013, 12, 3, 1, 22, 10) },
                new SharkTracking { Id = 29, SharkId = 3, Latitude = -34.6388m, Longitude = 20.49682m, TrackingDateTime = new DateTime(2013, 12, 2, 18, 54, 48) },
                new SharkTracking { Id = 30, SharkId = 3, Latitude = -34.70552m, Longitude = 20.44697m, TrackingDateTime = new DateTime(2013, 12, 2, 6, 28, 33) },
                new SharkTracking { Id = 31, SharkId = 3, Latitude = -34.73442m, Longitude = 20.42501m, TrackingDateTime = new DateTime(2013, 12, 2, 4, 46, 28) },
                new SharkTracking { Id = 32, SharkId = 3, Latitude = -34.71613m, Longitude = 20.43019m, TrackingDateTime = new DateTime(2013, 12, 2, 1, 28, 30) },
                new SharkTracking { Id = 33, SharkId = 3, Latitude = -34.70838m, Longitude = 20.42146m, TrackingDateTime = new DateTime(2013, 12, 1, 20, 47, 28) },
                new SharkTracking { Id = 34, SharkId = 3, Latitude = -34.64913m, Longitude = 20.3989m, TrackingDateTime = new DateTime(2013, 12, 1, 3, 20, 58) },
                new SharkTracking { Id = 35, SharkId = 3, Latitude = -34.64329m, Longitude = 20.40279m, TrackingDateTime = new DateTime(2013, 11, 30, 23, 42, 49) },
                new SharkTracking { Id = 36, SharkId = 3, Latitude = -34.15962m, Longitude = 22.12554m, TrackingDateTime = new DateTime(2013, 10, 9, 4, 43, 43) },
                new SharkTracking { Id = 37, SharkId = 3, Latitude = -34.15764m, Longitude = 22.13796m, TrackingDateTime = new DateTime(2013, 10, 6, 8, 13, 28) },
                new SharkTracking { Id = 38, SharkId = 3, Latitude = -34.17173m, Longitude = 22.13131m, TrackingDateTime = new DateTime(2013, 10, 6, 8, 9, 4) },
                new SharkTracking { Id = 39, SharkId = 3, Latitude = -34.17378m, Longitude = 22.13501m, TrackingDateTime = new DateTime(2013, 10, 5, 12, 59, 45) },
                new SharkTracking { Id = 40, SharkId = 3, Latitude = -34.51822475m, Longitude = 20.64837612m, TrackingDateTime = new DateTime(2013, 10, 1, 12, 31, 22) },
                new SharkTracking { Id = 41, SharkId = 3, Latitude = -34.47014m, Longitude = 21.26723m, TrackingDateTime = new DateTime(2013, 9, 30, 20, 0, 28) },
                new SharkTracking { Id = 42, SharkId = 3, Latitude = -34.54551m, Longitude = 20.4386m, TrackingDateTime = new DateTime(2013, 9, 29, 20, 12, 0) },
                new SharkTracking { Id = 43, SharkId = 3, Latitude = -34.54551m, Longitude = 20.4386m, TrackingDateTime = new DateTime(2013, 9, 29, 11, 12, 0) },
                new SharkTracking { Id = 44, SharkId = 3, Latitude = -34.63555m, Longitude = 20.3954m, TrackingDateTime = new DateTime(2013, 9, 28, 23, 22, 11) },
                new SharkTracking { Id = 45, SharkId = 3, Latitude = -34.6779m, Longitude = 20.3477m, TrackingDateTime = new DateTime(2013, 9, 28, 21, 43, 31) },
                new SharkTracking { Id = 46, SharkId = 3, Latitude = -34.46257m, Longitude = 20.48244m, TrackingDateTime = new DateTime(2013, 9, 28, 21, 34, 6) },
                new SharkTracking { Id = 47, SharkId = 3, Latitude = -34.69846m, Longitude = 20.30791m, TrackingDateTime = new DateTime(2013, 9, 28, 20, 59, 2) },
                new SharkTracking { Id = 48, SharkId = 3, Latitude = -34.69825m, Longitude = 20.31532m, TrackingDateTime = new DateTime(2013, 9, 28, 20, 28, 38) },
                new SharkTracking { Id = 49, SharkId = 3, Latitude = -34.63555m, Longitude = 20.3954m, TrackingDateTime = new DateTime(2013, 9, 28, 14, 22, 11) },
                new SharkTracking { Id = 50, SharkId = 3, Latitude = -34.6779m, Longitude = 20.3477m, TrackingDateTime = new DateTime(2013, 9, 28, 12, 43, 31) },
                new SharkTracking { Id = 51, SharkId = 3, Latitude = -34.69846m, Longitude = 20.30791m, TrackingDateTime = new DateTime(2013, 9, 28, 11, 59, 2) },
                new SharkTracking { Id = 52, SharkId = 3, Latitude = -34.69825m, Longitude = 20.31532m, TrackingDateTime = new DateTime(2013, 9, 28, 11, 28, 38) },
                new SharkTracking { Id = 53, SharkId = 3, Latitude = -34.44422m, Longitude = 21.16081m, TrackingDateTime = new DateTime(2013, 9, 13, 16, 7, 49) },
                new SharkTracking { Id = 54, SharkId = 3, Latitude = -34.44657m, Longitude = 21.17197m, TrackingDateTime = new DateTime(2013, 9, 13, 15, 21, 36) },
                new SharkTracking { Id = 55, SharkId = 3, Latitude = -34.49684m, Longitude = 20.63756m, TrackingDateTime = new DateTime(2013, 9, 4, 17, 47, 1) },
                new SharkTracking { Id = 56, SharkId = 3, Latitude = -34.49818m, Longitude = 20.64247m, TrackingDateTime = new DateTime(2013, 9, 4, 16, 40, 31) },
                new SharkTracking { Id = 57, SharkId = 3, Latitude = -34.50088m, Longitude = 20.66081m, TrackingDateTime = new DateTime(2013, 9, 4, 15, 17, 1) },
                new SharkTracking { Id = 58, SharkId = 3, Latitude = -34.52897m, Longitude = 20.72558m, TrackingDateTime = new DateTime(2013, 9, 4, 11, 55, 2) },
                new SharkTracking { Id = 59, SharkId = 3, Latitude = -34.5428m, Longitude = 20.75023m, TrackingDateTime = new DateTime(2013, 9, 4, 11, 17, 17) },
                new SharkTracking { Id = 60, SharkId = 3, Latitude = -34.60189m, Longitude = 20.68672m, TrackingDateTime = new DateTime(2013, 9, 4, 11, 4, 34) },
                new SharkTracking { Id = 61, SharkId = 3, Latitude = -34.65501m, Longitude = 20.79118m, TrackingDateTime = new DateTime(2013, 9, 4, 8, 41, 39) },
                new SharkTracking { Id = 62, SharkId = 3, Latitude = -34.65861m, Longitude = 20.7957m, TrackingDateTime = new DateTime(2013, 9, 4, 8, 39, 50) },
                new SharkTracking { Id = 63, SharkId = 3, Latitude = -34.32848m, Longitude = 21.96493m, TrackingDateTime = new DateTime(2013, 9, 2, 18, 32, 45) },
                new SharkTracking { Id = 64, SharkId = 3, Latitude = -34.30852m, Longitude = 21.98008m, TrackingDateTime = new DateTime(2013, 9, 2, 17, 27, 20) },
                new SharkTracking { Id = 65, SharkId = 3, Latitude = -34.30231m, Longitude = 21.98067m, TrackingDateTime = new DateTime(2013, 9, 2, 13, 55, 48) },
                new SharkTracking { Id = 66, SharkId = 3, Latitude = -34.12634m, Longitude = 22.64236m, TrackingDateTime = new DateTime(2013, 9, 1, 16, 38, 16) },
                new SharkTracking { Id = 67, SharkId = 3, Latitude = -34.23273m, Longitude = 22.45301m, TrackingDateTime = new DateTime(2013, 9, 1, 14, 12, 24) },
                new SharkTracking { Id = 68, SharkId = 3, Latitude = -34.21839m, Longitude = 22.4774m, TrackingDateTime = new DateTime(2013, 8, 31, 18, 16, 24) },
                new SharkTracking { Id = 69, SharkId = 3, Latitude = -34.22934m, Longitude = 22.44067m, TrackingDateTime = new DateTime(2013, 8, 31, 16, 50, 36) },
                new SharkTracking { Id = 70, SharkId = 3, Latitude = -34.25628m, Longitude = 22.45015m, TrackingDateTime = new DateTime(2013, 8, 31, 16, 38, 35) },
                new SharkTracking { Id = 71, SharkId = 3, Latitude = -34.27734m, Longitude = 22.41724m, TrackingDateTime = new DateTime(2013, 8, 31, 15, 59, 53) },
                new SharkTracking { Id = 72, SharkId = 3, Latitude = -34.26512m, Longitude = 22.39777m, TrackingDateTime = new DateTime(2013, 8, 31, 15, 10, 25) },
                new SharkTracking { Id = 73, SharkId = 3, Latitude = -34.15828m, Longitude = 22.24393m, TrackingDateTime = new DateTime(2013, 8, 31, 11, 34, 12) },
                new SharkTracking { Id = 74, SharkId = 3, Latitude = -34.13532m, Longitude = 22.22857m, TrackingDateTime = new DateTime(2013, 8, 31, 10, 47, 33) },
                new SharkTracking { Id = 75, SharkId = 3, Latitude = -34.13463m, Longitude = 22.21766m, TrackingDateTime = new DateTime(2013, 8, 31, 10, 23, 47) },
                new SharkTracking { Id = 76, SharkId = 3, Latitude = -34.12228m, Longitude = 22.31021m, TrackingDateTime = new DateTime(2013, 8, 30, 16, 13, 2) },
                new SharkTracking { Id = 77, SharkId = 3, Latitude = -34.1137m, Longitude = 22.26619m, TrackingDateTime = new DateTime(2013, 8, 30, 15, 21, 28) },
                new SharkTracking { Id = 78, SharkId = 3, Latitude = -34.10375m, Longitude = 22.31803m, TrackingDateTime = new DateTime(2013, 8, 29, 15, 36, 19) },
                new SharkTracking { Id = 79, SharkId = 3, Latitude = -34.52087m, Longitude = 21.43964m, TrackingDateTime = new DateTime(2013, 8, 26, 13, 30, 24) },
                new SharkTracking { Id = 80, SharkId = 3, Latitude = -34.54522m, Longitude = 21.39502m, TrackingDateTime = new DateTime(2013, 8, 26, 12, 24, 43) },
                new SharkTracking { Id = 81, SharkId = 3, Latitude = -34.47109m, Longitude = 20.95329m, TrackingDateTime = new DateTime(2013, 8, 26, 9, 46, 34) },
                new SharkTracking { Id = 82, SharkId = 3, Latitude = -34.45055m, Longitude = 20.93336m, TrackingDateTime = new DateTime(2013, 8, 25, 22, 21, 54) },
                new SharkTracking { Id = 83, SharkId = 3, Latitude = -34.45245m, Longitude = 20.94796m, TrackingDateTime = new DateTime(2013, 8, 25, 21, 20, 46) },
                new SharkTracking { Id = 84, SharkId = 3, Latitude = -34.45403m, Longitude = 20.94616m, TrackingDateTime = new DateTime(2013, 8, 25, 21, 5, 15) },
                new SharkTracking { Id = 85, SharkId = 3, Latitude = -34.44983m, Longitude = 21.1831m, TrackingDateTime = new DateTime(2013, 8, 25, 8, 53, 17) },
                new SharkTracking { Id = 86, SharkId = 3, Latitude = -34.46785m, Longitude = 21.22962m, TrackingDateTime = new DateTime(2013, 8, 25, 7, 49, 0) },
                new SharkTracking { Id = 87, SharkId = 3, Latitude = -34.49348m, Longitude = 21.2746m, TrackingDateTime = new DateTime(2013, 8, 25, 7, 11, 0) },
                new SharkTracking { Id = 88, SharkId = 3, Latitude = -34.49699m, Longitude = 21.28103m, TrackingDateTime = new DateTime(2013, 8, 25, 6, 32, 54) },
                new SharkTracking { Id = 89, SharkId = 3, Latitude = -34.51975m, Longitude = 21.29639m, TrackingDateTime = new DateTime(2013, 8, 25, 6, 6, 55) },
                new SharkTracking { Id = 90, SharkId = 3, Latitude = -34.52007m, Longitude = 21.33642m, TrackingDateTime = new DateTime(2013, 8, 25, 5, 43, 37) },
                new SharkTracking { Id = 91, SharkId = 3, Latitude = -34.50537m, Longitude = 21.36702m, TrackingDateTime = new DateTime(2013, 8, 25, 4, 55, 26) },
                new SharkTracking { Id = 92, SharkId = 3, Latitude = -34.48439m, Longitude = 21.42315m, TrackingDateTime = new DateTime(2013, 8, 25, 4, 2, 58) },
                new SharkTracking { Id = 93, SharkId = 3, Latitude = -34.47644m, Longitude = 21.5909m, TrackingDateTime = new DateTime(2013, 8, 25, 2, 24, 41) },
                new SharkTracking { Id = 94, SharkId = 3, Latitude = -34.43018m, Longitude = 21.60368m, TrackingDateTime = new DateTime(2013, 8, 25, 0, 26, 31) },
                new SharkTracking { Id = 95, SharkId = 3, Latitude = -34.24022m, Longitude = 22.2462m, TrackingDateTime = new DateTime(2013, 8, 16, 12, 33, 29) },
                new SharkTracking { Id = 96, SharkId = 3, Latitude = -34.21432m, Longitude = 22.25141m, TrackingDateTime = new DateTime(2013, 8, 16, 11, 45, 21) },
                new SharkTracking { Id = 97, SharkId = 3, Latitude = -34.21241m, Longitude = 22.2579m, TrackingDateTime = new DateTime(2013, 8, 16, 11, 44, 29) },
                new SharkTracking { Id = 98, SharkId = 3, Latitude = -34.16615m, Longitude = 22.24365m, TrackingDateTime = new DateTime(2013, 8, 16, 10, 57, 28) }
            };
        }
    }
}
