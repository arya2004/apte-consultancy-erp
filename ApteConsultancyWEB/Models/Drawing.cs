namespace ApteConsultancyWEB.Models
{
    public class Drawing
    {
        public int DrawingId { get; set; }
        public int DrawingNumber { get; set; }
        public int DrawingTitle { get; set; }
        public DateOnly DrawingDate { get; set; }
        public int RevisionNumber { get; set; }
        public DateOnly RevisionDate { get; set; }

    }
}
