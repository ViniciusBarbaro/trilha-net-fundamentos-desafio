using System.Numerics;

namespace Parking_Dio_Desafio.Class_Estacionamento
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

        public async void AdicionarVeiculo()
        {
     
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string Temp = Console.ReadLine();
            // Verifica se o veículo existe na lista
            if (veiculos.Any(x => x.ToUpper() == Temp.ToUpper())) {
                Console.WriteLine("Placa já cadastrada. \n Pressione uma tecla para tentar novamente.");
                    Console.ReadLine();
            }
            else {
                veiculos.Add(Temp);
            }

        }

        public async void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
            
                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = this.precoInicial + this.precoPorHora * horas; 

            
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                await Task.Delay(1000);
                veiculos.Remove(placa);
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
            
                foreach(string veiculo in veiculos) 
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}