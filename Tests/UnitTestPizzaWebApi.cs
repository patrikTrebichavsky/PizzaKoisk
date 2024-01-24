using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using PizzaKiosk.Model;

namespace Tests
{
    [Collection("Database collection")]
    public class UnitTestPizzaWebApi
    {
        private TestDatabaseFixture Fixture {get;}

        public UnitTestPizzaWebApi(TestDatabaseFixture fixture)
        {
            Fixture = fixture;
        }

        [Fact]
        public async Task thereshouldbetwopizzas()
        {
            using KoiskContext context = Fixture.CreateContext();

            Ok<Pizza[]> result = await WebApiV1.GetAllPizzas(context);

            Assert.NotNull(result);

            Pizza[] pizzas = result.Value;

            Assert.Equal(2, pizzas.Length);

        }
    }
}
