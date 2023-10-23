using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework;

public class Supplier
{
	public int SupplierId { get; set; }
	
	[Required]
	[StringLength(40)]
	public string? CompanyName { get; set; }
}
