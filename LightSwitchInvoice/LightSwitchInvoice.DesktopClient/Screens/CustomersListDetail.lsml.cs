﻿using Microsoft.LightSwitch.Presentation.Extensions;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.IO;
using System.Linq;
using System;

namespace LightSwitchApplication
{
    public partial class CustomersListDetail
    {
        partial void CustomersListDetail_Created()
        {
            // Write your code here.
            InvoiceDate = DateTime.Today.ToShortDateString();
        }
    }
}