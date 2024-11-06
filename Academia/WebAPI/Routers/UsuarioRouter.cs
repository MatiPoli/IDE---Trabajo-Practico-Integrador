using Domain.Models;
using Domain.Services;

namespace WebAPI.Routers
{
    public class UsuarioRouter
    {
        public static void Map(WebApplication app)
        {

            app.MapGet("/usuarios/login/{email}/{clave}", (string email, string clave) =>
            {
                UsuarioService service = new UsuarioService();

                return service.Login(email, clave);
            })
            .WithName("LoginUsuario")
            .WithOpenApi();


            app.MapGet("/usuarios/{id}", (int id) =>
            {
                UsuarioService service = new UsuarioService();

                return service.Get(id);
            })
            .WithName("GetUsuario")
            .WithOpenApi();

            app.MapGet("/usuarios", () =>
            {
                UsuarioService service = new UsuarioService();

                return service.GetAll();
            })
            .WithName("GetAllUsuarios")
            .WithOpenApi();

            app.MapGet("/docentes", () =>
            {
                UsuarioService service = new UsuarioService();

                return service.GetAllDocentes();
            })
            .WithName("GetAllDocentes")
            .WithOpenApi();

            app.MapGet("/alumnos", () =>
            {
                UsuarioService service = new UsuarioService();

                return service.GetAllAlumnos();
            })
            .WithName("GetAllAlumnos")
            .WithOpenApi();

            app.MapPost("/usuarios", (Usuario entity) =>
            {
                UsuarioService service = new UsuarioService();

                service.Add(entity);
            })
            .WithName("AddUsuario")
            .WithOpenApi();

            app.MapPut("/usuarios", (Usuario entity) =>
            {
                UsuarioService service = new UsuarioService();

                service.Update(entity);
            })
            .WithName("UpdateUsuario")
            .WithOpenApi();

            app.MapDelete("/usuarios/{id}", (int id) =>
            {
                UsuarioService service = new UsuarioService();

                service.Delete(id);
            })
            .WithName("DeleteUsuario")
            .WithOpenApi();

        }
    }
}
