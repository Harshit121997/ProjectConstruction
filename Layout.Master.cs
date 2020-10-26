using System;
using System.Data;
using System.IO;
using System.Web.UI.WebControls;

namespace ProjectConstruction
{
    public partial class Layout : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //GetMenu getMenu = new GetMenu();
                //DataTable dataTable = getMenu.GetMenus(0);
                //PopulateMenu(dataTable, 0, null);
            }
        }

        private void PopulateMenu(DataTable dt, int parentMenuId, MenuItem parentMenuItem)
        {
            string currentPage = Path.GetFileName(Request.Url.AbsolutePath);
            foreach (DataRow row in dt.Rows)
            {
                MenuItem menuItem = new MenuItem
                {
                    Value = row["MenuId"].ToString(),
                    Text = row["MenuName"].ToString(),
                    NavigateUrl = row["Url"].ToString(),
                    Selected = row["Url"].ToString().EndsWith(currentPage, StringComparison.CurrentCultureIgnoreCase)
                };
                if (parentMenuId == 0)
                {
                    GetMenu getMenu = new GetMenu();
                    //Menu1.Items.Add(menuItem);
                    DataTable dtChild = getMenu.GetMenus(int.Parse(menuItem.Value));
                    PopulateMenu(dtChild, int.Parse(menuItem.Value), menuItem);
                }
                else
                {
                    parentMenuItem.ChildItems.Add(menuItem);
                }
            }
        }

    }
}
