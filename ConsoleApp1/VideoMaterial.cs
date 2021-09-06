using System;
using System.Collections.Generic;

namespace Task001
{
    /// <summary>
    /// Class for implementing video material, inherits from TrainingMaterialand and implements ICloneable and IVersionable interfaces;
    /// </summary>
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
        public string UriSplashScreen { get; private set; }

        /// <summary>
        /// Class parametrized constructor;
        /// </summary>
        /// <param name="uriVideoContent"> string for description of uri of video content </param>
        /// <param name="videoFormat">enumerated video format, type Format </param>
        /// <param name="version"> byte array, implemetation of IVersionable interface, limited by const int VERSION_EXACT_LENGTH </param>
        /// <param name="uriSplashScreen"> string dor description of uri splash screen </param>
        /// <param name="uriPictureContent"> string dor description of uri picture content </param>
        /// <param name="description"> string for description of video material </param>
        /// <param name="uniqueId"> Guid type ID </param>
        public VideoMaterial ( string uriVideoContent, Format videoFormat, byte[] version, string uriSplashScreen, string uriPictureContent,string description, Guid uniqueId ) : base( description,uniqueId )
        {
            UriVideoContent = uriVideoContent;
            VideoFormat = videoFormat;
            UriSplashScreen = uriSplashScreen;
            UriPictureContent = uriPictureContent;
            _version = version;
        }

        /// <summary>
        /// implementing ICLoneable;
        /// </summary>
        /// <returns> returns a deep copy of itself </returns>
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
