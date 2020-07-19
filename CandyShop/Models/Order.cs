using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Models
{
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }

        [Required(ErrorMessage ="Please enter your first name")]
        [Display(Name ="First Name")]
        [StringLength(25)]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Please enter your last name")]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Please enter your street address")]
        [Display(Name = "Street address")]
        [StringLength(1000)]
        public string Address { get; set; }


        [Required(ErrorMessage = "Please enter your city name")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter your state")]
        [StringLength(2, MinimumLength =2)]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter your zip code")]
        [StringLength(5, MinimumLength = 5)]
        public string ZipCode { get; set; }
        [Required(ErrorMessage = "Please enter your phone number")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        
        public List<OrderDetail> OrderDetails { get; set; }

        [BindNever]
        public decimal OrderTotal { get; set; }

        [BindNever]
        public DateTime OrderPlaced { get; set; }

        }
    }

