﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Aplicacao_RESTful.Models
{
    [Table("Tarefas")]
    public class Tarefas
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Titulo { get; set; }

        [MaxLength(200)]
        public string Descricao { get; set; } 
    }
}