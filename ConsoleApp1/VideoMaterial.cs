using System;
using System.Collections.Generic;

namespace Task001
{
  class VideoMaterial : TrainingMaterial, IVersionable, ICloneable
    {
        private string _uriVideoContent;

        private const int VERSION_EXACT_LENGTH = 8;

        private byte[] _version;
        public byte[] Version
        {
            get
            {
                return _version;
            }
            set
            {
                if (value.Length == VERSION_EXACT_LENGTH)
                {
                    _version = value;
                }
                else
                {
                    throw new ArgumentException("Version is not 8bytes!!!");
                }
            }
        }
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
        public VideoMaterial ( string uriVideoContent, Format videoFormat, byte[] version, string uriSplashScreen, string uriPictureContent,string description, Guid uniqueId ) : base( description,uniqueId )
        {
            UriVideoContent = uriVideoContent;
            VideoFormat = videoFormat;
            UriSplashScreen = uriSplashScreen;
            UriPictureContent = uriPictureContent;
            _version = version;
        }
        public object Clone()
        {
           VideoMaterial  newVideoMaterial = ( VideoMaterial )this.MemberwiseClone();
           return newVideoMaterial;
        }
    }
}
