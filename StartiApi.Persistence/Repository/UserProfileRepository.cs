using System.Collections.Generic;
using System.Linq;
using Starti.Domain.Entities;
using StartiApi.Repositories.Interfaces;

namespace StartiApi.Repositories
{
    internal class UserProfileRepository : IUserProfileRepository
    {
        private readonly List<UserProfile> _userProfiles;

        public UserProfileRepository()
        {
            _userProfiles = new List<UserProfile>
            {
                new UserProfile("1", "John", "Doe", "john@teste.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("2", "Jane", "Doe", "jane.doe@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("3", "Chris", "Smith", "chris.smith@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("4", "Katie", "Brown", "katie.brown@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("5", "Paul", "Davis", "paul.davis@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("6", "Anna", "Wilson", "anna.wilson@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("7", "Michael", "Johnson", "michael.johnson@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("8", "Emily", "Smith", "emily.smith@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("9", "David", "Brown", "david.brown@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("10", "Sophia", "Davis", "sophia.davis@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("11", "James", "Wilson", "james.wilson@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("12", "Isabella", "Johnson", "isabella.johnson@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("13", "Daniel", "Smith", "daniel.smith@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("14", "Mia", "Brown", "mia.brown@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("15", "Matthew", "Davis", "matthew.davis@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("16", "Abigail", "Wilson", "abigail.wilson@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("17", "Anthony", "Johnson", "anthony.johnson@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("18", "Olivia", "Smith", "olivia.smith@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("19", "Joshua", "Brown", "joshua.brown@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("20", "Emma", "Davis", "emma.davis@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("21", "Andrew", "Wilson", "andrew.wilson@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("22", "Ava", "Johnson", "ava.johnson@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("23", "Ryan", "Smith", "ryan.smith@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("24", "Charlotte", "Brown", "charlotte.brown@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("25", "Joseph", "Davis", "joseph.davis@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("26", "Amelia", "Wilson", "amelia.wilson@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("27", "Noah", "Johnson", "noah.johnson@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("28", "Harper", "Smith", "harper.smith@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("29", "Christopher", "Brown", "christopher.brown@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("30", "Ella", "Davis", "ella.davis@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("31", "Ethan", "Wilson", "ethan.wilson@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("32", "Grace", "Johnson", "grace.johnson@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("33", "Nathan", "Smith", "nathan.smith@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("34", "Zoe", "Brown", "zoe.brown@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("35", "Alexander", "Davis", "alexander.davis@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("36", "Riley", "Wilson", "riley.wilson@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("37", "Jack", "Johnson", "jack.johnson@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("38", "Victoria", "Smith", "victoria.smith@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("39", "Sebastian", "Brown", "sebastian.brown@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("40", "Aria", "Davis", "aria.davis@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("41", "Benjamin", "Wilson", "benjamin.wilson@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("42", "Lily", "Johnson", "lily.johnson@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("43", "Samuel", "Smith", "samuel.smith@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("44", "Scarlett", "Brown", "scarlett.brown@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("45", "Henry", "Davis", "henry.davis@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("46", "Chloe", "Wilson", "chloe.wilson@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("47", "David", "Johnson", "david.johnson@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("48", "Eleanor", "Smith", "eleanor.smith@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("49", "Aiden", "Brown", "aiden.brown@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("50", "Nora", "Davis", "nora.davis@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("51", "Lucas", "Wilson", "lucas.wilson@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("52", "Layla", "Johnson", "layla.johnson@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("53", "Isaac", "Smith", "isaac.smith@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("54", "Penelope", "Brown", "penelope.brown@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("55", "Gabriel", "Davis", "gabriel.davis@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("56", "Zoey", "Wilson", "zoey.wilson@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("57", "Logan", "Johnson", "logan.johnson@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("58", "Hazel", "Smith", "hazel.smith@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("59", "Wyatt", "Brown", "wyatt.brown@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("60", "Violet", "Davis", "violet.davis@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("61", "Owen", "Wilson", "owen.wilson@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("62", "Aurora", "Johnson", "aurora.johnson@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("63", "Dylan", "Smith", "dylan.smith@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("64", "Savannah", "Brown", "savannah.brown@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("65", "Luke", "Davis", "luke.davis@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("66", "Mila", "Wilson", "mila.wilson@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("67", "Carter", "Johnson", "carter.johnson@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("68", "Aubrey", "Smith", "aubrey.smith@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("69", "Jayden", "Brown", "jayden.brown@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("70", "Hannah", "Davis", "hannah.davis@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("71", "Grayson", "Wilson", "grayson.wilson@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("72", "Lillian", "Johnson", "lillian.johnson@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("73", "Jaxon", "Smith", "jaxon.smith@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("74", "Sofia", "Brown", "sofia.brown@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("75", "Levi", "Davis", "levi.davis@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("76", "Stella", "Wilson", "stella.wilson@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("77", "Julian", "Johnson", "julian.johnson@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("78", "Brooklyn", "Smith", "brooklyn.smith@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("79", "Lincoln", "Brown", "lincoln.brown@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("80", "Paisley", "Davis", "paisley.davis@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("81", "Eli", "Wilson", "eli.wilson@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("82", "Everly", "Johnson", "everly.johnson@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("83", "Hunter", "Smith", "hunter.smith@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("84", "Kennedy", "Brown", "kennedy.brown@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("85", "Isaiah", "Davis", "isaiah.davis@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("86", "Skylar", "Wilson", "skylar.wilson@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("87", "Aaron", "Johnson", "aaron.johnson@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("88", "Ellie", "Smith", "ellie.smith@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("89", "Charles", "Brown", "charles.brown@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("90", "Leah", "Davis", "leah.davis@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("91", "Caleb", "Wilson", "caleb.wilson@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("92", "Lucy", "Johnson", "lucy.johnson@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("93", "Adam", "Smith", "adam.smith@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("94", "Samantha", "Brown", "samantha.brown@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("95", "Adrian", "Davis", "adrian.davis@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("96", "Hazel", "Wilson", "hazel.wilson@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("97", "Elias", "Johnson", "elias.johnson@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("98", "Kinsley", "Smith", "kinsley.smith@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("99", "Parker", "Brown", "parker.brown@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50)),
                new UserProfile("100", "Naomi", "Davis", "naomi.davis@example.com", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(-50))
            };
        }

        public IEnumerable<UserProfile> GetAll()
        {
            return _userProfiles;
        }

        public UserProfile GetBy(string id)
        {
            return _userProfiles.FirstOrDefault(up => up.Id == id);
        }

        public void Add(UserProfile userProfile)
        {
            _userProfiles.Add(userProfile);
        }

        public void Update(UserProfile userProfile)
        {
            var existingUserProfile = GetBy(userProfile.Id);
            if (existingUserProfile != null)
            {
                existingUserProfile.FirstName = userProfile.FirstName;
                existingUserProfile.LastName = userProfile.LastName;
                existingUserProfile.Email = userProfile.Email;
                existingUserProfile.UpdatedAt = DateTime.Now;
            }
        }

        public void Delete(string id)
        {
            var userProfile = GetBy(id);
            if (userProfile != null)
            {
                _userProfiles.Remove(userProfile);
            }
        }

        public Task<IEnumerable<UserProfile>> GetAsyncBy(string query)
        {
            IEnumerable<UserProfile> result = _userProfiles;

            if (!string.IsNullOrEmpty(query))
                result = _userProfiles.Where(user => user.FirstName.ToLower().Contains(query.ToLower()));
            
            if (!string.IsNullOrEmpty(query))
                result = _userProfiles.Where(user => user.Email.ToLower().Contains(query.ToLower()));
            
            return Task.FromResult(result);
        }
    }
}
