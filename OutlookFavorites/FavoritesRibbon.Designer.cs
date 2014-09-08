namespace OutlookFavorites
{
    partial class FavoritesRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public FavoritesRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Favorites = this.Factory.CreateRibbonTab();
            this.FavoritesGroup = this.Factory.CreateRibbonGroup();
            this.toggleButton1 = this.Factory.CreateRibbonToggleButton();
            this.UserDropDown = this.Factory.CreateRibbonDropDown();
            this.Favorites.SuspendLayout();
            this.FavoritesGroup.SuspendLayout();
            // 
            // Favorites
            // 
            this.Favorites.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.Favorites.ControlId.OfficeId = "TabMail";
            this.Favorites.Groups.Add(this.FavoritesGroup);
            this.Favorites.Label = "TabMail";
            this.Favorites.Name = "Favorites";
            // 
            // FavoritesGroup
            // 
            this.FavoritesGroup.Items.Add(this.toggleButton1);
            this.FavoritesGroup.Items.Add(this.UserDropDown);
            this.FavoritesGroup.Label = "Favorites";
            this.FavoritesGroup.Name = "FavoritesGroup";
            this.FavoritesGroup.Position = this.Factory.RibbonPosition.BeforeOfficeId("Find");
            // 
            // toggleButton1
            // 
            this.toggleButton1.Label = "Show Favorites";
            this.toggleButton1.Name = "toggleButton1";
            this.toggleButton1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.toggleButton1_Click);
            // 
            // UserDropDown
            // 
            this.UserDropDown.Label = "User";
            this.UserDropDown.Name = "UserDropDown";
            this.UserDropDown.SelectionChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.UserDropDown_SelectionChanged);
            // 
            // FavoritesRibbon
            // 
            this.Name = "FavoritesRibbon";
            this.RibbonType = "Microsoft.Outlook.Explorer";
            this.Tabs.Add(this.Favorites);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.FavoritesRibbon_Load);
            this.Favorites.ResumeLayout(false);
            this.Favorites.PerformLayout();
            this.FavoritesGroup.ResumeLayout(false);
            this.FavoritesGroup.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab Favorites;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup FavoritesGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton toggleButton1;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown UserDropDown;
    }

    partial class ThisRibbonCollection
    {
        internal FavoritesRibbon FavoritesRibbon
        {
            get { return this.GetRibbon<FavoritesRibbon>(); }
        }
    }
}
