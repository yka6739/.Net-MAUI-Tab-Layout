namespace MauiApp1
{
    public partial class AppShell : Shell
    {
        public string CopyrightText { get; }
        public AppShell()
        {
            InitializeComponent();
            // Set the current year and copy right text
            CopyrightText = $"© {DateTime.Now.Year} Yatendra Kumar Awana";

            // Binding context for the Shell
            this.BindingContext = this;
        }
    }
}
