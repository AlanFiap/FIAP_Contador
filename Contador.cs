namespace APIContagemV2
{
    public class Contador
    {
        private int _valorAtual = 0;

        public int ValorAtual { get => _valorAtual; }

        public void Incrementar()
        {
            _valorAtual+=4;
        }
    }
}
