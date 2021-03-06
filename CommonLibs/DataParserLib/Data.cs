﻿using System;
using System.Collections.Generic;

namespace DataParserLib
{
    public class Data
    {
        private int _id;
        private string _name;
        private string _group;

        private readonly Dictionary<string, Attribute> _attributes;

        public int Id { get => _id;}
        public string Name { get => _name; }
        public string Group { get => _group;}

        public delegate void PropertyCallback(Attribute property);

        public Data()
        {
            _attributes = new Dictionary<string, Attribute>();
        }

        internal bool SetAttribute(Attribute attr)
        {
            Attribute temp;
            if (_attributes.TryGetValue(attr.Key,out temp))
            {
                return false;
            }
            else
            {
                _attributes.Add(attr.Key, attr);
                return true;
            }
        }

        internal void SetId(int id)
        {
            _id = id;
        }
        internal void SetName(string name)
        {
            _name = name;
        }
        internal void SetGroup(string group)
        {
            _group = group;
        }

        public Attribute Get(string key)
        {
            Attribute attr;
            _attributes.TryGetValue(key, out attr);
            return attr;
        }

        public int GetInt(string key)
        {
            Attribute attr = Get(key);
            if (attr == null)
            {
                return 0;
            }
            else
            {
                return attr.GetInt();
            }
        }

        public short GetInt16(string key)
        {
            Attribute attr = Get(key);
            if (attr == null)
            {
                return 0;
            }
            else
            {
                return attr.GetInt16();
            }
        }

        public ushort GetUInt16(string key)
        {
            Attribute attr = Get(key);
            if (attr == null)
            {
                return 0;
            }
            else
            {
                return attr.GetUInt16();
            }
        }


        public bool GetBoolean(string key)
        {
            Attribute attr = Get(key);
            if (attr == null)
            {
                return false;
            }
            else
            {
                if (attr.GetInt()>0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public float GetFloat(string key)
        {
            Attribute attr = Get(key);
            if (attr==null)
            {
                return 0.0f;
            }
            else
            {
                return attr.GetFloat();
            }

        }

        public string GetString(string key)
        {
            Attribute attr = Get(key);
            if (attr == null)
            {
                return string.Empty;
            }
            else
            {
                return attr.GetString();
            }
        }

    }
}
