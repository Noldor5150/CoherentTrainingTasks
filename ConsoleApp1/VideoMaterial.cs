using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task001
{
    class VideoMaterial : TrainingMaterial
    {
        private string _uriVideoContent;
        
        private string _videoFormat;
        public enum  Format { Unknown, Avi, Mp4, Flv };
        public string UriVideoContent
        {
            get { return _uriVideoContent; }
            set { if ( value.Length > 0 )   _uriVideoContent = value; }
        }
        public string VideoFromat
        {
            get { return _videoFormat; }
            set { if (Enum.IsDefined(typeof(Format), value)) _videoFormat = value; }
        }
        public string UriSplashScreen { get; set; }
        public VideoMaterial (string uriVideoContent, string videoFormat, string uriSplashScreen, Guid unicId) : base(unicId)
        {
            UriVideoContent = uriVideoContent;
            VideoFromat = videoFormat;
            UriSplashScreen = uriSplashScreen;
        }
    }
}
