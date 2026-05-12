using BlazorApp1.Components;
using Microsoft.AspNetCore.Authentication.Certificate;
using Microsoft.Extensions.ML;
using BlazorApp1;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddPredictionEnginePool<MLModel.ModelInput, MLModel.ModelOutput>()
    .FromFile("MLModel.mlnet");
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddAuthentication(
CertificateAuthenticationDefaults.AuthenticationScheme)
      .AddCertificate();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
