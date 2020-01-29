using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.ComponentModel.DataAnnotations;

namespace PastoralEmpleo.ViewModel
{
    public class StudiesInformationViewModel
    {
        
        [Display(Name = "Institución")]
        public string School { get; set; }

        [Display(Name = "Adjunte Certificado ò Tìtulo")]
        public string FilePath { get; set; }

        public IFormFile File { get; set; }

        [Display(Name = "Nivel Estudio")]
        public int Idstudylevel { get; set; }
        public SelectList StudyLevelList { get; set; }

        [Display(Name = "Título Obtenido")]
        public string Obtainedtitle { get; set; }        

        [Display(Name = "Estado Acádemico")]
        public int Idacademicstate { get; set; }
        public SelectList academicStateList { get; set; }

        [Display(Name = "Fecha Inicio")]
        public DateTime Startdate { get; set; }

        [Display(Name = "Fecha Finalización")]
        public DateTime Enddate { get; set; }

        [Display(Name = "Periodicidad")]
        public int Idperiodicity { get; set; }
        public SelectList PeriodicityList { get; set; }       

    }
}
