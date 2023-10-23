using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework;

public class Product
{
	public int ProductId { get; set; }

	[Required]
	[StringLength(40)]
	public string? ProductName { get; set; }
	
	public int SupplierId { get; set; }
	public int CategoryId { get; set; }
	
	[Column("UnitPrice", TypeName = "money")]
	public decimal? UnitPrice { get; set; }
	
	[Column("UnitsInStock")]
	public short? UnitsInStock { get; set; }
	
	[Column("UnitsOnOrder")]
	public short? UnitsOnOrder { get; set; }
	
	[Column("ReorderLevel")]
	public short? ReorderLevel { get; set; }
	
	[Required]
	public bool Discontinued { get; set; }
	
	public virtual Category Category { get; set;} = null!;
}
