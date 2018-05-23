using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WS_Actas.Data;
using WS_Actas.Model;

namespace WS_Actas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiceUsuarios" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServiceUsuarios.svc o ServiceUsuarios.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceUsuarios : IServiceUsuarios
    {
        public void CrearUsuario(string nombre, string contraseña, int identificacion)
        {
            Data_Usuarios.CrearUsuario(new Usuario(0, nombre, contraseña, identificacion));
        }

        public List<Usuario> ObtenerUsuarios()
        {
            return Data_Usuarios.ObtenerUsuarios();
        }

        public Usuario ObtenerUsuario(string idUsuario)
        {
            return Data_Usuarios.ObtenerUsuario(idUsuario);
        }

        public void ActualizarUsuario(int id_usuario, string nombre, string contraseña, int identificacion)
        {
            Data_Usuarios.ActualizarUsuario(new Usuario(id_usuario, nombre, contraseña, identificacion));
        }

        public Usuario AutenticarUsuario(int identificacion, string contraseña)
        {
            return Data_Usuarios.AutenticarUsuario(identificacion, contraseña);
        }
    }
}
