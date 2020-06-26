using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WsTower.Contexts;
using WsTower.Domains;

namespace WsTower.Repositories
{
    public class JogoRepository
    {
        public List<Jogo> Listar()
        {
            using (CampeonatoContext ctx = new CampeonatoContext())
            {
                return ctx.Jogo.ToList();
            }
        }

        public List<Jogo> ListarPoData(string DataJogo)
        {
            using (CampeonatoContext ctx = new CampeonatoContext())
            {
                return ctx.Jogo.Where(u => u.Data == DateTime.Parse(DataJogo)).ToList();
            }
        }

        public List<Jogo> ListarPorEstadio(string Estadio)
        {
            using (CampeonatoContext ctx = new CampeonatoContext())
            {
                return ctx.Jogo.Where(u => u.Estadio == Estadio).ToList();
            }
        }

        public List<Jogo> ListarPorSelecao(string Selecao)
        {
            using (CampeonatoContext ctx = new CampeonatoContext())
            {
                return ctx.Jogo.Where(u => u.SelecaoCasaNavigation.Nome == Selecao).ToList();


            }
        }
    }
}
