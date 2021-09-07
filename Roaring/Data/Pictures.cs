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

    public class Pictures{
        private List<Picture> _pictures {get; set;}

        Pictures()
        {
            _pictures = new List<Picture>();
        }

        public void AddPicture(string Uri, string Alt)
        {
            _pictures.Add(new Picture(Uri, Alt));
        }

        public List<Picture> GetAllPictures()
        {
            return _pictures;
        }
    }
}
