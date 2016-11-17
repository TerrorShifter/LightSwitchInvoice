using Microsoft.LightSwitch;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;

namespace LightSwitchApplication
{
    public partial class Customer
    {
        partial void OrderTotal_Compute(ref decimal result)
        {
            // Set result to the desired field value
            result = (from items in Orders select items).Sum(X => X.OrderAmount);
        }
    }
}