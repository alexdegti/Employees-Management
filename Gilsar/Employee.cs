using BlazorBootstrap;
using System.ComponentModel.DataAnnotations;

namespace Gilsar.Models;

public class Employee{

    [Required(ErrorMessage = "id is required.")][RegularExpression(@"^(\d{9})$", ErrorMessage = "id must be 9 digits long.")]
    public int id{get; set;}

    [Required(ErrorMessage = "Name is required.")][RegularExpression(@"^[a-zA-Z''-''.'\s]{2,22}$", 
        ErrorMessage = "Name must be in English characters, and the length within the range 2-22.")]
    public string? name{get; set;}

    [Required(ErrorMessage = "Title is required.")]
    public Title title{get; set;}

    [Required(ErrorMessage = "Salary is required.")][Range(5000, 99999, ErrorMessage = "Salary must be within the range 5000-99999.")]
    public int salary{get; set;}

    [Required(ErrorMessage = "Profile image path is required.")]
    public string? profileImagePath{get; set;}

    public enum Title{Junior, Senior, CEO};

    //A utility method that converts a title to the adequate icon
    //to be displayed.
    public static IconName TitleToIcon(Employee.Title title){

        switch(title){

            case Employee.Title.Junior:
                return IconName.Dice1;

            case Employee.Title.Senior:
                return IconName.Dice2;

            default:
                return IconName.Dice3;

        }

    }

}