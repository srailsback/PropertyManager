using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PropertyManager.Models
{
    public class Parcel
    {
        [Key]
        public string MemberId { get; set; }
        public string ParcelNumber { get; set; }
        public string AccountNumber { get; set; }
        public string Owner1 { get; set; }
        public string Owner2 { get; set; }
        public string Address { get; set; }
        public string MailingAddress1 { get; set; }
        public string MailingAddress2 { get; set; }
        public string MailingAddressCity { get; set; }
        public string MailingAddressState { get; set; }
        public string MailingAddressZip { get; set; }
        public string Filing { get; set; }
        public string Subdivision { get; set; }
        public string Legal { get; set; }
        public DateTime? GrantLienSignedOn { get; set; }
        public DateTime? GrantLienFiledOn { get; set; }
    }
}