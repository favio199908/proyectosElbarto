using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiServicio.Models;

namespace apiServicio.Services.Contracts
{
    public interface IUsuarioService
    {
        Task<Usuario> GetNombreUsuario(string nombreusuario);
        string CrearPasswordHash(string pPassword, string pSalt);
        string GenerarToken(DateTime pDate, Usuario user, TimeSpan pvalidaDate, string vSigningkey, string vAudence, string vIssuer);
        Task<List<Usuario>> GetList();
        Task<Usuario> AgregaActualiza(Usuario l, string t);
    }
}