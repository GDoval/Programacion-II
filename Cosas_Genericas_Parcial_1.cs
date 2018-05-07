//Sobrescribir un operador string devolviendo un String Builder


        public static explicit operator string(Financiera financiera)
        {
            StringBuilder resp = new StringBuilder();
            resp.Append("Razon social: ");
            resp.Append(financiera.razonSocial);
            resp.Append("\nGanancia total: ");
            resp.Append(financiera.CalcularInteresGanado(TipoDePrestamo.Todos));
            resp.Append("\nGanancia por prestamos en dolares: ");
            resp.Append(financiera.CalcularInteresGanado(TipoDePrestamo.Dolares));
            resp.Append("\nGanancia por prestamos en pesos: ");
            resp.Append(financiera.CalcularInteresGanado(TipoDePrestamo.Pesos));
            resp.Append("\nDetalle de todos los prestamos: ");
            foreach (Prestamo p in financiera.listaDePrestamos)
            {
                if (p is PrestamoPesos)
                {
                    resp.Append(((PrestamoPesos)p).Mostrar());
                }
                else
                {
                    resp.Append(((PrestamoDolar)p).Mostrar());
                }
            }
            return resp.ToString();            
        }

//Sintaxis para sobrescribir operadores

        public static bool operator ==()
        {}
// asd
        public static bool operator !=()
        {}

        public static bool operator +()
        {}
//Un enum dentro de una clase

    public enum TipoDePrestamo
    {
        Pesos, Dolares, Todos
    }

//Sobrescritura ToString

        public override string ToString() //Heredado de la clase Object. Se lo sobrescribe para que llame a las funciones protected Mostrar de cada clase de la relacion de herencia de Vehiculo
        {
            return this.Mostrar();
        }

//Sobrescritura Equals()

        public override bool Equals(object obj)
        {
            if (obj is Auto)
            {
                if (this == (Auto)obj)
                    return true;
            }
            return false;
        }