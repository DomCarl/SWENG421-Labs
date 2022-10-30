using Lab10;

Employee chuck = new ProjectLeader("Chuck");

Employee denise = new ProjectLeader("Denise");

Employee jack = new Supervisor("Jack");

Employee jeff = new Supervisor("Jeff");

Employee john = new Worker("John");
john.parent = jack;

Employee steve = new CEO("Steve");

Employee bob = new Manager("Bob");

steve.evacuate();