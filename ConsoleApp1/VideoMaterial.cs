using System;


namespace Task001
{
  class VideoMaterial : TrainingMaterial
    {
        private string _uriVideoContent;
        public string UriPictureContent { get; private set; }
        public enum  Format { Unknown, Avi, Mp4, Flv };
        public Format VideoFormat { get; private set; }
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
        public VideoMaterial (string uriVideoContent, Format videoFormat, string uriSplashScreen, string uriPictureContent,string description, Guid uniqueId) : base(description,uniqueId)
        {
            UriVideoContent = uriVideoContent;
            VideoFormat = videoFormat;
            UriSplashScreen = uriSplashScreen;
            UriPictureContent = uriPictureContent;
        }
    }
}
