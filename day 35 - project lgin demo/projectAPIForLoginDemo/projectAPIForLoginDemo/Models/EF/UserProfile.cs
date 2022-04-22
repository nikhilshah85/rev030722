using System;
using System.Collections.Generic;

namespace projectAPIForLoginDemo.Models.EF
{
    public partial class UserProfile
    {
        public int AccountId { get; set; }
        public string AvatarLink { get; set; } = null!;
        public int UserElo { get; set; }
        public byte Wpm { get; set; }
        public string KeyboardLayout { get; set; } = null!;
        public byte A { get; set; }
        public byte B { get; set; }
        public byte C { get; set; }
        public byte D { get; set; }
        public byte E { get; set; }
        public byte F { get; set; }
        public byte G { get; set; }
        public byte H { get; set; }
        public byte I { get; set; }
        public byte J { get; set; }
        public byte K { get; set; }
        public byte L { get; set; }
        public byte M { get; set; }
        public byte N { get; set; }
        public byte O { get; set; }
        public byte P { get; set; }
        public byte Q { get; set; }
        public byte R { get; set; }
        public byte S { get; set; }
        public byte T { get; set; }
        public byte U { get; set; }
        public byte V { get; set; }
        public byte W { get; set; }
        public byte X { get; set; }
        public byte Y { get; set; }
        public byte Z { get; set; }

        public virtual LoginTable Account { get; set; } = null!;
    }
}
