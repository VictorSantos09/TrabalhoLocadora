using Locadora;
Store store = new Store();

string[] vhs = new string[10];
int rented = 0;
vhs[0] = "O Rei Leão";
vhs[1] = "Toy Story";
vhs[2] = "A Pequena Sereia";
vhs[3] = "Tarzan";
vhs[4] = "Branca de Neve";

Console.WriteLine("HTM LOCADORA\n");
bool userUsing = true;
while (userUsing)
{
    Console.WriteLine("1 - Alugar VHS\n2 - Recomendar\n3 - Devolver\n4 - Sair");
    string userFirstChoice = IsEmpty.EmptyST(Console.ReadLine());
    if (userFirstChoice == "1")
    {
        store.Rent(vhs);
        rented++;
    }
    if (userFirstChoice == "2")
    {
        store.Recommend(vhs);
    }
    if (userFirstChoice == "3")
    {
        store.ReturnVHS(rented);
    }
    if (userFirstChoice == "4")
    {
        Thread.Sleep(300);
        Console.WriteLine("\nAté a proxima!");
        userUsing = false;
    }
}
