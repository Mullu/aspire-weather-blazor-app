var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.AspireBlazorApp>("aspireblazorapp");

builder.Build().Run();
