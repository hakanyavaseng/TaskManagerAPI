using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllers();
builder.Services.AddSwaggerDocument();
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new 
    Microsoft.IdentityModel.Tokens.TokenValidationParameters
    {
       ValidateAudience = true,
       ValidateIssuer = true,
       ValidateLifetime = true,
       ValidateIssuerSigningKey = true,
       ValidIssuer = builder.Configuration["Token:Issuer"],
       ValidAudience = builder.Configuration["Token:Audience"],
       IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Token:Security"])),
       ClockSkew = TimeSpan.Zero
       };
  
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseStaticFiles();

app.UseRouting(); // UseRouting middleware'ini UseEndpoints'ten önce çaðýrýn

app.UseAuthentication();
app.UseAuthorization(); // UseAuthorization middleware'ini UseRouting ve UseEndpoints'ten sonra çaðýrýn

app.UseOpenApi();
app.UseSwaggerUi3();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
    app.MapRazorPages();
});

app.Run();