﻿using ConsoleDatastorage.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateDefaultBuilder().ConfigureServices(services =>
{

services.AddDbContext<DataContext>(x => x.UseSqlServer(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\willi\OneDrive\Skrivbord\Datastorage\ConsoleDatastorage\ConsoleDatastorage\Data\Database.mdf; Integrated Security = True; Connect Timeout = 30; Encrypt = True"));

}).Build();