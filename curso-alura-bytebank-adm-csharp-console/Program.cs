
using curso_alura_bytebank_adm_csharp_console.employee;
using curso_alura_bytebank_adm_csharp_console.internalSystem;
using curso_alura_bytebank_adm_csharp_console.partnership;
using curso_alura_bytebank_adm_csharp_console.utility;

#region
//Employee pedro = new Employee("Pedro Silva", "123456789", 2000);

//Console.WriteLine(pedro.name);
//Console.WriteLine(pedro.GetBonus());

//Director wellysson = new Director("Wellysson Rocha", "987654312");

//Console.WriteLine(wellysson.name);
//Console.WriteLine(wellysson.GetBonus());

//BonusManager bonusManager = new BonusManager();
//bonusManager.Register(pedro);
//bonusManager.Register(wellysson);

//Console.WriteLine("Total de bonificações: "+bonusManager.totalBonus);
//Console.WriteLine("Total de funcionarios: "+Employee.totalEmployees);

//pedro.IncreaseSalary();
//wellysson.IncreaseSalary();

//Console.WriteLine($"Novo salário do Pedro: {pedro.salary}");
//Console.WriteLine($"Novo salário do Wellysson: {wellysson.salary}");
#endregion

//CalculateBonus();
UseSystem();

void CalculateBonus()
{
    BonusManager bonusManager = new BonusManager();

    Design ulisses = new Design("Ulisses", "123456");

    Director paula = new Director("Paula", "987654");

    Assistant igor = new Assistant("Igor Dias", "852645");

    AccountManager camila = new AccountManager("Camila Oliveira", "951753");

    bonusManager.Register(camila);
    bonusManager.Register(igor);
    bonusManager.Register(paula);
    bonusManager.Register(ulisses);

    Console.WriteLine($"Total de bonificação {bonusManager.totalBonus}");
}

void UseSystem()
{
    InternalSystem internalSystem = new InternalSystem();

    Director ingrid = new Director("Ingrid Novaes", "951123");
    ingrid.password= "123";


    AccountManager ursula = new AccountManager("Ursula Alcantara", "852963");
    ursula.password = "456";

    CommercialPartner caio = new CommercialPartner();
    caio.password = "999";

    internalSystem.Logar(ingrid, "123");
    internalSystem.Logar(ingrid, "951");
    internalSystem.Logar(caio, "999");
}