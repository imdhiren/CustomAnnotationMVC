using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomAnnotationMVC.CustomAnnotation
{
    public class ValidJoinDate : ValidationAttribute
    {
        //to implement validation logic,ypu nedd to override this methos in base class.
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var model = (Models.Employee)validationContext.ObjectInstance;
            DateTime datejoin = Convert.ToDateTime(value);

            //For check join date not greater than dob
            if (model.DOB > datejoin)
            {
                return new ValidationResult("Join date not greater than birthdate.");
            }
            else if (datejoin < DateTime.Now) //for check join date and current date
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Join date not greater than current date.");
            }
        }
    }
}