using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace WcfBlip
{
    [ServiceContract]
    public interface IBlipApi
    {
        #region updates
        [OperationContract]
        [WebGet(UriTemplate = "/updates/{id}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update GetUpdate(string id);

        [OperationContract(Name="updates")]
        [WebGet(UriTemplate = "/updates", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetUpdates();

        [OperationContract(Name = "updatesLimit")]
        [WebGet(UriTemplate = "/updates?limit={limit}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetUpdates(string limit);

        [OperationContract(Name = "updatesLimitOffset")]
        [WebGet(UriTemplate = "/updates?limit={limit}&offset={offset}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetUpdates(string limit, string offset);

        [OperationContract(Name = "updatesSince")]
        [WebGet(UriTemplate = "/updates/{id}/since", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetUpdatesSince(string id);

        [OperationContract(Name = "updatesSinceLimit")]
        [WebGet(UriTemplate = "/updates/{id}/since?limit={limit}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetUpdatesSince(string id, string limit);

        [OperationContract(Name = "updatesSinceLimitOffset")]
        [WebGet(UriTemplate = "/updates/{id}/since?limit={limit}&offset={offset}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetUpdatesSince(string id, string limit, string offset);

        [OperationContract(Name = "updatesAll")]
        [WebGet(UriTemplate = "/updates/all", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetAllUpdates();

        [OperationContract(Name = "updatesAllLimit")]
        [WebGet(UriTemplate = "/updates/all?limit={limit}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetAllUpdates(string limit);

        [OperationContract(Name = "updatesAllLimitOffset")]
        [WebGet(UriTemplate = "/updates/all?limit={limit}&offset={offset}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetAllUpdates(string limit, string offset);

        [OperationContract(Name = "updatesAllSince")]
        [WebGet(UriTemplate = "/updates/{id}/all_since", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetAllUpdatesSince(string id);

        [OperationContract(Name = "updatesUser")]
        [WebGet(UriTemplate = "/users/{user}/updates", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetUserUpdates(string user);

        [OperationContract(Name = "updatesUserLimit")]
        [WebGet(UriTemplate = "/users/{user}/updates?limit={limit}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetUserUpdates(string user, string limit);

        [OperationContract(Name = "updatesUserLimitOffset")]
        [WebGet(UriTemplate = "/users/{user}/updates?limit={limit}&offset={offset}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetUserUpdates(string user, string limit, string offset);

        [OperationContract(Name = "updatesUserSince")]
        [WebGet(UriTemplate = "/users/{user}/updates/{id}/since", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetUserUpdatesSince(string user, string id);

        [OperationContract]
        [WebInvoke(UriTemplate = "/updates?update[body]={body}", Method = "POST", BodyStyle = WebMessageBodyStyle.Bare)]
        void CreateUpdate(string body);

        [OperationContract]
        [WebInvoke(UriTemplate = "/updates/{id}", Method="DELETE", BodyStyle=WebMessageBodyStyle.Bare)]
        void RemoveUpdate(string id);

        [OperationContract()]
        [WebGet(UriTemplate = "/updates/{updateId}/movie", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Movie GetMovie(string updateId);

        [OperationContract()]
        [WebGet(UriTemplate = "/updates/{updateId}/recording", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Movie GetRecording(string updateId);

        [OperationContract()]
        [WebGet(UriTemplate = "/updates/{updateId}/pictures", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Picture[] GetPictures(string updateId);
        #endregion

        #region directed_message
        [OperationContract]
        [WebGet(UriTemplate = "/directed_messages/{id}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update GetDirectedMessage(string id);

        [OperationContract(Name = "directed_messages")]
        [WebGet(UriTemplate = "/directed_messages", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetDirectedMessages();

        [OperationContract(Name = "directed_messagesLimit")]
        [WebGet(UriTemplate = "/directed_messages?limit={limit}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetDirectedMessages(string limit);

        [OperationContract(Name = "directed_messagesLimitOffset")]
        [WebGet(UriTemplate = "/directed_messages?limit={limit}&offset={offset}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetDirectedMessages(string limit, string offset);

        [OperationContract(Name = "directed_messagesSince")]
        [WebGet(UriTemplate = "/directed_messages/{id}/since", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetDirectedMessagesSince(string id);

        [OperationContract(Name = "directed_messagesSinceLimit")]
        [WebGet(UriTemplate = "/directed_messages/{id}/since?limit={limit}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetDirectedMessagesSince(string id, string limit);

        [OperationContract(Name = "directed_messagesSinceLimitOffset")]
        [WebGet(UriTemplate = "/directed_messages/{id}/since?limit={limit}&offset={offset}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetDirectedMessagesSince(string id, string limit, string offset);

        [OperationContract(Name = "directed_messagesAll")]
        [WebGet(UriTemplate = "/directed_messages/all", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetAllDirectedMessages();

        [OperationContract(Name = "directed_messagesAllLimit")]
        [WebGet(UriTemplate = "/directed_messages/all?limit={limit}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetAllDirectedMessages(string limit);

        [OperationContract(Name = "directed_messagesAllLimitOffset")]
        [WebGet(UriTemplate = "/directed_messages/all?limit={limit}&offset={offset}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetAllDirectedMessages(string limit, string offset);

        [OperationContract(Name = "directed_messagesAllSince")]
        [WebGet(UriTemplate = "/directed_messages/{id}/all_since", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetAllDirectedMessagesSince(string id);

        [OperationContract(Name = "directed_messagesUser")]
        [WebGet(UriTemplate = "/users/{user}/directed_messages", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetUserDirectedMessages(string user);

        [OperationContract(Name = "directed_messagesUserLimit")]
        [WebGet(UriTemplate = "/users/{user}/directed_messages?limit={limit}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetUserDirectedMessages(string user, string limit);

        [OperationContract(Name = "directed_messagesUserLimitOffset")]
        [WebGet(UriTemplate = "/users/{user}/directed_messages?limit={limit}&offset={offset}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetUserDirectedMessages(string user, string limit, string offset);

        [OperationContract(Name = "directed_messagesUserSince")]
        [WebGet(UriTemplate = "/users/{user}/directed_messages/{id}/since", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetUserDirectedMessagesSince(string user, string id);

        [OperationContract]
        [WebInvoke(UriTemplate = "/directed_messages?directed_message[body]={body}&directed_message[recipient]={recipient}", Method = "POST", BodyStyle = WebMessageBodyStyle.Bare)]
        void CreateDirectedMessage(string recipient, string body);

        [OperationContract]
        [WebInvoke(UriTemplate = "/directed_messages/{id}", Method = "DELETE", BodyStyle = WebMessageBodyStyle.Bare)]
        void RemoveDirectedMessage(string id);
        #endregion

        #region statuses
        [OperationContract]
        [WebGet(UriTemplate = "/statuses/{id}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update GetStatus(string id);

        [OperationContract(Name = "statuses")]
        [WebGet(UriTemplate = "/statuses", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetStatuses();

        [OperationContract(Name = "statusesLimit")]
        [WebGet(UriTemplate = "/statuses?limit={limit}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetStatuses(string limit);

        [OperationContract(Name = "statusesLimitOffset")]
        [WebGet(UriTemplate = "/statuses?limit={limit}&offset={offset}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetStatuses(string limit, string offset);

        [OperationContract(Name = "statusesSince")]
        [WebGet(UriTemplate = "/statuses/{id}/since", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetStatusesSince(string id);

        [OperationContract(Name = "statusesSinceLimit")]
        [WebGet(UriTemplate = "/statuses/{id}/since?limit={limit}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetStatusesSince(string id, string limit);

        [OperationContract(Name = "statusesSinceLimitOffset")]
        [WebGet(UriTemplate = "/statuses/{id}/since?limit={limit}&offset={offset}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetStatusesSince(string id, string limit, string offset);

        [OperationContract(Name = "statusesAll")]
        [WebGet(UriTemplate = "/statuses/all", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetAllStatuses();

        [OperationContract(Name = "statusesAllLimit")]
        [WebGet(UriTemplate = "/statuses/all?limit={limit}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetAllStatuses(string limit);

        [OperationContract(Name = "statusesAllLimitOffset")]
        [WebGet(UriTemplate = "/statuses/all?limit={limit}&offset={offset}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetAllStatuses(string limit, string offset);

        [OperationContract(Name = "statusesAllSince")]
        [WebGet(UriTemplate = "/statuses/{id}/all_since", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetAllStatusesSince(string id);

        [OperationContract(Name = "statusesUser")]
        [WebGet(UriTemplate = "/users/{user}/statuses", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetUserStatuses(string user);

        [OperationContract(Name = "statusesUserLimit")]
        [WebGet(UriTemplate = "/users/{user}/statuses?limit={limit}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetUserStatuses(string user, string limit);

        [OperationContract(Name = "statusesUserLimitOffset")]
        [WebGet(UriTemplate = "/users/{user}/statuses?limit={limit}&offset={offset}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetUserStatuses(string user, string limit, string offset);

        [OperationContract(Name = "statusesUserSince")]
        [WebGet(UriTemplate = "/users/{user}/statuses/{id}/since", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetUserStatusesSince(string user, string id);

        [OperationContract(Name = "statusesTags")]
        [WebGet(UriTemplate = "/tags/{tag}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetTaggedStatuses(string tag);

        [OperationContract(Name = "statusesTagsLimit")]
        [WebGet(UriTemplate = "/tags/{tag}?limit={limit}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetTaggedStatuses(string tag, string limit);

        [OperationContract(Name = "statusesTagsLimitOffset")]
        [WebGet(UriTemplate = "/tags/{tag}?limit={limit}&offset={offset}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetTaggedStatuses(string tag, string limit, string offset);

        [OperationContract(Name = "statusesTagsSince")]
        [WebGet(UriTemplate = "/tags/{tag}/since/{id}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetTaggedStatusesSince(string tag, string id);

        [OperationContract]
        [WebInvoke(UriTemplate = "/statuses?status[body]={body}", Method = "POST", BodyStyle = WebMessageBodyStyle.Bare)]
        void CreateStatus(string body);

        [OperationContract]
        [WebInvoke(UriTemplate = "/statuses/{id}", Method = "DELETE", BodyStyle = WebMessageBodyStyle.Bare)]
        void RemoveStatus(string id);
        #endregion

        #region private_messages
        [OperationContract]
        [WebGet(UriTemplate = "/private_messages/{id}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update GetPrivateMessage(string id);

        [OperationContract(Name = "private_messages")]
        [WebGet(UriTemplate = "/private_messages", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetPrivateMessages();

        [OperationContract(Name = "private_messagesLimit")]
        [WebGet(UriTemplate = "/private_messages?limit={limit}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetPrivateMessages(string limit);

        [OperationContract(Name = "private_messagesLimitOffset")]
        [WebGet(UriTemplate = "/private_messages?limit={limit}&offset={offset}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetPrivateMessages(string limit, string offset);

        [OperationContract(Name = "private_messagesSince")]
        [WebGet(UriTemplate = "/private_messages/{id}/since", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetPrivateMessagesSince(string id);

        [OperationContract(Name = "private_messagesSinceLimit")]
        [WebGet(UriTemplate = "/private_messages/{id}/since?limit={limit}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetPrivateMessagesSince(string id, string limit);

        [OperationContract(Name = "private_messagesSinceLimitOffset")]
        [WebGet(UriTemplate = "/private_messages/{id}/since?limit={limit}&offset={offset}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetPrivateMessagesSince(string id, string limit, string offset);

        [OperationContract]
        [WebInvoke(UriTemplate = "/private_messages?private_message[body]={body}&private_message[recipient]={recipient}", Method = "POST", BodyStyle = WebMessageBodyStyle.Bare)]
        void CreatePrivateMessage(string recipient, string body);

        [OperationContract]
        [WebInvoke(UriTemplate = "/private_messages/{id}", Method = "DELETE", BodyStyle = WebMessageBodyStyle.Bare)]
        void RemovePrivateMessage(string id);
        #endregion

        #region notices
        [OperationContract]
        [WebGet(UriTemplate = "/notices/{id}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update GetNotice(string id);

        [OperationContract(Name = "notices")]
        [WebGet(UriTemplate = "/notices", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetNotices();

        [OperationContract(Name = "noticesLimit")]
        [WebGet(UriTemplate = "/notices?limit={limit}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetNotices(string limit);

        [OperationContract(Name = "noticesLimitOffset")]
        [WebGet(UriTemplate = "/notices?limit={limit}&offset={offset}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetNotices(string limit, string offset);

        [OperationContract(Name = "noticesSince")]
        [WebGet(UriTemplate = "/notices/{id}/since", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetNoticesSince(string id);

        [OperationContract(Name = "noticesSinceLimit")]
        [WebGet(UriTemplate = "/notices/{id}/since?limit={limit}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetNoticesSince(string id, string limit);

        [OperationContract(Name = "noticesSinceLimitOffset")]
        [WebGet(UriTemplate = "/notices/{id}/since?limit={limit}&offset={offset}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetNoticesSince(string id, string limit, string offset);

        [OperationContract(Name = "noticesAll")]
        [WebGet(UriTemplate = "/notices/all", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetAllNotices();

        [OperationContract(Name = "noticesAllLimit")]
        [WebGet(UriTemplate = "/notices/all?limit={limit}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetAllNotices(string limit);

        [OperationContract(Name = "noticesAllLimitOffset")]
        [WebGet(UriTemplate = "/notices/all?limit={limit}&offset={offset}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetAllNotices(string limit, string offset);

        [OperationContract(Name = "noticesAllSince")]
        [WebGet(UriTemplate = "/notices/{id}/all_since", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetAllNoticesSince(string id);

        [OperationContract(Name = "noticesUser")]
        [WebGet(UriTemplate = "/users/{user}/notices", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetUserNotices(string user);

        [OperationContract(Name = "noticesUserLimit")]
        [WebGet(UriTemplate = "/users/{user}/notices?limit={limit}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetUserNotices(string user, string limit);

        [OperationContract(Name = "noticesUserLimitOffset")]
        [WebGet(UriTemplate = "/users/{user}/notices?limit={limit}&offset={offset}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetUserNotices(string user, string limit, string offset);

        [OperationContract(Name = "noticesUserSince")]
        [WebGet(UriTemplate = "/users/{user}/notices/{id}/since", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetUserNoticesSince(string user, string id);

        [OperationContract]
        [WebInvoke(UriTemplate = "/notices/{id}", Method = "DELETE", BodyStyle = WebMessageBodyStyle.Bare)]
        void RemoveNotice(string id);
        #endregion

        #region pictures
        [OperationContract(Name = "picturesAll")]
        [WebGet(UriTemplate = "/pictures/all", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Picture[] GetAllPictures();

        [OperationContract(Name = "picturesAllLimit")]
        [WebGet(UriTemplate = "/pictures/all?limit={limit}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Picture[] GetAllPictures(string limit);

        [OperationContract(Name = "picturesAllLimitOffset")]
        [WebGet(UriTemplate = "/pictures/all?limit={limit}&offset={offset}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Picture[] GetAllPictures(string limit, string offset);

        [OperationContract(Name = "picturesAllSince")]
        [WebGet(UriTemplate = "/pictures/{id}/all_since", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Picture[] GetAllPicturesSince(string id);
        #endregion

        #region shortcuts
        [OperationContract(Name = "shortlinksAll")]
        [WebGet(UriTemplate = "/shortlinks/all", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Shortlink[] GetAllShortlinks();

        [OperationContract(Name = "shortlinksAllLimit")]
        [WebGet(UriTemplate = "/shortlinks/all?limit={limit}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Shortlink[] GetAllShortlinks(string limit);

        [OperationContract(Name = "shortlinksAllLimitOffset")]
        [WebGet(UriTemplate = "/shortlinks/all?limit={limit}&offset={offset}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Shortlink[] GetAllShortlinks(string limit, string offset);

        [OperationContract(Name = "shortlinksAllSince")]
        [WebGet(UriTemplate = "/shortlinks/{id}/all_since", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Shortlink[] GetAllShortlinksSince(string id);

        [OperationContract(Name = "createShortlinks")]
        [WebInvoke(UriTemplate = "/shortlinks?shortlink[original_link]={original_link}", Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Shortlink CreateShortlink(string original_link);
        #endregion

        #region dashboard
        [OperationContract(Name="dashboard")]
        [WebGet(UriTemplate = "/dashboard", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetDashboardUpdates();

        [OperationContract(Name = "dashboardSince")]
        [WebGet(UriTemplate = "/dashboard/since/{id}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetDashboardUpdatesSince(string id);

        [OperationContract(Name = "dashboardUser")]
        [WebGet(UriTemplate = "/users/{user}/dashboard", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetDashboardUpdates(string user);

        [OperationContract(Name = "dashboardUserSince")]
        [WebGet(UriTemplate = "/users/{user}/dashboard/since/{id}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetDashboardUpdatesSince(string user, string id);
        #endregion

        #region bliposphere
        [OperationContract(Name = "bliposphere")]
        [WebGet(UriTemplate = "/bliposphere", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Update[] GetBliposphereUpdates();
        #endregion

        #region user
        [OperationContract(Name = "user")]
        [WebGet(UriTemplate = "/users/{user}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        User GetUser(string user);

        [OperationContract(Name = "userAvatar")]
        [WebGet(UriTemplate = "/users/{user}/avatar", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Picture GetUserAvatar(string user);

        [OperationContract(Name = "userBackground")]
        [WebGet(UriTemplate = "/users/{user}/background", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Picture GetUserBackground(string user);
        #endregion

        #region subscriptions
        [OperationContract(Name = "subscriptions")]
        [WebGet(UriTemplate = "/subscriptions", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Subscription[] GetSubscriptions();

        [OperationContract(Name = "subscriptionsFrom")]
        [WebGet(UriTemplate = "/subscriptions/from", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Subscription[] GetSubscriptionsFrom();

        [OperationContract(Name = "subscriptionsTo")]
        [WebGet(UriTemplate = "/subscriptions/to", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Subscription[] GetSubscriptionsTo();

        [OperationContract(Name = "subscriptionsUser")]
        [WebGet(UriTemplate = "/users/{user}/subscriptions", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Subscription[] GetSubscriptions(string user);

        [OperationContract(Name = "subscriptionsUserFrom")]
        [WebGet(UriTemplate = "/users/{user}/subscriptions/from", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Subscription[] GetSubscriptionsFrom(string user);

        [OperationContract(Name = "subscriptionsUserTo")]
        [WebGet(UriTemplate = "/users/{user}/subscriptions/to", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Subscription[] GetSubscriptionsTo(string user);

        [OperationContract]
        [WebInvoke(UriTemplate = "/subscriptions/{user}", Method = "DELETE", BodyStyle = WebMessageBodyStyle.Bare)]
        void RemoveSubscription(string user);

        [OperationContract]
        [WebInvoke(UriTemplate = "/subscriptions/{user}?subscription[www]={www}&subscription[im]={im}", Method = "PUT", BodyStyle = WebMessageBodyStyle.Bare)]
        void UpdateSubscription(string user, string www, string im);
        #endregion
    }
}
