using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task001
{
    class LinkToNetworkResource : TrainingMaterial
    {
        private string _uri;

        private string _linkType;
        public string Uri
        {
            get { return _uri; }
            set { if (value.Length > 0) _uri = value; }
        }
        public enum Type { Unknown, Html, Image, Audio, Video};
        
        public Type LinkType { get; private set; }
    

        public LinkToNetworkResource (string uri, string linkType, Guid unicId) : base(unicId)
        {
            Uri = uri;
            LinkType = linkType;
        }
    }
}
