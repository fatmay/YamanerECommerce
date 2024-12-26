﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YamanerECommerce.Application.Features.CQRS.Commands.CartCommands
{
    public class CreateCartCommand
    {
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public float TotalAmount { get; set; }
        public string Status { get; set; }
    }
}
