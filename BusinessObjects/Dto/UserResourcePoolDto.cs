//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusinessObjects.Dto
{
    using System;
    using System.ComponentModel.DataAnnotations;
    
    public class UserResourcePoolDto
    {
    	[Required]
        public int Id { get; set; }
    	[Required]
        public int UserId { get; set; }
    	[Required]
        public int ResourcePoolId { get; set; }
    	[Required]
        public decimal ResourcePoolRate { get; set; }
    	[Required]
        public decimal TotalCostIndexRating { get; set; }
    	[Required]
        public decimal KnowledgeIndexRating { get; set; }
    	[Required]
        public decimal QualityIndexRating { get; set; }
    	[Required]
        public decimal SectorIndexRating { get; set; }
    	[Required]
        public decimal EmployeeSatisfactionIndexRating { get; set; }
    	[Required]
        public decimal CustomerSatisfactionIndexRating { get; set; }
    	[Required]
        public decimal DistanceIndexRating { get; set; }
    	[Required]
        public System.DateTime CreatedOn { get; set; }
    	[Required]
        public System.DateTime ModifiedOn { get; set; }
        public Nullable<System.DateTime> DeletedOn { get; set; }
    	
    	public UserResourcePool ToBusinessObject()
    	{
    		return new UserResourcePool()
    		{
    			Id = Id, 
    			UserId = UserId, 
    			ResourcePoolId = ResourcePoolId, 
    			ResourcePoolRate = ResourcePoolRate, 
    			TotalCostIndexRating = TotalCostIndexRating, 
    			KnowledgeIndexRating = KnowledgeIndexRating, 
    			QualityIndexRating = QualityIndexRating, 
    			SectorIndexRating = SectorIndexRating, 
    			EmployeeSatisfactionIndexRating = EmployeeSatisfactionIndexRating, 
    			CustomerSatisfactionIndexRating = CustomerSatisfactionIndexRating, 
    			DistanceIndexRating = DistanceIndexRating, 
    			CreatedOn = CreatedOn, 
    			ModifiedOn = ModifiedOn, 
    			DeletedOn = DeletedOn
    		};
    	}
    }
}