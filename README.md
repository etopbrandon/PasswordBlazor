# PasswordBlazor
**What is it?**
PasswordBlazor is an app built on the ASP.NET Core Blazor Server framework to generate passwords and secure sharing links through PWPush. The passwords generated combine a randomly selected Adjective, Noun, number, and symbol to meet the initial requirements of most software. It is recommended that these are only used for initial passwords and users are prompted to reset upon first sign-in

**How do I set this up?**

 1. Download the full repository to a location accessible to your favorite IDE
 2. Open Data\ApiIntegration.cs
 3. In the ApiIntegration class, change the variables PwPushAPI and PwPushPass to your PWPush domains.
 -PwPushAPI should be the API endpoint. For example, if your PWpush is hosted at pw.domain.com, use "https://pw.domain.com/p.json"
 -PwPushPass is the beginning of the URL to combine with the URL slug provided by the API. For example, using the same domain above you'd enter "https://pw.domain.com/p/"
 4. To update the tool name, edit the relevant HTML in Pages\Index.razor and Shared\NavMenu.razor
 5. To update the dictionary of Nouns, Adjectives, and Symbols, edit the corresponding txt files in the root folder

**How do I host this?**

 1. For cloud hosting, Microsoft Azure App Services is recommended. They offer a free F1 plan that works for most internal development purposes.
 2. For on-prem self-hosting, IIS can also run Blazor Server apps
 
 See the following guide for more information: [Host and deploy ASP.NET Core Blazor Server | Microsoft Docs](https://docs.microsoft.com/en-us/aspnet/core/blazor/host-and-deploy/server?view=aspnetcore-6.0)
