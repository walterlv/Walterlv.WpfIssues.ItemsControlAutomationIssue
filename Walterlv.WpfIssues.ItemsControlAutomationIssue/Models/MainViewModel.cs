namespace Walterlv.WpfIssues.ItemsControlAutomationIssue.Models;
public class MainViewModel
{
    public MainViewModel()
    {
        Items = new ObservableCollection<DemoItem>
        {
            new DemoItem { GroupName = "Group1", ItemName = "Item1" },
            new DemoItem { GroupName = "Group1", ItemName = "Item2" },
            new DemoItem { GroupName = "Group1", ItemName = "Item3" },
            new DemoItem { GroupName = "Group2", ItemName = "Item4" },
            new DemoItem { GroupName = "Group2", ItemName = "Item5" },
            new DemoItem { GroupName = "Group2", ItemName = "Item6" },
        };
    }

    public ObservableCollection<DemoItem> Items { get; }
}
