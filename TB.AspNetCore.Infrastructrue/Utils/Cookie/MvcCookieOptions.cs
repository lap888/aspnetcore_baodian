﻿using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.IO;
using System.Security.Principal;
using TB.AspNetCore.Domain.DataProtection;

namespace TB.AspNetCore.Infrastructrue.Utils.Cookie
{
    /// <summary>
    /// 分装MvcCookieOptions
    /// </summary>
    public class MvcCookieOptions
    {
        internal static readonly MvcCookieOptions Instance = new MvcCookieOptions();

        public string ReturnUrlParameter
        {
            get;
            set;
        } = "ReturnUrl";


        public PathString AccessDeniedPath
        {
            get;
            set;
        } = new PathString("/Account/AccessDenied");


        public PathString LogoutPath
        {
            get;
            set;
        } = new PathString("/Account/Logout");


        public PathString LoginPath
        {
            get;
            set;
        } = new PathString("/Account/Login");


        public string AuthenticationScheme
        {
            get;
            set;
        } = "NetCore";


        public bool GenerateKey
        {
            get;
            set;
        }

        public DirectoryInfo KeyDirectory
        {
            get;
            set;
        }

        public List<string> Schemes
        {
            get;
            set;
        } = new List<string>();


        public KeyPath KeyPath
        {
            get;
            set;
        } = KeyPath.System;

    }
}
