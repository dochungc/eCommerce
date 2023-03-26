using eCommerce.Model.Abstractions.Audits;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.Model.Products;

[BindProperties]
public class ProductFilterRequestModel : IFilterRequestAuditModel
{
    [BindProperty(Name = "page_index")] 
    public int PageIndex { get; set; } = 1;
        
    [BindProperty(Name = "page_size")]
    public int PageSize { get; set; } = 10;
        
    [BindProperty(Name = "search_string")]
    public string? SearchString { get; set; }
        
    [BindProperty(Name = "category_id")]
    public Guid? CategoryId { get; set; }
        
    [BindProperty(Name = "brand_id")]
    public Guid? BrandId { get; set; }
        
    [BindProperty(Name = "from_date")]
    public DateTime? FromTime { get; set; }
        
    [BindProperty(Name = "to_date")]
    public DateTime? ToTime { get; set; }
        
    [BindProperty(Name = "from_price")]
    public DateTime? FromPrice { get; set; }
        
    [BindProperty(Name = "to_price")]
    public DateTime? ToPrice { get; set; }
        
    [BindProperty(Name = "is_best_selling")]
    public bool? IsBestSelling { get; set; }
        
    [BindProperty(Name = "is_new")]
    public bool? IsNew { get; set; }
}