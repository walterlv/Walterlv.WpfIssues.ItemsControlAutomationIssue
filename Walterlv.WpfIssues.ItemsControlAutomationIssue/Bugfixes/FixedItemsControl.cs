using System.Windows.Automation.Peers;
using System.Windows.Controls;

namespace Walterlv.WpfIssues.ItemsControlAutomationIssue.Bugfixes;

public class FixedItemsControl : ItemsControl
{
    protected override AutomationPeer OnCreateAutomationPeer()
    {
        return new ItemsControlWrapperAutomationPeer(this);
    }

    private sealed class ItemsControlWrapperAutomationPeer : ItemsControlAutomationPeer
    {
        public ItemsControlWrapperAutomationPeer(ItemsControl owner) : base(owner)
        {
        }

        protected override ItemAutomationPeer CreateItemAutomationPeer(object item)
        {
            return new ItemsControlItemAutomationPeer(item, this);
        }

        protected override string GetClassNameCore()
        {
            return "ItemsControl";
        }

        protected override AutomationControlType GetAutomationControlTypeCore()
        {
            return AutomationControlType.List;
        }
    }

    private class ItemsControlItemAutomationPeer : ItemAutomationPeer
    {
        public ItemsControlItemAutomationPeer(object item, ItemsControlWrapperAutomationPeer parent)
            : base(item, parent)
        { }

        protected override AutomationControlType GetAutomationControlTypeCore()
        {
            return AutomationControlType.DataItem;
        }

        protected override string GetClassNameCore()
        {
            return "ItemsControlItem";
        }
    }
}
