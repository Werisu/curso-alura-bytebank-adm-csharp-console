
using curso_alura_bytebank_adm_csharp_console.employee;
using curso_alura_bytebank_adm_csharp_console.utility;

Employee pedro = new Employee("Pedro Silva", "123456789", 2500, 0);

Console.WriteLine(pedro.name);
Console.WriteLine(pedro.GetBonus());

Director wellysson = new Director("Wellysson Rocha", "987654312", 5000, 1);

Console.WriteLine(wellysson.name);
Console.WriteLine(wellysson.GetBonus());

BonusManager bonusManager = new BonusManager();
bonusManager.Register(pedro);
bonusManager.Register(wellysson);

Console.WriteLine("Total de bonificações: "+bonusManager.totalBonus);