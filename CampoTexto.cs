namespace ClassesAbstratas
{
    class CampoTexto : CampoFormulario, IValidavel
    {
        public bool Validar()
        {
            return !string.IsNullOrEmpty(Valor);
        }
    }
}
