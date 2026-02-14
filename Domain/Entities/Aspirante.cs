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
        public string _Apellido{get;set;}
        public string _Nombres{get;set;}
        public string _Direccion{get;set;}
        public string _Telefono{get;set;}
        public string _Email{get;set;}
        public string _ExamenId{get;set;}
        public string _CarreraId{get;set;}
        public string _JornadaId{get;set;}

    }
}