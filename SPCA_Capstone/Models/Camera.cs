//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SPCA_Capstone.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Camera
    {
        public int Camera_Number { get; set; }
        public string Dog_Name { get; set; }
    
        public virtual Dog Dog { get; set; }
    }
}
