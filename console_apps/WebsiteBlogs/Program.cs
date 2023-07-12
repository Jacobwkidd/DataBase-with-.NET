using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebsiteBlogs.Data;
using WebsiteBlogs.Services;

var services = new ServiceCollection();

services.AddDbContext<ApplicationDbContext>();

var serviceProvider = services.BuildServiceProvider();

SeedData.Initialize(serviceProvider);