using System;

namespace hu.czompisoftware.api.module
{
    public class ModuleAttribute: Attribute
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Version { get; set; }
        public string Authors { get; set; }
        public ModuleType Type { get; set; }
    }
}