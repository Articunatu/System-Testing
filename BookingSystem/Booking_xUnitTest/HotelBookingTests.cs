using System;
using Xunit;
using BookingSystem.Models;
using Shouldly;

namespace Booking_xUnitTest
{
    public class HotelBookingTests
    {
        [Fact]
        public void Should_Return_RoomBookingResponse_With_Request_Value()
        {
            ///Arrange
            var request = new RoomBookingRequest
            {
                FullName = "John Smith",
                EMail = "johnsmith@gmail.com",
                Date = new DateTime(2022,06,13)
            };

            var process = new RoomBookingRequestProcess();

            ///Act
            RoomBookingResponse response = process.BookRoom(request);

            ///Assert
            Assert.NotNull(response);
            Assert.Equal(request.FullName, response.FullName);
            Assert.Equal(request.EMail, response.EMail);

            response.ShouldNotBeNull();

            response.FullName.ShouldBe(request.FullName);
        }
    }
}
