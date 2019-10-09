namespace screen
{
    public class modal : Janela, IDimensionavel
    {
        //Atributos
        private int maxAlt;
        private int maxLarg;
        private int atualAlt;
        private int atualLarg;
        //Construtores
        public modal(){}
        public modal(int mAlt,int mLarg, int aAlt, int aLarg)
        {
            this.maxAlt = mAlt;
            this.maxLarg = mLarg;
            this.atualAlt = aAlt;
            this.atualLarg = aLarg;
        }
        private void alterarTitulo(string t)
        {
            Title = t;
        }
        public void fullScreen()
        {
            this.atualAlt = maxAlt;
            this.atualLarg = maxLarg;
        }
        public void setLargura(int l)
        {
            if(l >=1 && l<=this.maxLarg)
            {
                this.atualLarg = l;
            }else
            {
                System.Console.WriteLine("Número inválido");
            }            
        }
        public void setAltura(int a)
        {
            if(a >=1 && a<=this.maxAlt)
            {
                this.atualAlt = a;
            }else
            {
                System.Console.WriteLine("Número inválido");
            }
        }

    }
}