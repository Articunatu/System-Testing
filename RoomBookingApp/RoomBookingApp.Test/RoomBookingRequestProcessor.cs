using System;

namespace RoomBookingApp.Test
{
    internal class RoomBookingRequestProcessor
    {
        public RoomBookingRequestProcessor()
        {
        }

        internal RoomBookingResult BookRoom(RoomBookingRequest bookingRequest)
        {
            return new RoomBookingResult
            {
                FullName = "zdpfnodsfosdbfo",
                Email = bookingRequest.Email,
                DateTime = bookingRequest.DateTime
            };
        }
    }
}