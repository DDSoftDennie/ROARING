using System;
using System.Collections.Generic;

namespace Roaring.Data
{
    public class Picture
    {
        public string Uri { get; set; }
        public string Alt { get; set; }

        public Picture(string uri, string alt)
        {
            Uri = uri;
            Alt = alt;
        }

    }
}
