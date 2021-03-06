﻿#region usings

using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text;

#endregion

namespace EpoSql.Util
{
    public sealed class DebugWriter : TextWriter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DebugWriter"/> class.
        /// </summary>
        public DebugWriter()
            : base(CultureInfo.InvariantCulture)
        {
            // Do nothing here
        }

        /// <summary>
        /// Returns the <see cref="Encoding"/> in which the output is written.
        /// </summary>
        /// <returns>
        /// The Encoding in which the output is written.
        /// </returns>
        public override Encoding Encoding
        {
            get { return Encoding.Default; }
        }

        /// <summary>
        /// Writes a character to the text stream.
        /// </summary>
        /// <param name="value">
        /// The character to write to the text stream. 
        /// </param>
        public override void Write(char value)
        {
            Debug.Write(value);
        }

        /// <summary>
        /// Writes a string to the text stream.
        /// </summary>
        /// <param name="value">
        /// The string to write. 
        /// </param>
        public override void Write(string value)
        {
            Debug.Write(value);
        }
    }
}