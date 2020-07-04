﻿using Codenation.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Codenation.Dominio.Interfaces
{
    public interface IMarcaRepository
    {
        IEnumerable<Marca> Get();
        Marca GetById(int Id);
        Marca Save(Marca marca);
        Marca Update(Marca marca);
        bool Delete(int Id);
    }
}