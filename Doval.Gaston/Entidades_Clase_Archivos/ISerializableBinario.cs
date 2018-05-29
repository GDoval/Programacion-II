using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Clase_Archivos
{
    public interface ISerializableBinario
    {
        void Serializar();

        Jugador Deserializar();
    }
}
