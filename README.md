# Basics Learning

These are scripts made to learn basic principles of coding, primarily following Udemy lectures.

## Getting Started

The scripts present in this repository were written in Visual Studio 2015. They are used in a Unity application as the ultimate goal of the tutorial is to learn to use Unity. Hence the references to monobehaviour. 

### Prerequisites

Any Integrated Development Environment that accepts C sharp.
Unity 5

```
Visual Studio 2015
```

### Installing

Clone this repository locally.

Open a Unity project

Add these scripts to the Unity projects assets

Drag and drop one of the scripts on the default main camera

Press the play button to run the script.

Take note of the debugging/console/ other outputs at the bottom of the screen.

Only use One script at a time.

### Coding Snippets

The following ia the main body of the conditionals script

```
if (PlayerAlphaMainTowersDestroyed || PlayerBravoMainTowersDestroyed)
        {
            if (PlayerAlphaMainTowersDestroyed)
            {
                Debug.Log("Player Bravo wins!!");
            }
            else { Debug.Log("Player Alpha wins!!"); }
        }
        else if (timer <= 0)
        {
         if (PlayerAlphaTowersRemaining < PlayerBravoTowersRemaining)
            {
                Debug.Log("Player Bravo wins!!");
            }   
         else if (PlayerBravoTowersRemaining < PlayerAlphaTowersRemaining)
            {
                Debug.Log("Player Alpha wins!!");
            }
         else
            {
                Debug.Log("The game was a draw");
            }
        }
        }
```
The conditionals script is an example of how and when to use various conditionals such as "else if". This script is for a game where two players try to destroy each others towers, the game logic is dictated primarily by the given snippet of code.

## Deployment

The scripts are pure game logic, there are no accompanying game assets and no functional game bar some output in the console.

## Built With

* [Unity](https://docs.unity3d.com/Manual/index.html) - The game engine
* [Visual studio 2015](https://msdn.microsoft.com/en-us/library/dd831853.aspx) - IDE


## Contributing

These scripts are for learning purposes only, they are on Github only as a means of practice and should be considered complete or obselete. No Contributions requested.

## Versioning

I use [SemVer](http://semver.org/) for versioning. Version 1.0.0.

## Authors

* **Michael Everett** - *Sole Contributer* - [3real](https://github.com/3real)

## License

This project is licensed under the MIT License

## Acknowledgments

* Thank you to all those who have critiqued this README which is an attempt to learn best practices. 
* Inspiration, https://www.udemy.com/user/mark-price-2/ the teacher who's lessons I followed to produce the stated scripts.

