using Npoi.Core.OpenXml4Net.Util;
using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Npoi.Core.OpenXmlFormats.Vml.Presentation
{
    [Serializable]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:schemas-microsoft-com:office:powerpoint")]
    [XmlRoot(Namespace = "urn:schemas-microsoft-com:office:powerpoint", IsNullable = true)]
    public class CT_Empty
    {
    }

    [Serializable]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:schemas-microsoft-com:office:powerpoint")]
    [XmlRoot(Namespace = "urn:schemas-microsoft-com:office:powerpoint", IsNullable = true)]
    public class CT_Rel
    {
        private string idField;

        [XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/relationships")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        public static CT_Rel Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_Rel ctObj = new CT_Rel();
            ctObj.id = XmlHelper.ReadString(node.Attribute("r:id"));
            return ctObj;
        }

        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<p:{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "r:id", this.id);
            sw.Write(">");
            sw.Write(string.Format("</p:{0}>", nodeName));
        }
    }
}