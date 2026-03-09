// string[] fraudulentOrdersIDs = new string[3];

// fraudulentOrdersIDs[0] = "A123";
// fraudulentOrdersIDs[1] = "B456";
// fraudulentOrdersIDs[2] = "C789";

// Console.WriteLine("The first fraudulent order ID is: " + fraudulentOrdersIDs[0]);

// string[] names = { "Alice",
//  "Bob",
//  "Charlie"
// };

// foreach (string name in names)
// {
//     Console.WriteLine(name);
// }
// int[] inventory = { 200, 450, 700, 175, 250 };
// int sum = 0;
// foreach (int stock in inventory)
// {
//     sum += stock;
// }
// Console.WriteLine("The total inventory is: " + sum);

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
};

static class Program
    {
        static void Main()
{
    Person person1 = new Person("Alice", 30);
    Console.WriteLine("Name: " + person1.Name);
}
}