namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }
        
        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo que deseja adicionar: ");
            veiculos.Add(Console.ReadLine()!);
        }


        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover: ");
            string? placa = Console.ReadLine();

            
            if (veiculos.Any(x => x.Equals(placa, StringComparison.CurrentCultureIgnoreCase)))
            {
                //Implementando a variável "valorTotal"

                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                decimal horas = 0;      decimal valorTotal = 0;
                valorTotal = precoInicial + precoPorHora * horas;
                horas = Convert.ToDecimal(Console.ReadLine());

                placa = "";
                veiculos.Remove(placa.ToUpper());
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");

            } else
              {
                 Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
              }
        }

        public void ListarVeiculos()
        {
            
            if(veiculos.Any())
            {
             //Laço para enumerar os veículos listados

                int numeroDoVeiculo = 1;

                foreach(string itens in veiculos)
                {
                    Console.WriteLine($" \n {numeroDoVeiculo}° {itens} \n");
                    numeroDoVeiculo++;

                } 
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
