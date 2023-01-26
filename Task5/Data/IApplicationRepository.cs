using Task5.Data.Entites;

namespace Task5.Data
{
    public interface IApplicationRepository
    {
        public IEnumerable<Cities> GetCitiesByLocale(string locale, int seed, int number);

        public IEnumerable<CityTypes> GetCityTypesByLocale(string locale, int seed, int number);

        public IEnumerable<Identifiers> GetIdentifiersByLocale(string locale, int seed, int number);

        public IEnumerable<Names> GetNamesByLocale(string locale, int seed, int number);

        public IEnumerable<PhoneTypes> GetPhoneTypesByLocale(string locale, int seed, int number);

        public IEnumerable<Regions> GetRegionsByLocale(string locale, int seed, int number);

        public IEnumerable<Streets> GetStreetsByLocale(string locale, int seed, int number);

        public IEnumerable<StreetTypes> GetStreetTypesByLocale(string locale, int seed, int number);

        public IEnumerable<Surnames> GetSurnamesByLocale(string locale, int seed, int number);
    }
}
