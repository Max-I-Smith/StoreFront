using System;
using System.ComponentModel.DataAnnotations;

namespace StoreFront.Data.EF
{
    public class CategoryMetaData
    {
      
        //public int CategoryID { get; set; }

        [Required(ErrorMessage ="Category Name is required")]
        [StringLength(50,ErrorMessage ="Category Name cannot be longer than 50 characters")]
        [Display(Name ="Category Name")]
        public string CategoryName { get; set; }
      
        [StringLength(50,ErrorMessage ="Description cannot be longer than 50 characters")]
        [DisplayFormat(NullDisplayText ="N/A")]
        [UIHint("MultilineText")]
        public string Description { get; set; }
    }
    [MetadataType(typeof(CategoryMetaData))]
    public partial class Category
    {

    }

    public class DepartmentMetaData
    {

        //public int DepartmentID { get; set; }

        [Required(ErrorMessage = "Department Name is required~")]
        [StringLength(50, ErrorMessage = "Department Name cannot be longer than 50 characters")]
        [Display(Name = "Department Name")]
        public string DepartmentName { get; set; }

        [StringLength(50, ErrorMessage = "Description cannot be longer than 50 characters")]
        [DisplayFormat(NullDisplayText = "N/A")]
        [UIHint("MultilineText")]
        public string Description { get; set; }
    }
    public partial class Department
    {

    }



    public class ProductMetaData
    {
        //public int ProductID { get; set; }

        [Required(ErrorMessage ="Product Name is required")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Status ID is required")]
        public int StatusID { get; set; }

        [Required(ErrorMessage = "Category ID is required")]
        public int CategoryID { get; set; }

        [Required(ErrorMessage = "Department ID is required")]
        public int DepartmentID { get; set; }


        public Nullable<decimal> Price { get; set; }
        public Nullable<int> UnitsInStock { get; set; }
    }

    public partial class Product
    {

    }

    public class StatusMetaData
    {

        public int StatusID { get; set; }
        public string StatusName { get; set; }
    }

    public partial class Status
    {

    }

    
}
