using System.Collections.Generic;

namespace FnsUtility
{
    /// <summary>
    /// Generic file reader template
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IFileReader<T> 
    {
        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        string FileName { get; set; }

        /// <summary>
        /// yields each record
        /// </summary>
        IEnumerable<T> Records();
    }
}
