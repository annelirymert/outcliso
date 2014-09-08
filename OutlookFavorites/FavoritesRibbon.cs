using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Tools.Ribbon;
using Microsoft.SharePoint.Client;

namespace OutlookFavorites
{
    public partial class FavoritesRibbon
    {
        private void FavoritesRibbon_Load(object sender, RibbonUIEventArgs e)
        {
            LoadUsersComboBox();

        }

        private void LoadUsersComboBox()
        {
            using (var context = new ClientContext(Constants.HostUri))
            {
                context.Credentials = new SharePointOnlineCredentials(Constants.UserName, Constants.Password);
                context.Load(context.Web.AssociatedMemberGroup.Users);
                context.ExecuteQuery();
                foreach (var user in context.Web.AssociatedMemberGroup.Users)
                {
                    var userItem = Globals.Factory.GetRibbonFactory().CreateRibbonDropDownItem();
                    userItem.Label = user.Title;
                    UserDropDown.Items.Add(userItem);
                }
            }
        }

        private void toggleButton1_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.FavoritesPane.Visible = ((RibbonToggleButton)sender).Checked;
        }

        private void UserDropDown_SelectionChanged(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.FavoritesControl.ClearRecordsTreeView();
            Globals.ThisAddIn.FavoritesControl.ClearFavoritesTreeView();
            using (var context = new ClientContext(Constants.HostUri))
            {
                context.Credentials = new SharePointOnlineCredentials(Constants.UserName, Constants.Password); 
                var selectedUserName = (sender as RibbonDropDown).SelectedItem.Label;
                var favoritesControl = Globals.ThisAddIn.FavoritesControl;
                
                var recordsLibrary = context.Web.Lists.GetByTitle("Legal Records");
                var records = recordsLibrary.RootFolder.Folders;
                context.Load(records);
                context.ExecuteQuery();
                foreach (Folder subFolder in records)
                {
                    if (subFolder.Name == "Forms") continue;
                    var newNode = new TreeNode(subFolder.Name);
                    favoritesControl.AddRecordsNode(newNode);
                    FillTreeViewNodes(subFolder, newNode, context);
                }

                var favoritesLibrary = context.Web.Lists.GetByTitle("Favorites");
                var favorites = favoritesLibrary.RootFolder.Folders;
                context.Load(favorites);
                context.ExecuteQuery();
                Folder usersFavoritesRootFolder = null;
                foreach (Folder favoriteFolder in favorites)
                {
                    if (favoriteFolder.Name == selectedUserName)
                    {
                        usersFavoritesRootFolder = favoriteFolder;
                        break;
                    }
                }
                if (usersFavoritesRootFolder == null) return;
                context.Load(usersFavoritesRootFolder.Folders);
                context.ExecuteQuery();
                foreach (Folder subFolder in usersFavoritesRootFolder.Folders)
                {
                    if (subFolder.Name == "Forms") continue;
                    var newNode = new TreeNode(subFolder.Name);
                    favoritesControl.AddFavoritesNode(newNode);
                    FillTreeViewNodes(subFolder, newNode, context);
                }
            }
        }
        private void FillTreeViewNodes(Folder subFolder, TreeNode currentNode, ClientContext context)
        {
            context.Load(subFolder.Folders);
            context.ExecuteQuery();
            foreach (Folder folder in subFolder.Folders)
            {
                TreeNode subNode = new TreeNode(folder.Name);
                currentNode.Nodes.Add(subNode);
                FillTreeViewNodes(folder, subNode, context);
            }
        }
    }
}
