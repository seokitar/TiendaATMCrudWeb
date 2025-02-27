﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWeb.Entidades
{
    public class Cliente:EntidadBase
    {
        public string Nombre { get; set; } = default!;
        public string Apellidos { get; set; } = default!;
        public string Email { get; set; } = default!;


        public override string ToString()
        {
            return $"{Id}: {Nombre} | {Apellidos} | {Email}";
        }
    }
}
