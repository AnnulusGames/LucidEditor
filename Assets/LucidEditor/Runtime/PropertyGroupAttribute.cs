using System;
using System.Linq;

namespace AnnulusGames.LucidTools.Inspector
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class PropertyGroupAttribute : Attribute
    {
        public readonly string path;
        public readonly string name;
        public readonly int groupDepth;

        public PropertyGroupAttribute(string groupPath)
        {
            this.path = groupPath;
            name = path.Split('/').Last();
            groupDepth = path.Count(x => x == '/');
        }
    }
}