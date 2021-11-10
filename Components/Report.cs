using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using DotNetNuke.Common.Utilities;
using DotNetNuke.Entities.Content;

namespace Gafware.Modules.SSRSReportViewer.Components
{
    public class Report : ContentItem
    {
        /// <summary>
        /// Report name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Path to report
        /// </summary>
        public string Path { get; set; }

        public override void Fill(IDataReader dr)
        {
            //base.Fill(dr);

            Name = Null.SetNullString(dr["Name"]);
            Path = Null.SetNullString(dr["Path"]);
        }
    }
}