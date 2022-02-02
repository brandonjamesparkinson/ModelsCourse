using JurisTempus.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace JurisTempus.ViewModels
{
  public class CaseViewModel
  {
    public int Id { get; set; }

    //[Required]
    //[MinLength(9)]
    public string FileNumber { get; set; }

    //[Required]
    public CaseStatus Status{ get; set; }
  }
}
