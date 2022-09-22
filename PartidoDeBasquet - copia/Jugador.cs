namespace PartidoDeBasquet
{
    class Jugador
    {
        //variables y propiedades


        //static int genID = -1;
        private int simples;
        private int dobles;
        private int triples;
        private bool juega = true;
        public int Faltas { get; private set; }
        public string Nombre { get; private set; }
        public string Camiseta { get; private set; }
        public bool Juega
        {
            get { return juega; }
            set { juega = value; }
        }
        /*static public int GenID
        {
            get { return genID; }
        }*/






        //constructor

        public Jugador(string nombre)
        {
            this.Nombre = nombre;
            //Jugador.genID++;
        }




        //metodos

        public void Anotar(int tanto)
        {
            switch (tanto)
            {
                case 1: simples++; break;
                case 2: dobles++; break;
                case 3: triples++; break;
            }
        }
        public int VerPuntaje()
        { return simples + dobles * 2 + triples * 3; }
        public int VerFaltas()
        { return Faltas; }
        public bool Falta()
        {
            Faltas++;
            if (Faltas > 4)
                Juega = false;
            return Juega;
        }
    }
}
