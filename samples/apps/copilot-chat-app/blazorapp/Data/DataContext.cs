﻿// Copyright (c) Microsoft. All rights reserved.

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CopilotChatBlazorServerClient.Data;

public class DataContext:IdentityDbContext
{
    public DataContext(DbContextOptions options):base(options)
    {
        
    }
}
