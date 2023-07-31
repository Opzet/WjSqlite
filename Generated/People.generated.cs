//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
//
//     Produced by Entity Framework Visual Editor v4.2.4.4
//     Source:                    https://github.com/msawczyn/EFDesigner
//     Visual Studio Marketplace: https://marketplace.visualstudio.com/items?itemName=michaelsawczyn.EFDesigner
//     Documentation:             https://msawczyn.github.io/EFDesigner/
//     License (MIT):             https://github.com/msawczyn/EFDesigner/blob/master/LICENSE
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;

namespace WjSqlite
{
   public partial class People
   {
      partial void Init();

      /// <summary>
      /// Default constructor
      /// </summary>
      public People()
      {
         Init();
      }

      /*************************************************************************
       * Properties
       *************************************************************************/

      public DateTime? DOB { get; set; }

      public string Email { get; set; }

      /// <summary>
      /// Max length = 125
      /// </summary>
      [MaxLength(125)]
      [StringLength(125)]
      public string FirstName { get; set; }

      /// <summary>
      /// Identity, Required
      /// </summary>
      [Key]
      [Required]
      public long Id { get; set; }

      /// <summary>
      /// Max length = 125
      /// </summary>
      [MaxLength(125)]
      [StringLength(125)]
      public string LastName { get; set; }

      public string MiddleName { get; set; }

      public string Phone { get; set; }

      public string PreferredName { get; set; }

   }
}
