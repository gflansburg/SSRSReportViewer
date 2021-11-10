/*
' Copyright (c) 2015 Christoc.com
'  All rights reserved.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' 
*/

using System.Collections.Generic;
using System.Configuration;
using System.Web.Configuration;
//using System.Xml;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Services.Search;

namespace Gafware.Modules.SSRSReportViewer.Components
{

    /// -----------------------------------------------------------------------------
    /// <summary>
    /// The Controller class for SSRSReportViewer
    /// 
    /// The FeatureController class is defined as the BusinessController in the manifest file (.dnn)
    /// DotNetNuke will poll this class to find out which Interfaces the class implements. 
    /// 
    /// The IPortable interface is used to import/export content from a DNN module
    /// 
    /// The ISearchable interface is used by DNN to index the content of a module
    /// 
    /// The IUpgradeable interface allows module developers to execute code during the upgrade 
    /// process for a module.
    /// 
    /// Below you will find stubbed out implementations of each, uncomment and populate with your own data
    /// </summary>
    /// -----------------------------------------------------------------------------

    //uncomment the interfaces to add the support.
    public class FeatureController : IUpgradeable
    {


        #region Optional Interfaces

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// ExportModule implements the IPortable ExportModule Interface
        /// </summary>
        /// <param name="ModuleID">The Id of the module to be exported</param>
        /// -----------------------------------------------------------------------------
        //public string ExportModule(int ModuleID)
        //{
        //string strXML = "";

        //List<SSRSReportViewerInfo> colSSRSReportViewers = GetSSRSReportViewers(ModuleID);
        //if (colSSRSReportViewers.Count != 0)
        //{
        //    strXML += "<SSRSReportViewers>";

        //    foreach (SSRSReportViewerInfo objSSRSReportViewer in colSSRSReportViewers)
        //    {
        //        strXML += "<SSRSReportViewer>";
        //        strXML += "<content>" + DotNetNuke.Common.Utilities.XmlUtils.XMLEncode(objSSRSReportViewer.Content) + "</content>";
        //        strXML += "</SSRSReportViewer>";
        //    }
        //    strXML += "</SSRSReportViewers>";
        //}

        //return strXML;

        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// ImportModule implements the IPortable ImportModule Interface
        /// </summary>
        /// <param name="ModuleID">The Id of the module to be imported</param>
        /// <param name="Content">The content to be imported</param>
        /// <param name="Version">The version of the module to be imported</param>
        /// <param name="UserId">The Id of the user performing the import</param>
        /// -----------------------------------------------------------------------------
        //public void ImportModule(int ModuleID, string Content, string Version, int UserID)
        //{
        //XmlNode xmlSSRSReportViewers = DotNetNuke.Common.Globals.GetContent(Content, "SSRSReportViewers");
        //foreach (XmlNode xmlSSRSReportViewer in xmlSSRSReportViewers.SelectNodes("SSRSReportViewer"))
        //{
        //    SSRSReportViewerInfo objSSRSReportViewer = new SSRSReportViewerInfo();
        //    objSSRSReportViewer.ModuleId = ModuleID;
        //    objSSRSReportViewer.Content = xmlSSRSReportViewer.SelectSingleNode("content").InnerText;
        //    objSSRSReportViewer.CreatedByUser = UserID;
        //    AddSSRSReportViewer(objSSRSReportViewer);
        //}

        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// GetSearchItems implements the ISearchable Interface
        /// </summary>
        /// <param name="ModInfo">The ModuleInfo for the module to be Indexed</param>
        /// -----------------------------------------------------------------------------
        //public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        //{
        //SearchItemInfoCollection SearchItemCollection = new SearchItemInfoCollection();

        //List<SSRSReportViewerInfo> colSSRSReportViewers = GetSSRSReportViewers(ModInfo.ModuleID);

        //foreach (SSRSReportViewerInfo objSSRSReportViewer in colSSRSReportViewers)
        //{
        //    SearchItemInfo SearchItem = new SearchItemInfo(ModInfo.ModuleTitle, objSSRSReportViewer.Content, objSSRSReportViewer.CreatedByUser, objSSRSReportViewer.CreatedDate, ModInfo.ModuleID, objSSRSReportViewer.ItemId.ToString(), objSSRSReportViewer.Content, "ItemId=" + objSSRSReportViewer.ItemId.ToString());
        //    SearchItemCollection.Add(SearchItem);
        //}

        //return SearchItemCollection;

        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// UpgradeModule implements the IUpgradeable Interface
        /// </summary>
        /// <param name="Version">The current version of the module</param>
        /// -----------------------------------------------------------------------------
        public string UpgradeModule(string Version)
        {
            Configuration config = WebConfigurationManager.OpenWebConfiguration("~");
            HttpHandlersSection section = (HttpHandlersSection)config.GetSection("system.web/httpHandlers");
            foreach(HttpHandlerAction handler in section.Handlers)
            {
                if(handler.Path.Equals("Reserved.ReportViewerWebControl.axd"))
                {
                    return Version;
                }
            }
            section.Handlers.Add(new HttpHandlerAction("Reserved.ReportViewerWebControl.axd", "Microsoft.Reporting.WebForms.HttpHandler, Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91", "*"));
            config.Save();

            /*section = (HttpHandlersSection)config.GetSection("system.webServer/handlers");
            foreach (HttpHandlerAction handler in section.Handlers)
            {
                if (handler.Path.Equals("Reserved.ReportViewerWebControl.axd"))
                {
                    return Version;
                }
            }
            section.Handlers.Add(new HttpHandlerAction("Reserved.ReportViewerWebControl.axd", "Microsoft.Reporting.WebForms.HttpHandler, Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91", "*"));*/

            return Version;
        }

        #endregion
    }

}
