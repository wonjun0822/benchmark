using Bogus;
using BenchmarkDotNet.Attributes;

namespace JsonBenchmark
{
    [RankColumn]
    [MemoryDiagnoser]
    [ThreadingDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    public class JsonBenchmarks
    {
        List<Person> to_small = Person.FakeData.Generate(100).ToList();
        List<Person> to_medium = Person.FakeData.Generate(10000).ToList();
        List<Person> to_large = Person.FakeData.Generate(1000000).ToList();

        [Benchmark]
        public string Serialization_Text_Newtonsoft_To_Small() => Newtonsoft.Json.JsonConvert.SerializeObject(to_small);
        [Benchmark]
        public string Serialization_Text_Newtonsoft_To_Medium() => Newtonsoft.Json.JsonConvert.SerializeObject(to_medium);
        [Benchmark]
        public string Serialization_Text_Newtonsoft_To_Large() => Newtonsoft.Json.JsonConvert.SerializeObject(to_large);

        [Benchmark]
        public string Serialization_Text_SystemTextJson_To_Small() => System.Text.Json.JsonSerializer.Serialize(to_small);
        [Benchmark]
        public string Serialization_Text_SystemTextJson_To_Medium() => System.Text.Json.JsonSerializer.Serialize(to_medium);
        [Benchmark]
        public string Serialization_Text_SystemTextJson_To_Large() => System.Text.Json.JsonSerializer.Serialize(to_large);

        [Benchmark]
        public string Serialization_Text_SpanJson_To_Small() => SpanJson.JsonSerializer.Generic.Utf16.Serialize(to_small);
        [Benchmark]
        public string Serialization_Text_SpanJson_To_Medium() => SpanJson.JsonSerializer.Generic.Utf16.Serialize(to_medium);
        [Benchmark]
        public string Serialization_Text_SpanJson_To_Large() => SpanJson.JsonSerializer.Generic.Utf16.Serialize(to_large);

        [Benchmark]
        public string Serialization_Text_FastJson_To_Small() => fastJSON.JSON.ToJSON(to_small);
        [Benchmark]
        public string Serialization_Text_FastJson_To_Medium() => fastJSON.JSON.ToJSON(to_medium);
        [Benchmark]
        public string Serialization_Text_FastJson_To_Large() => fastJSON.JSON.ToJSON(to_large);
    }

    public class Person
    {
        /// <summary>  Setting this as a starting value for id</summary>
        private static int _userId = 100;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public string Email { get; set; }
        public string SSN { get; set; }
        public string Suffix { get; set; }
        public string Phone { get; set; }

        public static Faker<Person> FakeData { get; } =
            new Faker<Person>()
                .RuleFor(p => p.Id, f => _userId++)
                .RuleFor(p => p.FirstName, f => f.Name.FirstName())
                .RuleFor(p => p.MiddleName, f => f.Name.FirstName())
                .RuleFor(p => p.LastName, f => f.Name.LastName())
                .RuleFor(p => p.Title, f => f.Name.Prefix(f.Person.Gender))
                .RuleFor(p => p.Suffix, f => f.Name.Suffix())
                .RuleFor(p => p.Email, (f, p) => f.Internet.Email(p.FirstName, p.LastName))
                .RuleFor(p => p.DOB, f => f.Date.Past(18))
                .RuleFor(p => p.SSN, f => f.Random.Replace("###-##-####"))
                .RuleFor(p => p.Phone, f => f.Phone.PhoneNumber("(###)-###-####"));
    }
}