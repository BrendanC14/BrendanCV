using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace typekey
{
    public class Typekey
    {
        private string _name = "";
        public string Name
        {
            get { return _name; }
        }

        private string _description;
        public string Description
        {
            get { return _description; }
        }
        public bool HasDescription
        {
            get { return Description != null; }
        }

        protected Typekey(string name)
        {
            _name = name;
        }

        protected Typekey(string name, string description)
        {
            _name = name;
            _description = description;
        }
    }
}
