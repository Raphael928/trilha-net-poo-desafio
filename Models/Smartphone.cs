namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        public Smartphone(string pNumero, string pModelo, string pIMEI, int pMemoria)
        {
            // TODO: Passar os parâmetros do construtor para as propriedades
            Numero = pNumero;
            Modelo = pModelo;
            IMEI = pIMEI;
            Memoria = pMemoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public virtual void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando aplicativo " + nomeApp);
        }
    }
}