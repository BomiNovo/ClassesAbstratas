namespace ClassesAbstratas
{
    class Drone : ICamera, IVoavel
    {
        public void TirarFoto()
        {
            Console.WriteLine("Tirando foto paranâmica");
        }

        public void Decolar()
        {
            Console.WriteLine("Drone decolando certicalmente");
        }

        public void Pousar()
        {
            Console.WriteLine("Drone pousando");
        }
    }
}
