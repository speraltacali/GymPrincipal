using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GE.Dominio.Entity;
using GE.Dominio.Repositorio.Cliente;
using GE.Infraestructura.Context;
using GE.Infraestructura.Repositorio.Cliente;
using GE.IServicio.Cliente;
using GE.IServicio.Cliente.DTO;
using GE.Repositorio;
using GE.Repositorio.Base;
using GE.Servicio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GE.Infraestructura.Repositorio;

namespace GE.Presentacion.Gym.Controllers
{
    public class ClienteController : Controller
    {
        private IClienteServicio repositorioCliente = new ClienteServicio();

        // GET: Cliente
        public ActionResult Index()
        {
            var cliente = repositorioCliente.ObtenerTodo();
            return View(cliente);
        }

        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(ClienteDto cliente)
        {
            if (ModelState.IsValid)
            {
                repositorioCliente.Agregar(cliente);

                return RedirectToAction("Index");
            }

            return View(cliente);
        }

        public ActionResult Update(long id)
        {
            var cliente = repositorioCliente.ObtenerTodoPorId(id);

            return View(cliente);
        }


        [HttpPost]
        public ActionResult Update(ClienteDto clienteDto)
        {
            if (ModelState.IsValid)
            {
                repositorioCliente.Modificar(clienteDto);

                return RedirectToAction("Index");
            }

            return View(clienteDto);
        }

        public ActionResult Delete(long id)
        {
            var cliente = repositorioCliente.ObtenerTodoPorId(id);

            return View(cliente);
        }

        [HttpPost]
        public ActionResult Delete(ClienteDto clienteDto)
        {
            repositorioCliente.Eliminar(clienteDto.Id);
            return RedirectToAction("Index");
        }
    }
}