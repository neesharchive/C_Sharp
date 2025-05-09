using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
public enum Roles
{
    AdminRole, UserRole
}

interface IRoleChanger
{
    void ChangeRoleTemporarily();
    void RestoreOriginalRole();
}

public class User
{
    public int ID { get; set; }
    public string Name { get; set; }
    public Roles Role { get; set; } = Roles.UserRole;

    public Roles GetRole()
    {
        return Role;
    }
}

public class NormalUser : User
{
    public NormalUser()
    {
        Role = Roles.UserRole;
    }
}

public class Admin : User, IRoleChanger
{
    private Roles OgRole;

    public Admin()
    {
        Role = Roles.AdminRole;
        OgRole = Roles.AdminRole;
    }

    public void ChangeRoleTemporarily()
    {
        Role = Roles.UserRole;
    }

    public void RestoreOriginalRole()
    {
        Role = OgRole;
    }
}

internal class Program
    {
    static void Main(string[] args)
    {
        List<User> users = new List<User>()
            {
                new NormalUser(){ID=101, Name="N"},
                new NormalUser(){ID=102, Name="Ni"},
                new NormalUser(){ID=103, Name="Nish"},
                new NormalUser(){ID=104, Name="Nishant"}
        };
        users.Add(new Admin()
        {
            ID = 100,
            Name = "Nishant Bhatt"
        });

        var GetNameByID = from U in users
                          where U.Role != Roles.AdminRole
                          orderby U.ID
                          select U;

        foreach (User u in GetNameByID)
        {
            Console.WriteLine(u.Name);
        }
        Console.WriteLine("==========");
        var r = from u in users
                where u.ID == 100
                select u.Role;
        {
            Console.WriteLine("Regular Users:");
            foreach (User user in GetNameByID)
            {
                Console.WriteLine($"{user.ID}: {user.Name}");
            }
            Console.WriteLine("==========");
        }

        var GetAdmin = from u in users
                       where u.Role == Roles.AdminRole
                       select u;

        foreach (var a in GetAdmin)
        {
            Console.WriteLine($"{a.ID}: {a.Name}, is the Admin");
        }

        Console.Read();

    }
}
