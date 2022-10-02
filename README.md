# Musicly
![mus](https://user-images.githubusercontent.com/100843256/193441326-84a5e6a8-6895-47ed-9e2a-33b6df0d4fdd.png)

Musicly is an mp3 player interface created with Visual Studio 2019, C# and [NAudio](https://github.com/naudio/NAudio).  

This app is highly experimental. It is an absolute mess of spaghetti code and there are tons of things I haven't figured out yet.  

## How To Use
Firstly, you'll need to install Visual Studio from [here](https://visualstudio.microsoft.com/vs/).  

The app has NO setup, so this is a Visual Studio project you're gonna run here.  

You'll also need to install [Mont Font](https://www.dafont.com/mont.font) in order for the UI to display properly.  

Secondly, run the app in Visual Studio. The application window'll open just like so:  

![3](https://user-images.githubusercontent.com/100843256/193441503-ef2bfcfa-6fa7-4a54-a714-1de6bddfb80c.PNG)  

From here click the "Select Songs" button. You'll be prompted to choose one or multiple .mp3 or .wav files.
  
Do **NOT** choose any other file format.  
Although you can, trying to play any other file format will result in a crash as I'll discuss later on.  
For now just stick to those two.  

![4](https://user-images.githubusercontent.com/100843256/193441649-c337bece-b56c-4632-b2b4-560a2e0d9c7c.PNG)

After selecting your music tracks, simply choose the track you want to play from the list and hit play.  

**Auto Play** is on by default so it'll move automatically to the next track.  

The player has the most basic mp3 player features including a loop button which, if checked, will loop the music track over and over.  

![Capture](https://user-images.githubusercontent.com/100843256/193441877-a4549099-b4fb-4b0d-b1ef-8ebaabfe4fdc.PNG)

## Known issues
1 - If a file that isn't audio is played using the previous or next buttons, the program will crash! 
This is due to me not figuring out how to identify the next index in the list and check whether the name ends with .mp3 or .wav or not using the NAudio library.  

2 - The interface feels VERY sluggish though there are no issues in playback.  

I'm still studying how to use the NAudio library and hopefully soon I'll come up with a fix for these issues, but for now feel free to use it.
