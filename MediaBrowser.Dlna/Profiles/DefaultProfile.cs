﻿using MediaBrowser.Model.Dlna;
using System.Xml.Serialization;

namespace MediaBrowser.Dlna.Profiles
{
    [XmlRoot("Profile")]
    public class DefaultProfile : DeviceProfile
    {
        public DefaultProfile()
        {
            Name = "Generic Device";

            ProtocolInfo = "DLNA";

            FriendlyName = "Media Browser";
            Manufacturer = "Media Browser";
            ModelDescription = "Media Browser";
            ModelName = "Media Browser";
            ModelNumber = "Media Browser";
            ModelUrl = "http://mediabrowser3.com/";
            ManufacturerUrl = "http://mediabrowser3.com/";

            TranscodingProfiles = new[]
            {
                new TranscodingProfile
                {
                    Container = "mp3",
                    AudioCodec = "mp3",
                    Type = DlnaProfileType.Audio
                },

                new TranscodingProfile
                {
                    Container = "mp4",
                    Type = DlnaProfileType.Video,
                    AudioCodec = "aac",
                    VideoCodec = "h264",
                    VideoProfile= "baseline"
                }
            };

            DirectPlayProfiles = new[]
            {
                new DirectPlayProfile
                {
                    Container = "mp3,wma",
                    Type = DlnaProfileType.Audio
                },

                new DirectPlayProfile
                {
                    Container = "avi,mp4",
                    Type = DlnaProfileType.Video
                }
            };
        }
    }
}
