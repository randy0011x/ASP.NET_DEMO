using System;
namespace hello_world.Models;
using System.ComponentModel.DataAnnotations;
public class User
{
    [Required]
    public string username { get; set; }
    [Required]
    [Display(Name ="Full name")]
    public string fullname{get; set;}

    [Required]
    [DataType(DataType.Password)]
    public string password{get; set;}


    
}
