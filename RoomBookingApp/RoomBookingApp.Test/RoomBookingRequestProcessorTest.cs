using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RoomBookingApp.Test
{
    public class RoomBookingRequestProcessorTest
    {
        [Fact]
        public void Shoud_Return_Roombooking_Response_with_Request_values()
        {
            var bookingRequest = new RoomBookingRequest
            {
                ///Test values
                FullName = "Reidar Nilsen",
                Email="nomail4reidar@gmail.com",
                DateTime = new DateTime(2022,07,12)
            };

            var processor = new RoomBookingRequestProcessor();

            RoomBookingResult result = processor.BookRoom(bookingRequest);
        }
    }
}
