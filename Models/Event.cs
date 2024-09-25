using System.ComponentModel.DataAnnotations;

namespace LiveCoding.Models
{
    [Serializable]
    public class Event
    {
        [Required]
        public long EventId { get; set; }

        public EventStatusUpdate StatusUpdate { get; set; }

        public static Event GetExample()
        {
            var exempleEvent = new Event()
            {
                EventId = 879001256801,
                StatusUpdate = EventStatusUpdate.GetExample(),
            };

            return exempleEvent;
        }
    }
}
