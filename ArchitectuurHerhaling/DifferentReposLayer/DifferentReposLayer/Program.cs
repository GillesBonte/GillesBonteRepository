using DRLRepositoryEF;
using DRLUserModel;

IRepo dataRepo = new RepoEF();
//IRepo dataRepo = new RepoJSON();

//Test Adding
User nieuweUser = new User() { Id = 9, Name = "MVP", Function = "BOSS" };
dataRepo.Add(nieuweUser);

//Show All
ShowAll(dataRepo);

//Test Deleting
dataRepo.Delete(nieuweUser);
//Show All
ShowAll(dataRepo);




static void ShowAll(IRepo dataRepo)
{
    foreach (User user in dataRepo.GetAll())
    {
        Console.WriteLine($"Id = {user.Id}");
        Console.WriteLine($"Name = {user.Name}");
        Console.WriteLine($"Function = {user.Function}");
        Console.WriteLine();
    }
    Console.ReadLine();
}