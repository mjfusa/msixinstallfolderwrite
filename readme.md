# Sample : MSIX - Two Apps Read and Write to Install Folder

## Note:

The app will throw an exception when writing to the install folder when debugging from Visual Studio. You need to create and install the MSIX package.

## To run the sample

1. Create the app package (MSIX)
2. Install the app package

```
Note: In the Start menu you'll see two apps: HelloWpf and HelloWpf1.
```
3. Start HelloWpf
4. Click **Write**
5. Start HelloWpf1
4. Click **Read**

HelloWpf1 reads the file created by HelloWpf in the Install folder

## How does it work

To set up redirection for all apps in the same MSIX package add the capability packageWriteRedirectionCompatibilityShim to your Manifest.Package file as follows:
```xml
<Capabilities>
    <rescap:Capability Name="packageWriteRedirectionCompatibilityShim" />
	<rescap:Capability Name="runFullTrust" />
</Capabilities>
```

This will reroute all file writes/reads to/from the install folder to AppData.
Here are the relevant docs: [App capability declarations - UWP applications | Microsoft Docs](https://docs.microsoft.com/en-us/windows/uwp/packaging/app-capability-declarations?msclkid=f9106e3ec80311eca694b16143c0f327)
