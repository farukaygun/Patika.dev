namespace access_modifiers_constructor;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("****Employee One****");
        Employee employeeOne = new Employee("Dilek","Bohça",10,"IT");
        employeeOne.GetEmployeeInfo();
        
        Console.WriteLine("************");
         
        Console.WriteLine("****Employee Two****");
        Employee employeeTwo = new Employee();
        employeeTwo.Name = "Ali";
        employeeTwo.LastName = "Solmaz";
        employeeTwo.No = 123434;
        employeeTwo.Department = "Hr";

        employeeTwo.GetEmployeeInfo();

         Console.WriteLine("****Employee Three****");
        Employee employeeThree = new Employee("Fatih","Tarhan");
        employeeThree.GetEmployeeInfo();        
    }
}


class Employee
    {
        public string Name;
        public string LastName;
        public int No;
        public string Department;

        public Employee(string name, string lastName, int no, string department)
        {
            this.Name = name;
            this.LastName = lastName;
            this.No = no;
            this.Department = department;
            
        }
        
        public Employee(){}
        
       public Employee(string name, string lastName)
        {
            this.Name = name;
            this.LastName = lastName;
                
        }

        public void GetEmployeeInfo()
        {
            Console.WriteLine("Name of the employee: {0}",Name);
            Console.WriteLine("Last Name of the employee: {0}",LastName);
            Console.WriteLine("Id of the employee: {0}",No);
            Console.WriteLine("Department of the employee: {0}",Department);
        }
    }
