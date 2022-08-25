// See https://aka.ms/new-console-template for more information
using Ex_Expression.Class.Pattern.Composite;


Expression exp1 = new Addition(new Nombre(33), new Nombre(33));
int resultat1 = exp1.Evalue(); // 66
Console.WriteLine(resultat1);

Expression exp2 = new Addition(new Nombre(33), new Addition(new Nombre(33), new Nombre(11)));
int resultat2 = exp2.Evalue(); // 77
Console.WriteLine(resultat2);

Expression exp3 = new Soustraction(new Nombre(33), new Nombre(33));
int resultat3 = exp3.Evalue(); // 0
Console.WriteLine(resultat3);

Expression exp4 = new Soustraction(new Nombre(33), new Soustraction(new Nombre(33), new Nombre(11)));
int resultat4 = exp4.Evalue(); // 11
Console.WriteLine(resultat4);

Expression exp5 = new Soustraction(exp1, exp4);
int resultat5 = exp5.Evalue();  
Console.WriteLine(resultat5); // 55

Expression exp6 = new Addition(exp2, exp5);
int resultat6 = exp6.Evalue();
Console.WriteLine(resultat6); // 132

Console.WriteLine(exp6.Formate());
Console.WriteLine(exp6.Formate2());