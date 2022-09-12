using AccessControl;
using Lab3;

namespace MyNamespace
{
    class Lab3Main
    {
        static void Main(string[] args)
        {
            Employee jane = new Accountant("Jane", 45);
            Employee joe = new Accountant("Joe", 56);

            Employee john = new Manager("John", 28);
            Employee mary = new Manager("Mary", 32);

            Employee jack = new Blacksmith("Jack", 47);
            Employee katie = new Blacksmith("Katie", 35);
            Employee amy = new Blacksmith("Amy", 40);
            Employee lin = new Blacksmith("Lin", 28);
            Employee greg = new Blacksmith("Greg", 36);

            Employee craig = new Owner(47);

            AccessControl.Task t1 = new AccessControl.Task(123, "September 12", "Task 1");
            AccessControl.Task t2 = new AccessControl.Task(1234, "September 12", "Task 2");
            AccessControl.Task t3 = new AccessControl.Task(12345, "September 12", "Task 3");


            craig.Send("Good Job", john);
            craig.Send("Good Job", jane);
            craig.Send("Good Job", jack);

            greg.perform(t1);
            amy.Delegate(greg, t2);

            jane.Update(greg, 36000);
            lin.Delegate(jane, t3);

            john.Delegate(mary, jack, 4);
            mary.evaluate(katie, 5);
        }
    }
}
