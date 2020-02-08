using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionTesting
{
    public class Role
    {
        virtual public bool Mute { get { return false; }}
        virtual public bool AddPoints { get { return false; } }
        virtual public bool ReferOther { get { return false; } }
        virtual public bool UsernameOther { get { return false; } }
        virtual public bool BannerOther { get { return false; } }
        virtual public bool SignUps { get { return false; } }
        virtual public bool Announcements { get { return false; } }
        virtual public bool LiveOther { get { return false; } }
        virtual public bool LevelDown { get { return false; } }
        virtual public bool RemovePoints { get { return false; } }
        virtual public bool ToggleJoinMethod { get { return false; } }
        virtual public bool ManageJoinRequest { get { return false; } }
        virtual public bool AssignMod { get { return false; } }
        virtual public bool AssignMarketing { get { return false; } }
        virtual public bool AssignSuperMod { get { return false; } }
    }
}

