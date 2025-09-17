Console.WriteLine($"\nGit Branch = Main\n");
List<User> mylist = new();

for (int i = 1; i <= 10; i++)
{
  mylist.Add(new User(i, "", Random.Shared.NextDouble(), true));
}
mylist.ForEach(x => Console.WriteLine($"{x.Score} - {x.Check}"));

Console.WriteLine("Despues del cambio");

mylist.Select(i => Cambios(i))
      .ToList()
      .ForEach(x => Console.WriteLine($"{x.Score} - {x.Check}"));

static User Cambios(User user)
{
  return user with
  {
    Check = user.Score < 0.5,
    Score = Math.Round(user.Score,2)
  };
}
public record User(int Id, string? Nap, double Score, bool Check);
