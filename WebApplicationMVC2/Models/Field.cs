//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplicationMVC2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Field
    {
        public int fldid { get; set; }
        public string Lang { get; set; }
        public Nullable<System.DateTime> Created { get; set; }
        [Display(Name = "Customer Name")]
        public string CName { get; set; }
        [Display(Name = "Title")]
        public string CTitle { get; set; }
        [Display(Name = "Facility")]
        public string FacName { get; set; }
        public string FacAddress { get; set; }
        public string FacPhone { get; set; }
        public string SurgeonName { get; set; }
        public string SurgeonEmail { get; set; }
        public string CryolifeRep { get; set; }
        public string RegionMgr { get; set; }
        public string LetterAck { get; set; }
        public string LetterFinal { get; set; }
        public string LetterNone { get; set; }
        public string LetterSendTo { get; set; }
        public string ReturnSample { get; set; }
        public string RMANumber { get; set; }
        public string Product { get; set; }
        public string SerialLotNumber { get; set; }
        public string UDI { get; set; }
        public string Implanted { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> DateIncident { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> DateReported { get; set; }
        public string Outcome { get; set; }
        public string Description { get; set; }
        public string DocumentNumber { get; set; }
        public Nullable<System.DateTime> EffectiveDate { get; set; }
    }
}
