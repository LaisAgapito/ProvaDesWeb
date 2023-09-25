﻿using Microsoft.AspNetCore.Authentication;
using System.ComponentModel.DataAnnotations;

namespace APIExemplo.Models
{
    public class Veiculo
    {
        [Key]
        public int IdVeiculo { get; set; }

        public string descricao { get; set; }

        public int ano { get; set; }

        public string placa { get; set; }

        public string modelo { get; set; }

        public string marca { get; set; }

        public string cor { get; set; }

    }
}
