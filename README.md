# Using Session and Forms Authentication with DotVVM

This sample demonstrates using ASP.NET Session, `HttpContext` cookies and Forms Authentication with [DotVVM](https://github.com/riganti/dotvvm).

> This sample is applicable only for the OWIN version of DotVVM. We do not recommend using any of these features in new apps. This scenario is useful especially when you try to [modernize old ASP.NET Web Forms applications using DotVVM](https://github.com/riganti/dotvvm-samples-webforms-migration) or use DotVVM in a Web Forms app.

## Prerequisites

* Make sure you have installed [DotVVM for Visual Studio](https://www.dotvvm.com/install)

## How to run the sample

1. [Open the GitHub repo in Visual Studio](git-client://clone/?repo=https%3A%2F%2Fgithub.com%2Friganti%2Fdotvvm-samples-session)
or 
`git clone https://github.com/riganti/dotvvm-samples-session.git`

2. Open `src/DotvvmSessionSample.sln`

3. Right-click the `DotvvmSessionSample` project and select **View > View in Browser**

## What you can learn in the sample

* How to use [Session State behavior and a custom CookieManager](https://www.dotvvm.com/docs/tutorials/advanced-using-session-or-http-context-cookies/latest) in order to make old ASP.NET features like session and Forms Authentication to work with cookies correctly

---

# About the sample

The sample shows the necessary configuration in `Startup.cs` (enabling session state behavior and registering a custom cookie manager that tells DotVVM to write the cookies to the `HttpContext` cookie container instead of using the OWIN cookie container).

There is also a sample page that uses Forms Authentication - it has to be enabled in `web.config` using `<authentication mode="Forms" />`. 

---

## Other resources

* [Gitter Chat](https://gitter.im/riganti/dotvvm)
* [DotVVM Official Website](https://www.dotvvm.com)
* [DotVVM Documentation](https://www.dotvvm.com/docs)
* [DotVVM GitHub](https://github.com/riganti/dotvvm)
* [Twitter @dotvvm](https://twitter.com/dotvvm)
* [Samples](https://www.dotvvm.com/samples)
