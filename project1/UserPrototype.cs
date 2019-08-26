using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace project1
{
    public enum eGender
    {
        female = 0,
        male = 1
    }

    public enum eRelationshipStatus
    {
        Single = 0,
        Married = 3
    }

    public class UserPrototype
    {
        public string m_Name { get; set; }

        public eGender e_Gender { get; set; }

        public eRelationshipStatus e_UserStatus { get; set; }

        public string PictureNormalURL { get; set; }

        public UserPrototype ShalowClone()
        {
            return this.MemberwiseClone() as UserPrototype;
        }
    }
}
