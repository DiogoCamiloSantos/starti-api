using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using StartiApi.Application.Interfaces;
using System.Text;
using StartiApi.Application.Services;
using System.Reflection;
using StartiApi.Repositories;
using StartiApi.Services;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddCors(options => 
{
    options.AddPolicy("AllowAll", 
        builder => builder.AllowAnyOrigin()
                            .AllowAnyMethod()
                            .AllowAnyHeader());
});

builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
builder.Services.AddSingleton<IUserProfileRepository, UserProfileRepository>();
builder.Services.AddTransient<IUserProfileService, UserProfileService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var key = Encoding.ASCII.GetBytes(builder.Configuration["Jwt:Key"]);

builder.WebHost.ConfigureKestrel((context, serverOptions) =>
{
    var kestrelSection = context.Configuration.GetSection("Kestrel");

    serverOptions.Configure(kestrelSection)
        .Endpoint("HTTPS", listenOptions =>
        {
            // ...
        });
});

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.RequireHttpsMetadata = false;
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(key)
    };
});

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AppPolicy", policy =>
    {
        policy.RequireClaim("Client", "app");
    });

    options.AddPolicy("SitePolicy", policy =>
    {
        policy.RequireClaim("Client", "site");
    });
});


builder.Services.AddSwaggerGen(c => 
{
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);
});

var app = builder.Build();

app.UseRouting();

app.UseCors("AllowAll");

app.UseAuthentication();
app.UseAuthorization();

app.UseHttpsRedirection();

app.MapControllers();

app.UseDeveloperExceptionPage();
app.UseSwagger();
app.UseSwaggerUI(c => {
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Starti API V3.1");
    c.RoutePrefix = string.Empty;
});  

app.MapGet("/", c => 
{
    c.Response.Redirect("/swagger");
    return Task.CompletedTask;
});

app.Run();