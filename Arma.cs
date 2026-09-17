namespace ClassesAbstratas
{
    abstract class Arma
    {
        public string Nome
        {
            get; set;
        }
        public int DanoBase
        {
            get; set;
        }
        public void ExibirInfo()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Dano: " + DanoBase);
        }

        public abstract int CalcularAtaqueCritico();
    }
}
