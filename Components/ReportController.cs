using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using DotNetNuke.Common.Utilities;
using Gafware.Modules.SSRSReportViewer.Data;

namespace Gafware.Modules.SSRSReportViewer.Components
{
    public class ReportController
    {
        public static List<Report> GetReports()
        {
            return CBO.FillCollection<Report>(DataProvider.Instance().GetReports());
        }
    }
}