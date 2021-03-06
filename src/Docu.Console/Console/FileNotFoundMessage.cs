﻿using System.Collections.Generic;

namespace Docu.Console
{
    public class BadFileMessage : IScreenMessage
    {
        private readonly string path;

        public BadFileMessage(string path)
        {
            this.path = path;
        }

        public IEnumerable<string> GetBody()
        {
            yield return "The requested file is in a bad format and could not be loaded: '" + path + "'";
        }
    }
}
