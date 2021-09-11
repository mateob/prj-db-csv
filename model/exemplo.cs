namespace prj_db_csv.model
{
    public class exemplo
    {
        public Doguinho dog = new Doguinho();
        public Doguinho dog2 = new Doguinho();
        public Doguinho dog3 = new Doguinho();

        public exemplo()
        {

            this.dog.nome = "Pingo";
            this.dog2.nome = "Amora";
            this.dog3.nome = "Rufus";

            this.dog.correndo();
            this.dog2.caminhando();

            this.dog.latir();
            this.dog2.latir();
            this.dog3.latir();
        }
    }

    public interface IAnimal
    {
        int qtdPatas { get; }
        int velocidade { get; }
        bool respirar();
        bool caminhando();
        bool correndo();
    }

    public class Animal : IAnimal
    {
        protected int _patas = 4;
        public int qtdPatas => this._patas;

        protected int _velocidade = 0;
        public int velocidade => this._velocidade;

        public bool caminhando()
        {
            this._velocidade = 10;
            return true;
        }

        public bool correndo()
        {
            this._velocidade = 30;
            return true;
        }

        public bool respirar()
        {
            return true;
        }
    }

    public interface ICachorro : IAnimal
    {
        string latido { get; }
        string latir();
    }

    public class Cachorro : Animal, ICachorro
    {
        private string _latido;
        public Cachorro(int patas, string latido)
        {
            this._patas = patas;
            this._latido = latido;
        }

        public string latido => this._latido;

        public string latir()
        {
            return this.latido;
        }
    }

    public class Doguinho : Cachorro
    {
        public Doguinho() : base(4, "WauWua") { }
        private string _nome = "";
        public string nome
        {
            get { return $" THN-{this._nome}"; }
            set { _nome = value; }
        }

        public string latir()
        {
            // aqui vai ter algo mais
            return base.latir();
        }
    }
}