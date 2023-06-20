namespace OOP
{          //Função do abstract
    public abstract class Eletrodomestico // Essa classe só pode ser herdada e nunca estanciada!
    {
        private readonly string _nome;
        private readonly int _voltagem;
        protected Eletrodomestico(string nome, int voltagem)
        {
            _nome = nome;
            _voltagem = voltagem;
        }

        public abstract void Ligar(); // Não sou obrigado a implementar esse método nessa clase pois ele é abstrato mas quem herdar precisa
        public abstract void Desligar();

        public virtual void Testar() // Sou obrigado a implementar o metodo aqui mas quem herdar nao precisa usar esse metodo
        {
            //testar
        }
    }
}