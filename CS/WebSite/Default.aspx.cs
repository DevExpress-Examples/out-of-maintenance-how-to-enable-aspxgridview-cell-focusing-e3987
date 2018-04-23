using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxGridView;
using System.Data;

public partial class _Default : System.Web.UI.Page
{

    protected void gvData_DataBound(object sender, EventArgs e) {
        ASPxGridView gridView = sender as ASPxGridView;

        foreach(GridViewDataColumn column in gridView.Columns) {
            column.DataItemTemplate = new LinkDataItemTemplate();
        }
    }
}
