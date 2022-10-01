using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface Servicios
    {
        void EstudiantesPregado();
        void EstudiantesPostgrado();
        void PromedioGeneral(String tipo,String programa);
        void EstudiantesDescatacados(String tipo, String programa);
    }
}
