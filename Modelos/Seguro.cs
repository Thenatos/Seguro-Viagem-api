using System;
using System.ComponentModel.DataAnnotations;
using SeguroViagem.Api.Modelos;

namespace SeguroViagem.Api.Modelos 
{
    public class Seguro
    {
        public int Id { get; set; }
        public required string NomeContratante { get; set; }
        public required string CpfContratante { get; set; }
        public required string Destino { get; set; }
        public TipoPlano TipoPlano { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
    }
}