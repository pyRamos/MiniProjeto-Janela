namespace screen
{
    public abstract class Janela
    {
        //Atributos
        private bool BotaoFechar;
        private bool BotaoMax;
        private bool BotaoMin;
        private string Titulo;
        private int PosX;
        private int PosY;
        //Construtores
        public Janela(){}
        public Janela(bool bFechar, bool bMax, bool bMin,string title, int pX,int pY)
        {
            this.BotaoFechar = bFechar;
            this.BotaoMax = bMax;
            this.BotaoMin = bMin;
            this.Titulo = title;
            this.PosX = pX;
            this.PosY = pY;
        }
        //Métodos de Acesso Funcional
        public bool BFechar
        {
            get => this.BotaoFechar;
            set => this.BotaoFechar = value;
        }
         public bool BMax
        {
            get => this.BotaoMax;
            set => this.BotaoMax = value;
        }
         public bool BMin
        {
            get => this.BotaoMin;
            set => this.BotaoMin = value;
        }
         public string Title
        {
            get => this.Titulo;
            set => this.Titulo = value;
        }
         public bool PX
        {
            get => this.PosX;
            set => this.PosX = value;
        }
         public bool PY
        {
            get => this.PosY;
            set => this.PosY = value;
        }
        //Métodos da Classe
        public void MoverJanela(int x, int y)
        {
            PX = x;
            PY = y;            
        }
    }
}