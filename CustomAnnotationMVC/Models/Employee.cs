using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using CustomAnnotationMVC.CustomAnnotation;

namespace CustomAnnotationMVC.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public DateTime DOB { get; set; }
        [ValidJoinDate]
        public DateTime JoinDate { get; set; }
    }
}