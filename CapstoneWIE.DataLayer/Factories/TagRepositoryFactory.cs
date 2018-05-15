using System.Configuration;
using CapstoneWIE.DataLayer.EfRepositories;
using CapstoneWIE.DataLayer.Interfaces;
using CapstoneWIE.DataLayer.Repositories;

namespace CapstoneWIE.DataLayer.Factories
{
    public static class TagRepositoryFactory
    {
        public static ITagRepository GetRepository()
        {
            var mode = ConfigurationManager.AppSettings["Mode"];

            switch (mode)
            {
                case "Dapper":
                    return new TagRepository();
           //     case "Mock":
           //         return new MockTagRepository();
                default:
                    return new EfTagRepository();
            }
        }
    }
}
