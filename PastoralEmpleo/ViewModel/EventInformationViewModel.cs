using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using PastoralEmpleo.Shared.Enums;

namespace PastoralEmpleo.ViewModel
{
    public class EventInformationViewModel
    {
        [Display(Name = "Número Convocatoria")]
        public int Callnumber { get; set; }

        [Display(Name = "Cargo")]
        public string Position { get; set; }

        [Display(Name = "Iniciación de Jornada")]
        public TimeSpan Initialjobetime { get; set; }

        [Display(Name = "Fin de Jornada")]
        public TimeSpan Endjobtime { get; set; }

        [Display(Name = "Formación")]
        public string Study { get; set; }

        [Display(Name = "Experiencia")]
        public string Experience { get; set; }

        [Display(Name = "Funciones a Desempeñar")]
        public string Functions { get; set; }

        [Display(Name = "Salario")]
        public decimal Salary { get; set; }

        [Display(Name = "Observaciones")]
        public string Observations { get; set; }

        [Display(Name = "Fecha de Convocatoria")]
        public DateTime Initialeventdate { get; set; }

        [Display(Name = "Fin de Convocatoria")]
        public DateTime Endeventdate { get; set; }

        [Display(Name = "Estado Convocatoria")]
        public int Idstatus { get; set; }
        public SelectList StatusList { get; set; }

        [Display(Name = "Descripción")]
        public string Description { get; set; }

        [Display(Name = "Producto")]
        public string Product { get; set; }

        [Display(Name = "Números Vacantes")]
        public int Vacant { get; set; }

        [Display(Name = "Periodo Laboral")]
        public string Laboraltime { get; set; }

        [Display(Name = "Lugar de Trabajo")]
        public string Place { get; set; }

        [Display(Name = "Tipo de Contrato")]
        public int Idcontracttype { get; set; }
        public SelectList ContractTypeList { get; set; }

        [Display(Name = "Forma de Pago")]
        public int Idwaytopay { get; set; }
        public SelectList WayTopayList { get; set; }
        
        public int Idevent { get; set; }
    }
}
