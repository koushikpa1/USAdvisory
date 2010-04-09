using System;
using System.Collections;
using System.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using DStreet.USAdvisory.Business.UI.Portfolio;
using System.Collections.Generic;

public partial class VirtualPortfolios : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        AjaxControlToolkit.TabContainer container = (AjaxControlToolkit.TabContainer)TabContainer1;
        foreach (object obj in container.Controls)
        {
            if (obj is AjaxControlToolkit.TabPanel)
            {
                AjaxControlToolkit.TabPanel tabPanel = (AjaxControlToolkit.TabPanel)obj;
                foreach (object ctrl in tabPanel.Controls)
                {
                    if (ctrl is Control)
                    {
                        Control c = (Control)ctrl;
                        foreach (object innerCtrl in c.Controls)
                        {
                            if (innerCtrl is System.Web.UI.WebControls.GridView)
                            {
                                if (((GridView)innerCtrl).ID == "GridView_VirtualPortfolioOpen")
                                {
                                    //((GridView)innerCtrl).PageSize = Convert.ToInt32(count);
                                    VirtualPortfolio vp = new VirtualPortfolio();
                                    List<VirtualPortfolio> list = vp.GetAllPortfolio("o");
                                    ((GridView)innerCtrl).DataSource = list;
                                    ((GridView)innerCtrl).DataBind();
                                }
                                else
                                {
                                    VirtualPortfolio vp1 = new VirtualPortfolio();
                                    List<VirtualPortfolio> list1 = vp1.GetAllPortfolio("c");
                                    ((GridView)innerCtrl).DataSource = list1;
                                    ((GridView)innerCtrl).DataBind();
                                }
                            }
                        }
                    }
                }
            }
        }
        //GridView_VirtualPortfolio.DataSource = list;
        //GridView_VirtualPortfolio.DataBind();
    }
   
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

        AjaxControlToolkit.TabContainer container = (AjaxControlToolkit.TabContainer)TabContainer1;
        foreach (object obj in container.Controls)
        {
            if (obj is AjaxControlToolkit.TabPanel)
            {
                AjaxControlToolkit.TabPanel tabPanel = (AjaxControlToolkit.TabPanel)obj;
                foreach (object ctrl in tabPanel.Controls)
                {
                    if (ctrl is Control)
                    {
                        Control c = (Control)ctrl;
                        foreach (object innerCtrl in c.Controls)
                        {
                            if (innerCtrl is System.Web.UI.WebControls.GridView)
                            {
                                if (((GridView)innerCtrl).ID == "GridView_VirtualPortfolioOpen")
                                {
                                   ((GridView)innerCtrl).PageSize = Convert.ToInt32(DropDownList1.SelectedValue);
                                    ((GridView)innerCtrl).DataBind();
                                }

                            }
                        }
                    }
                }
            }
        }
    }

    protected void GridView_VirtualPortfolioOpen_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView_VirtualPortfolioOpen.PageIndex = e.NewPageIndex;
        GridView_VirtualPortfolioOpen.DataBind();
    }

    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        AjaxControlToolkit.TabContainer container = (AjaxControlToolkit.TabContainer)TabContainer1;
        foreach (object obj in container.Controls)
        {
            if (obj is AjaxControlToolkit.TabPanel)
            {
                AjaxControlToolkit.TabPanel tabPanel = (AjaxControlToolkit.TabPanel)obj;
                foreach (object ctrl in tabPanel.Controls)
                {
                    if (ctrl is Control)
                    {
                        Control c = (Control)ctrl;
                        foreach (object innerCtrl in c.Controls)
                        {
                            if (innerCtrl is System.Web.UI.WebControls.GridView)
                            {
                                if (((GridView)innerCtrl).ID == "GridView_VirtualPortfolioClosed")
                                {
                                    ((GridView)innerCtrl).PageSize = Convert.ToInt32(DropDownList2.SelectedValue);
                                    ((GridView)innerCtrl).DataBind();
                                }

                            }
                        }
                    }
                }
            }
        }
    }

    protected void GridView_VirtualPortfolioClosed_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView_VirtualPortfolioClosed.PageIndex = e.NewPageIndex;
        GridView_VirtualPortfolioClosed.DataBind();

    }
}
