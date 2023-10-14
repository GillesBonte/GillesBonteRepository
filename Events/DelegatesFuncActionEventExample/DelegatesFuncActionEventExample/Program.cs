internal class Program
{
    public static void Main(string[] args)
    {
        var guild = new Guild();
        var welcomer = new MemberWelcomer();
        var hall = new GuildHall();

        //public NONstatic events
        //guild.NewMemberAdded += welcomer.WelcomeMember;
        //guild.NewMemberAdded += hall.AddBedroom;

        guild.AddMember("Gilles");
    }

}

public class Guild
{
    private readonly List<string> _members = new List<string>();

    //public NONstatic events
    //public event Action<string> NewMemberAdded;

    //public STATIC events
    public static event Action<string> NewMemberAdded;

    public void AddMember(string strMemberName)
    {
        _members.Add(strMemberName);
        NewMemberAdded?.Invoke(strMemberName);
    }

}

public class MemberWelcomer
{
    public MemberWelcomer() 
    {
        Guild.NewMemberAdded += WelcomeMember;
    } 
    public void WelcomeMember(string strMemberName)
    {
        Console.WriteLine($"Welcome {strMemberName}.");
    }

}

public class GuildHall
{
    public void AddBedroom(string strMemberName)
    {
        Console.WriteLine($"A room was added to the guild hall for {strMemberName}");
    }

}

