using System;
using System.Collections.Generic;
using Starti.Persistence.Data.ContextConfigurer;

namespace Starti.Persistence.Data
{
    internal static class DbContextConfigurerMap
    {
        private static readonly Dictionary<string, Type> configurerMap = new Dictionary<string, Type>
        {
            { "npgsql", typeof(NpgsqlDbContextConfigurer) },
            { "sqlserver", typeof(SqlServerDbContextConfigurer) }
        };

        public static Type GetType(string dbProvider)
        {
            if (configurerMap.TryGetValue(dbProvider.ToLower(), out Type configurerType))
            {
                return configurerType;
            }
            throw new ArgumentException($"Unsupported database provider: {dbProvider}");
        }
    }
}
