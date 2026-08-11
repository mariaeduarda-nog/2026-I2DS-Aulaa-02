using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=================================");
        Console.WriteLine("       RPG - BATALHA");
        Console.WriteLine("=================================");

        Console.Write("\nDigite o nome do seu personagem: ");
        string nome = Console.ReadLine();

        // Escolhendo personagem
        Personagem jogador = EscolherPersonagem(nome);

        Console.Clear();

        Console.WriteLine("Escolha o seu inimigo:");

        Console.WriteLine("\n1 - Mago");
        Console.WriteLine("2 - Elfo");
        Console.WriteLine("3 - Cavaleiro");

        Console.Write("\nEscolha: ");
        int escolhaInimigo = int.Parse(Console.ReadLine());

        Personagem inimigo;

        if (escolhaInimigo == 1)
        {
            inimigo = new Mago("Mago Sombrio");
        }
        else if (escolhaInimigo == 2)
        {
            inimigo = new Elfo("Elfo Sombrio");
        }
        else
        {
            inimigo = new Cavaleiro("Cavaleiro Sombrio");
        }

        Console.Clear();

        Console.WriteLine("===== SEU PERSONAGEM =====");
        jogador.Apresentar();

        Console.WriteLine("\n===== INIMIGO =====");
        inimigo.Apresentar();

        Console.WriteLine("\nPressione ENTER para começar...");
        Console.ReadLine();

        Batalha(jogador, inimigo);
    }


    private static Personagem EscolherPersonagem(string nome)
    {
        Console.WriteLine("\nEscolha sua classe:");

        Console.WriteLine("1 - Mago");
        Console.WriteLine("2 - Elfo");
        Console.WriteLine("3 - Cavaleiro");

        Console.Write("\nEscolha: ");
        int escolha = int.Parse(Console.ReadLine());

        if (escolha == 1)
        {
            return new Mago(nome);
        }
        else if (escolha == 2)
        {
            return new Elfo(nome);
        }
        else
        {
            return new Cavaleiro(nome);
        }
    }


    private static void Batalha(Personagem jogador, Personagem inimigo)
    {
        while (jogador.EstaVivo() && inimigo.EstaVivo())
        {
            Console.Clear();

            Console.WriteLine("=================================");
            Console.WriteLine("             BATALHA");
            Console.WriteLine("=================================");

            Console.WriteLine("\n" + jogador.Nome +
                              " - Vida: " + jogador.Vida);

            Console.WriteLine(inimigo.Nome +
                              " - Vida: " + inimigo.Vida);

            Console.WriteLine("\nEscolha uma ação:");

            Console.WriteLine("1 - Atacar");
            Console.WriteLine("2 - Evoluir");
            Console.WriteLine("3 - Ver status");

            Console.Write("\nEscolha: ");
            int escolha = int.Parse(Console.ReadLine());

            if (escolha == 1)
            {
                jogador.Atacar(inimigo);
            }
            else if (escolha == 2)
            {
                jogador.Evoluir();
            }
            else if (escolha == 3)
            {
                jogador.Apresentar();
                Console.WriteLine("\nPressione ENTER...");
                Console.ReadLine();

                continue;
            }
            else
            {
                Console.WriteLine("Opção inválida!");
                Console.ReadLine();
                continue;
            }

            if (!inimigo.EstaVivo())
            {
                Console.WriteLine("\nVOCÊ VENCEU!");
                break;
            }

            Console.WriteLine("\nPressione ENTER para o inimigo atacar...");
            Console.ReadLine();

            inimigo.Atacar(jogador);

            if (!jogador.EstaVivo())
            {
                Console.WriteLine("\nVOCÊ PERDEU!");
                break;
            }

            Console.WriteLine("\nPressione ENTER para continuar...");
            Console.ReadLine();
        }
    }


    // =====================================================
    // CLASSE PERSONAGEM
    // =====================================================

    public class Personagem
    {
        public string Nome { get; private set; }
        public int Nivel { get; protected set; }
        public int Forca { get; protected set; }
        public int Agilidade { get; protected set; }
        public int Inteligencia { get; protected set; }
        public int Vida { get; protected set; }

        public Personagem(
            string nome,
            int nivel,
            int forca,
            int agilidade,
            int inteligencia,
            int vida)
        {
            Nome = nome;
            Nivel = nivel;
            Forca = forca;
            Agilidade = agilidade;
            Inteligencia = inteligencia;
            Vida = vida;
        }


        public virtual void Apresentar()
        {
            Console.WriteLine("\nNome: " + Nome);
            Console.WriteLine("Nível: " + Nivel);
            Console.WriteLine("Força: " + Forca);
            Console.WriteLine("Agilidade: " + Agilidade);
            Console.WriteLine("Inteligência: " + Inteligencia);
            Console.WriteLine("Vida: " + Vida);
        }


        public virtual void Atacar(Personagem inimigo)
        {
            int dano = Forca;

            Console.WriteLine("\n" + Nome + " atacou!");
            Console.WriteLine("Dano: " + dano);

            inimigo.Defender(dano);
        }


        public virtual void Defender(int dano)
        {
            Vida -= dano;

            if (Vida < 0)
            {
                Vida = 0;
            }

            Console.WriteLine(Nome + " perdeu " + dano + " de vida.");
            Console.WriteLine("Vida atual: " + Vida);
        }


        public virtual void Evoluir()
        {
            Nivel++;
            Forca += 2;
            Agilidade += 2;
            Inteligencia += 2;
            Vida += 10;

            Console.WriteLine("\n" + Nome +
                              " evoluiu para o nível " + Nivel + "!");
        }


        public bool EstaVivo()
        {
            return Vida > 0;
        }
    }


    // =====================================================
    // CLASSE MAGO
    // =====================================================

    public class Mago : Personagem
    {
        public Mago(string nome)
            : base(nome, 1, 5, 5, 15, 80)
        {
        }


        public override void Apresentar()
        {
            Console.WriteLine("\n===== MAGO =====");

            base.Apresentar();
        }


        public override void Atacar(Personagem inimigo)
        {
            int dano = Inteligencia * 2;

            Console.WriteLine("\n" + Nome +
                              " lançou uma magia!");

            Console.WriteLine("Dano: " + dano);

            inimigo.Defender(dano);
        }
    }


    // =====================================================
    // CLASSE ELFO
    // =====================================================

    public class Elfo : Personagem
    {
        public Elfo(string nome)
            : base(nome, 1, 8, 15, 10, 90)
        {
        }


        public override void Apresentar()
        {
            Console.WriteLine("\n===== ELFO =====");

            base.Apresentar();
        }


        public override void Atacar(Personagem inimigo)
        {
            int dano = Agilidade;

            Console.WriteLine("\n" + Nome +
                              " disparou uma flecha!");

            Console.WriteLine("Dano: " + dano);

            inimigo.Defender(dano);
        }
    }


    // =====================================================
    // CLASSE CAVALEIRO
    // =====================================================

    public class Cavaleiro : Personagem
    {
        public Cavaleiro(string nome)
            : base(nome, 1, 15, 7, 5, 120)
        {
        }


        public override void Apresentar()
        {
            Console.WriteLine("\n===== CAVALEIRO =====");

            base.Apresentar();
        }


        public override void Atacar(Personagem inimigo)
        {
            int dano = Forca + 5;

            Console.WriteLine("\n" + Nome +
                              " atacou com sua espada!");

            Console.WriteLine("Dano: " + dano);

            inimigo.Defender(dano);
        }

        public override void Defender(int dano)
        {
            // O cavaleiro usa o escudo
            int danoReduzido = dano / 2;

            Console.WriteLine("\n" + Nome +
                              " bloqueou parte do ataque!");

            base.Defender(danoReduzido);
        }
    }
}