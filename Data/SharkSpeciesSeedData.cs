using sharks.Models;

namespace sharks.Data
{
    public static class SharkSpeciesSeedData
    {
        public static List<SharkSpecies> GetSharkSpecies()
        {
            return new List<SharkSpecies>
            {
                new SharkSpecies
                {
                    Id = 1,
                    Name = "Tiburón Blanco",
                    ScientificName = "Carcharodon carcharias",
                    Description = "El gran tiburón blanco es uno de los depredadores marinos más grandes y temidos del océano.",
                    AverageLength = 5.0,
                    AverageWeight = 1000.0,
                    Habitat = "Aguas costeras templadas y tropicales",
                    DangerLevel = "High",
                    ConservationStatus = "Vulnerable"
                },
                new SharkSpecies
                {
                    Id = 2,
                    Name = "Tiburón Tigre",
                    ScientificName = "Galeocerdo cuvier",
                    Description = "Conocido por su patrón de rayas distintivo y su dieta variada.",
                    AverageLength = 4.25,
                    AverageWeight = 635.0,
                    Habitat = "Aguas tropicales y subtropicales",
                    DangerLevel = "High",
                    ConservationStatus = "Near Threatened"
                },
                new SharkSpecies
                {
                    Id = 3,
                    Name = "Tiburón Limón",
                    ScientificName = "Negaprion brevirostris",
                    Description = "Tiburón de color amarillento que habita en aguas poco profundas.",
                    AverageLength = 2.4,
                    AverageWeight = 90.0,
                    Habitat = "Aguas costeras poco profundas, manglares",
                    DangerLevel = "Medium",
                    ConservationStatus = "Vulnerable"
                },
                new SharkSpecies
                {
                    Id = 4,
                    Name = "Tiburón Martillo",
                    ScientificName = "Sphyrna lewini",
                    Description = "Reconocible por su cabeza en forma de martillo distintiva.",
                    AverageLength = 3.7,
                    AverageWeight = 152.0,
                    Habitat = "Aguas costeras tropicales y subtropicales",
                    DangerLevel = "Medium",
                    ConservationStatus = "Critically Endangered"
                },
                new SharkSpecies
                {
                    Id = 5,
                    Name = "Tiburón Toro",
                    ScientificName = "Carcharhinus leucas",
                    Description = "Conocido por su capacidad de vivir tanto en agua salada como dulce.",
                    AverageLength = 2.5,
                    AverageWeight = 130.0,
                    Habitat = "Aguas costeras, ríos, lagos",
                    DangerLevel = "High",
                    ConservationStatus = "Vulnerable"
                },
                new SharkSpecies
                {
                    Id = 6,
                    Name = "Tiburón Azul",
                    ScientificName = "Prionace glauca",
                    Description = "Tiburón pelágico con una coloración azul distintiva.",
                    AverageLength = 3.0,
                    AverageWeight = 80.0,
                    Habitat = "Aguas abiertas del océano",
                    DangerLevel = "Low",
                    ConservationStatus = "Near Threatened"
                }
            };
        }
    }
}
