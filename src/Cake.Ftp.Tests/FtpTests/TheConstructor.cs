using System;
using Cake.Ftp.Tests.Fixtures;
using FluentAssertions;
using Xunit;

namespace Cake.Ftp.Tests.FtpTests
{
    public sealed class TheConstructor
    {
        [Fact]
        public void Should_Throw_If_File_System_Is_Null()
        {
            // Given
            var fixture = new FtpClientFixture { FileSystem = null };

            // When 
            var result = Record.Exception(() => fixture.UploadFile());

            // Then
            result.Should().BeOfType<ArgumentNullException>().Subject
                .ParamName.Should().Equals("fileSystem");
        }

        [Fact]
        public void Should_Throw_If_Cake_Environment_Is_Null()
        {
            // Given
            var fixture = new FtpClientFixture { Environment = null };

            // When 
            var result = Record.Exception(() => fixture.UploadFile());

            // Then
            result.Should().BeOfType<ArgumentNullException>().Subject
                .ParamName.Should().Equals("environment");
        }

        [Fact]
        public void Should_Throw_If_FTP_Service_Is_Null()
        {
            // Given
            var fixture = new FtpClientFixture { FtpService = null };

            // When 
            var result = Record.Exception(() => fixture.UploadFile());

            // Then
            result.Should().BeOfType<ArgumentNullException>().Subject
                .ParamName.Should().Equals("ftpService");
        }
    }
}