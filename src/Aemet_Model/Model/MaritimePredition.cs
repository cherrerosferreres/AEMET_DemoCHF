using System;

namespace Aemet_Model.Model
{

    public class Rootobject
    {
        public MaritimePredition[] Property1 { get; set; }
    }

    public class MaritimePredition
    {
        public Origen origen { get; set; }
        public Aviso aviso { get; set; }
        public Situacion situacion { get; set; }
        public Prediccion prediccion { get; set; }
        public Tendencia tendencia { get; set; }
        public string id { get; set; }
        public string nombre { get; set; }
    }

    public class Origen
    {
        public string productor { get; set; }
        public string web { get; set; }
        public string language { get; set; }
        public string copyright { get; set; }
        public string notaLegal { get; set; }
        public DateTime elaborado { get; set; }
        public DateTime inicio { get; set; }
        public DateTime fin { get; set; }
    }

    public class Aviso
    {
        public DateTime inicio { get; set; }
        public DateTime fin { get; set; }
        public string texto { get; set; }
        public string id { get; set; }
        public string nombre { get; set; }
    }

    public class Situacion
    {
        public DateTime analisis { get; set; }
        public DateTime inicio { get; set; }
        public DateTime fin { get; set; }
        public string texto { get; set; }
        public string id { get; set; }
        public string nombre { get; set; }
    }

    public class Prediccion
    {
        public DateTime inicio { get; set; }
        public DateTime fin { get; set; }
        public Zona[] zona { get; set; }
    }

    public class Zona
    {
        public Subzona subzona { get; set; }
        public int id { get; set; }
        public string nombre { get; set; }
    }

    public class Subzona
    {
        public string texto { get; set; }
        public int id { get; set; }
        public string nombre { get; set; }
    }

    public class Tendencia
    {
        public DateTime inicio { get; set; }
        public DateTime fin { get; set; }
        public string texto { get; set; }
    }

}
