using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NorthwindSystem.Entities
{
    [Table("Region")]
    class Region
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)] //in the database the RegionID is not flagged as an identity, so we must do the DatabaseGenerated shiz
        public int RegionID { get; set; }

        public string RegionDescription { get; set; }

        [NotMapped]

        public string RegionDescriptionAndID
        { get
            {
                 return RegionDescription + "(" + RegionID + ")";
            }
        }
    }
}
