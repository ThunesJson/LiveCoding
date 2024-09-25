namespace LiveCoding.Models
{
    public class EventDetailResponse : CommonResponse
    {
        public Event Event { get; set; }

        public static new EventDetailResponse GetExample()
        {
            var eventDetailResponse = new EventDetailResponse()
            {
                ReturnCode = 1000,
                ReturnMessage = "Success",
                RequestId = "1b07e7c6-0d92-4cc8-b500-75510acb49bf",
                Event = Event.GetExample(),
            };

            return eventDetailResponse;
        }
    }
}
