using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionTesting
{
    public class AdminRole : Role
    {
        public override bool Mute => true;
        public override bool AddPoints => true;
        public override bool UsernameOther => true;
        public override bool BannerOther => true;
        public override bool SignUps => true;
        public override bool Announcements => true;
        public override bool LiveOther => true;
        public override bool RemovePoints => true;
        public override bool LevelDown => true;
        public override bool AssignMod => true;
        public override bool AssignMarketing => true;
        public override bool AssignSuperMod => true;
        public override bool ToggleJoinMethod => true;
        public override bool ManageJoinRequest => true;
    }
}
