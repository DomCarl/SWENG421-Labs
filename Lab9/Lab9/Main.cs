// See https://aka.ms/new-console-template for more information
using Lab9;
/**
* Jason Cross and Dominick Carlucci
* Main.cs class
* Due Date: 10/23/2022 11:59 p.m.
*/


CMM cmm = new CMM();

CondimentIF cdifCh = new Chocolate();
CoffeeIF esp = (Espresso)cmm.setCoffeeType("Espresso");

CoffeeIF espWithStuff = (CoffeeWithStuff)cmm.addCondiment(cdifCh);
espWithStuff = (CoffeeWithStuff)cmm.addCondiment(cdifCh);
espWithStuff = (CoffeeWithStuff)cmm.addCondiment(cdifCh);
espWithStuff.run();

Console.WriteLine("Total price: $" + cmm.computePrice(espWithStuff) + "\n");


CondimentIF cdifV = new Vanilla();
CondimentIF cdifC = new Cream();

CoffeeIF mocha = new Mocha(cmm);
CoffeeIF mochaWithStuff = new CoffeeWithStuff(mocha, cdifV);
mochaWithStuff = new CoffeeWithStuff(mochaWithStuff, cdifC);

mochaWithStuff.run();

Console.WriteLine("Total price: $" + cmm.computePrice(mochaWithStuff) + "\n");



CoffeeIF mocha2 = new Mocha(cmm);
CoffeeIF mochaWithStuff2 = new CoffeeWithStuff(mocha2, cdifV);
mochaWithStuff2 = new CoffeeWithStuff(mochaWithStuff2, cdifC);
mochaWithStuff2 = new CoffeeWithStuff(mochaWithStuff2, cdifC);

mochaWithStuff2.run();

Console.WriteLine("Total price: $" + cmm.computePrice(mochaWithStuff2) + "\n");



CoffeeIF cap = new Cappuccino(cmm);
CoffeeIF capWithStuff = new CoffeeWithStuff(cap, cdifV);
capWithStuff = new CoffeeWithStuff(capWithStuff, cdifCh);
mochaWithStuff2 = new CoffeeWithStuff(capWithStuff, cdifCh);

capWithStuff.run();

Console.WriteLine("Total price: $" + cmm.computePrice(capWithStuff) + "\n");


