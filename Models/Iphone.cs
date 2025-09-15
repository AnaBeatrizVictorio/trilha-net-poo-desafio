namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        //Construtor da base tem parâmetros obrigatórios. Smartphone não tem um construtor vazio (public Smartphone() {}). Ele exige os valores numero, modelo, imei, memoria. Portanto, o compilador obriga você a repassar esses valores usando : base(...).
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no Iphone...");
        }
    }
}