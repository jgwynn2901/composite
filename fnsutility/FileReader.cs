using System;

namespace FnsUtility
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class FileReader : IDisposable
    {
        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Opens this instance.
        /// </summary>
        public abstract bool Open();

        /// <summary>
        /// Reads the next line.
        /// </summary>
        public abstract string ReadLine();

       
        #region IDisposable Members

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
        }

        /// <summary>
        /// override this to release unmanaged and - optionally - managed resources
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        { }

        #endregion
    }
}
