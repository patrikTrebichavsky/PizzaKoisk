using System.Runtime.Serialization;
using PizzaKiosk.Model;

namespace Tests
{
    [Collection("Database Collection")]
    public class PizzaContextTest : IClassFixture<TestDatabaseFixture>
    {
        public PizzaContextTest(TestDatabaseFixture fixture) => Fixture = fixture;

        public TestDatabaseFixture Fixture { get; }
        
        [Fact]
        public void PizzaJeSmakulada()
        {
             using KoiskContext context = Fixture.CreateContext();
            
             Pizza pizza = context.Pizzas.Single(p => p.Id == 1);

            Assert.Equal("Smakulada", pizza.Name);
        }

        [Fact]
        public void PizzaNazvy()
        {
            using KoiskContext context = Fixture.CreateContext();
            
            
            Assert.Collection(context.Pizzas,
            p1 => 
            {
                Assert.Equal(1, p1.Id);
                Assert.Equal("Smakulada", p1.Name);
            },
            p2 =>
            {
                Assert.Equal(2, p2.Id);
                Assert.Equal("Dobrotka", p2.Name);
            });
        }
    }
}
