using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using Task5.Data;
using Task5.Data.Entites;
using Task5.Models;

namespace Task5.Controllers
{
    public class HomeController : Controller
    {
        private readonly IApplicationRepository _repository;
        const int pageSize = 20;

        public HomeController(IApplicationRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index(int? id, int? seed, string? locale)
        {
            var isAjax = Request.Headers["X-Requested-With"] == "XMLHttpRequest";
            int page = id ?? 0;
            int seed1 = seed ?? 0;
            string locale1 = locale ?? "USA";
            if (isAjax)
            {
                return PartialView("_Items", GetItemsPage(page, seed1, locale1));
            }
            return View(GetItemsPage(page, seed1, locale1));
        }

        private List<UserModel> GetItemsPage(int page = 1, int seed = 0, string locale = "USA")
        {
            List<UserModel> _users = new List<UserModel>();
            Random random = new Random(page * pageSize + seed * 10);
            List <Cities> cities = _repository.GetCitiesByLocale(locale, random.Next(), pageSize).ToList();
            List<CityTypes> cityTypes = _repository.GetCityTypesByLocale(locale, random.Next(), pageSize).ToList();
            List<Identifiers> identifiers = _repository.GetIdentifiersByLocale(locale, random.Next(), pageSize).ToList();
            List<Names> names = _repository.GetNamesByLocale(locale, random.Next(), pageSize).ToList();
            List<PhoneTypes> phoneTypes = _repository.GetPhoneTypesByLocale(locale, random.Next(), pageSize).ToList();
            List<Regions> regions = _repository.GetRegionsByLocale(locale, random.Next(), pageSize).ToList();
            List<Streets> streets = _repository.GetStreetsByLocale(locale, random.Next(), pageSize).ToList();
            List<StreetTypes> streetTypes = _repository.GetStreetTypesByLocale(locale, random.Next(), pageSize).ToList();
            List<Surnames> surnames = _repository.GetSurnamesByLocale(locale, random.Next(), pageSize).ToList();

            for (int i = 0; i < pageSize; i++)
            {
                string id = identifiers[i].Identifier;
                string fullName = names[i].Name + " " + surnames[i].Surname;
                string address = regions[i].Region + ", " + cityTypes[i].CityType + " " + cities[i].City + 
                    ", " + streetTypes[i].StreetType + " " + streets[i].Street + ", " + (random.Next() % 150).ToString();
                if (random.Next() % 100 >= 70)
                {
                    address += ", " + (random.Next() % 200).ToString();
                }
                string phone = phoneTypes[i].PhoneType;
                _users.Add(new UserModel()
                {
                    NumberInList = page * pageSize + i,
                    Adress = address,
                    FullName = fullName,
                    Id = id,
                    PhoneNumber = phone
                });
            }

            return _users.Take(pageSize).ToList();
        }

        public int GetRandomNumberWithSeed(int seed)
        {
            return new Random(seed).Next();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}