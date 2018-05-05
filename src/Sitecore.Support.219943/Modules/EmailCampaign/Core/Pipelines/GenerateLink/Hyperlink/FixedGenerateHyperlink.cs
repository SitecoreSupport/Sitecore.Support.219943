namespace Sitecore.Support.Modules.EmailCampaign.Core.Pipelines.GenerateLink.Hyperlink
{
    using Diagnostics;
    using Sitecore.Modules.EmailCampaign.Core.Pipelines.GenerateLink;
    using Sitecore.Modules.EmailCampaign.Core.Pipelines.GenerateLink.Hyperlink;

    public class FixedGenerateHyperlink : GenerateHyperlink
    {
        public override void Process(GenerateLinkPipelineArgs args)
        {
            Assert.IsNotNull(args, "Arguments can't be null");
            Assert.IsNotNull(args.Url, "Url can't be null");
            base.Process(args);
        }
    }
}