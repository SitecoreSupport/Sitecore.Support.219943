namespace Sitecore.Support.Modules.EmailCampaign.Core.Pipelines.GenerateLink.Hyperlink
{
    using Sitecore.Modules.EmailCampaign.Core.Crypto;
    using Sitecore.Modules.EmailCampaign.Core.Pipelines.GenerateLink;
    using System.Net;
    using OriginEncryptQueryString = Sitecore.Modules.EmailCampaign.Core.Pipelines.GenerateLink.Hyperlink.EncryptQueryString;

    public class EncryptQueryString : OriginEncryptQueryString
    {
        public EncryptQueryString(QueryStringEncryption queryStringEncryption)
            : base(queryStringEncryption)
        {
        }

        public override void Process(GenerateLinkPipelineArgs args)
        {
            if (args.PreviewMode)
            {

                args.GeneratedUrl = WebUtility.HtmlDecode(args.GeneratedUrl);

            }
            else
            {
                base.Process(args);
            }
        }
    }
}