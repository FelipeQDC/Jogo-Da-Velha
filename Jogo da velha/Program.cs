string[,] jogo = new string[3, 3] { { "-", "-", "-" }, { "-", "-", "-" }, { "-", "-", "-" } };
char resp = 'S';
int h, v, cont = 1;
string X, O;
bool vencer = false;

do
{
    Console.WriteLine("Jogador X: ");
    X = Console.ReadLine();
    Console.WriteLine("Jogador O: ");
    O = Console.ReadLine();
    do
    {

        if (cont % 2 == 0)
        {

            Console.WriteLine("Escreva a Coluna horizontal do O : ");
            h = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva a Coluna vertical do O : ");
            v = int.Parse(Console.ReadLine());
            if (jogo[h - 1, v - 1] == "-")
            {
                jogo[h - 1, v - 1] = ("O");

            }
            else
            {
                Console.WriteLine("Local Ja usado");
                Console.ReadKey();
            }
        }
        if (cont % 2 != 0)
        {

            Console.WriteLine("Escreva a Coluna horizontal do X : ");
            h = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva a Coluna vertical do X : ");
            v = int.Parse(Console.ReadLine());
            if (jogo[h - 1, v - 1] == "-")
            {
                jogo[h - 1, v - 1] = ("X");

            }
            else
                Console.WriteLine("Local Ja usado");
            Console.ReadKey();
        }
        Console.Clear();

        Console.WriteLine("( {0}  {1}  {2} )", jogo[0, 0], jogo[0, 1], jogo[0, 2]);
        Console.WriteLine("-----------------", jogo[0, 0], jogo[0, 1], jogo[0, 2]);
        Console.WriteLine("( {0}  {1}  {2} )", jogo[1, 0], jogo[1, 1], jogo[1, 2]);
        Console.WriteLine("-----------------", jogo[0, 0], jogo[0, 1], jogo[0, 2]);
        Console.WriteLine("( {0}  {1}  {2} )", jogo[2, 0], jogo[2, 1], jogo[2, 2]);
        Console.WriteLine("-----------------", jogo[0, 0], jogo[0, 1], jogo[0, 2]);



        cont++;
        //horizontal
        if (jogo[0, 0] == "X" && jogo[0, 1] == "X" && jogo[0, 2] == "X")
        {
            Console.WriteLine("vencedor é o {0} ", X);
            vencer = true;
        }
        if (jogo[1, 0] == "X" && jogo[1, 1] == "X" && jogo[1, 2] == "X")
        {
            Console.WriteLine("vencedor é o {0} ", X);
            vencer = true;
        }
        if (jogo[2, 0] == "X" && jogo[2, 1] == "X" && jogo[2, 2] == "X")
        {
            Console.WriteLine("vencedor é o {0} ", X);
            vencer = true;
        }
        //vertical
        if (jogo[0, 0] == "X" && jogo[1, 0] == "X" && jogo[2, 0] == "X")
        {
            Console.WriteLine("vencedor é o {0} ", X);
            vencer = true;
        }
        if (jogo[0, 1] == "X" && jogo[1, 1] == "X" && jogo[2, 1] == "X")
        {
            Console.WriteLine("vencedor é o {0} ", X);
            vencer = true;
        }
        if (jogo[0, 2] == "X" && jogo[1, 2] == "X" && jogo[2, 2] == "X")
        {
            Console.WriteLine("vencedor é o {0} ", X);
            vencer = true;
        }
        //diagonal
        if (jogo[0, 0] == "X" && jogo[1, 1] == "X" && jogo[2, 2] == "X")
        {
            Console.WriteLine("vencedor é o {0} ", X);
            vencer = true;
        }
        if (jogo[0, 2] == "X" && jogo[1, 1] == "X" && jogo[2, 0] == "X")
        {
            Console.WriteLine("vencedor é o {0} ", X);
            vencer = true;
        }
        //horizontal
        if (jogo[0, 0] == "O" && jogo[0, 1] == "O" && jogo[0, 2] == "O")
        {
            Console.WriteLine("vencedor é o {0} ", O);
            vencer = true;
        }
        if (jogo[1, 0] == "O" && jogo[1, 1] == "O" && jogo[1, 2] == "O")
        {
            Console.WriteLine("vencedor é o {0} ", O);
            vencer = true;
        }
        if (jogo[2, 0] == "O" && jogo[2, 1] == "O" && jogo[2, 2] == "O")
        {
            Console.WriteLine("vencedor é o {0} ", O);
            vencer = true;
        }
        //vertical
        if (jogo[0, 0] == "O" && jogo[1, 0] == "O" && jogo[2, 0] == "O")
        {
            Console.WriteLine("vencedor é o {0} ", O);
            vencer = true;
        }
        if (jogo[0, 1] == "O" && jogo[1, 1] == "O" && jogo[2, 1] == "O")
        {
            Console.WriteLine("vencedor é o {0} ", O);
            vencer = true;
        }
        if (jogo[0, 2] == "O" && jogo[1, 2] == "O" && jogo[2, 2] == "O")
        {
            Console.WriteLine("vencedor é o {0} ", O);
            vencer = true;
        }
        //diagonal
        if (jogo[0, 0] == "O" && jogo[1, 1] == "O" && jogo[2, 2] == "O")
        {
            Console.WriteLine("vencedor é o {0} ", O);
            vencer = true;
        }
        if (jogo[0, 2] == "O" && jogo[1, 1] == "O" && jogo[2, 0] == "O")
        {
            Console.WriteLine("vencedor é o {0} ", O);
            vencer = true;
        }
        if (cont == 10)
        {
            Console.WriteLine("Deu Empate");
            vencer = true;
        }
    } while (cont < 7 || vencer == false);
    Console.WriteLine("Quer continuar?");
    Console.WriteLine("n/s?");
    resp = char.ToUpper(Console.ReadKey().KeyChar);
    Console.Clear();
} while (resp == 'S');

