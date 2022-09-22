namespace WindowsFormsApp4
{
    internal class Prueba
    {
        private int tantos;
        public int Tantos { get; private set; }
        //{
        //    get
        //    {
        //        return tantos;
        //    } 
        //    private set
        //    {
        //        tantos = value;
        //    }
        //}




        public void AgregarTanto(int valor)
        {
            Tantos += valor;
        }













        int Tanto;
        int simples;
        int dobles;
        int triples;

        public void AgregarTanto(int tanto)
        {
            switch(tanto)
            {
                case 1:
                    simples++;
                    break;
                case 2:
                    dobles++;
                    break;
                case 3:
                    triples++;
                    break;
            }
        }
    }
}
