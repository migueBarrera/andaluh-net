using System;
using System.Collections.Generic;
using System.Text;

namespace Andaluh
{
    public class EPA
    {
        public static string Transcribe(string text)
        {
            //Do not start transcription if the input is empty
            if (string.IsNullOrWhiteSpace(text))
            {
                return string.Empty;
            }

            return text;
        }
    }
}
