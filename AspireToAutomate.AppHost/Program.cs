var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.AspireToAutomate_ApiService>("apiservice");

builder.AddProject<Projects.AspireToAutomate_Web>("webfrontend")
    .WithReference(apiService);

builder.Build().Run();
