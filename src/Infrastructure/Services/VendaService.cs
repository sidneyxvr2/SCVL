﻿using Infrastructure.Entities;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Services
{
    public class VendaService : IVendaService
    {
        private readonly IVendaRepository _repository;

        public VendaService(IVendaRepository repository)
        {
            _repository = repository;
        }

        public Venda Add(Venda venda)
        {
            venda.Id = 0;
            venda.Horario = DateTime.Now;
            return _repository.Add(venda);
        }

        public IEnumerable<Venda> GetAll()
        {
            return _repository.GetAll();
        }

        public Venda GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Remove(int id)
        {
            _repository.Remove(id);
        }

        public void Update(Venda venda)
        {

            _repository.Update(venda);
        }
    }
}