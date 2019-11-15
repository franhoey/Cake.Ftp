using System;
using Cake.Core.IO;

namespace Cake.Ftp.Services {
    public interface IFtpService {
        /// <summary>
        /// Uploads a file.
        /// </summary>
        /// <param name="serverUri">The URI for the FTP server.</param>
        /// <param name="uploadFile">The file to upload.</param>
        /// <param name="username">The FTP username.</param>
        /// <param name="password">The FTP password.</param>
        void UploadFile(Uri serverUri, IFile uploadFile, string username, string password);

        /// <summary>
        /// Deletes a file.
        /// </summary>
        /// <param name="serverUri">The URI for the FTP server.</param>
        /// <param name="username">The FTP username.</param>
        /// <param name="password">The FTP password.</param>
        void DeleteFile(Uri serverUri, string username, string password);

        /// <summary>
        /// Creates a directory
        /// </summary>
        /// <param name="serverUri">The URI for the FTP server including the folder name.</param>
        /// <param name="username">The FTP username.</param>
        /// <param name="password">The FTP password.</param>
        void CreateDirectory(Uri serverUri, string username, string password);

        /// <summary>
        /// Creates a directory
        /// </summary>
        /// <param name="serverUri">The URI for the FTP server including the folder name.</param>
        /// <param name="username">The FTP username.</param>
        /// <param name="password">The FTP password.</param>
        void DeleteDirectory(Uri serverUri, string username, string password);
    }
}
