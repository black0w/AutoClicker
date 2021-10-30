# AutoClicker
![GitHub release (latest by date)](https://img.shields.io/github/v/release/black0w/AutoClicker)
![GitHub pull requests](https://img.shields.io/github/issues-pr/black0w/AutoClicker?label=Pull%20Requests)
![GitHub all releases](https://img.shields.io/github/downloads/black0w/AutoClicker/total?logo=GitHub&style=social)

Small and simple auto clicker written in C#( .Net Framework ) which allows you to emulate mouse clicks and most of the keyboard buttons aswell as allowing you to choose specific points on the screen to click in order.


## Main Screen

![Screenshot_2](https://user-images.githubusercontent.com/19394845/139529767-d392757b-38f6-4b7a-a4e2-b0728f9bebcb.png)

## How to use
When you run it for first time you need to setup atleast one hotkey (start/stop or scan_position hotkey)
After the initial setup you can choose whether to use the normal auto clicker or the multi clicker

### Auto Clicker 
![Screenshot_3](https://user-images.githubusercontent.com/19394845/139530376-4196876f-b03b-4ecf-85f8-4ee34f4bde4c.png)

Here you can choose which button to emulate and with what delay to emulate it.
You can even delay the start when using the checkbox for delayed start.

## Multi Clicker
![Screenshot_4](https://user-images.githubusercontent.com/19394845/139530401-ebda8a1b-00ca-4193-9c8e-18d91845faee.png)

The second option that this application let you use is the multi clicker. 
In this tab the application let you manage positions onto which you want to click automatically.
Firstly you need to choose locations (you can choose up to 1000 positions ( its not like you would need them but there should be a limit) ).
When choosing location by clicking the "Scan Positions" button you will be promted with this screen: 

![Screenshot_5](https://user-images.githubusercontent.com/19394845/139531740-4824ba89-5383-433d-b836-c0236c171ee1.png)

By choosing the number of positions and clicking on the "Scan Positions" button, the application will be waiting for you to choose a position with your cursor and pressing the scan hotkey which you have already choose in the settings tab. When you're done with choosing the locations you can either choose name for that specific list of locations or leave it blank and the application will automatically name it. By saving it the window will be closed and you will be returned to the multi clicker window where you can choose the list of positions that you've just created via the dropdown menu and then choosing the number of loops of the list you created and the time between click on each position.
Next step is to start the auto clicker, here you can either start the auto clicker via the button "Start" or via the hotkey you've chosen in the settings menu. Whenever the auto clicks loop finishes, the auto clicker will automatically stop itself.

Additional Info:
Whenever you start/stop the auto clicker a sound will be played.
