using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;

namespace H2W_mvc.Models
{
    public class nvp
    {
        public string name{ get; set;}
        public string value { get; set;}
    }

    public class measurementTables
    {
        public static List<string> weight = new List<string>() { "lbs", "kgs" };
        public static List<string> length = new List<string>() { "inches", "mm" };
        public static List<string> velocity = new List<string>() { "in/sec", "m/sec" };
        public static List<string> power = new List<string>() { "DC", "AC:Single", "AC:Three Phase" };
        public static List<string> force = new List<string>() { "lbs", "N" };
        public static List<string> accuracy = new List<string>() { "inches", "microns" };
        public static List<string> accuracy2 = new List<string>() { "arc-sec", "degrees" };
        public static List<string> torque = new List<string>() { "oz-in", "N-m" };
        public static List<string> flatness = new List<string>() { "inches/foot", "microns/meter" };
    }

    public class LinearMotorsWorksheet
    {
        [Required(ErrorMessage="We need to know your name.")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Please provide your company name.")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Company")]
        public string Company { get; set; }

        [Required(ErrorMessage = "Your phone number is required.")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Phone")]
        public string Phone { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 4)]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Please enter a valid email address.")]
        [DataType(DataType.Text)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "What force is required?")]
        public string Quest1 { get; set; }

        
        [DataType(DataType.Text)]
        public string Quest1ddl { get; set; }

        
        [DataType(DataType.Text)]
        [Display(Name = "What is the weight of your payload?")]
        public string Quest2 { get; set; }

        [DataType(DataType.Text)]
        public string Quest2ddl { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "What is the required acceleration?")]
        public string Quest3 { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "What is the time required to complete the travel?")]
        public string Quest4 { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "What is the total required travel?  ")]
        public string Quest5 { get; set; }

        [DataType(DataType.Text)]
        public string Quest5ddl { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "What is the duty cycle for force or acceleration required?")]
        public string Quest6 { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "What is the required velocity?")]
        public string Quest7 { get; set; }

        [DataType(DataType.Text)]
        public string Quest7ddl { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Open or closed loop operation?")]
        public string Quest8 { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Does your motor require bearings?")]
        public string Quest9 { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "What are the ambient conditions of the application?")]
        public string Quest10 { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "What is the available power source?")]
        public string Quest11 { get; set; }

        [DataType(DataType.Text)]
        public string Quest11ddl { get; set; }

        [DataType(DataType.MultilineText)]
        public string Comments { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Horizontal or vertical orientation?")]
        public string Quest12 { get; set; }
    }

    public class RotaryMotorsWorksheet
    {
        [Required(ErrorMessage = "We need to know your name.")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Please provide your company name.")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Company")]
        public string Company { get; set; }

        [Required(ErrorMessage = "Your phone number is required.")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Phone")]
        public string Phone { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 4)]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Please enter a valid email address.")]
        [DataType(DataType.Text)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "What is your total angular excursion?")]
        public string Quest1 { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "What is the inertia of your payload?  ")]
        public string Quest2 { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "What is the required speed?  ")]
        public string Quest3 { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "What is the time required to complete the rotation?")]
        public string Quest4 { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "What is the required angular acceleration?")]
        public string Quest5 { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "What continuous torque is required?")]
        public string Quest6 { get; set; }

        [DataType(DataType.Text)]
        public string Quest6ddl { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "What is the peak torque is required?")]
        public string Quest7 { get; set; }

        [DataType(DataType.Text)]
        public string Quest7ddl { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "What is the duty cycle for torque or acceleration required?")]
        public string Quest8 { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Is position feedback required?")]
        public string Quest9 { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "What is the required accuracy?")]
        public string Quest10 { get; set; }

        [DataType(DataType.Text)]
        public string Quest10ddl { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "What is the required repeatability?")]
        public string Quest11 { get; set; }

        [DataType(DataType.Text)]
        public string Quest11ddl { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "What are the ambient conditions of the application?")]
        public string Quest12 { get; set; }

        [DataType(DataType.Text)]
        public string Quest12ddl { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "What is the available continuous current (amps)?")]
        public string Quest13 { get; set; }

        [DataType(DataType.Text)]
        public string Quest13ddl { get; set; }

        [DataType(DataType.MultilineText)]
        public string Comments { get; set; }
    }

    public class PositioningStagesWorksheet
    {
        [Required(ErrorMessage = "We need to know your name.")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Please provide your company name.")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Company")]
        public string Company { get; set; }

        [Required(ErrorMessage = "Your phone number is required.")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Phone")]
        public string Phone { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 4)]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Please enter a valid email address.")]
        [DataType(DataType.Text)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "What force is required?")]
        public string Quest1 { get; set; }

        [DataType(DataType.Text)]
        public string Quest1ddl { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "What is the weight of your payload?")]
        public string Quest2 { get; set; }

        [DataType(DataType.Text)]
        public string Quest2ddl { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "What is the required acceleration?")]
        public string Quest3 { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "What is the time required to complete the travel?")]
        public string Quest4 { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "What is the total required travel?")]
        public string Quest5 { get; set; }

        [DataType(DataType.Text)]
        public string Quest5ddl { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "What is the duty cycle for force or acceleration required?")]
        public string Quest6 { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "What is the required velocity?")]
        public string Quest7 { get; set; }

        [DataType(DataType.Text)]
        public string Quest7ddl { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "What is the required accuracy?")]
        public string Quest8 { get; set; }

        [DataType(DataType.Text)]
        public string Quest8ddl { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = " What is the required repeatability?")]
        public string Quest9 { get; set; }

        [DataType(DataType.Text)]
        public string Quest9ddl { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "What is the required flatness of motion?")]
        public string Quest10 { get; set; }

        [DataType(DataType.Text)]
        public string Quest10ddl { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "What is the required straightness of motion?")]
        public string Quest11 { get; set; }

        [DataType(DataType.Text)]
        public string Quest11ddl { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "What are the ambient conditions for the application?")]
        public string Quest12 { get; set; }

        [DataType(DataType.Text)]
        public string Quest12ddl { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "What is the available continuous current (amps)?")]
        public string Quest13 { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "What is the available power source?  ")]
        public string Quest14 { get; set; }

        [DataType(DataType.Text)]
        public string Quest14ddl { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Horizontal or vertical orientation?")]
        public string Quest15 { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "What are the ambient conditions of the application?")]
        public string Quest16 { get; set; }

        [DataType(DataType.MultilineText)]
        public string Comments { get; set; }
    }

    public class RequestForQuoteForm
    {
        [Required(ErrorMessage = "We need to know your name.")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Please provide your company name.")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Company")]
        public string Company { get; set; }

        [Required(ErrorMessage = "Your phone number is required.")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Phone")]
        public string Phone { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 4)]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Please enter a valid email address.")]
        [DataType(DataType.Text)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Model Number to Quote:")]
        public string Quest1 { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Category of Product:")]
        public string Quest2 { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Quantity Required:")]
        public string Quest3 { get; set; }

        [DataType(DataType.MultilineText)]
        public string Comments { get; set; }
    }
}