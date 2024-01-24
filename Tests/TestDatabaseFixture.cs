using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaKiosk.Model;

namespace Tests
{
    [CollectionDefinition("Database collection")]
    public class DatabaseCollection : ICollectionFixture<TestDatabaseFixture>
    {
        // This class has no code, and is never created. Its purpose is simply
        // to be the place to apply [CollectionDefinition] and all the
        // ICollectionFixture<> interfaces.
    }
    public class TestDatabaseFixture
    {
        private static readonly object _lock = new();
        public static bool _databaseInitialized;

        public TestDatabaseFixture() 
        { 
            lock (_lock)
            {
                if (!_databaseInitialized) 
                {
                    using (var context = CreateContext())
                    {
                        context.Database.EnsureDeleted();
                        context.Database.EnsureCreated();

                    }

                    _databaseInitialized = true;
                }
            }
        }
        public KoiskContext CreateContext() => new KoiskContext("test.db");
    }

}
