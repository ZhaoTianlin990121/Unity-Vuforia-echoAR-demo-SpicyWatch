# Unity-Vuforia-echoAR-demo-SpicyWatch

In this demo, I will introduce you to Spicy Watch, a Unity based software that allow you to preview your watches on your wrist without actually wearing them

## Register
If you don't have an echoAR API key yet, make sure to register for FREE at [echoAR](https://console.echoar.xyz/#/auth/register).

## Make Your Wrist Band
1. Download the images from [Images folder](/Images) and print them out in 30cm x 30cm or 12inch x 12inch squares
2. Stick them into a wrist band that looks like this 
![wristband](/ScreenShots/Wrist-Band.jpg)

## Setup & Run
1. Clone this repo, open Unity Hub, add project Unity-Vuforia-echoAR-demo-SpicyWatch
2. Make sure you have the right version of Unity
3. Click the project and wait for the packages to resolve
4. Open Build Setting under File and switch to IOS mode
5. Build to a folder
6. Move the folder to a laptop with MacOS if you are using Windows
7. Using your Mac, open the file that ends with .xcodeproj using xcode (download XCode from App Store if you don't have one)
8. Click XCode on top left and log in using your Apple ID
9. Then click on the blue Unity-IPhone icon, go to signing
10. Tick the automatic option, sign in using the Mac's password, choose team, and enter the project name (e.g. com.xxx.yyy)
11. Connect your IPhone with your Mac
12. Click the "Play" button on top of the application to build
13. If build successful, an App with the Unity icon should appear on your phone (API Key already handled, no need to get API key)
14. Add the 3D models from the [Models folder](/Models) to the ecchoAR console, remember to pull in both the obj and mtl for the texture to be applied.
15. Run the application and you will see the watch appearing on your wrist band
* NOTE: You can try the software on Editor with webcam, although its performance will be significantly poorer than that of a mobile phone

## Learn more
Refer to our [documentation](https://docs.echoar.xyz/ar.js/deploy-experience) to learn more about how to use AR.js with echoAR.

## Support
Feel free to reach out at [support@echoAR.xyz](mailto:support@echoAR.xyz) or join our [support channel on Slack](https://join.slack.com/t/echoar/shared_invite/enQtNTg4NjI5NjM3OTc1LWU1M2M2MTNlNTM3NGY1YTUxYmY3ZDNjNTc3YjA5M2QyNGZiOTgzMjVmZWZmZmFjNGJjYTcxZjhhNzk3YjNhNjE). 

## Screenshots
Video available in the [ScreenShots folder](/ScreenShots)

![showcase](/ScreenShots/show-case.gif)
![UploadPage](/ScreenShots/EchoAR.jpg)