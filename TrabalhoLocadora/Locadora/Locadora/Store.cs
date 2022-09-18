namespace Locadora
{
    public class Store
    {
        public void Rent(string[] vhs)
        {
            Console.Clear();
            int contador = 1;
            Console.WriteLine("VHS disponíveis");
            for (int i = 0; i < vhs.Length; i++)
            {
                if (vhs[i] == null)
                {

                }
                else
                {
                    Console.WriteLine($"{contador} - {vhs[i]}");
                    contador++;
                }
            }
            Console.Write("Digite a escolha: ");
            string userChoiceVHS = IsEmpty.EmptyST(Console.ReadLine());
            if (userChoiceVHS == "1")
            {
                RentPattern(vhs, 0);
            }
            if (userChoiceVHS == "2")
            {
                RentPattern(vhs, 1);
            }
            if (userChoiceVHS == "3")
            {
                RentPattern(vhs, 2);
            }
            if (userChoiceVHS == "4")
            {
                RentPattern(vhs, 3);
            }
            if (userChoiceVHS == "5")
            {
                RentPattern(vhs, 4);
            }
        }
        public void RentPattern(string[] vhs, int choice)
        {
            int DevolutionTime = 3;
            Console.WriteLine($"\nSelecionado: {vhs[choice]}");
            Console.WriteLine($"Necessario devolvem em até {DevolutionTime} meses. Aproveite!");
        }
        public void Recommend(string[] vhs)
        {
            Console.Clear();
            int contador = 1; int index = 0;
            Console.WriteLine("Quantos deseja recomendar?");
            string userInputRecommendQtdST = IsEmpty.EmptyST(Console.ReadLine());
            int userInputRecommendQtd = Convert.ToInt32(userInputRecommendQtdST);
            if (userInputRecommendQtd > 5)
            {
                Console.WriteLine("Quantia indisponivel");
            }
            else
            {
                userInputRecommendQtd = userInputRecommendQtd + 5;
                for (int i = 5; i < userInputRecommendQtd; i++)
                {
                    if (vhs[i] == null)
                    {
                        Console.Write($"Digite o nome do VHS {contador}: ");
                        vhs[i] = Console.ReadLine();
                        contador++; index++;
                    }
                    else
                    {
                        Console.WriteLine("Não há espaços para recomendações");
                    }
                }
            }
        }
        public void ReturnVHS(int rented)
        {
            Console.Clear();
            if (rented == 0)
            {
                Console.WriteLine("Não foram alugados VHS");
            }
            else
            {
                Console.WriteLine($"Foram alugados {rented}. Clique ENTER para devolve-los");
                Console.ReadKey();
                Console.WriteLine("VHS Devolvidos");
                rented = 0;
            }
        }
    }
}
