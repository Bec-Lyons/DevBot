//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LuisBot.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Worker
    {
        public int PersonID { get; set; }
        public bool CorrectGear { get; set; }
        public Nullable<int> ObjectID { get; set; }
        public int MobileNo { get; set; }
        public bool IsSafe { get; set; }
        public int AuthLevel { get; set; }
        public Nullable<int> RoomID { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public Nullable<int> SafetyInfringements { get; set; }
    }
}