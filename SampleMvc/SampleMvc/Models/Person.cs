using System.ComponentModel.DataAnnotations;

namespace SampleMvc.Models;

public partial class Person
{
    public int Id { get; set; }

    [Display(Name = "名前")]
    public string Name { get; set; } = null!;

    [Display(Name = "年齢")]
    [DisplayFormat(DataFormatString = "{0} 歳")]
    public int Age { get; set; }
}
