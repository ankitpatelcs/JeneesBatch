using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace codeFirst.Models
{
    [Table("tblemployee")]
    public class tblemployee
    {
        [Column("emp_id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Required(ErrorMessage = "Employee ID is Required")]
        //[Display(Name = "Employee ID")]
        public int emp_id { get; set; }

        [Column("f_name")]
        [Display(Name = "First name")]
        //[Required(ErrorMessage = "First name is Required")]
        [StringLength(10, ErrorMessage = "First name must be less than 10 characters.")]
        public string f_name { get; set; }

        [Column("salary")]
        [Display(Name = "Salary")]
        //[Required(ErrorMessage = "Salary is Required")]
        public int salary { get; set; }

        [Column("mobile")]
        [Display(Name = "Mobile No.")]
        //[Required(ErrorMessage = "Mobile No. is Required")]
        public decimal mobile { get; set; }

        [Column("email")]
        [Display(Name = "Email")]
        //[Required(ErrorMessage = "Email is Required")]
        [EmailAddress]
        public string email { get; set; }

        [Column("dob")]
        [Display(Name = "Date Of Birth")]
        //[Required(ErrorMessage = "Date Of Birth is Required")]
        public DateTime? dob { get; set; }

        [Column("address")]
        [Display(Name = "Address")]
        //[Required(ErrorMessage = "Address is Required")]
        public string address { get; set; }

        [Column("city_id")]
        [Display(Name = "City")]
        [ForeignKey("tblcity")]
        //[Required(ErrorMessage = "City is Required")]
        public int? city_id { get; set; }

        public tblcity tblcity { get; set; }

    }
}
