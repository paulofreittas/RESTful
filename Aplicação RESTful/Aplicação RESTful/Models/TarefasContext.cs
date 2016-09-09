using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Aplicacao_RESTful.Models
{
    public class TarefasContext : DbContext
    {
        public DbSet<Tarefas> Tarefas { get; set; }
    }
}