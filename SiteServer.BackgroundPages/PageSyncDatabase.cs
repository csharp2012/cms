﻿using System;
using System.Web.UI;
using SiteServer.CMS.Api;
using SiteServer.CMS.Api.Sys.Packaging;
using SiteServer.Utils;
using SiteServer.CMS.Core;

namespace SiteServer.BackgroundPages
{
    public class PageSyncDatabase : Page
    {
        public string UpdateDatabaseApiUrl => ApiRouteSyncDatabase.GetUrl(ApiManager.InnerApiUrl);

        public string AdminUrl => PageUtils.GetAdminDirectoryUrl(string.Empty);

        public void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            if (SystemManager.IsNeedInstall())
            {
                Page.Response.Write("系统未安装，向导被禁用！");
                Page.Response.End();
            }
        }
    }
}
