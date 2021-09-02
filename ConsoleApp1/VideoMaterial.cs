using System;


namespace Task001
{
  class VideoMaterial : TrainingMaterial, IVersionable
    {
        private string _uriVideoContent;
        public string UriPictureContent { get; private set; }
        public enum  Format { Unknown, Avi, Mp4, Flv };
        public Format VideoFormat { get; private set; }
        public  byte[] Version { get; set; }
        public string UriVideoContent
        {
            get 
            {
                return _uriVideoContent; 
            }
            set
            {
                if (value.Length > 0)
                {
                    _uriVideoContent = value;
                }
                else
                {
                    throw new ArgumentException("URI cannot be emty!!!");
                }
            }
        }
        public string UriSplashScreen { get; set; }
        public VideoMaterial (string uriVideoContent, Format videoFormat, byte[] version, string uriSplashScreen, string uriPictureContent,string description, Guid uniqueId) : base(description,uniqueId)
        {
            UriVideoContent = uriVideoContent;
            VideoFormat = videoFormat;
            UriSplashScreen = uriSplashScreen;
            UriPictureContent = uriPictureContent;
            Version = version;
        }
        public void ReadVersion(byte[] array)
        {
            throw new NotImplementedException();
        }
        public void InstallVersion(byte[] array)
        {
            throw new NotImplementedException();
        }
    }
}
