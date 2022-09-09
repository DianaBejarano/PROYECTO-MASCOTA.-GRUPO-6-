
using System.Collections.Generic;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioVeterinario
    {
        IEnumerable<Veterinario> GetAllVeterinarios ();
        Veterinario AddVeterinario (Veterinario veterinario);
        Veterinario UpdateVeterinario (Veterinario veterinario);
        void DeleteVeterinario (int idVeterinario);
        Veterinario GetVeterinario (int idVeterinario);
    
    }

}

