namespace Lab11
{
    public interface IService
    {
        string Info();
    }
    public class CsitService : IService
    {
        public string Info()
        {
            return ("This is CSIT information.");
        }
    }

    public class BitService : IService
    {
        public string Info()
        {
            return ("This is BIT information.");
        }
    }
        
}

/*

ACTIVE RECALL NOTES:

LAB: Dependancy Injection

    -> Let's say we have implemented a XService Class containing multiple methods. 
       Now we want to replace every XService implementations with another class YService.
       With tight coupling, where control is on code, we need to change thousands of lines of codes.
       But with loose coupling, where control in on System, we only need to add/change the service in Program.cs.
       (Add services before builder.Build())
      
    -> Inversion of Control: Tight coupling -> Loose Coupling

    -> Constructor injection, method injection, view injection

    -> 3 ways on the basis of scope/lifetime: scope, transcient, singleton
       singleton: one object for all functions, all users
       scope: diff objects for each functions
       transcient: same object, but user can destroy object

    -> Middleware ?
    
*/
