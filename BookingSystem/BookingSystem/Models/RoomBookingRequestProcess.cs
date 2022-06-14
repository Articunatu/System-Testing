using System;
using System.Collections.Generic;
using System.Text;

namespace BookingSystem.Models
{
    public class RoomBookingRequestProcess
    {
        public RoomBookingRequestProcess()
        {

        }

        public RoomBookingResponse BookRoom(RoomBookingRequest request)
        {
            return new RoomBookingResponse
            {
                FullName = request.FullName,
                EMail = request.EMail,
                Date = request.Date
            };
        }
    }
}
