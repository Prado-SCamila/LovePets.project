﻿using senai_lovePets_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Interfaces
{
    interface ISituacaoRepository
    {
        List<Situacao> ListarTodas();
    }
}
