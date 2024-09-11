﻿namespace Backend.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.UtcNow.AddHours(5).AddMinutes(30);
        public string Status { get; set; }
        public int UserId { get; set; }
    
        public int ProviderId { get; set; }
        
        public int VenueId { get; set; }
     
        public DateTime End { get; set; }
        public DateTime Start { get; set; }
        public DateTime Date { get;set; }
        public double Amount { get; set; }
        
        public ICollection<BookedSlot> BookedSlots { get; set; }    
    }
}
