namespace PartidoDeBasquet
{
    class Equipo
    {
        //variables y propiedades
        private string nombre;
        public int NroJ { get; private set; }
        Jugador[] j;
        public int Puntaje { get; private set; }




        //constructor
        public Equipo(string nombre)
        {
            this.nombre = nombre;
            j = new Jugador[12];
            NroJ = 0;
        }




        //metodos
        public void AgregarJugador(Jugador jugador)
        {
            j[NroJ++] = jugador;

        }
        public bool Falta(string nombre)
        {
            bool juega = true;
            for (int i = 0; i < NroJ; i++)
            {
                if (nombre == j[i].Nombre)
                    juega = j[i].Falta();
            }
            return juega;
        }
        public Jugador VerJugador(int nro)
        {
            return j[nro];
        }
        public int VerFaltasEquipo()
        {
            int faltas = 0;
            for (int i = 0; i < NroJ; i++)
            {
                faltas += j[i].VerFaltas();
            }
            return faltas;
        }
        public int VerPuntajeEquipo()
        {
            int puntaje=0;
            for (int i = 0; i < NroJ; i++)
            {
                puntaje += j[i].VerPuntaje();
            }
            return puntaje;
        }
    }
}
