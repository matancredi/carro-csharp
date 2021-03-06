﻿using Codenation.Dominio.Entidades;
using Codenation.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Codenation.Dominio.Services
{
    public class MarcaService : IMarcaService
    {
        private readonly IMarcaRepository _marcaRepository;

        public MarcaService(IMarcaRepository marcaRepository)
        {
            _marcaRepository = marcaRepository;
        }

        public IEnumerable<Marca> Marcas()
        {
            try
            {
                return _marcaRepository.Get();
            }
            catch
            {
                return new List<Marca>();
            }
        }

        public Marca MarcaById(int ID)
        {
            try
            {
                return _marcaRepository.GetById(ID);
            }
            catch
            {
                return null;
            }
        }

        public Marca Salvar(Marca marca)
        {
            try
            {
                return _marcaRepository.Save(marca);
            }
            catch
            {
                return null;
            }
        }

        public Marca Atualizar(Marca marca)
        {
            try
            {
                return _marcaRepository.Update(marca);
            }
            catch
            {
                return null;
            }
        }

        public bool Deletar(int ID)
        {
            try
            {
                return _marcaRepository.Delete(ID);
            }
            catch
            {
                return false;
            }
        }
    }
}