Simple example that illustrate how APIs can be built as OWIN middleware to be decoupled from their host. 
The example shows to APIs, API1 and API2, that are cohosted. They can of course be hosted independently just as simple.

#To test

Open the solution in Visual Studio 2015 and press F5.
If you have a problem with e.g. Chrome http->https redirection - use a different browser or tweak the settings :-).

http://localhost:59753/api1cohostroot/api1root/api1

http://localhost:59753/api2cohostroot/api2root/api2

#Note on isolation
Although cohosting is a logical decoupling, they are not isolated so depending on the technology in place, side-effects can exist.
You are in the same app domain, so anything that relies on assembly scanning or discovery mechanisms could be 
Convention-based IoC registrations or MVC/Web API controller discovery are typical examples.

In this sample, you can see this effect at play here:
http://localhost:59753/api1cohostroot/api1root/api2

http://localhost:59753/api2cohostroot/api2root/api1

Workaround: http://www.strathweb.com/2016/05/running-multiple-asp-net-web-api-pipelines-side-by-side/

