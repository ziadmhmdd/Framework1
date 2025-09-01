using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework1.Entities
{
    // EF Core support 4 Ways For Mapping Classes in Database:ممكن يتحول ل [Table, View, Function] مش شرط كلاس بس
    // 1. By Convention [Default Behavior] 
    // 2. Data Annotation [Set Of Attributes(Classes) Used For Data Validation] 
    // 3. Fluent APIs
    // 4. Class Configuration

    // Entity
    // Poco Class : Plain OLD CLR Object 
    //internal class Employee // Table 
    //{
    //    public int Id { get; set; } // Public Numeric Property Named 'Id' | EmployeeId --> PK - Identity(1,1)
    //    public string Name { get; set; } // Reference Type : Required : [Not Allow Null] - nvarchar(max)
    //    public int? Age { get; set; } // Nullable Value Type : int[Age] - Optional - [Allow Null] 
    //    public double Salary { get; set; } // Value Type : Float[Salary] - Required 
    //    public string? Email { get; set; } // nvarchar(max) - Optional  
    //    public DateTime DateOfCreation { get; set; } // datetime2 - Required  
    //}



    // 2. Data Annotation 

    //[Table("Hamada", Schema ="dbo")]
    //class Employee
    //{
    //    [Key]
    //    [DatabaseGenerated(DatabaseGeneratedOption.None)] // ده لو عايزه انه برايمري كاي بس من غير ايدينتيتي
    //    public int EmpId { get; set; }

    //    [Required]
    //    [Column("EmpName", TypeName ="Varchar")] // ده لو عايز اغير الداتا تايب
    //    [MaxLength(50)]
    //    [StringLength(50, MinimumLength = 10)]
    //    public string? Name { get; set; }

    //    [Range(20, 60)]
    //    public int? Age { get; set; }

    //    [EmailAddress]
    //    public string Email { get; set; } // Example@example.com

    //    [Phone]
    //    [DataType(DataType.PhoneNumber)]
    //    public string PhoneNumber { get; set; }

    //    [Column(TypeName ="Money")]
    //    [DataType(DataType.Currency)]
    //    public double Salary { get; set; }

    //    [NotMapped]
    //    public double TotalSalary { get; set; }
    //    public string Password { get; set; }



    //}

    class Employee
    {
        public string EmId { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }
        public DateTime DateOfCreation { get; set; }
    }

}
