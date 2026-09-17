namespace ClassesAbstratas
{
    class CampoNumerico : CampoFormulario, IValidavel
    {
        public bool Validar()
        {
            int numero;
            return int.TryParse(Valor, out numero);
        }
    }
}
