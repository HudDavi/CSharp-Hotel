namespace Hotel.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            try{
                if (Suite.Capacidade >= hospedes.Count)
                {
                    Hospedes = hospedes;
                }
                else{
                    Console.Write($"A Capacidade da Suíte é: {Suite.Capacidade} e a Quantidade de Hóspedes é: {hospedes.Count}, Quantidade de Hóspedes é Superior a Capacidade da Suíte!");
                    System.Environment.Exit(0);
                }
            }
            catch (Exception)
            {
                System.Environment.Exit(0);
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
            {
                valor = valor - ((valor * 10) / 100);
            }
            return valor;
        }
    }
}