namespace Sitecore.Support.Modules.EmailCampaign.Core.Pipelines.GenerateLink.Hyperlink
{
    using System.Web;

    using Diagnostics;
    using Sitecore.Modules.EmailCampaign.Core.Pipelines.GenerateLink;
    using Sitecore.Modules.EmailCampaign.Core.Pipelines.GenerateLink.Hyperlink;

    public class FixedGenerateHyperlink : GenerateHyperlink
    {
        public override void Process(GenerateLinkPipelineArgs args)
        {
            Assert.IsNotNull(args, "Arguments can't be null");
            Assert.IsNotNull(args.Url, "Url can't be null");

            #region FIX

            if (args.PreviewMode)
                args.GeneratedUrl = HttpUtility.HtmlDecode(args.Url);
            else
                base.Process(args);

            #endregion
        }
    }
}