using System.Globalization;
using System.Threading.Channels;

internal class User
{
    private string _name;
    private string _password;
    public string Name
    {
        get => _name;
        set
        {
            if (_name != value)
            {
                _name = value;
            }
            else
            {
                Console.WriteLine("duzgun daxil et");
            }
        }
    }
    public string Password
    {
        get { return _password; }
        set
        {
            
            int minLength = 8; 
            if (value.Length>minLength) 
            {

                _password=value;
            }
            else
            {
                Console.WriteLine("insert valid password");
            }
                
               

                
            
        }
    }
    public Employee[] Employees;


    public User()
    {
        Employees = new Employee[0];
    }
    public void CreateEmployee()
    {
        Console.WriteLine("Insert Name");
        string Name = Console.ReadLine();
        Console.WriteLine("Insert Password");
        string password = Console.ReadLine();
        Employee employee = new Employee
        {
            Password = password,
            Name = Name,
        };
        Array.Resize(ref Employees, Employees.Length + 1);
        Employees[Employees.Length - 1] = employee;
    }
    public void ShowEmployee()
    {
        foreach (Employee item in Employees)
        {
            Console.WriteLine($"name:{item.Name},password:{item.Password}");
        }

    }
}

