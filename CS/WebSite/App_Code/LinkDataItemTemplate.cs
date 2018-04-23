using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using DevExpress.Web.ASPxGridView;
using DevExpress.Web.ASPxEditors;
using System.Web.UI.WebControls;

public class LinkDataItemTemplate : ITemplate {
    Control fContainer;

    public LinkDataItemTemplate() {
    }

    GridViewDataItemTemplateContainer Container {
        get { return fContainer as GridViewDataItemTemplateContainer; }
    }

    Control CreateHyperLink() {
        object value = DataBinder.Eval(Container.DataItem, Container.Column.FieldName);
        return new LiteralControl(String.Format("<a id='{1}Alink_{2}_{3}' href='javascript:' onkeydown='LinkKeyPressed(this, event)' style='color: Black; text-decoration: none'>{0}</a>", value, Container.Grid.ID, Container.VisibleIndex, Container.Column.VisibleIndex));
    }

    protected virtual void CreateControls() {
        Container.Controls.Add(CreateHyperLink());
    }

    #region ITemplate Members

    public void InstantiateIn(Control container) {
        fContainer = container;
        CreateControls();
    }

    #endregion
}
