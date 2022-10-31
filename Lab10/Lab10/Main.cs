using Lab10;

Employee steve = new CEO("Steve", null);

Employee bob = new Manager("Bob", steve);
Employee rachel = new Manager("Rachel", steve);

Employee chuck = new ProjectLeader("Chuck", rachel);

Employee denise = new ProjectLeader("Denise", rachel);

Employee jack = new Supervisor("Jack", bob);

Employee jeff = new Supervisor("Jeff", bob);

Employee john = new Worker("John", jack);
Employee mary = new Worker("Mary", jack);
Employee jane = new Worker("Jane", jack);
Employee tom = new Worker("Tom", jack);
Employee nick = new Worker("Nick", jack);
Employee joe = new Worker("Joe", chuck);
Employee frank = new Worker("Frank", chuck);
Employee sam = new Worker("Sam", chuck);
Employee greg = new Worker("Greg", chuck);
Employee rob = new Worker("Rob", jeff);
Employee ed = new Worker("Ed", jeff);
Employee rick = new Worker("Rick", jeff);
Employee michael = new Worker("Michael", jeff);


john.seeDanger();