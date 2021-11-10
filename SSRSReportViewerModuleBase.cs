/*
' Copyright (c) 2021 Gafware
'  All rights reserved.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' 
*/

using DotNetNuke.Entities.Modules;
using System;

namespace Gafware.Modules.SSRSReportViewer
{
    public class SSRSReportViewerModuleBase : PortalModuleBase
    {
        public string ReportServerUrl
        {
            get
            {
                if (Settings.Contains("ReportServerURL"))
                {
                    return Settings["ReportServerURL"].ToString();
                }
                return string.Empty;
            }
        }

        public System.Web.UI.WebControls.Unit ReportServerHeight
        {
            get
            {
                if (Settings.Contains("Height"))
                {
                    return new System.Web.UI.WebControls.Unit(string.Format("{0}px", Convert.ToInt32(Settings["Height"].ToString())));
                }
                return new System.Web.UI.WebControls.Unit("800px");
            }
        }
    }
}