namespace TestMenuItemsWinUI
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            Shell.Current.ToolbarItems.Add(new()
            {
                Text = "Menu item 1",
                Order = ToolbarItemOrder.Secondary
            });
            Shell.Current.ToolbarItems.Add(new()
            {
                Text = "Menu item 2",
                Order = ToolbarItemOrder.Secondary
            });
            Shell.Current.ToolbarItems.Add(new()
            {
                Text = "Menu item 3",
                Order = ToolbarItemOrder.Secondary
            });
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
