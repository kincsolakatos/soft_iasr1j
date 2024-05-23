﻿using System;
using System.Collections.Generic;

namespace ZH3D_IASR1J.Models;

public partial class OrderItem
{
    public int OrderFk { get; set; }

    public int ProductFk { get; set; }

    public int Quantity { get; set; }

    public decimal? ListPrice { get; set; }

    public decimal? Discount { get; set; }

    public virtual Order OrderFkNavigation { get; set; } = null!;

    public virtual Product ProductFkNavigation { get; set; } = null!;
}
