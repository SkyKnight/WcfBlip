using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.ServiceModel.Channels;

namespace WcfBlip
{
    public class Blip : IDisposable
    {
        private string user;
        private string password;
        private IBlipApi api;
        private WebChannelFactory<IBlipApi> channelFactory;
        private OperationContextScope context;

        #region properties
        public string User
        {
            get
            {
                return user;
            }
        }

        public IBlipApi Api
        {
            get
            {
                if (context == null)
                {
                    context = new OperationContextScope((IContextChannel)api);
                    PrepareHeaders();
                }
                return api;
            }
        }
        #endregion

        #region constans
        public const string DateFormat = "yyyy'-'MM'-'dd HH':'mm':'ss";
        public const string BlipApiUrl = "http://api.blip.pl";
        #endregion

        public Blip(string user, string password)
        {
            this.user = user;
            this.password = password;
            channelFactory = new WebChannelFactory<IBlipApi>(GetBinding(), new Uri(BlipApiUrl));
            api = channelFactory.CreateChannel();
        }

        public void Dispose()
        {
            context.Dispose();
            context = null;
        }

        private void PrepareHeaders()
        {
            WebOperationContext.Current.OutgoingRequest.Accept = "application/json";
            WebOperationContext.Current.OutgoingRequest.Headers.Add("X-Blip-API", "0.02");
            WebOperationContext.Current.OutgoingRequest.UserAgent = "WcfBlip";
            WebOperationContext.Current.OutgoingRequest.Headers.Add("Authorization", string.Format("Basic {0}",
                EncodeTo64(string.Format("{0}:{1}", user, password))));
        }

        private Binding GetBinding()
        {
            CustomBinding binding = new CustomBinding(new WebHttpBinding());
            WebMessageEncodingBindingElement element = binding.Elements.Find<WebMessageEncodingBindingElement>();
            element.ContentTypeMapper = new BlipMapper();
            return binding;
        }

        private string EncodeTo64(string toEncode)
        {
            byte[] toEncodeAsBytes = ASCIIEncoding.ASCII.GetBytes(toEncode);
            string returnValue = Convert.ToBase64String(toEncodeAsBytes);
            return returnValue;
        }
    } // Blip

    internal class BlipMapper : WebContentTypeMapper
    {
        public override WebContentFormat GetMessageFormatForContentType(string contentType)
        {
            return WebContentFormat.Json;
        }
    } // BlipMapper
}
