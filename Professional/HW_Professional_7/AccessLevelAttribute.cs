using System;
using System.Collections.Generic;
using System.Text;

namespace HW_Professional_7
{
	[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
	sealed class AccessLevelAttribute : Attribute
	{
        readonly AccessLevelControl accessLevel;

        public AccessLevelAttribute(AccessLevelControl accessLevel) {
            this.accessLevel = accessLevel;
        }

        public AccessLevelControl AccessLevel {
            get { return accessLevel; }
        }
    }
}
