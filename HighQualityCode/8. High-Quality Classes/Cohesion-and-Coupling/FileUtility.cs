//-----------------------------------------------------------------------
// <copyright file="FileUtility.cs" company="Telerik Academy">
// Copyright (c) 2013 Telerik Academy. All rights reserved.
// </copyright>
// <author>For academic reasons - crypted info</author>
//-----------------------------------------------------------------------
namespace CohesionAndCoupling
{
    using System;

    /// <summary>
    /// Provide methods to get filename and his extension from <see cref="System.String"/> data.
    /// </summary>
    public static class FileUtility
    {
        /// <summary>
        /// Get file name extension.
        /// </summary>
        /// <param name="fileName"><see cref="System.String"/> file name data</param>
        /// <returns>Extension of checked file name data.</returns>
        /// <exception cref="System.ArgumentNullException">Thrown when <paramref name="fileName"/> is empty.</exception>
        public static string GetFileExtension(string fileName)
        {
            if (fileName == null)
            {
                throw new ArgumentNullException("Missing file name!");
            }

            int indexOfLastDot = fileName.LastIndexOf(".");
            string extension;

            if (indexOfLastDot == -1)
            {
                extension = string.Empty;
            }
            else
            {
                extension = fileName.Substring(indexOfLastDot + 1);
            }
            
            return extension;
        }

        /// <summary>
        /// Get only file name (without his extension).
        /// </summary>
        /// <param name="fileName"><see cref="System.String"/> file name data</param>
        /// <returns>Only file name without his extension.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when <paramref name="width"/> is zero or negative.</exception>
        public static string GetFileNameWithoutExtension(string fileName)
        {
            if (fileName == null)
            {
                throw new ArgumentNullException("Missing file name!");
            }

            int indexOfLastDot = fileName.LastIndexOf(".");
            string fileNameWithoutExtension;

            if (indexOfLastDot == -1)
            {
                fileNameWithoutExtension = fileName;
            }
            else
            {
                fileNameWithoutExtension = fileName.Substring(0, indexOfLastDot);
            }

            return fileNameWithoutExtension;
        }      
    }
}