// See https://aka.ms/new-console-template for more information
using Lab9;
/**
* Jason Cross and Dominick Carlucci
* Main.cs class
* Due Date: 10/23/2022 11:59 p.m.
*/

//string str = "Espresso";
CMM cmm = new CMM();
CoffeeIF sample1 = new Mocha();
CondimentIF cdifCh = new Chocolate();
//Object o = Activator.CreateInstance(t);
//CoffeeIF ecif = (Espresso)o;
CoffeeIF esp = new Espresso();
CoffeeIF espWithStuff = new CoffeeWithStuff(esp, cdifCh);
espWithStuff.run();

Console.WriteLine(cmm.computePrice(espWithStuff));

//cmm.setCoffeeType("Espresso");
//cmm.addCondiment(cdifCh);

//cmm.done();
//CoffeeIF sample = new CoffeeWithStuff(sample1, cdifCh);
//Console.WriteLine(cmm.computePrice(sample));


CoffeeIF mocha = new Mocha();

CondimentIF cdifV = new Vanilla();
CondimentIF cdifC = new Cream();


CoffeeIF mochaWithStuff = new CoffeeWithStuff(mocha, cdifV);
mochaWithStuff = new CoffeeWithStuff(mochaWithStuff, cdifC);

mochaWithStuff.run();

Console.WriteLine("Total price: $" + cmm.computePrice(mochaWithStuff));

//CoffeeIF espWithStuff = new CoffeeWithStuff(esp, cdifC);
//espWithStuff = new CoffeeWithStuff(espWithStuff, cdifV);
//espWithStuff = new CoffeeWithStuff(espWithStuff, cdifCh);
//espWithStuff = new CoffeeWithStuff(espWithStuff, cdifCh);
//espWithStuff.run();

