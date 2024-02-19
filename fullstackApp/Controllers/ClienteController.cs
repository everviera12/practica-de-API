using fullstackApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace fullstackApp.Controllers
{
    [ApiController]
    [Route("cliente")]
    public class ClientesController : ControllerBase
    {
        // obtener todos los clientes
        [HttpGet]
        [Route("/lista")]
        public dynamic ListarClientes()
        {
            List<Cliente> clientes = new List<Cliente>
            {
                // usuario 1
                new Cliente
                {
                    id = "1",
                    nombre = "Victor Viera",
                    edad = "23",
                    email = "everisc2@gmail.com"
                },

                // usuario 2
                new Cliente
                {
                    id = "2",
                    nombre = "Victor Viera",
                    edad = "23",
                    email = "everisc2@gmail.com"
                }
            };
            return clientes;
        }

        // obtener cliente por ID
        [HttpGet]
        [Route("listaID")]
        public dynamic ListarClientePorID(int codigo)
        {
            return new Cliente
            {
                id = codigo.ToString(),
                nombre = "Victor Viera",
                edad = "23",
                email = "everisc2@gmail.com"
            };
        }

        [HttpPost]
        [Route("/guardar")]
        public dynamic GuardarCliente([FromBody] Cliente cliente)
        {
            return cliente;
        }
    }
}  
