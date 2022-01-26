using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using ApiMenu.Data;
using ITSolution.Framework.Core.BaseClasses;
using ITSolution.Framework.Core.CustomUserAPI.Data;
using ITSolution.Framework.Server.Core.BaseClasses.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace ITE.WebClient.Pages.Shared
{
    public class MenuService
    {
        public MenuService()
        {

        }

        static List<ItsMenu> _Menus;
        public static List<ItsMenu> Menus
        {
            get
            {
                if (_Menus == null)
                    _Menus = new DBAccessContext(new ITSolution.Framework.Core.Server.BaseClasses.Repository.ItsDbContextOptions()).MenuRep.GetAll().ToList();

                return _Menus;
            }
        }

        public async static Task GetMenusApi(string url)
        {
             using (HttpClient httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(url))
                {
                    var apiResponse = await response.Content.ReadAsStringAsync();
                    _Menus = JsonConvert.DeserializeObject<List<ItsMenu>>(apiResponse);
                }
            }
        }
    }
}