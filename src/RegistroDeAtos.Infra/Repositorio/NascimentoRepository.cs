﻿using RegistroAtos.Domain.Entidade;
using RegistroAtos.Domain.Repositorio;
using RegistroAtos.Infra.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAtos.Infra.Repositorio
{
    public class NascimentoRepository : BaseRepository<Nascimento>, INascimentoRepository
    {
        public NascimentoRepository(Context db) : base(db)
        {
        }
    }
}
