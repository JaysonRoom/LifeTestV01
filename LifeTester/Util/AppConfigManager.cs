﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace LifeTester.Util
{
    /// <summary>
    /// 配置文件读取类
    /// </summary>
    public class AppConfigManager
    {
        private XmlDocument Doc = new XmlDocument();
        private AppDomain Ad = AppDomain.CurrentDomain;
        public AppConfigManager()
        {
            Doc.Load(Ad.SetupInformation.ConfigurationFile);
        }
        public void LoadAppConfig()
        {
            Doc.Load(Ad.SetupInformation.ConfigurationFile);
        }
        public void SetAppValue(string key, string newValue)
        {
            Doc.SelectSingleNode("/configuration/appSettings/add[@key='" + key + "']").Attributes["value"].Value = newValue;
        }
        public void SaveAppConfig()
        {
            Doc.Save(Ad.SetupInformation.ConfigurationFile);
            Doc.Load(Ad.SetupInformation.ConfigurationFile);
        }
        public string GetAppValue(string key)
        {
            return Doc.SelectSingleNode("/configuration/appSettings/add[@key='" + key + "']").Attributes["value"].Value;
        }
    }
}
