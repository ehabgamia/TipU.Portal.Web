﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MCV.Portal.Web.Areas.App.Models.Layout;
using MCV.Portal.Web.Session;
using MCV.Portal.Web.Views;

namespace MCV.Portal.Web.Areas.App.Views.Shared.Themes.Theme4.Components.AppTheme4Brand
{
    public class AppTheme4BrandViewComponent : PortalViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppTheme4BrandViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var headerModel = new HeaderViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(headerModel);
        }
    }
}
