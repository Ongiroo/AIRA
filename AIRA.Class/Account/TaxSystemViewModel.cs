using System;
using System.Collections.Generic;
using System.Text;

namespace AIRA.Class
{
    public class TaxSystemViewModel
    {
        public System.Collections.Generic.IEnumerable<Tax> Taxes { get; set; }
        public System.Collections.Generic.IEnumerable<TaxGroup> TaxGroups { get; set; }
        public System.Collections.Generic.IEnumerable<ItemTaxGroup> ItemTaxGroups { get; set; }
    }
}
public abstract class BaseDto
{
    public virtual int Id { get; set; }
    public string ModifiedBy { get; set; }
}
public class ItemTaxGroupTax : BaseDto
{
    public int TaxId { get; set; }
    public int ItemTaxGroupId { get; set; }
    public bool IsExempt { get; set; }
}
public class ItemTaxGroup : BaseDto
{
    public string Name { get; set; }
    public bool IsFullyExempt { get; set; }
    public IList<ItemTaxGroupTax> Taxes { get; set; }

    public ItemTaxGroup()
    {
        Taxes = new List<ItemTaxGroupTax>();
    }
}
public class TaxGroupTax : BaseDto
{
    public int TaxId { get; set; }
    public int TaxGroupId { get; set; }
}

public class Tax : BaseDto
{
    public string TaxName { get; set; }
    public string TaxCode { get; set; }
    public decimal Rate { get; set; }
    public bool IsActive { get; set; }
}

public class TaxSystemDto
{
    public System.Collections.Generic.IEnumerable<Tax> Taxes { get; set; }
    public System.Collections.Generic.IEnumerable<TaxGroup> TaxGroups { get; set; }
    public System.Collections.Generic.IEnumerable<ItemTaxGroup> ItemTaxGroups { get; set; }
}
public class TaxGroup : BaseDto
{
    public string Description { get; set; }
    public bool TaxAppliedToShipping { get; set; }
    public bool IsActive { get; set; }
    public IList<TaxGroupTax> Taxes { get; set; }

    public TaxGroup()
    {
        Taxes = new List<TaxGroupTax>();
    }
}