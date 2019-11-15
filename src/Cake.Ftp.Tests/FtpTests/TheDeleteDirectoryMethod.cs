using System;
using Cake.Ftp.Tests.Fixtures;
using FluentAssertions;
using Xunit;

namespace Cake.Ftp.Tests.FtpTests {

    public sealed class TheDeleteDirectoryMethod
    {
        [Fact]
        public void Should_Throw_If_Server_Uri_Is_Null()
        {
            // Given
            var fixture = new FtpClientFixture { ServerUri = null };

            // When 
            var result = Record.Exception(() => fixture.DeleteDirectory());

            // Then
            result.Should().BeOfType<ArgumentNullException>().Subject
              .ParamName.Should().Equals("serverUri");

        }

        [Fact]
        public void Should_Throw_If_Username_Is_Null()
        {
            // Given
            var fixture = new FtpClientFixture { Username = null };

            // When 
            var result = Record.Exception(() => fixture.CreateDirectory());

            // Then
            result.Should().BeOfType<ArgumentNullException>().Subject
              .ParamName.Should().Equals("Username");
        }

        [Fact]
        public void Should_Throw_If_Password_Is_Null()
        {
            // Given
            var fixture = new FtpClientFixture { Password = null };

            // When 
            var result = Record.Exception(() => fixture.CreateDirectory());

            // Then
            result.Should().BeOfType<ArgumentNullException>().Subject
             .ParamName.Should().Equals("Password");
        }

        [Fact]
        public void Should_Throw_If_Url_Is_Not_FTP_Scheme()
        {
            // Given
            var fixture = new FtpClientFixture { ServerUri = new Uri("http://my.server.com/test.html") };

            // When 
            var result = Record.Exception(() => fixture.CreateDirectory());

            // Then
            result.Should().BeOfType<ArgumentOutOfRangeException>().Subject
            .ParamName.Should().Equals("serverUri");
        }

        [Fact]
        public void Should_Delete_File_Without_Error()
        {
            // Given
            var fixture = new FtpClientFixture();

            // When 
            var result = Record.Exception(() => fixture.CreateDirectory());

            // Then
            result.Should().BeNull();
        }
    }
}