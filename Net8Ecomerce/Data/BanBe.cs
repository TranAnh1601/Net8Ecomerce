﻿using System;
using System.Collections.Generic;

namespace Net8Ecomerce.Data;

public partial class BanBe
{
    public int MaBb { get; set; }

    public string? MaKh { get; set; }

    public int MaHh { get; set; }

    public string? HoTen { get; set; }

    public string Email { get; set; } = null!;

    public DateTime NgayGui { get; set; }

    public string? GhiChu { get; set; }
}
