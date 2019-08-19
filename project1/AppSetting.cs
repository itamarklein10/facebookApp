using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace project1
{
    class AppSetting
    {
        private static readonly string sr_FileName;

        static AppSetting()
        {
            sr_FileName = Application.ExecutablePath + ".settings.xml";
        }
        private static AppSetting s_This;
        public static AppSetting Instance
        {
            get
            {
                if (s_This == null)
                {
                    s_This = AppSetting.FromFileOrDefault();
                }

                return s_This;
            }
        }

        public bool AutoLogin { get; set; }
        public Size LastWindowSize { get; set; }
        public FormWindowState LastWindowState { get; set; }
        public Point LastWindowLocation { get; set; }
        public string AccessToken { get; set; }

        public void Save()
        {
            using (FileStream stream = new FileStream(sr_FileName, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(AppSetting));
                serializer.Serialize(stream, this);
            }
        }

        public static AppSetting FromFileOrDefault()
        {
            AppSetting loadedThis = null;

            if (File.Exists(sr_FileName))
            {
                using (FileStream stream = new FileStream(sr_FileName, FileMode.OpenOrCreate))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSetting));
                    loadedThis = (AppSetting)serializer.Deserialize(stream);
                }
            }
            else
            {
                /// C# 3.0 feature: Object Initializer
                loadedThis = new AppSetting()
                {
                    AutoLogin = false,
                    LastWindowSize = new Size(800, 500),
                    LastWindowState = FormWindowState.Normal
                };
            }

            return loadedThis;
        }

    }
}
