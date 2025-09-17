// See https://aka.ms/new-console-template for more information
List<User> mylist = new();

for (int i = 1; i <= 10; i++)
{
  mylist.Add(new User(i, "", Random.Shared.NextDouble(), true));
}
mylist.ForEach(x => Console.WriteLine($"{x.Score} - {x.Check}"));

Console.WriteLine("Despues del cambio");

mylist.Select(i => i with { Check = i.Score < 0.5 ? true : false })
      .ToList()
      .ForEach(x => Console.WriteLine($"{x.Score} - {x.Check}"));

public record User(int Id, string? Nap, double Score, bool Check);