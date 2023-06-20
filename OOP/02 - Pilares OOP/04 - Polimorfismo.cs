namespace OOP
{
    // Poli-morfismo
    public sealed class CafeteiraEspressa : Eletrodomestico
    {
        public CafeteiraEspressa(string nome, int voltagem)
            : base(nome, voltagem) { }

        public CafeteiraEspressa()
            : base("Padrao", 220) {  }

        private static void AquecerAgua() { }

        private static void MoerGraos() { }

        public void PrepararCafe()
        {
            Testar();
            AquecerAgua();
            MoerGraos();
            // ETC...
        }

        public override void Testar()
        {
            //testar
        }
   
              //Sobreescrever
        public override void Ligar()
        {
            // Verificar recipiente de agua
        }

        public override void Desligar()
        {
            // Resfriar aquecedor
        }
    }
}