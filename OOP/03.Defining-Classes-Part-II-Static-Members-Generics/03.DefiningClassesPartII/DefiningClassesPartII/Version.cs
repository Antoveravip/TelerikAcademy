namespace DefiningClassesPartII
{
    using System;

    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class |
    AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method)]

    public sealed class VersionAttribute : Attribute
    {
        private string version;
        private string subversion;

        public string Version
        {
            get { return this.version; }
        }

        public string Subversion
        {
            get { return subversion; }
        }

        public VersionAttribute(string version)
            : this(version, null)
        {
        }

        public VersionAttribute(string version, string subversion)
        {
            this.version = version;
            this.subversion = subversion;
        }
    }
}