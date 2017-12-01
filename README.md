# POLR Windows Client
[![GitHub license](https://img.shields.io/badge/license-GPLv2%2B-blue.svg)]()

Sometimes it's pretty unconfortable to open a web browser to short an URL. So I decided to create a small client for Windows that read the URL saved in the clipboard and make it shorter. 

The client resides in the system tray and it's silent. When you want to short an URL, simply copy the URL in the clippdoard and then right-click on the icon: the shortned URL will be loaded in your keyboard.

The software uses two environment variable in the user space to set which is the domain of the URL shortner service and the API_KEY.
If you don't want manually create these two environment variables, you can use the Settings function available right-clicking on the system tray icon.
