﻿using System;
using System.Collections.Generic;

namespace Harmony.Repositories.Entities;

public partial class Dashboard
{
    public int DashboardId { get; set; }

    public string? Statistics { get; set; }

    public string? Reports { get; set; }
}
