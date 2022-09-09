
using System.Collections.Generic;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioMascota
    {
        IEnumerable<Mascota> GetAllMascotas ();
        Mascota AddMascota (Mascota mascota);
        Mascota UpdateMascota (Mascota mascota);
        void DeleteMascota (int idMascota);
        Mascota GetMascota (int idMascota);
    
    }


}
