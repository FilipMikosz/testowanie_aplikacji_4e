namespace fm6._11;
using Bogus;

public class UnitTest1
{

    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Hobby { get; set; }
        public double Weight { get; set; }
    }

    [Fact]
    public void Test1()
    {
        var userFaker = new Faker<User>()
            .RuleFor(u => u.Name, f => f.Name.FullName())
            .RuleFor(u => u.Age, f => f.Random.Int(80, 120))
            .RuleFor(u => u.Hobby, f => f.Random.Word())
            .RuleFor(u => u.Weight, f => f.Random.Double(50, 150));

        var asdd = userFaker.Generate();

        Assert.InRange(asdd.Age, 18, 79);

        int asd = 123;
    }
}
