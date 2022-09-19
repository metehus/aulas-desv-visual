using System;
using Microsoft.EntityFrameworkCore;

using Models;

namespace ApiProject
{

    class Program
    {
        static void Main(string[] args) 
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            var connectionString = builder.Configuration.GetConnectionString("Usuarios") ?? "Data Source=usuarios.db";
            builder.Services.AddSqlite<BaseUsuarios>(connectionString);

            // var baseUsuarios = new BaseUsuarios("users.txt");



            // app.MapGet("/", () => ":D");

            // app.MapGet("/usuarios", () => {
            //     return baseUsuarios.Serializar();
            // });

            // app.MapGet("/usuarios/{email}", (string email) => {
            //     return baseUsuarios.BuscarPorEmail(email).Serializar();
            // });

            // app.MapPost("/usuarios", (ModeloUsuario u) => {
            //     var user = new Usuario(u.nome, u.email, u.password);
            //     baseUsuarios.AdicionarUsuario(user);
            //     baseUsuarios.Salvar();
            //     return $"usuário ${user.GetEmail()} adicionado!";
            // });

            // app.MapPut("/usuarios/{email}", (string email, ModeloUsuario update) => {
            //     var user = baseUsuarios.BuscarPorEmail(email);
            //     user.SetNome(update.nome);
            //     user.SetEmail(update.email);
            //     baseUsuarios.Salvar();
            //     return user.Serializar();
            // });

            // app.MapDelete("/usuarios/{email}", (string email) => {
            //     var user = baseUsuarios.BuscarPorEmail(email);
            //     baseUsuarios.RemoverUsuario(user);
            //     baseUsuarios.Salvar();
            //     return $"usuário ${user.GetEmail()} removido!";
            // });

            app.Run();
        }
        record ModeloUsuario(
            string nome, string email, string password
        );
    }
}