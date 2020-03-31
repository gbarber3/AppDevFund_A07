﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace FSISSystem.GBarb.Entities
{
    [Table("Player")]
    public class Player
    {
        [Key]
        public int PlayerID { get; set; }

        public int GuardianID { get; set; }

        public int TeamID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string AlbertaHealthCareNumber { get; set; }
        public string MedicalAlertDetails { get; set; }
        /*
        {
            set
            {
                if (String.IsNullOrEmpty(MedicalAlertDetails))
                {
                    MedicalAlertDetails = null;
                }
                else
                {
                    MedicalAlertDetails = value;
                }
            }
            get
            {
                return MedicalAlertDetails;
            }
        }
    */

        [NotMapped]
        public string FullName
        {
            get { return LastName + ", " + FirstName; }
        }
        [NotMapped]
        public string GenderFormatted
        {
            get
            {
                if (Gender == "F")
                {
                    return "Female";                        
                }
                else if (Gender == "M")
                {
                    return "Male";
                }
                else { return Gender; }
            }
        }

    }
}
