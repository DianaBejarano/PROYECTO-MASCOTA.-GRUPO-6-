
using System.Collections.Generic;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioDueno
    {
        IEnumerable<Dueno> GetAllDuenos ();
        Dueno AddDueno (Dueno dueno);
        Dueno UpdateDueno (Dueno dueno);
        void DeleteDueno (int idDueno);
        Dueno GetDueno (int idDueno);
    
    }


}

