using System.ComponentModel.DataAnnotations;

namespace Vaerktojer.Prompt.Example.Models;

public enum MyEnum
{
    [Display(Name = "Foo value", Order = 3)]
    Foo,

    [Display(Name = "Bar value", Order = 2)]
    Bar,

    [Display(Name = "Baz value", Order = 1)]
    Baz,

    [Display(Name = "Test value")]
    Test
}
