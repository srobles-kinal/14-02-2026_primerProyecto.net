using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace WorkerOrderManagement.Domain.Entities
{
    public class Aspirante
    {
        public string Apellido{get;set;}
        public string Nombres{get;set;}
        public string Direccion{get;set;}
        public string Telefono{get;set;}
        public string Email{get;set;}
        public string ExamenId{get;set;}
        public string CarreraId{get;set;}
        public string JornadaId{get;set;}

    }
}