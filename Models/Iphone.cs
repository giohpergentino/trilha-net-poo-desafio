namespace DesafioPOO.Models
{
    public class Iphone : Smartphone //Herança
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) //Construtor chamando o da classe Smartphone
        {

        }
        public override void InstalarAplicativo(string nomeApp) //Polimorfismo de tempo de execução: sobrescrevendo o método abstrato
        {
            Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no iPhone");
        }
    }
}