namespace ER8UC9
{
    public abstract class Pessoa : Endereco
    {
        public string? nome { get; set; }
        public string? Localizacao { get; set; }
        public abstract double PagarImposto(float Salario);
    }
}