﻿using System;
using System.ComponentModel.DataAnnotations;

namespace ATL_API_SPMT.Models
{
    public class Message
    {
        [Key]
        public Guid Message_Id { get; set; }
        public Guid Shipment_Id { get; set; }
        public string Details { get; set; }
    }
}
