using ERPTeste.App_Base;
using ERPTeste.DTO;
using ERPTeste.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ERPTeste.Virtual_Objects
{
    [Route("usuario")]
    [ApiController]
    public class UsuarioVO : Contexto
    {
        [EndpointName("salvar")]
        [HttpPost("{usuario}")]
        public int Salvar(UsuarioDTO usuario)
        {
            Usuario model = new Usuario();

            if (usuario.Id.HasValue)
            {
                _db.Entry(usuario).State = EntityState.Modified;
            }
            else
            {
                 model = viewParaModel(usuario); 
                _db.Usuarios.Add(model);

            }

            _db.SaveChanges();

            return model.Id;
        }

        private Usuario viewParaModel(UsuarioDTO vm)
        {
            var model = new Usuario();

            model.Nome = vm.Nome;
            model.Login = vm.Login;
            model.Senha = vm.Senha;
            model.Email = vm.Email;
            model.IdColaborador = vm.idColaborador;
            model.DataInclusao = DateTime.Now;
            model.Ativo = true;

            return model;

        }
    }
}
