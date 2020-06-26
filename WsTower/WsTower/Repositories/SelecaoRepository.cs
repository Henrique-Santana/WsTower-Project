using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WsTower.Contexts;
using WsTower.Domains;

namespace WsTower.Repositories
{
    public class SelecaoRepository
    {
        public List<Selecao> Listar()
        {
            using (CampeonatoContext ctx = new CampeonatoContext())
            {
                return ctx.Selecao.ToList();
            }
        }
    }
}
