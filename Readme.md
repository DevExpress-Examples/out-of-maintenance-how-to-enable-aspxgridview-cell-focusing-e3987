<!-- default file list -->
*Files to look at*:

* [LinkDataItemTemplate.cs](./CS/WebSite/App_Code/LinkDataItemTemplate.cs) (VB: [LinkDataItemTemplate.vb](./VB/WebSite/App_Code/LinkDataItemTemplate.vb))
* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# How to enable ASPxGridView cell focusing


<p>This example demonstrates how you can enable ASPxGridView cell focusing, and how to change a focused cell by arrow keys.</p><br />
<p>To implement this functionality it is necessary to use the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewGridViewDataColumn_DataItemTemplatetopic"><u>GridViewDataColumn.DataItemTemplate</u></a> to render GridView cells as <a> tag hyperlinks. To enable changing of focus via arrow keys  I have handled a  hyperlink's <a href="http://www.w3schools.com/jsref/event_onkeydown.asp"><u>onkeydown</u></a> event.</p>

<br/>


