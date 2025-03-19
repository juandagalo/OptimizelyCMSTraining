using AlloyTraining.Models.Blocks; // TeaserBlock
using AlloyTraining.Models.ViewModels; // TeaserBlockViewModel
using EPiServer.Web.Mvc; // BlockComponent<T>
using Microsoft.AspNetCore.Mvc; // IViewComponentResult
using EPiServer.Framework.DataAnnotations;

namespace AlloyTraining.Components
{
    [TemplateDescriptor(Tags = new[] { SiteTags.Full }, AvailableWithoutTag = true)]
    public class TeaserBlockComponent : BlockComponent<TeaserBlock>
    {
        protected override IViewComponentResult InvokeComponent(TeaserBlock currentBlock)
        {
            TeaserBlockViewModel viewmodel = new()
            {
                CurrentBlock = currentBlock,
                TodaysVisitorCount = new Random().Next(300, 900)
            };
            return View(viewName:"full", model: viewmodel);
        }

    }

    [TemplateDescriptor(Tags = new[] { SiteTags.Wide })]
    public class TeaserBlockWideComponent : BlockComponent<TeaserBlock>
    {
        protected override IViewComponentResult InvokeComponent(TeaserBlock currentBlock)
        {
            TeaserBlockViewModel viewmodel = new()
            {
                CurrentBlock = currentBlock,
                TodaysVisitorCount = new Random().Next(300, 900)
            };
            return View(viewName: "wide", model: viewmodel);
        }
    }

    [TemplateDescriptor(Tags = new[] { SiteTags.Narrow })]
    public class TeaserBlockNarrowComponent : BlockComponent<TeaserBlock>
    {
        protected override IViewComponentResult InvokeComponent(TeaserBlock currentBlock)
        {
            TeaserBlockViewModel viewmodel = new()
            {
                CurrentBlock = currentBlock,
                TodaysVisitorCount = new Random().Next(300, 900)
            };
            return View(viewName: "narrow", model: viewmodel);
        }
    }
}