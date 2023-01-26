

using Task5.Data.Entites;

namespace Task5.Data
{
    public class ApplicaionRepository : IApplicationRepository
    {
        private readonly ApplicationContext _context;

        public ApplicaionRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<Cities> GetCitiesByLocale(string locale, int seed, int number)
        {
            List<Cities> cities = _context.Cities.Where(c => c.Locale == locale).ToList();
            List<Cities> result = new List<Cities>();
            Random random = new Random(seed);
            for (int i = 0; i < number; i++)
                result.Add(cities[random.Next() % cities.Count]);
            return result;
        }

        public IEnumerable<CityTypes> GetCityTypesByLocale(string locale, int seed, int number)
        {
            List<CityTypes> cityTypes = _context.CityTypes.Where(c => c.Locale == locale).ToList();
            List<CityTypes> result = new List<CityTypes>();
            Random random = new Random(seed);
            for (int i = 0; i < number; i++)
                result.Add(cityTypes[random.Next() % cityTypes.Count]);
            return result;
        }

        public IEnumerable<Identifiers> GetIdentifiersByLocale(string locale, int seed, int number)
        {
            List<Identifiers> identifiers = _context.Identifiers.Where(c => c.Locale == locale).ToList();
            List<Identifiers> result = new List<Identifiers>();
            Random random = new Random(seed);
            for (int i = 0; i < number; i++)
                result.Add(identifiers[random.Next() % identifiers.Count]);
            return result;
        }

        public IEnumerable<Names> GetNamesByLocale(string locale, int seed, int number)
        {
            List<Names> names = _context.Names.Where(c => c.Locale == locale).ToList();
            List<Names> result = new List<Names>();
            Random random = new Random(seed);
            for (int i = 0; i < number; i++)
                result.Add(names[random.Next() % names.Count]);
            return result;
        }

        public IEnumerable<PhoneTypes> GetPhoneTypesByLocale(string locale, int seed, int number)
        {
            List<PhoneTypes> phoneTypes = _context.PhoneTypes.Where(c => c.Locale == locale).ToList();
            List<PhoneTypes> result = new List<PhoneTypes>();
            Random random = new Random(seed);
            for (int i = 0; i < number; i++)
                result.Add(phoneTypes[random.Next() % phoneTypes.Count]);
            return result;
        }

        public IEnumerable<Regions> GetRegionsByLocale(string locale, int seed, int number)
        {
            List<Regions> regions = _context.Regions.Where(c => c.Locale == locale).ToList();
            List<Regions> result = new List<Regions>();
            Random random = new Random(seed);
            for (int i = 0; i < number; i++)
                result.Add(regions[random.Next() % regions.Count]);
            return result;
        }

        public IEnumerable<Streets> GetStreetsByLocale(string locale, int seed, int number)
        {
            List<Streets> streets = _context.Streets.Where(c => c.Locale == locale).ToList();
            List<Streets> result = new List<Streets>();
            Random random = new Random(seed);
            for (int i = 0; i < number; i++)
                result.Add(streets[random.Next() % streets.Count]);
            return result;
        }

        public IEnumerable<StreetTypes> GetStreetTypesByLocale(string locale, int seed, int number)
        {
            List<StreetTypes> streetTypes = _context.StreetTypes.Where(c => c.Locale == locale).ToList();
            List<StreetTypes> result = new List<StreetTypes>();
            Random random = new Random(seed);
            for (int i = 0; i < number; i++)
                result.Add(streetTypes[random.Next() % streetTypes.Count]);
            return result;
        }

        public IEnumerable<Surnames> GetSurnamesByLocale(string locale, int seed, int number)
        {
            List<Surnames> surnames = _context.Surnames.Where(c => c.Locale == locale).ToList();
            List<Surnames> result = new List<Surnames>();
            Random random = new Random(seed);
            for (int i = 0; i < number; i++)
                result.Add(surnames[random.Next() % surnames.Count]);
            return result;
        }

    }
}
