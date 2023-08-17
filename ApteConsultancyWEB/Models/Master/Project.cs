using System.ComponentModel.DataAnnotations;

namespace ApteConsultancyWEB.Models.Master
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public string ClientWoNumber { get; set; }
        public DateOnly Start { get; set; }
        public DateOnly? End { get; set; }
        public string Services { get; set; }
        public string ProjecLocation { get; set; }
        public decimal TotalFees { get; set; }
        public decimal FeesReceived { get; set; }
        public decimal FeesBalance { get; set; }
        public decimal Expenses { get; set; }
        public decimal ProfitAmount { get; set; }
        public bool IsCompleted { get; set; } 


    }
}
