using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace WcfBlip
{
    [DataContract]
    public class Transport
    {
        [DataMember(Name="id")]
        public int Id { get; set; }
        [DataMember(Name="name")]
        public string Name { get; set; }
    } // Transport

    [DataContract]
    public class Update
    {
        [DataMember(Name="id")]
        public int Id { get; set; }

        private DateTime createdAt;

        /// <summary>
        /// Datetime formated for Blip
        /// </summary>
        [DataMember(Name="created_at")]
        public string CreatedAtAsString { 
            get
            {
                return createdAt.ToString(Blip.DateFormat);   
            } set
            {
                createdAt = DateTime.Parse(value);
            } 
        }

        public DateTime CreatedAt
        {
            get
            {
                return createdAt;
            }
            set
            {
                createdAt = value;
            }
        }

        [DataMember(Name="transport")]
        public Transport Transport { get; set; }

        [DataMember(Name="body")]
        public string Body { get; set; }

        private UpdateTypes type;
        [DataMember(Name = "type")]
        public string TypeAsString {
            get
            {
                return type.ToString();
            }
            set
            {
                type = (UpdateTypes)Enum.Parse(typeof(UpdateTypes), value);   
            }
        }
        public UpdateTypes Type { 
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        [DataMember(Name="user_path")]
        public string UserPath { get; set; }

        /// <summary>
        /// Name of user from parsing UserPath
        /// </summary>
        public string User
        {
            get { return this.UserPath.Substring(this.UserPath.LastIndexOf('/') + 1); }
        }


        [DataMember(Name="recipient_path")]
        public string RecipientPath { get; set; }

        [DataMember(Name="pictures_path")]
        public string PicturesPath { get; set; }

        [DataMember(Name="recording_path")]
        public string RecordingPath { get; set; }

        [DataMember(Name="movie_path")]
        public string MoviePath { get; set; }
    } // Update

    public enum UpdateTypes
    {
        Status,
        DirectedMessage,
        PrivateMessage,
        Notice
    } // UpdateTypes

    [DataContract]
    public class User
    {
        [DataMember(Name="id")]
        public int Id { get; set; }

        [DataMember(Name="login")]
        public string Login { get; set; }

        [DataMember(Name="background_path")]
        public string BackgroundPath { get; set; }

        [DataMember(Name="avatar_path")]
        public string AvatarPath { get; set; }

        [DataMember(Name="current_status_path")]
        public string CurrentStatusPath { get; set; }
    }

    [DataContract]
    public class Movie
    {
        [DataMember(Name="id")]
        public int Id { get; set; }

        [DataMember(Name="url")]
        public string Url { get; set; }
    }

    [DataContract]
    public class Recording
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "url")]
        public string Url { get; set; }
    }

    [DataContract]
    public class Picture
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "url")]
        public string Url { get; set; }

        [DataMember(Name="update_path")]
        public string UpdatePath { get; set; }
    }

    [DataContract]
    public class Shortlink
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        private DateTime createdAt;
        /// <summary>
        /// Datetime formated for Blip
        /// </summary>
        [DataMember(Name = "created_at")]
        public string CreatedAtAsString
        {
            get
            {
                return createdAt.ToString(Blip.DateFormat);
            }
            set
            {
                createdAt = DateTime.Parse(value);
            }
        }

        public DateTime CreatedAt
        {
            get
            {
                return createdAt;
            }
            set
            {
                createdAt = value;
            }
        }

        [DataMember(Name="hit_count")]
        public int HitCount { get; set; }

        [DataMember(Name="original_link")]
        public string OriginalLink { get; set; }

        [DataMember(Name="shortcode")]
        public string Shortcode { get; set; }

        /// <summary>
        /// Holds shorten link
        /// </summary>
        [DataMember(Name = "url")]
        public string URL { get; set; }
    }

    [DataContract]
    public class Subscription
    {
        [DataMember(Name="tracked_user_path")]
        public string TrackedUserPath { get; set; }

        [DataMember(Name="tracking_user_path")]
        public string TrackingUserPath { get; set; }

        [DataMember(Name="transport")]
        public Transport Transport { get; set; }
    }
}