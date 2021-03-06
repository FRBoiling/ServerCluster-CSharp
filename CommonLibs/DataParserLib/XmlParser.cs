﻿using System;
using System.Xml;

/// <summary>
/// <idspace id="idspaceId" >
///     <header id = "headerId" />
///     <class id="1" name="class1" group="groupA" Attribute1="1001" Attribute2="1" Attribute3="11"/>
///     <class id="1" name="class2" group="groupA" Attribute1="1001" Attribute2="1" Attribute3="11"/>
/// </idspace>
/// </summary>
namespace DataParserLib
{
    public class XmlParser
    {
        private string _filename;
        private string _idspace;

        internal DataList Parse(string filename)
        {
            _filename = filename;
            XmlDocument xmlDoc = new XmlDocument();
            try
            {
                if (string.IsNullOrWhiteSpace(_filename))
                {
                }
                else
                {
                    xmlDoc.Load(_filename);
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e);
                return null;
            }

            DataList dataList = ParseIdspace(xmlDoc);
            if (!ParseHeaderData(dataList,xmlDoc))
            {
                return null;
            }
            if (!ParseClassData(dataList,xmlDoc))
            {
                return null;
            }
            return dataList;
        }

        internal DataList ParseXml(string xmlstring)
        {
            XmlDocument xmlDoc = new XmlDocument();
            try
            {
                if (string.IsNullOrWhiteSpace(xmlstring))
                {
                }
                else
                {
                    xmlDoc.LoadXml(xmlstring);
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e);
                Console.ForegroundColor = ConsoleColor.Gray;
                return null;
            }

            DataList dataList = ParseIdspace(xmlDoc);
            if (!ParseHeaderData(dataList, xmlDoc))
            {
                return null;
            }
            if (!ParseClassData(dataList, xmlDoc))
            {
                return null;
            }
            return dataList;
        }


        private void ParseAttributes(Data data, XmlAttributeCollection attributes)
        {
            foreach (XmlAttribute attr in attributes)
            {
                object outValue;
                AttributeValueType type = ParseAttributeValue(attr.Value, out outValue);
                Attribute attribute = new Attribute(type, attr.Name, outValue);
                if (data.SetAttribute(attribute))
                {

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("idspace '{0}' -class '{1}' has more than one attribute named '{2}'.",_idspace,data.Id,attribute.Key);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
        }

        private AttributeValueType ParseAttributeValue(string input, out object outValue)
        {
            AttributeValueType type;
            int outInt;
            float outFloat;

            if (int.TryParse(input, out outInt))
            {
                type = AttributeValueType.INT;
                outValue = outInt;
            }
            else if (float.TryParse(input, out outFloat))
            {
                type = AttributeValueType.FLOAT;
                outValue = outFloat;
            }
            else
            {
                type = AttributeValueType.STRING;
                outValue = input;
            }
            return type;
        }

        private DataList ParseIdspace(XmlDocument xmlDoc)
        {
            _idspace = xmlDoc.DocumentElement.GetAttribute("id");

            DataList dataList = new DataList();
            dataList.Init(_idspace);
            return dataList;
        }

        private bool ParseHeaderData(DataList dataList, XmlDocument xmlDoc)
        {
            XmlNodeList xmlNodes = xmlDoc.GetElementsByTagName("header");
            if (xmlNodes.Count ==  0)
            {
                //没有header元素
            }
            else if (xmlNodes.Count ==1)
            {
                Data header = dataList.Header;
                XmlNode headerNode = xmlNodes.Item(0);

                ParseAttributes(header, headerNode.Attributes);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                if (string.IsNullOrWhiteSpace(_filename))
                {
                    Console.WriteLine("idspace '{0}' has more than one header node .", _idspace);
                }
                else
                {
                    Console.WriteLine("File '{0}' has more than one header node .", _filename);
                }
                Console.ForegroundColor = ConsoleColor.Gray;
                return false;
            }
            return true;
        }

        private bool ParseClassData(DataList dataList, XmlDocument xmlDoc)
        {
            XmlNodeList xmlNodes = xmlDoc.GetElementsByTagName("class");
            foreach (XmlNode node in xmlNodes)
            {
                Data data = new Data();

                XmlAttribute idAttribute = node.Attributes["id"];
                if (idAttribute !=null)
                {
                    string strId = idAttribute.Value;
                    int id = int.Parse(strId);
                    data.SetId(id);
                    node.Attributes.Remove(idAttribute);
                }
                else
                {
                    return false;  //id为必须有的属性
                }
                XmlAttribute nameAttribute = node.Attributes["name"];
                if (nameAttribute !=null && nameAttribute.Value.Length !=0)
                {
                    string name = nameAttribute.Value;
                    data.SetName(name);
                    node.Attributes.Remove(nameAttribute);
                }
                XmlAttribute groupAttribute = node.Attributes["group"];
                if (groupAttribute != null && groupAttribute.Value.Length != 0)
                {
                    string group = groupAttribute.Value;
                    data.SetGroup(group);
                    node.Attributes.Remove(groupAttribute);
                }
                ParseAttributes(data, node.Attributes);
                dataList.Add(data);
            }
            return true;
        }


    }
}
