﻿using System;
using System.Collections.Generic;

namespace UP_2;

public partial class Consignment
{
    public int Id { get; set; }

    public DateTime Date { get; set; }

    public int? PoductId { get; set; }

    public virtual Product? Poduct { get; set; }
}
